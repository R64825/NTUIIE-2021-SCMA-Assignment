using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COP;
using Particle_Swamp_Optimizer;
using ABC_library;
using TerryYang_GA_Library;
using System.Windows.Forms.DataVisualization.Charting;

namespace r09546042_TerryYang_FinalProject
{
    public partial class Form_Compare : Form
    {
        Random rnd;// = new Random();

        COPBenchmark the_Problem;
        Artificial_Bee_Colony ABC_Solver;
        Directed_Artificial_Bee_Colony dABC_Solver;
        Real_Number_Encoded_GA GA_Solver;
        Particle_Swamp_Optimizer_Solver PSO_Solver;

        // statistic
        double[][] val_End_Best;
        double[][] val_Initial_Best;

        // series
        Series series_GA_SFTB;
        Series series_PSO_SFTB;
        Series series_ABC_SFTB;
        Series series_dABC_SFTB;

        static int i = 0;

        int iteration_Limit;
        int number_Of_Agents;
        int number_Of_Test;

        public Form_Compare()
        {
            InitializeComponent();          
        }
        #region Calculate Statistic
        static double Get_STD(IEnumerable<double> sequence)
        {
            double result = 0;

            if (sequence.Any())
            {
                double average = sequence.Average();
                double sum = sequence.Sum(d => Math.Pow(d - average, 2));
                result = Math.Sqrt((sum) / (sequence.Count() - 1));
            }
            return result;
        }

        static double Get_MED(double[] data)
        {
            Array.Sort(data);
            int len = data.Length;
            double med = -1;
            if (len%2 == 0)
            {
                med = data[len/ 2] + data[(len/2)-1];
                med /= 2;
            }
            else
            {
                med = data[(len - 1) / 2];
            }
            return med;
        }

        static double Get_MOD(double[] data)
        {
            var mode = data.GroupBy(n => n).
                OrderByDescending(g => g.Count()).
                Select(g => g.Key).FirstOrDefault();
            return mode;
        }
        #endregion

