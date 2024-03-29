﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace r09546042_TerryYang_Assignment11
{
    class BbackPropagationMLP
    {

        #region Data Field
        Random rnd = new Random();
        float[][] x; // neuron values
        float[][][] w; // weights
        float[][][] dw;
        float[][] e; // epsilon; partial derivative of error with respect to net value.
        float[][] v;
        int[] n; // numbers of neuron on layers
        int dimension_inupt; // dimension of input vector
        int number_of_Data; // number of instances on the data set
        int number_of_Trainning_Data; // number of instances that are serving as training data
        int number_of_Testing_Data;
        float[,] original_Inputs; // original instances of input vectors (without normalization)
        float[,] inputs; // normalized input vectors
        float[] input_Max; // upper bounds on all components of input vectors
        float[] input_Min; // lower bounds on all components of input vectors
        int inputWidth; // dimension in width for a two-dimensional input vector
        int dimension_Target; // dimension of target vector
        float[,] original_Targets; // original instances of target vectors (without normalization)
        //float[,] targets; // normalized target vectors
        float[] targetMax; // upper bounds on all components of target vectors
        float[] targetMin; // lower bounds on all components of target vectors.
        int[] data_Indices; // array of shuffled indices of data instances; the front portion is training vectors;
                            //the rear portion is testing vectors
        int[,] confusing_Table;
        int current_Epoch = 0;
        int epoch_Limit = 500;
        float rootMeanSquareError = 0.0f; // root mean square of error for an epoch of data training
        int layerNumber; // number of neuron layer (including the input layer)
        Random randomizer = new Random();
        float learning_Rate = 0.999f; // learning rate, specified by the user
        float training_Ratio = 0.66f;        
        float eta; // step size that specify the update amount on each weight
        float initialEta = 0.7f; // initial step size, specified by the user

        double rmse = 0;
        Series series_RMSE;
        bool nn_Finished = false;
        #endregion

        #region Properties


        [Category("Traing Setting")]
        /// <summary>
        /// Initialize variable of the eta (can be regarded as step size).
        /// </summary>
        public float InitialEta
        {
            set { initialEta = value; }
            get { return initialEta; }
        }
        [Browsable(false)]
        /// <summary>
        /// Current root mean square after an epoch training.
        /// </summary>
        public float RootMeanSquareError
        {
            get { return rootMeanSquareError; } //set { rootMeanSquare = value; }
        }

        [Category("Traing Setting")]
        /// <summary>
        /// The factor of reducing the eta epoch by epoch. That is
        /// eta <-- LearningRate * eta
        /// </summary>
        public float Learning_Rate { get => learning_Rate; set => learning_Rate = value; }
        [Category("Traing Setting")]
        public int Epoch_Limit
        {
            get => epoch_Limit; set
            {
                if (value >0)
                epoch_Limit = value; 
            }
        }
        [Category("Traing Setting")]
        public float Training_Ratio
        {
            get => training_Ratio; 
            set {
                if (value > 0 && value<1)
                    training_Ratio = value;
            }
        }
        [Browsable(false)]
        public Series Series_RMSE { get => series_RMSE; set => series_RMSE = value; }
        [Browsable(false)]
        public double RMSE { get => rmse; set => rmse = value; }
        [Browsable(false)]
        public int Number_of_Testing_Data { get => number_of_Testing_Data; set => number_of_Testing_Data = value; }
        [Browsable(false)]
        public int Dimension_Target { get => dimension_Target; set => dimension_Target = value; }
        [Browsable(false)]
        public int[,] ConfusingTable { get => confusing_Table; set => confusing_Table = value; }
        [Browsable(false)]
        public bool Nn_Finished { get => nn_Finished; set => nn_Finished = value; }

        #endregion

        #region Helping Function

        /// <summary>
        /// Randomly shuffle the orders of the data in the data set.
        /// </summary>
        private void Shuffle_Indices_Array(int n, int take)
        {
            // shuffle current indices from 0 up to limit-1
            data_Indices = Enumerable.Range(0, n).OrderBy(x => rnd.Next()).Take(take).ToList().ToArray();
        }

        public float Activation_Function(float v)
        {
            return (float)(1.0 / (Math.Exp(-v) + 1.0));
        }

        public void Draw_MLP(Graphics g, Rectangle bounds)
        {
            if (n == null) return;
            
            Font font = new Font("Arial", 10.0f);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 0);
            int box_width = bounds.Height / 10;
            if (box_width < 10) box_width = 10;
            Rectangle dot = new Rectangle(0, 0, 5, 5);
            dot.Width = 5;
            Rectangle box = new Rectangle(0, 0, box_width, box_width);
            box_width /= 2;
            

            int width = bounds.Width / n.Length;
            int x_off = width / 2;
            for (int l = 0; l < n.Length; l++)
            {
                int h = bounds.Height / n[l];
                int y_off = h / 2;
                int x1 = x_off + width * l;
                int next_x;
                int next_y;
                int next_h;
                int w_gap =0;
                if (l!=n.Length-1)   w_gap= w[l+1][0].Length;
                for (int r = 0; r < n[l]; r++)
                {
                    int y = y_off + r * h;

                    if (r == 0)
                    {
                        dot.X = x1 - 2;
                        dot.Y = y - 2;
                        

                        // draw line
                        if (l != n.Length - 1)
                        {
                            for (int i = 1; i < n[l + 1]; i++)
                            {
                                next_x = (width / 2) + width * (l + 1);
                                next_h = bounds.Height / n[l+1];
                                next_y = (next_h / 2) + i * next_h;
                                g.DrawLine(Pens.Maroon, dot.X, dot.Y, next_x, next_y);
                                g.DrawString( Math.Round(w[l+1][i-1][r],2).ToString(), font, Brushes.Black, next_x - 3*box_width, next_y - w_gap * (font.Size+2));
                            }
                        }

                        // draw dot 
                        g.FillRectangle(Brushes.Red, dot);
                    }
                    else 
                    {
                        box.X = x1 - box_width;
                        box.Y = y - box_width;

                        // draw line
                        if (l != n.Length - 1)
                        {
                            for (int i = 1; i < n[l + 1]; i++)
                            {
                                next_x = (width / 2) + width * (l + 1);
                                next_h = bounds.Height / n[l + 1];
                                next_y = (next_h / 2) + i * next_h;
                                g.DrawLine(Pens.Maroon, box.X+box_width, box.Y + box_width, next_x, next_y);
                                g.DrawString(Math.Round(w[l + 1][i - 1][r], 2).ToString(), font, Brushes.Black, next_x - 3 * box_width, next_y - w_gap * (font.Size + 2) + r* (font.Size + 2));
                            }
                        }                     

                        // draw circle
                        g.FillEllipse(Brushes.White, box);
                        g.DrawEllipse(Pens.Black, box);
                        g.DrawString(Math.Round(x[l][r-1], 2).ToString(), font, Brushes.Maroon, box, sf);
                    }
                   
                }


            }
        }
        #endregion

        #region Run Time Function
        /// <summary>
        /// Read in the data set from the given file stream. Configure the portions of training 
        /// and testing data subsets. Original data are stored, bounds on each component of 
        /// input vector and target vector are founds, and normalized data set is prepared.
        /// </summary>
        /// <param name="sr">file stream</param>
        /// <param name="trainingRatio">portion of trainning data</param>
        public void Read_Data(string file_path)
        {
            StreamReader sr = new StreamReader(file_path);
            char[] separators = new char[] { ',', ' ' };
            string s = sr.ReadLine();
            string[] items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            number_of_Data = Convert.ToInt32(items[0]);
            dimension_inupt = Convert.ToInt32(items[1]);
            dimension_Target = Convert.ToInt32(items[2]);
            inputWidth = Convert.ToInt32(items[3]);

            original_Inputs = new float[number_of_Data, dimension_inupt];
            confusing_Table = new int[dimension_Target, dimension_Target];
            input_Max = new float[dimension_inupt];
            input_Min = new float[dimension_inupt];

            data_Indices = new int[number_of_Data];
            for (int r = 0; r < dimension_inupt; r++)
            {
                input_Max[r] = float.MinValue;
                input_Min[r] = float.MaxValue;
            }
            //for (int data = 0; data < number_of_Data; data++)
            //{
            //    for (int input = 0; input < dimension_inupt; input++)
            //    {
            //        if (original_Inputs[data, input] > input_Max[input])
            //            input_Max[input] = original_Inputs[data, input];
            //        if (original_Inputs[data, input] < input_Min[input])
            //            input_Min[input] = original_Inputs[data, input];
            //    }
                
            //}

            original_Targets = new float[number_of_Data, dimension_Target];
            for (int r = 0; r < number_of_Data; r++)
            {
                s = sr.ReadLine();
                items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < dimension_inupt; c++)
                {
                    original_Inputs[r, c] = float.Parse(items[c]);
                    if (original_Inputs[r, c] > input_Max[c]) input_Max[c] = original_Inputs[r, c];
                    else if (original_Inputs[r, c] < input_Min[c]) input_Min[c] = original_Inputs[r, c];
                }
                for (int i = dimension_inupt; i < items.Length; i++)
                    original_Targets[r, i - dimension_inupt] = float.Parse(items[i]);
            }
            sr.Close();

            series_RMSE = new Series("RMSE");
            series_RMSE.ChartType = SeriesChartType.Line;
            series_RMSE.Color = Color.Red;
            series_RMSE.BorderWidth = 2;
        }
        /// <summary>
        /// Configure the topology of the NN with the user specified numbers of hidden 
        /// neuorns and layers.
        /// </summary>
        /// <param name="hiddenNeuronNumbers">list of numbers of neurons of hidden layers</param>
        public void Configure_NeuralNetwork(int[] hiddenNeuronNumbers)
        {
            layerNumber = hiddenNeuronNumbers.Length + 2;

            // n contain error term
            n = new int[layerNumber];
            n[0] = dimension_inupt + 1;
            for (int i = 0; i < hiddenNeuronNumbers.Length; i++)
                n[i + 1] = hiddenNeuronNumbers[i] + 1;
            n[layerNumber - 1] = dimension_Target + 1;

            x = new float[layerNumber][];
            e = new float[layerNumber][];
            v = new float[layerNumber][];
            dw = new float[layerNumber][][];
            w = new float[layerNumber][][];
            for (int l = 0; l < layerNumber; l++)
            {
                x[l] = new float[n[l] - 1];
                if (l > 0)
                {
                    e[l] = new float[n[l] - 1];
                    v[l] = new float[n[l] - 1];
                    w[l] = new float[n[l] - 1][];
                    dw[l] = new float[n[l] - 1][];
                    for (int p = 0; p < w[l].Length; p++)
                    {
                        w[l][p] = new float[n[l - 1]];
                        dw[l][p] = new float[n[l - 1]];
                        for (int q = 0; q < w[l][p].Length; q++)
                        {
                            // initialize weight value
                            w[l][p][q] = (float)(2 * (rnd.NextDouble() - 0.5));
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Randomly set values of weights between [-1,1] and randomly shuffle the orders of all
        /// the datum in the data set. Reset value of initial eta and root mean square to 0.0.
        /// </summary>
        public void Reset_Weights_And_Initial_Condition(int[] hiddenNeuronNumbers)
        {
            series_RMSE.Points.Clear();
            Configure_NeuralNetwork(hiddenNeuronNumbers);
            number_of_Trainning_Data = (int)(training_Ratio * number_of_Data);
            number_of_Testing_Data = number_of_Data - number_of_Trainning_Data;
            for (int i = 0; i < number_of_Data; i++) data_Indices[i] = i;
            Shuffle_Indices_Array(number_of_Data, number_of_Data);

            eta = initialEta;
            current_Epoch = 0;
            nn_Finished = false;
        }

        /// <summary>
        /// Sequentially loop through each training datum of the training data whose indices are
        /// randomly shuffled in vectorIndices[] array, to perform on-line training of the NN.
        /// </summary>
        public void TrainAnEpoch()
        {
            int layerNumberMinusOne = layerNumber - 1;
            double error_sumation = 0.0;
            float xw;
            float ew;

            // loop though each training data
            for (int data = 0; data < number_of_Trainning_Data; data++)
            {
                // read input data
                for (int i = 0; i < dimension_inupt; i++)
                    x[0][i] = (original_Inputs[data_Indices[data], i]-input_Min[i])/(input_Max[i]-input_Min[i]);
                // update v, x
                for (int l = 1; l < v.Length; l++)
                {
                    for (int j = 0; j < v[l].Length; j++)
                    {
                        xw = 0;
                        for (int q = 1; q < w[l][j].Length; q++)
                            xw += x[l - 1][q - 1] * w[l][j][q];
                        v[l][j] = xw + w[l][j][0];
                        x[l][j] = Activation_Function(v[l][j]);
                    }
                }

                // read target data
                int end_index = n.Length - 1;
                for (int i = 0; i < dimension_Target; i++)
                    e[end_index][i] = -eta *
                        (original_Targets[data_Indices[data], i] - x[end_index][i]) *
                        (x[end_index][i]) *
                        (1 - x[end_index][i]);

                // update e
                for (int l = end_index - 1; l >= 1; l--)
                {
                    for (int r = 0; r < e[l].Length; r++)
                    {
                        ew = 0;
                        for (int s = 0; s < e[l + 1].Length; s++) // last layer e number
                            ew += e[l + 1][s] * w[l + 1][s][r + 1];
                        e[l][r] = x[l][r] * (1 - x[l][r]) * ew;
                    }
                }

                // update w
                for (int l = 1; l < w.Length; l++)
                {
                    for (int i = 0; i < w[l].Length; i++)
                    {
                        w[l][i][0] = w[l][i][0] + (-eta * e[l][i]);
                        for (int j = 1; j < w[l][i].Length; j++)
                            w[l][i][j] = w[l][i][j] + (-eta * e[l][i] * x[l - 1][j - 1]);
                    }
                }

            }
            /// forward computing for all neuro values.

            /// compute the epsilon values for neurons on the output layer

            /// backward computing for the epsilon values

            /// update weights for all weights by using epsilon and neuron values.

            /// At the end of the epoch,  update step size(learning rate) of the updating amount

            // calculate RMSE
            for (int data = number_of_Trainning_Data; data < number_of_Data; data++)
                error_sumation += ComputeResults(data_Indices[data]).Sum();
            error_sumation = error_sumation / (float)(number_of_Data - number_of_Trainning_Data);
            error_sumation = Math.Sqrt(((double)error_sumation));
            rmse = error_sumation;
            series_RMSE.Points.AddXY(current_Epoch, error_sumation);
            eta = eta * learning_Rate;

            if (current_Epoch < epoch_Limit)
                current_Epoch++;
            else
                nn_Finished = true;

        }
        public void Train_To_End()
        {
            for (int i = current_Epoch; i < epoch_Limit; i++)
            {
                TrainAnEpoch();
            }
        }
        #endregion

        #region Measuring Result
        /// <summary>
        /// Compute the output vector for an input vector. Both vectors are in the raw
        /// format. The input vector is subject to scaling first before forward computing.
        /// Output vector is then scaled back to raw format for recognition. 
        /// </summary>
        /// <param name="input">input vector in raw format</param>
        /// <returns>output vector in raw format</returns>
        public float[] ComputeResults(int data)
        {
            float[] error_term = new float[dimension_Target];
            float xw;

            // read input data
            for (int i = 0; i < dimension_inupt; i++)
                x[0][i] = (original_Inputs[data, i] - input_Min[i]) / (input_Max[i] - input_Min[i]);
            // update v, x
            for (int l = 1; l < v.Length; l++)
            {
                for (int j = 0; j < v[l].Length; j++)
                {
                    xw = 0;
                    for (int q = 1; q < w[l][j].Length; q++)
                        xw += x[l - 1][q - 1] * w[l][j][q];
                    v[l][j] = xw + w[l][j][0];
                    x[l][j] = Activation_Function(v[l][j]);
                }
            }

            // calculate e
            int end_index = n.Length - 1;
            for (int i = 0; i < dimension_Target; i++)
            {
                error_term[i] =
                        (original_Targets[data, i] - x[end_index][i]);
                error_term[i] = error_term[i] * error_term[i];
            }


            return error_term;
        }

        /// <summary>
        /// If the data set is a classification data set, test the data to generate confusing table.
        /// The index of the largest component of the target vector is the targeted class id.
        /// The index of the largest component of the computed output vector is the resulting class id.
        /// If both the targeted class id and the resulting class id are the same, then the test 
        /// data is correctly classified.
        /// </summary>
        /// <param name="out_confusingTable">generated confusing table</param>
        /// <returns>the ratio between the number of correctly classified testing data and the total number of testing 
        //data.</returns>
        public float TestingClassification()
        {
            confusing_Table = new int[dimension_Target, dimension_Target];
            int successed_Count = 0;
            float x_max = float.MinValue;
            int guess_Type=-1;
            int real_Type=-1;
            float xw;

            for (int i = 0; i < dimension_Target; i++)
            {
                for (int j = 0; j < dimension_Target; j++)
                {
                    confusing_Table[i, j] = 0;
                }
            }

            for (int data = number_of_Trainning_Data; data < number_of_Data; data++)
            {
                // read input data
                for (int i = 0; i < dimension_inupt; i++)
                    x[0][i] = (original_Inputs[data_Indices[data], i] - input_Min[i]) / (input_Max[i] - input_Min[i]);

                // update v, x
                for (int l = 1; l < v.Length; l++)
                {
                    for (int j = 0; j < v[l].Length; j++)
                    {
                        xw = 0;
                        for (int q = 1; q < w[l][j].Length; q++)
                            xw += x[l - 1][q - 1] * w[l][j][q];
                        v[l][j] = xw + w[l][j][0];
                        x[l][j] = Activation_Function(v[l][j]);
                    }

                    
                    if (l == v.Length-1) // define classification type
                    {
                        x_max = float.MinValue;
                        for (int i = 0; i < x[l].Length; i++)                       
                            if (x_max < x[l][i]) x_max = x[l][i];

                        for (int i = 0; i < x[l].Length; i++)
                        {
                            if (x[l][i] == x_max) guess_Type = i;
                        }
                    }
                }

                // check classification
                for (int i = 0; i < dimension_Target; i++)               
                    if (original_Targets[data_Indices[data],i] == 1) real_Type = i;
                if (guess_Type == real_Type) successed_Count++;

                confusing_Table[guess_Type, real_Type] += 1;
                //out_confusingTable
            }

            return (float)successed_Count;
        }
        #endregion
    }
}
