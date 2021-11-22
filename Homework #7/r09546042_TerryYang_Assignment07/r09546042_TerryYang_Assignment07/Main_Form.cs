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
        public void Update_New_Solutions_on_UI()
        {
            TB_BOV.Text = GA_Solver.So_Far_The_Best_Objective_Value.ToString();
            RTB_BOV.Text = GA_Solver.Flatten_Solution_to_String(GA_Solver.So_Far_The_Best_Soulution);

            // print out chromosomes in rich text box
            RTB_Population.Text += "Current Iteration: " + GA_Solver.Iteration_ID.ToString() + "\n";
            RTB_Population.Text += "Parents: " + "\n";
            for (int i = 0; i < NUD_population.Value; i++)
            {
                RTB_Population.Text += GA_Solver.Flatten_Solution_to_String(GA_Solver.Chromosomes[i]) + "\n";
            }
            RTB_Population.Text += "Crossovered: " + "\n";
            for (int i = Convert.ToInt32(NUD_population.Value); i < NUD_population.Value + GA_Solver.Number_Of_Crossovered_Children; i++)
            {
                RTB_Population.Text += GA_Solver.Flatten_Solution_to_String(GA_Solver.Chromosomes[i]) + "\n";
            }
            RTB_Population.Text += "Mutated: " + "\n";
            for (int i = Convert.ToInt32(NUD_population.Value + GA_Solver.Number_Of_Crossovered_Children); i < NUD_population.Value + GA_Solver.Number_Of_Crossovered_Children + GA_Solver.Number_Of_Mutated_Children; i++)
            {
                RTB_Population.Text += GA_Solver.Flatten_Solution_to_String(GA_Solver.Chromosomes[i]) + "\n";
            }
        }
        public void Clear_Old_Solutions_on_UI()
        {
            TB_BOV.Text = "";
            RTB_Population.Text = "";

            // add series
            Chart_Main.Series.Clear();
            Chart_Main.Series.Add(GA_Solver.Series_Average);
            Chart_Main.Series.Add(GA_Solver.Series_SoFarTheBest);

            //enable BTN
            BTN_Run_one.Enabled = true;
            BTN_Run_to_end.Enabled = true;
        }
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
        private Binary_Crossover_Operator Get_Binary_Crossover_Type()
        {
            Binary_Crossover_Operator cross_type;
            switch (CB_Binary_Cross_Type.SelectedItem.ToString())
            {
                case "One Point Cut":
                    return Binary_Crossover_Operator.One_Point_Cut;
                case "Two Points Cut":
                    return Binary_Crossover_Operator.Two_Point_Cut;
                case "N Points Cut":
                    return Binary_Crossover_Operator.N_Point_Cut;
                default:
                    return Binary_Crossover_Operator.One_Point_Cut;
                    break;
            }
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
            // set GA function
            int population_Size = decimal.ToInt32(NUD_population.Value);
            double crossover_Rate = decimal.ToDouble(NUD_crossrate.Value);
            double mutate_Rate = decimal.ToDouble(NUD_mutaterate.Value);
            int iteration_Limit = Convert.ToInt32(NUD_Iteration.Value);
            double penalty_Factor = decimal.ToDouble(NUD_Penalty_Factor.Value);
            Selection_Type sel_type = Get_Selection_Type();
            Binary_Crossover_Operator binary_cro_type = Get_Binary_Crossover_Type(); 
            if (RDB_Binary.Checked)
            {
                GA_Solver = new Binary_GA(number_of_Jobs * number_of_Jobs, Optimization_Type.Minimization, Get_Setup_Time_Total, binary_cro_type);
            }
               
            GA_Solver.Selection_Type1 = sel_type;
            GA_Solver.Population_Size = population_Size;
            GA_Solver.Iteration_Limit = iteration_Limit;
            GA_Solver.Penatly_Factor = penalty_Factor;
            GA_Solver.Crossover_Rate = Convert.ToDouble(NUD_crossrate.Value);
            GA_Solver.Mutation_Rate = Convert.ToDouble(NUD_mutaterate.Value);
            GA_Solver.Reset();

            Clear_Old_Solutions_on_UI();

        }

        

        private void BTN_Run_one_Click(object sender, EventArgs e)
        {
            RTB_Population.Clear();
            GA_Solver.Run_One_Iteration();
            Update_New_Solutions_on_UI();
        }

        private void BTN_Run_to_end_Click(object sender, EventArgs e)
        {
            int iteration = decimal.ToInt32(NUD_Iteration.Value);
            TM_GA.Interval = 100 * TKB_Animation.Value;
            // run animation
            if (CKB_Show_animation.Checked)
            {
                TM_GA.Enabled = true;
            }
            else
            {
                GA_Solver.Run_To_End(iteration);
                Update_New_Solutions_on_UI();
            }

            BTN_Reset.Enabled = true;
            BTN_Run_one.Enabled = true;
            BTN_Run_to_end.Enabled = false;
        }

        #endregion

        private void TM_GA_Tick(object sender, EventArgs e)
        {
            GA_Solver.Run_One_Iteration();
            if (GA_Solver.Iteration_ID == NUD_Iteration.Value)
            {
                TM_GA.Enabled = false;
                Update_New_Solutions_on_UI();
            }
        }

        private void CKB_Show_animation_CheckedChanged(object sender, EventArgs e)
        {
            if (CKB_Show_animation.Checked == false)
                TM_GA.Enabled = false;
        }
    }
}
