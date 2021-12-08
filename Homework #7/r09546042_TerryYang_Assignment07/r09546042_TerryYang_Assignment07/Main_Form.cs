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
using TerryYang_GA_Library;
using static TerryYang_GA_Library.Generic_GA_Solver<byte>;

namespace r09546042_TerryYang_Assignment07
{
    public partial class Main_Form : Form
    {
        Generic_GA_Solver<byte> GA_Bin_Solver = null;
        Generic_GA_Solver<int> GA_Per_Solver = null;

        int number_of_Jobs;
        public Main_Form()
        {

            InitializeComponent();
            Setup_UI();
        }
        #region Helping Functions
        public void Update_New_Solutions_on_UI()
        {
            if (RDB_Binary.Checked)
            {
                // print best solution
                TB_BOV.Text = GA_Bin_Solver.So_Far_The_Best_Objective_Value.ToString();

                // print best chromosomes
                LTB_BOV.Items.Clear();
                for (int i = 0; i < number_of_Jobs; i++)
                {
                    LTB_BOV.Items.Add(GA_Bin_Solver.Flatten_Solution_to_String(GA_Bin_Solver.So_Far_The_Best_Soulution).Split(new string[] { "  " }, StringSplitOptions.None)[i + 1]);
                }

                // print out chromosomes in rich text box
                LTB_Population.Items.Clear();
                LTB_Population.Items.Add("Current Iteration: " + GA_Bin_Solver.Iteration_ID.ToString() + "\n");
                LTB_Population.Items.Add("Parents: " + "\n");
                for (int i = 0; i < NUD_population.Value; i++)
                {
                    LTB_Population.Items.Add($"P_{i}: " + GA_Bin_Solver.Flatten_Solution_to_String(GA_Bin_Solver.Chromosomes[i]) + "obj: " + GA_Bin_Solver.Objective_Value[i] + "\n");
                }
                LTB_Population.Items.Add("Crossovered: " + "\n");
                for (int i = Convert.ToInt32(NUD_population.Value); i < NUD_population.Value + GA_Bin_Solver.Number_Of_Crossovered_Children; i++)
                {
                    LTB_Population.Items.Add($"C_{i - Convert.ToInt32(NUD_population.Value)}: " + GA_Bin_Solver.Flatten_Solution_to_String(GA_Bin_Solver.Chromosomes[i]) + "obj: " + GA_Bin_Solver.Objective_Value[i] + "\n");
                }
                LTB_Population.Items.Add("Mutated: " + "\n");
                for (int i = Convert.ToInt32(NUD_population.Value + GA_Bin_Solver.Number_Of_Crossovered_Children); i < NUD_population.Value + GA_Bin_Solver.Number_Of_Crossovered_Children + GA_Bin_Solver.Number_Of_Mutated_Children; i++)
                {
                    LTB_Population.Items.Add($"M_{i - Convert.ToInt32(NUD_population.Value + GA_Bin_Solver.Number_Of_Crossovered_Children)}: " + GA_Bin_Solver.Flatten_Solution_to_String(GA_Bin_Solver.Chromosomes[i]) + "obj: " + GA_Bin_Solver.Objective_Value[i] + "\n");
                }

                // print hard violation
                int[] vio = Return_Chromosomes_Violations(GA_Bin_Solver.So_Far_The_Best_Soulution);
                LTB_HCV.Items.Clear();
                for (int i = 0; i < number_of_Jobs; i++)
                {
                    LTB_HCV.Items.Add($"Row{i + 1}: " + vio[i]);
                }
                for (int i = number_of_Jobs; i < 2 * number_of_Jobs; i++)
                {
                    LTB_HCV.Items.Add($"Col{i + 1 - number_of_Jobs}: " + vio[i]);
                }

                // print shorst time
                TB_shortest_time.Text = Get_Setup_Time_Total_Binary(GA_Bin_Solver.So_Far_The_Best_Soulution, false).ToString();

                // show model status
                TSL_Iteration.Text = $"Iteration: {GA_Bin_Solver.Iteration_ID}";
            }
            else
            {
                // print best solution
                TB_BOV.Text = GA_Per_Solver.So_Far_The_Best_Objective_Value.ToString();

                // print best chromosomes
                LTB_BOV.Items.Clear();
                LTB_BOV.Items.Add(GA_Per_Solver.Flatten_Solution_to_String(GA_Per_Solver.So_Far_The_Best_Soulution));                

                // print out chromosomes in rich text box
                LTB_Population.Items.Clear();
                LTB_Population.Items.Add("Current Iteration: " + GA_Per_Solver.Iteration_ID.ToString() + "\n");
                LTB_Population.Items.Add("Parents: " + "\n");
                for (int i = 0; i < NUD_population.Value; i++)
                {
                    LTB_Population.Items.Add($"P_{i}: " + GA_Per_Solver.Flatten_Solution_to_String(GA_Per_Solver.Chromosomes[i]) + "obj: " + GA_Per_Solver.Objective_Value[i] + "\n");
                }
                LTB_Population.Items.Add("Crossovered: " + "\n");
                for (int i = Convert.ToInt32(NUD_population.Value); i < NUD_population.Value + GA_Per_Solver.Number_Of_Crossovered_Children; i++)
                {
                    LTB_Population.Items.Add($"C_{i - Convert.ToInt32(NUD_population.Value)}: " + GA_Per_Solver.Flatten_Solution_to_String(GA_Per_Solver.Chromosomes[i]) + "obj: " + GA_Per_Solver.Objective_Value[i] + "\n");
                }
                LTB_Population.Items.Add("Mutated: " + "\n");
                for (int i = Convert.ToInt32(NUD_population.Value + GA_Per_Solver.Number_Of_Crossovered_Children); i < NUD_population.Value + GA_Per_Solver.Number_Of_Crossovered_Children + GA_Per_Solver.Number_Of_Mutated_Children; i++)
                {
                    LTB_Population.Items.Add($"M_{i - Convert.ToInt32(NUD_population.Value + GA_Per_Solver.Number_Of_Crossovered_Children)}: " + GA_Per_Solver.Flatten_Solution_to_String(GA_Per_Solver.Chromosomes[i]) + "obj: " + GA_Per_Solver.Objective_Value[i] + "\n");
                }

                // show model status
                TSL_Iteration.Text = $"Iteration: {GA_Per_Solver.Iteration_ID}";

            }
        }      
        public void Clear_Old_Solutions_on_UI()
        {
            TB_BOV.Text = "";
            LTB_Population.Text = "";

            // add series
            Chart_Main.Series.Clear();
            if (RDB_Binary.Checked)
            {
                Chart_Main.Series.Add(GA_Bin_Solver.Series_Average);
                Chart_Main.Series.Add(GA_Bin_Solver.Series_IterationTheBest);
                Chart_Main.Series.Add(GA_Bin_Solver.Series_SoFarTheBest);
            }
            else
            {
                Chart_Main.Series.Add(GA_Per_Solver.Series_Average);
                Chart_Main.Series.Add(GA_Per_Solver.Series_IterationTheBest);
                Chart_Main.Series.Add(GA_Per_Solver.Series_SoFarTheBest);
            }
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
        public void Ban_or_Enable_GB(bool set)
        {
            GB_GA_encoding.Enabled = set;
            GB_GeneratedProblem.Enabled = set;
            GB_Mutation.Enabled = set;
            GB_Optimization.Enabled = set;
            GB_Parameter.Enabled = set;
            GB_Selection.Enabled = set;
            GB_ProblemSetting.Enabled = set;
            BTN_proGenerate.Enabled = set;
            NUD_Iteration.Enabled = set;

        }

        public int[] Return_Chromosomes_Violations(byte[] chrom)
        {          
            int[] violations = new int[2 * number_of_Jobs];
            int counts;

            // row wise
            for (int r = 0; r < number_of_Jobs; r++)
            {
                counts = 0;
                for (int c = 0; c < number_of_Jobs; c++)
                    counts += chrom[r * number_of_Jobs + c];

                violations[r] = Math.Abs(counts - 1);
            }
            // col wise
            for (int c = 0; c < number_of_Jobs; c++)
            {
                counts = 0;
                for (int r = 0; r < number_of_Jobs; r++)
                    counts += chrom[r * number_of_Jobs + c];

                violations[number_of_Jobs + c] = Math.Abs(counts - 1);
            }
            return violations;
        }
        public double Get_Setup_Time_Total_Binary(byte[] solution, bool violation)
        {
            double objective_Value = 0 ;
            int[] violations = new int[number_of_Jobs * 2];
            int current_Job_ID = 0; // row count

            for (int row = 0; row < number_of_Jobs; row++)
            {
                for (int column = 0; column < number_of_Jobs; column++)
                {
                    objective_Value += Convert.ToDouble(solution[current_Job_ID]) * Convert.ToDouble(DGV_Problem[row, column].Value);
                    current_Job_ID++;
                }
            }

            if (violation)
            {
                violations = Return_Chromosomes_Violations(solution);
                if (RDB_Maxi.Checked)
                    objective_Value = objective_Value - violations.Sum() * GA_Bin_Solver.Penalty_Factor;
                else
                    objective_Value = objective_Value + violations.Sum() * GA_Bin_Solver.Penalty_Factor;                
            }
            return objective_Value;
        }
        public double Get_Setup_Time_Total_Permutation(int[] solution, bool violation)
        {
            double total_Time = 0;
            for (int i = 0; i < solution.Length; i++)
            {
                total_Time += Convert.ToDouble(DGV_Problem[i, solution[i]].Value);
            }
            return total_Time;
        }
        #endregion

        #region Get Type Functions
        public GA_Selection_Type Get_Selection_Type()
        {
            GA_Selection_Type sel_type;
            if (RDB_Stochastic.Checked)
                sel_type = GA_Selection_Type.Stochastic;
            else
                sel_type = GA_Selection_Type.Deterministic;
            return sel_type;
        }
        private Binary_Crossover_Type Get_Binary_Crossover_Type()
        {
            switch (CB_Binary_Cross_Type.SelectedItem.ToString())
            {
                case "One Point Cut":
                    return Binary_Crossover_Type.One_Point_Cut;
                case "Two Points Cut":
                    return Binary_Crossover_Type.Two_Point_Cut;
                case "N Points Cut":
                    return Binary_Crossover_Type.N_Point_Cut;
                default:
                    return Binary_Crossover_Type.One_Point_Cut;
            }
        }
        private Permutation_Crossover_Type Get_Permutation_Crossover_Type()
        {
            switch (CB_Permutation_Cross_Type.SelectedItem.ToString())
            {
                case "Partial-mapped Crossover":
                    return Permutation_Crossover_Type.Parial_Mapped_X;
                case "Order Crossover":
                    return Permutation_Crossover_Type.Order_X;
                case "Position-based Crossover":
                    return Permutation_Crossover_Type.Postition_Base_X;
                case "Order-based Crossover":
                    return Permutation_Crossover_Type.Order_Based_X;
                case "Cycle Crossover":
                    return Permutation_Crossover_Type.Cycle_X;
                case "Subtour Exchange":
                    return Permutation_Crossover_Type.Subtour_Exchange;
                default:
                    return Permutation_Crossover_Type.Parial_Mapped_X;
            }
        }
        private GA_Mutation_Type Get_Bin_Mutation_Type()
        {
            GA_Mutation_Type mut_type;
            if (RDB_Chrom_Base.Checked)
                mut_type = GA_Mutation_Type.Chromosomes_Number_Based;
            else
                mut_type = GA_Mutation_Type.Gene_Number_Based;
            return mut_type;
        }
        private GA_Optimization_Type Get_Optimization_Type()
        {
            GA_Optimization_Type op_type;
            if (RDB_Maxi.Checked)
                op_type = GA_Optimization_Type.Maximization;
            else
                op_type = GA_Optimization_Type.Minimization;
            return op_type;
        }
        private Permutation_Mutation_Type Get_Per_Mutation_Type()
        {            
            Permutation_Mutation_Type pm_Type = Permutation_Mutation_Type.Inversion;
            switch (CB_Permutation_Mutat_Type.Text)
            {
                case "Inversion Mutation":
                    pm_Type = Permutation_Mutation_Type.Inversion;
                    break;
                case "Insertion Mutation":
                    pm_Type = Permutation_Mutation_Type.Insertion;
                    break;
                case "Displacement Mutation":
                    pm_Type = Permutation_Mutation_Type.Displacement;
                    break;
                case "Reciprocla Exchange Mutation":
                    pm_Type = Permutation_Mutation_Type.Reciprocal_Exchange;
                    break;
                case "Heuristic":
                    pm_Type = Permutation_Mutation_Type.Heuristic;
                    break;
                default:
                    break;
            }
            return pm_Type;
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
            double penalty_Factor = decimal.ToDouble(NUD_Penalty_Factor.Value);
            int iteration_Limit = Convert.ToInt32(NUD_Iteration.Value);
            double alpha = decimal.ToDouble(NUD_Least_Fitness_Fraction.Value);
            GA_Selection_Type sel_type = Get_Selection_Type();
            GA_Optimization_Type op_type = Get_Optimization_Type();
            GA_Mutation_Type mut_type = Get_Bin_Mutation_Type();
            if (RDB_Binary.Checked)
            {
            GA_Bin_Solver = new Binary_GA(number_of_Jobs * number_of_Jobs, GA_Optimization_Type.Minimization, Get_Setup_Time_Total_Binary, Get_Binary_Crossover_Type());
            GA_Bin_Solver.Selection_Type1 = sel_type;
            GA_Bin_Solver.Population_Size = population_Size;
            GA_Bin_Solver.Iteration_Limit = iteration_Limit;
            GA_Bin_Solver.Least_Fitness_Fraction = alpha;
            GA_Bin_Solver.Mutation_Type = mut_type;
            GA_Bin_Solver.Optimization_Type = op_type;
            GA_Bin_Solver.Penalty_Factor = penalty_Factor;
            GA_Bin_Solver.Crossover_Rate = Convert.ToDouble(NUD_crossrate.Value);
            GA_Bin_Solver.Mutation_Rate = Convert.ToDouble(NUD_mutaterate.Value);
            GA_Bin_Solver.Reset();
            }
            else
            {
                GA_Per_Solver = new Permutation_GA(number_of_Jobs, GA_Optimization_Type.Minimization, Get_Setup_Time_Total_Permutation, Get_Permutation_Crossover_Type(), Get_Per_Mutation_Type());
                GA_Per_Solver.Selection_Type1 = sel_type;
                GA_Per_Solver.Population_Size = population_Size;
                GA_Per_Solver.Iteration_Limit = iteration_Limit;
                GA_Per_Solver.Least_Fitness_Fraction = alpha;
                GA_Per_Solver.Mutation_Type = mut_type;
                GA_Per_Solver.Optimization_Type = op_type;
                GA_Per_Solver.Penalty_Factor = penalty_Factor;
                GA_Per_Solver.Crossover_Rate = Convert.ToDouble(NUD_crossrate.Value);
                GA_Per_Solver.Mutation_Rate = Convert.ToDouble(NUD_mutaterate.Value);
                GA_Per_Solver.Reset();
            }
            Clear_Old_Solutions_on_UI();
            Update_New_Solutions_on_UI();
            Ban_or_Enable_GB(true);

            // show model status
            if (RDB_Binary.Checked)
                TSL_model_status.Text = "Binary GA";
            else
                TSL_model_status.Text = "Permutation GA";
            TSL_Iteration.Text = "Model Initialize";
        }    
        private void BTN_Run_one_Click(object sender, EventArgs e)
        {LTB_Population.Items.Clear();
            if (RDB_Binary.Checked)
            {              
                GA_Bin_Solver.Run_One_Iteration();
                
                if (GA_Bin_Solver.Iteration_ID != GA_Bin_Solver.Iteration_Limit)
                    Ban_or_Enable_GB(false);
                else
                    Ban_or_Enable_GB(true);
            }
            else
            {               
                GA_Per_Solver.Run_One_Iteration();
                if (GA_Per_Solver.Iteration_ID != GA_Per_Solver.Iteration_Limit)
                    Ban_or_Enable_GB(false);
                else
                    Ban_or_Enable_GB(true);
            }
            Update_New_Solutions_on_UI();
            Chart_Main.ChartAreas[0].RecalculateAxesScale();
        }
        private void BTN_Run_to_end_Click(object sender, EventArgs e)
        {
            int iteration = decimal.ToInt32(NUD_Iteration.Value);
            TM_GA.Interval = 30 * TKB_Animation.Value;
            // run animation
            if (CKB_Show_animation.Checked)
            {
                TM_GA.Enabled = true;
            }
            else
            {
                if (RDB_Binary.Checked)
                    GA_Bin_Solver.Run_To_End(iteration);
                else
                    GA_Per_Solver.Run_To_End(iteration);
                Update_New_Solutions_on_UI();
            }
            Chart_Main.ChartAreas[0].RecalculateAxesScale();
            BTN_Reset.Enabled = true;
            BTN_Run_one.Enabled = true;  
            BTN_Run_to_end.Enabled = false;
            Ban_or_Enable_GB(true);

           
        }
        #region File BTN
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;

            //StreamReader sr = new StreamReader(OpenFileDialog.FileName);
            //string str = sr.ReadLine();

            //sr.Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        private void TM_GA_Tick(object sender, EventArgs e)
        {
            if (RDB_Binary.Checked)
            {
                GA_Bin_Solver.Run_One_Iteration();
                Update_New_Solutions_on_UI();
                if (GA_Bin_Solver.Iteration_ID == NUD_Iteration.Value)
                {
                    TM_GA.Enabled = false;
                    Chart_Main.ChartAreas[0].RecalculateAxesScale();
                }
            }
            else
            {
                GA_Per_Solver.Run_One_Iteration();
                Update_New_Solutions_on_UI();
                if (GA_Per_Solver.Iteration_ID == NUD_Iteration.Value)
                {
                    TM_GA.Enabled = false;
                    Chart_Main.ChartAreas[0].RecalculateAxesScale();
                }
            }            
        }
        private void CKB_Show_animation_CheckedChanged(object sender, EventArgs e)
        {
            if (CKB_Show_animation.Checked == false)
                TM_GA.Enabled = false;
        }

       
    }
}