        private void Read_Input()
        {
            iteration_Limit = decimal.ToInt32(NUD_Iter_Limit.Value);
            number_Of_Agents = decimal.ToInt32(NUD_Agents.Value);
            number_Of_Test = decimal.ToInt32(NUD_Test.Value);
            Pro_Bar.Maximum = number_Of_Test;
        }
        private void BTN_Val_Open_Click(object sender, EventArgs e)
        {
            the_Problem = COPBenchmark.LoadAProblemFromAFile();
            if (the_Problem == null) return;
            BTN_Val_Open.Text = "Benchmark: " + the_Problem.Title;

            // Argo's
            ABC_Solver = new Artificial_Bee_Colony(the_Problem);
            ABC_Solver.Iteration_Limit = iteration_Limit;
            ABC_Solver.Population_Size = number_Of_Agents;
            ABC_Solver.Reset();

            dABC_Solver = new Directed_Artificial_Bee_Colony(the_Problem);
            dABC_Solver.Iteration_Limit = iteration_Limit;
            dABC_Solver.Population_Size = number_Of_Agents;
            dABC_Solver.Reset();

            PSO_Solver = new Particle_Swamp_Optimizer_Solver(the_Problem);
            PSO_Solver.Iteration_Limit = iteration_Limit;
            PSO_Solver.Number_Of_Particles = number_Of_Agents;
            PSO_Solver.Reset();

            GA_Optimization_Type type;
            if (the_Problem.OptimizationGoal == OptimizationType.Minimization)
                type = GA_Optimization_Type.Minimization;
            else
                type = GA_Optimization_Type.Maximization;
            GA_Solver = new Real_Number_Encoded_GA(the_Problem.Dimension, the_Problem.LowerBound, the_Problem.UpperBound, type, the_Problem.GetObjectiveValue);
            GA_Solver.Iteration_Limit = iteration_Limit;
            GA_Solver.Population = number_Of_Agents;
            GA_Solver.Reset();

            PPTG.SelectedObject = GA_Solver;

            // enable
            GB_Validation.Enabled = true;
            GB_Argo.Enabled = true;
        }
        private void Plot_SFTB_Comparsion()
        {
            CT_Comparsion.Series.Clear();
            series_GA_SFTB = new Series("GA");
            series_PSO_SFTB = new Series("PSO");
            series_ABC_SFTB = new Series("ABC");
            series_dABC_SFTB = new Series("dABC");
            series_GA_SFTB.Color = Color.Coral;
            series_PSO_SFTB.Color = Color.LimeGreen;
            series_ABC_SFTB.Color = Color.CadetBlue;
            series_dABC_SFTB.Color = Color.Brown;
            series_GA_SFTB.ChartType = SeriesChartType.Line;
            series_PSO_SFTB.ChartType = SeriesChartType.Line;
            series_ABC_SFTB.ChartType = SeriesChartType.Line;
            series_dABC_SFTB.ChartType = SeriesChartType.Line;
            series_GA_SFTB.BorderWidth = 2;
            series_PSO_SFTB.BorderWidth = 2;
            series_ABC_SFTB.BorderWidth = 2;
            series_dABC_SFTB.BorderWidth = 2;
            series_GA_SFTB.MarkerStyle = MarkerStyle.Cross;
            series_PSO_SFTB.MarkerStyle = MarkerStyle.Cross;
            series_ABC_SFTB.MarkerStyle = MarkerStyle.Cross;
            series_dABC_SFTB.MarkerStyle = MarkerStyle.Cross;

            for (int t = 0; t < number_Of_Test; t++)
            {
                series_GA_SFTB.Points.AddXY(t+1, val_End_Best[0][t]);
                series_PSO_SFTB.Points.AddXY(t+1, val_End_Best[1][t]);
                series_ABC_SFTB.Points.AddXY(t+1, val_End_Best[ 2][t]);
                series_dABC_SFTB.Points.AddXY(t+1, val_End_Best[ 3][t]);
            }

            CT_Comparsion.Series.Add(series_GA_SFTB);
            CT_Comparsion.Series.Add(series_PSO_SFTB);
            CT_Comparsion.Series.Add(series_ABC_SFTB);
            CT_Comparsion.Series.Add(series_dABC_SFTB);
            CT_Comparsion.ChartAreas[0].RecalculateAxesScale();
            CT_Comparsion.ChartAreas[0].AxisX.Maximum = number_Of_Test;


            //Scyn two charts
            ChartArea ca1 = CT_Comparsion.ChartAreas[0];
            Axis ax1 = ca1.AxisY;
            ax1.ScaleView.Zoomable = true;
            ca1.CursorY.IsUserSelectionEnabled = true;
        }
        private void Write_DGV_Comparsion()
        {
            // removed existed data
            DGV.EnableHeadersVisualStyles = false;
            DGV.Rows.Clear();
            DGV.Columns.Clear();

            // adding headers to DGV
            DGV.TopLeftHeaderCell.Value = "Argorithm/Statistic";
            DGV.Columns.Add("AVG", "Average");
            DGV.Columns.Add("STD", "Standard deviation");
            DGV.Columns.Add("RNG", "Range");
            DGV.Columns.Add("MED", "Median");
            DGV.Columns.Add("MOD", "Mode");
            //DGV.Columns.Add("IB", "Average initial Best");
            //DGV.Columns.Add("EB", "Average end Best");
            //DGV.Columns.Add("CT", "Average converge Rate");

            DGV.Rows.Add();
            DGV.Rows[0].HeaderCell.Value = "GA";
            DGV.Rows[0].HeaderCell.Style.BackColor = series_GA_SFTB.Color;
            DGV.Rows.Add();
            DGV.Rows[1].HeaderCell.Value = "PSO";
            DGV.Rows[1].HeaderCell.Style.BackColor = series_PSO_SFTB.Color;
            DGV.Rows.Add();
            DGV.Rows[2].HeaderCell.Value = "ABC";
            DGV.Rows[2].HeaderCell.Style.BackColor = series_ABC_SFTB.Color;
            DGV.Rows.Add();
            DGV.Rows[3].HeaderCell.Value = "dABC";
            DGV.Rows[3].HeaderCell.Style.BackColor = series_dABC_SFTB.Color;



            for (int row = 0; row < DGV.Rows.Count; row++)
            {
                // fill statistic
                DGV["AVG", row].Value = Math.Round(val_End_Best[row].Average(), 3);
                DGV["STD", row].Value = Math.Round(Get_STD(val_End_Best[row]), 3);
                DGV["RNG", row].Value = Math.Round((val_End_Best[row].Max() - val_End_Best[row].Min()), 3);
                DGV["MED", row].Value = Math.Round(Get_MED(val_End_Best[row]), 3);
                DGV["MOD", row].Value = Math.Round(Get_MOD(val_End_Best[row]), 3);
                DGV.Rows[row].HeaderCell.Style.ForeColor = Color.White;
                // fill sol
                //DGV["CT", row].Value = 
                //Math.Round(((val_Initial_Best[row].Average() - val_End_Best[row].Average())/iteration_Limit), 3);
            }

               
            
            DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGV.Columns[DGV.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Update_Pro_Bar(int t)
        {
            Pro_Bar.Value = t+1;
        }
        private void CB_Argo_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (the_Problem == null) return;
            switch (CB_Argo.Text)
            {
                case "GA":
                    PPTG.SelectedObject = GA_Solver;
                    break;
                case "PSO":
                    PPTG.SelectedObject = PSO_Solver;
                    break;
                case "ABC":
                    PPTG.SelectedObject = ABC_Solver;
                    break;
                case "dABC":
                    PPTG.SelectedObject = dABC_Solver;
                    break;
                default:
                    break;
            }
        }

        private void PPTG_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            PPTG.Refresh();

            // reset model
            GA_Solver.Reset();
            PSO_Solver.Reset();
            ABC_Solver.Reset();
            dABC_Solver.Reset();

        }

