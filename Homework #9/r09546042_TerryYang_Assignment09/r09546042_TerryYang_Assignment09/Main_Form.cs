using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Ant_Colony_System_Library;


namespace r09546042_TerryYang_Assignment09
{
    public partial class Main_Form : Form
    {
        #region Data Field
        Ant_Colony_System_For_Sequencing_Problems ACS = null;
        int number_Of_Cites;
        double[,] from_To_Distances;
        double[,] coordinates;
        double[,] distance_Inversed;
        int[] so_Far_The_Best_Routh;
        public event EventHandler event_;
        #endregion

        public Main_Form()
        {
            InitializeComponent();
        }

        #region Helping Functions
        public double Objective_Function(int[] solution)
        {
            double distance = 0;
            for (int i = 0; i < solution.Length; i++)           
                distance += Calculate_Distance(i, i + 1);
            distance += Calculate_Distance(0,solution.Length);
            return distance;
        }
        public double[] Return_Array(double[,] Arr, int index)
        {
            double[] d = new double[2];
            d[0] = Arr[index, 0];
            d[1] = Arr[index, 1];
            return d;
        }
        //public double Get_The_Routh_Length(int[] route)
        //{
        //    // use from-to matrix to calculate length

        //    return 0.0;
        //}
        private double Calculate_Distance(int p_index_1, int p_index_2)
        {
            double distance;
            double[] p1 = new double[2];
            p1[0] = coordinates[p_index_1, 0];
            p1[1] = coordinates[p_index_1, 1];

            double[] p2 = new double[2];
            p2[0] = coordinates[p_index_2, 0];
            p2[1] = coordinates[p_index_2, 1];

            double x_squre = Math.Pow((p1[0] - p2[0]), 2);
            double y_squre = Math.Pow((p1[1] - p2[1]), 2); ;
            distance = Math.Sqrt(x_squre+y_squre);
            return distance;
        }
        private void Show_Problem_Description(string name, string comment, string type, string edge_Weight_Type)
        {
            LST_Problem.Items.Clear();
            LST_Problem.Items.Add("Title: "+ name);
            LST_Problem.Items.Add("Description: "+comment);
            //LST_Problem.Items.Add("Type: " + type);
            LST_Problem.Items.Add("Dimension: " + number_Of_Cites);
            //LST_Problem.Items.Add("Edge: " + edge_Weight_Type);
        }
        #endregion

        #region BTN Functions
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            // read model discription
            StreamReader sr = new StreamReader(dlg.FileName);
            string str = string.Empty;
            str = sr.ReadLine();
            string problem_Name = str.Split(':')[1].Replace(" ", string.Empty);
            str = sr.ReadLine();
            string problem_Comment = str.Split(':')[1];//.Replace(" ", string.Empty); ;
            str = sr.ReadLine();
            string problem_Type = str.Split(':')[1].Replace(" ", string.Empty); ;
            str = sr.ReadLine();
            number_Of_Cites = int.Parse( str.Split(':')[1].Replace(" ", string.Empty));
            str = sr.ReadLine();
            string edge_Weight_Type = str.Split(':')[1].Replace(" ", string.Empty); ;

            // read coordinates

            CT_Route.Series[0].Points.Clear();
            CT_Route.Series[0].Color = Color.Red;
            str = sr.ReadLine();
            coordinates = new double[number_Of_Cites, 2];
            char[] seps = { ' ', ',' };
            for (int i = 0; i < number_Of_Cites; i++)
            {
                string[] items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                coordinates[i, 0] = double.Parse(items[1]);
                coordinates[i, 1] = double.Parse(items[2]);
                DataPoint dp = new DataPoint(coordinates[i, 0], coordinates[i, 1]);
                dp.MarkerStyle = MarkerStyle.Square;
                dp.MarkerBorderWidth = 1;
                dp.MarkerSize = 5;
                dp.MarkerColor = Color.White;
                dp.MarkerBorderColor = Color.Black;
                //dp.Label = (i + 1).ToString();

                CT_Route.Series[0].Points.Add(dp);
            }

            //double min = double.MaxValue;
            //double max = double.MinValue;
            //double ct_Min = Math.Min(CT_Route.ChartAreas[0].AxisX.Minimum, CT_Route.ChartAreas[0].AxisY.Minimum);
            //double ct_Max = Math.Max(CT_Route.ChartAreas[0].AxisX.Maximum, CT_Route.ChartAreas[0].AxisY.Maximum);

            //CT_Route.ChartAreas[0].AxisX.Minimum = ct_Min;
            //CT_Route.ChartAreas[0].AxisY.Minimum = ct_Min;
            //CT_Route.ChartAreas[0].AxisX.Maximum = ct_Max;
            //CT_Route.ChartAreas[0].AxisY.Maximum = ct_Max;


            // calculate distance inverse matrix
            distance_Inversed = new double[number_Of_Cites, number_Of_Cites];
            for (int s = 0; s < number_Of_Cites; s++)
                for (int t = 0; t < number_Of_Cites; t++)
                {
                    if (s == t )
                        distance_Inversed[s, t] = 0;
                    else
                    {
                        distance_Inversed[s, t] = 1.0 / Calculate_Distance(s, t);
                    }
                    
                }


            // show
            Show_Problem_Description(problem_Name, problem_Comment, problem_Type, edge_Weight_Type);
            sr.Close();
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ACS.Reset();
            //event_ += ACS.So_Far_The_Best_Update;
        }
        #endregion

        private void BTN_Create_ACS_Model_Click(object sender, EventArgs e)
        {
            ACS = new Ant_Colony_System_For_Sequencing_Problems(number_Of_Cites, distance_Inversed, Optimization_Type.Minimization, Objective_Function);
        }
    }
}
