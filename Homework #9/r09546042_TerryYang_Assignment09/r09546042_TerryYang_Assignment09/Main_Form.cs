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
using TerryYang_GA_Library;


namespace r09546042_TerryYang_Assignment09
{
    public partial class Main_Form : Form
    {
        #region Data Field
        Ant_Colony_System_For_Sequencing_Problems ACS = null;
        Permutation_GA GA = null;
        int number_Of_Cites;
        double[,] coordinates;
        double[,] distance_Inversed;
        int[] so_Far_The_Best_Routh;
        #endregion

        public Main_Form()
        {
            InitializeComponent();
        }

        

        #region Helping Functions
        public double Objective_Function(int[] solution)
        {
            double distance = 0;
            for (int i = 0; i < solution.Length-1; i++)           
                distance += Calculate_Distance(solution[ i], solution[i + 1]);
            distance += Calculate_Distance(solution[ 0], solution[ solution.Length-1]);
            return distance;
        }
        public double Objective_Function_Per(int[] solution, bool f)
        {
            double distance = 0;
            for (int i = 0; i < solution.Length - 1; i++)
                distance += Calculate_Distance(solution[i], solution[i + 1]);
            distance += Calculate_Distance(solution[0], solution[solution.Length - 1]);
            return distance;
        }

        private double Calculate_Distance(int p_index_1, int p_index_2)
        {
            double distance;
            double[] p1 = new double[2];
            p1[0] = coordinates[p_index_1, 0];
            p1[1] = coordinates[p_index_1, 1];

            double[] p2 = new double[2];
            p2[0] = coordinates[p_index_2, 0];
            p2[1] = coordinates[p_index_2, 1];

            // 歐式距離
            double x_squre = Math.Pow((p1[0] - p2[0]), 2);
            double y_squre = Math.Pow((p1[1] - p2[1]), 2);
            distance = Math.Sqrt(x_squre + y_squre);

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
        public void Update_UI_Element()
        {
            LSB_Solution.Items.Clear();
            LSB_Phromone.Items.Clear();

            // update so far the best solution
            CT_Route.Series[1].Points.Clear();
            if (ACS == null)
            {
                string str = string.Empty;
                for (int i = 0; i < number_Of_Cites; i++)
                    str += GA.So_Far_The_Best_Soulution[i] + " ";
                LB_SFTBS.Text = "So Far The Best Solution: \n" + str;
                LB_SFTSL.Text = "So Far The Shorest Length: " + Math.Round(GA.So_Far_The_Best_Objective_Value, 3).ToString();

                // update route map
                for (int i = 0; i < number_Of_Cites; i++)
                {
                    int index = GA.So_Far_The_Best_Soulution[i];
                    CT_Route.Series[1].Points.AddXY(coordinates[index, 0], coordinates[index, 1]);
                }
                CT_Route.Series[1].Points.AddXY(coordinates[GA.So_Far_The_Best_Soulution[0], 0], coordinates[GA.So_Far_The_Best_Soulution[number_Of_Cites-1], 1]);
            }
            else
            {
                for (int i = 0; i < ACS.Population; i++)
                    LSB_Solution.Items.Add(ACS.Return_A_Solution(i));

                for (int i = 0; i < number_Of_Cites; i++)
                    LSB_Phromone.Items.Add(ACS.Return_Pheromone_Matrix(i, 3));

                string str = string.Empty;
                for (int i = 0; i < number_Of_Cites; i++)
                    str += ACS.So_Far_The_Best_Solution[i] + " ";
                LB_SFTBS.Text = "So Far The Best Solution: \n" + str;
                LB_SFTSL.Text = "So Far The Shorest Length: " + Math.Round(ACS.So_Far_The_Best_Objective, 3).ToString();

                // update route map
                for (int i = 0; i < number_Of_Cites; i++)
                {
                    int index = ACS.So_Far_The_Best_Solution[i];
                    CT_Route.Series[1].Points.AddXY(coordinates[index, 0], coordinates[index, 1]);
                }
                CT_Route.Series[1].Points.AddXY(coordinates[ACS.So_Far_The_Best_Solution[0], 0], coordinates[ACS.So_Far_The_Best_Solution[number_Of_Cites-1], 1]);
            }

            PPTG_model.Update();
            CT_Model.Update();
            CT_Route.Update();
        }
        #endregion

        #region BTN Functions
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GB_Model.Enabled = false;
            BTN_Reset.Enabled = false;
            BTN_Run_To_End.Enabled = false;
            BTN_Run_One.Enabled = false;

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            GB_Model.Enabled = true;
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
            CT_Route.Series[1].Points.Clear();

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
                dp.Label = (i).ToString();
                CT_Route.Series[0].Points.Add(dp);
            }

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


