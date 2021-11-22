using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerryYang_GA_Library;
using static TerryYang_GA_Library.Generic_GA_Solver<byte>;

namespace r09546042_TerryYang_Assignment07
{
    public partial class Main_Form : Form
    {
        Generic_GA_Solver<byte> GA_Solver = null;
        int number_of_Jobs;
        public Main_Form()
        {
            InitializeComponent();
            Setup_UI();
        }
        #region Helping Functions
        public void Setup_UI()
        {
            Generate_Problem_at_DGV();
        }
        public void Generate_Problem_at_DGV()
        {
            number_of_Jobs = int.Parse(CB_Number_of_Jobs.Text);
            Random rnd = new Random();
            double rnd_minimum = decimal.ToDouble( NUD_minimum.Value);
            double rnd_maximum = decimal.ToDouble( NUD_maximum.Value);

            // removed existed data
            DGV_Problem.Rows.Clear();
            DGV_Problem.Columns.Clear();

            // adding headers to DGV
            DGV_Problem.TopLeftHeaderCell.Value="Job/Machine";
            for (int i = 1; i < number_of_Jobs+1; i++)
            {
                DGV_Problem.Columns.Add($"M{i}", $"M{i}");
                DGV_Problem.Rows.Add();               
                DGV_Problem.Rows[i-1].HeaderCell.Value = $"J{i}";
            }

            // adding rnd data to DGV
            for (int col = 0; col < DGV_Problem.Columns.Count; col++)
            {
                for (int row = 0; row < DGV_Problem.Rows.Count; row++)
                {
                    if (col != row)
                    {
                        double rnd_value = Math.Round( rnd_minimum + (rnd.NextDouble() * (rnd_maximum - rnd_minimum)),3);
                        DGV_Problem[col, row].Value = rnd_value;
                    }
                    else
                        DGV_Problem[col, row].Value = 0;
                }
            }
            DGV_Problem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }
        public Selection_Type Get_Selection_Type()
        {
            Selection_Type sel_type;
            if (RDB_Stochastic.Checked)
                sel_type = Selection_Type.Stochastic;
            else
                sel_type = Selection_Type.Deterministic;
            return sel_type;
        }

        public double Get_Setup_Time_Total(byte[] solution)
        {
            double objective_Value = 0 ;
            int current_Job_ID = 0; // row count

            for (int row = 0; row < number_of_Jobs; row++)
            {
                for (int column = 0; column < number_of_Jobs; column++)
                {
                    objective_Value += Convert.ToDouble(solution[current_Job_ID]) * Convert.ToDouble(DGV_Problem[row, column].Value);
                    current_Job_ID++;
                }
            }

        return objective_Value;
        }
        #endregion


        #region ButtomEvents
        private void BTN_proGenerate_Click(object sender, EventArgs e)
        {
            Generate_Problem_at_DGV();
        }
        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            int population_Size = decimal.ToInt32(NUD_population.Value);
            double crossover_Rate = decimal.ToDouble(NUD_crossrate.Value);
            double mutate_Rate = decimal.ToDouble(NUD_mutaterate.Value);
            Selection_Type sel_type = Get_Selection_Type();
            if (RDB_Binary.Checked)
                GA_Solver = new Binary_GA(number_of_Jobs*number_of_Jobs, Optimization_Type.Minimization,Get_Setup_Time_Total);
            GA_Solver.Selection_Type1 = sel_type;
            GA_Solver.Crossover_Rate = Convert.ToDouble(NUD_crossrate.Value);
            GA_Solver.Mutation_Rate = Convert.ToDouble(NUD_mutaterate.Value);
            GA_Solver.Reset();
        }
        private void BTN_Run_one_Click(object sender, EventArgs e)
        {
            RTB_Population.Clear();
            GA_Solver.Run_One_Iteration();
            TB_BOV.Text = GA_Solver.So_Far_The_Best_Objective_Value.ToString();
            RTB_BOV.Text = GA_Solver.Flatten_Solution_to_String(GA_Solver.So_Far_The_Best_Soulution);

            RTB_Population.Text += "Current Iteration: " + GA_Solver.Iteration_ID.ToString();
            RTB_Population.Text += "Parents: " + "\n";
            for (int i = 0; i < NUD_population.Value; i++)
            {
                RTB_Population.Text += GA_Solver.Flatten_Solution_to_String(GA_Solver.Chromosomes[i])+"\n";
            }
            RTB_Population.Text += "Crossovered: " + "\n";
            //for (int i = 0; i < NUD_population.Value+GA_Solver; i++)
            //{
            //    RTB_Population.Text += GA_Solver.Flatten_Solution_to_String(GA_Solver.Chromosomes[i]) + "\n";
            //}
        }
        #endregion


    }
}