        private void BTN_Validate_Click(object sender, EventArgs e)
        {
            Read_Input();
            // 0 GA, 1 PSO, 2 ABC, 3 dABC
            val_End_Best = new double[CB_Argo.Items.Count ][];
            val_Initial_Best = new double[CB_Argo.Items.Count][];
            for (int r = 0; r < CB_Argo.Items.Count; r++)
            {
                val_End_Best[r] = new double[number_Of_Test];
                val_Initial_Best[r] = new double[number_Of_Test];
            }
            for (int t = 0; t < number_Of_Test; t++)
            {
                #region Reset
                // Argo's
                ABC_Solver.Iteration_Limit = iteration_Limit;
                ABC_Solver.Population_Size = number_Of_Agents;
                ABC_Solver.Reset();

                dABC_Solver.Iteration_Limit = iteration_Limit;
                dABC_Solver.Population_Size = number_Of_Agents;
                dABC_Solver.Reset();

                PSO_Solver.Iteration_Limit = iteration_Limit;
                PSO_Solver.Number_Of_Particles = number_Of_Agents;
                PSO_Solver.Reset();

                GA_Optimization_Type type;
                if (the_Problem.OptimizationGoal == OptimizationType.Minimization)
                    type = GA_Optimization_Type.Minimization;
                else
                    type = GA_Optimization_Type.Maximization;               
                GA_Solver.Iteration_Limit = iteration_Limit;
                GA_Solver.Population = number_Of_Agents;
                GA_Solver.Reset();
                #endregion

                // model run to end
                GA_Solver.Run_To_End();
                val_End_Best[0][t] = GA_Solver.So_Far_The_Best_Objective_Value;
                val_Initial_Best[0][t] = GA_Solver.Initial_Best_OBJ;

                PSO_Solver.Run_To_End();
                val_End_Best[1][t] = PSO_Solver.So_Far_the_Best_Objective;
                val_Initial_Best[1][t] = PSO_Solver.Initial_Best_OBJ;

                ABC_Solver.Run_To_End();
                val_End_Best[2][t] = ABC_Solver.So_Far_Best_OBJ;
                val_Initial_Best[2][t] = ABC_Solver.Initial_Best_OBJ;

                dABC_Solver.Run_To_End();
                val_End_Best[3][t] = dABC_Solver.So_Far_Best_OBJ;
                val_Initial_Best[3][t] = dABC_Solver.Initial_Best_OBJ;

                Update_Pro_Bar(t);
            }

            Plot_SFTB_Comparsion();
            Write_DGV_Comparsion();
        }

        private void Form_Compare_SizeChanged(object sender, EventArgs e)
        {
            Pro_Bar.Width = this.Width - 50;
        }
    }
}
