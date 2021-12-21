using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r09546042_TerryYang_Assignment11
{
    class BbackPropagationMLP
    {
        #region Data Field
        float[][] x; // neuron values
        float[][][] w; // weights
        float[][] e; // epsilon; partial derivative of error with respect to net value.
        int[] n; // numbers of neuron on layers
        int input_Dimension; // dimension of input vector
        int number_of_Data; // number of instances on the data set
        int number_of_Trainning_Data; // number of instances that are serving as training data
        float[,] originalInputs; // original instances of input vectors (without normalization)
        float[,] inputs; // normalized input vectors
        float[] inputMax; // upper bounds on all components of input vectors
        float[] inputMin; // lower bounds on all components of input vectors
        int inputWidth; // dimension in width for a two-dimensional input vector
        int target_Dimension; // dimension of target vector
        float[,] originalTargets; // original instances of target vectors (without normalization)
        float[,] targets; // normalized target vectors
        float[] targetMraax; // upper bounds on all components of target vectors
        float[] targetMin; // lower bounds on all components of target vectors.
        int[] data_Indices; // array of shuffled indices of data instances; the front portion is training vectors;
                             //the rear portion is testing vectors
        float rootMeanSquareError = 0.0f; // root mean square of error for an epoch of data training
        int layerNumber; // number of neuron layer (including the input layer)
        Random randomizer = new Random();
        float learning_Rate = 0.999f; // learning rate, specified by the user
        float training_Ratio;
        #endregion
        /// <summary>
        /// The factor of reducing the eta epoch by epoch. That is
        /// eta <-- LearningRate * eta
        /// </summary>
        public float LearningRate
        {
            get { return learning_Rate; }
            set { learning_Rate = value; }
        }
        float eta; // step size that specify the update amount on each weight
        float initialEta = 0.7f; // initial step size, specified by the user
        /// <summary>
        /// Initialize variable of the eta (can be regarded as step size).
        /// </summary>
        public float InitialEta
        {
            set { initialEta = value; }
            get { return initialEta; }
        }
        /// <summary>
        /// Current root mean square after an epoch training.
        /// </summary>
        public float RootMeanSquareError
        {
            get { return rootMeanSquareError; } //set { rootMeanSquare = value; }
        }
        /// <summary>
        /// Read in the data set from the given file stream. Configure the portions of training 
        /// and testing data subsets. Original data are stored, bounds on each component of 
        /// input vector and target vector are founds, and normalized data set is prepared.
        /// </summary>
        /// <param name="sr">file stream</param>
        /// <param name="trainingRatio">portion of trainning data</param>
        public void ReadInDataSet(string file_path)
        {
            StreamReader sr = new StreamReader(file_path);
            char[] separators = new char[] { ',', ' ' };
            string s = sr.ReadLine();
            string[] items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            number_of_Data = Convert.ToInt32(items[0]);
            input_Dimension = Convert.ToInt32(items[1]);
            target_Dimension = Convert.ToInt32(items[2]);
            inputWidth = Convert.ToInt32(items[3]);

            originalInputs = new float[number_of_Data, input_Dimension];          
            inputMax = new float[input_Dimension];
            inputMin = new float[input_Dimension];
            for (int r = 0; r < number_of_Data; r++)
            {
                inputMax[r] = float.MinValue;
                inputMin[r] = float.MaxValue;
            }

            originalTargets = new float[number_of_Data, target_Dimension];
            for (int r = 0; r < number_of_Data; r++)
            {
                s = sr.ReadLine();
                items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < input_Dimension; c++)
                {
                    originalInputs[r, c] = float.Parse(items[c]);
                    if (originalInputs[r, c] > inputMax[c]) inputMax[c] = originalInputs[r, c];
                    else if (originalInputs[r, c] < inputMin[c]) inputMin[c] = originalInputs[r, c];
                }
            }
            sr.Close();
        }
        /// <summary>
        /// Configure the topology of the NN with the user specified numbers of hidden 
        /// neuorns and layers.
        /// </summary>
        /// <param name="hiddenNeuronNumbers">list of numbers of neurons of hidden layers</param>
        public void ConfigureNeuralNetwork(int[] hiddenNeuronNumbers)
        {
            layerNumber = hiddenNeuronNumbers.Length + 2;
            n = new int[layerNumber];
            n[0] = input_Dimension + 1;

            n[layerNumber - 1] = target_Dimension + 1;

            x = new float[layerNumber][];
            w = new float[layerNumber][][];
            for (int l = 0; l < layerNumber; l++)
            {
                x[l] = new float[n[l]];
                if (l > 0)
                {
                    e[l] = new float[n[l]];
                    w[l] = new float[n[l]][];
                    //for (int p = 0; p < n[l - 1]; p++)
                        //w[l][p] = new float[];
                }

            }
        }
        /// <summary>
        /// Randomly shuffle the orders of the data in the data set.
        /// </summary>
        private void Shuffle_Indices_Array(int limit)
        {
            // shuffle current indices from 0 up to limit-1
        }
        /// <summary>
        /// Randomly set values of weights between [-1,1] and randomly shuffle the orders of all
        /// the datum in the data set. Reset value of initial eta and root mean square to 0.0.
        /// </summary>
        public void ResetWeightsAndInitialCondition(int [] hiddenNeuronNumbers)
        {
            ConfigureNeuralNetwork(hiddenNeuronNumbers);
            number_of_Trainning_Data = (int)(training_Ratio * number_of_Data);
            for (int i = 0; i < number_of_Data; i++) data_Indices[i] = i;
            Shuffle_Indices_Array(number_of_Data);
            //Shuffle_Indices_Array(number_of_Trainning_Data);

            // initialize weight value
            for (int l = 0; l < w.Length; l++)            
                for (int i = 0; i < w[l].Length; i++)               
                    for (int j = 0; j < w[l][i].Length; j++)                  
                        w[l][i][j] = (float)(randomizer.NextDouble() * 2-1.0);
          
            eta = initialEta;
        }
        /// <summary>
        /// Sequentially loop through each training datum of the training data whose indices are
        /// randomly shuffled in vectorIndices[] array, to perform on-line training of the NN.
        /// </summary>
        public void TrainAnEpoch()
        {
            float v;
            float errorSquareSum = 0.0f;
            float sumation = 0.0f;
            int layerNumberMinusOne = layerNumber - 1;
            // loop though each training data
            /// forward computing for all neuro values.

            /// compute the epsilon values for neurons on the output layer

            /// backward computing for the epsilon values

            /// update weights for all weights by using epsilon and neuron values.

            /// At the end of the epoch,  update step size(learning rate) of the updating amount
            eta = eta * learning_Rate;
        }

        public void Train_To_End()
        { 
            
        }
        /// <summary>
        /// Compute the output vector for an input vector. Both vectors are in the raw
        /// format. The input vector is subject to scaling first before forward computing.
        /// Output vector is then scaled back to raw format for recognition. 
        /// </summary>
        /// <param name="input">input vector in raw format</param>
        /// <returns>output vector in raw format</returns>
        public float[] ComputeResults(float[] input)
        {
            float[] results = null;
            float v;
            results = new float[target_Dimension];

        return results;
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
        public float TestingClassification(out int[,] out_confusingTable)
        {
            out_confusingTable = new int[target_Dimension, target_Dimension];
            int successedCount = 0;
            float v;
            out_confusingTable = out_confusingTable;
        return (float)successedCount / (float)(number_of_Data - number_of_Trainning_Data);
        }

    }
}