            // make route chart square
            int min_Size = Math.Min(CT_Route.Parent.Size.Width, CT_Route.Parent.Size.Height);
            CT_Route.Size= new Size(min_Size,min_Size);
            CT_Route.Location = new Point((int)((CT_Route.Parent.Width / 2.0) - (CT_Route.Size.Width / 2.0)), 0);
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            CT_Model.Series.Clear();
            if (ACS == null)
            {
                GA.Reset();               
                CT_Model.Series.Add(GA.Series_Average);
                CT_Model.Series.Add(GA.Series_IterationTheBest);
                CT_Model.Series.Add(GA.Series_SoFarTheBest);
            }
            else
            {
                ACS.Reset();
                CT_Model.Series.Add(ACS.Series_Iteration_Average_Objective);
                CT_Model.Series.Add(ACS.Series_iteration_The_Best_Objective);
                CT_Model.Series.Add(ACS.Series_So_Far_The_Best_Objective);
            }

            Update_UI_Element();
            // enable
            BTN_Run_One.Enabled = true ;
            BTN_Run_To_End.Enabled = true;
        }
        #endregion

        private void BTN_Create_ACS_Model_Click(object sender, EventArgs e)
        {
            ACS = new Ant_Colony_System_For_Sequencing_Problems(number_Of_Cites, distance_Inversed, Optimization_Type.Minimization, Objective_Function);
            PPTG_model.SelectedObject = ACS;
            BTN_Reset.Enabled = true;

            GA = null;
        }

        private void BTN_Run_One_Click(object sender, EventArgs e)
        {
            if (ACS == null)
                GA.Run_One_Iteration();
            else
                ACS.Run_One_Iteration();
            Update_UI_Element();
        }

        private void BTN_Run_To_End_Click(object sender, EventArgs e)
        {
            if (CB_Animation.Checked)
                Timer.Enabled = true;
            else
            {
                if (ACS == null)
                    GA.Run_To_End(GA.Iteration_Limit);
                else
                    ACS.Run_To_End();
            }
                
            Update_UI_Element();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CB_Animation.Checked)
            {
                if (ACS == null && GA.Current_Iteration <= GA.Iteration_Limit)
                    GA.Run_One_Iteration();
                else if (ACS.Current_Iteration <= ACS.Iteration_Limit)
                    ACS.Run_One_Iteration();
                else
                    CB_Animation.Checked = false;
                Update_UI_Element();
            }
        }

        private void CB_Animation_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Animation.Checked == false)
            {
                Timer.Enabled = false;
                Update_UI_Element();
            }
                
        }

        private void BTN_GA_Click(object sender, EventArgs e)
        {
            GA = new Permutation_GA(number_Of_Cites, GA_Optimization_Type.Minimization, Objective_Function_Per, Permutation_Crossover_Type.Parial_Mapped_X, Permutation_Mutation_Type.Displacement);
            PPTG_model.SelectedObject = GA;
            BTN_Reset.Enabled = true;

            ACS = null;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0) return;
            int interval = (int)(Convert.ToDouble(numericUpDown1.Value) / 100.0);
            if (interval <= 0) return;

            Timer.Interval = interval;
        }

        private void TBC_Show_result_SizeChanged(object sender, EventArgs e)
        {
            // make route chart square
            int min_Size = Math.Min(CT_Route.Parent.Size.Width, CT_Route.Parent.Size.Height);
            CT_Route.Size = new Size(min_Size, min_Size);
            CT_Route.Location = new Point( (int)((CT_Route.Parent.Width / 2.0) - (CT_Route.Size.Width / 2.0)) , 0);
        }
    }
}