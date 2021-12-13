using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace TerryYang_GA_Library
{
    public enum GA_Optimization_Type { Minimization, Maximization }
    public enum GA_Mutation_Type { Gene_Number_Based, Chromosomes_Number_Based }
    public enum GA_Selection_Type { Deterministic, Stochastic }

    // template class
    public class Generic_GA_Solver<T>
    {
        #region Data Field
        // data field
        protected Random rnd = new Random();
        protected T[][] chromosomes;
        protected double[] objective_Value;
        protected double[] fitness_Value;

        private T[] so_Far_The_Best_Soulution;
        private double so_Far_The_Best_Objective_Value;
        double iteration_Best_Objective;
        double iteration_Average_Objective;

        protected int[] indices;

        protected T[][] selected_Chromosomes;
        protected double[] selected_Objective_Value;
        protected int number_Of_Genes;
        
        protected Objective_Function<T> objective_Function = null;
        protected double less_Fitness_Fraction;

        protected int population_Size = 10;
        protected double crossover_Rate = 0.8;
        protected double mutation_Rate = 0.2;// Gene base, not population size
        private double least_Fitness_Fraction = 0.1;
        private double penalty_Factor = 100;

        GA_Optimization_Type optimization_Type = GA_Optimization_Type.Minimization;
        GA_Mutation_Type mutation_Type = GA_Mutation_Type.Chromosomes_Number_Based;
        GA_Selection_Type selection_Type = GA_Selection_Type.Deterministic;

        public delegate double Objective_Function<S>(S[] a_Solution, bool violation);

        int iteration_Limit = 200;
        int number_Of_Crossovered_Children;
        int number_Of_Mutated_Children;

        private Series series_SoFarTheBest;
        private Series series_Average;
        private Series series_IterationTheBest;

        bool[][] mutated_Genes; // guide for gene base mutation
        // run time date
        int iteration_ID;
        #endregion
              
        #region Property
        public int Population_Size
        {
            get => population_Size; set
            {
                if (value > 1)
                {
                    population_Size = value;
                }
            }
        }
        public double Crossover_Rate
        {
            get => crossover_Rate; set
            {
                if (value <= 1 && value >= 0)
                {
                    crossover_Rate = value;
                }
            }
        }
        public double Mutation_Rate { get => mutation_Rate; set => mutation_Rate = value; }
        public T[][] Chromosomes { get => chromosomes; set => chromosomes = value; }
        public GA_Selection_Type Selection_Type1 { get => selection_Type; set => selection_Type = value; }
        public T[] So_Far_The_Best_Soulution { get => so_Far_The_Best_Soulution; set => so_Far_The_Best_Soulution = value; }
        public double So_Far_The_Best_Objective_Value { get => so_Far_The_Best_Objective_Value; set => so_Far_The_Best_Objective_Value = value; }
        public int Iteration_ID { get => iteration_ID; set => iteration_ID = value; }
        public int Number_Of_Crossovered_Children { get => number_Of_Crossovered_Children; set => number_Of_Crossovered_Children = value; }
        public int Number_Of_Mutated_Children { get => number_Of_Mutated_Children; set => number_Of_Mutated_Children = value; }
        public Series Series_SoFarTheBest { get => series_SoFarTheBest; set => series_SoFarTheBest = value; }
        public Series Series_Average { get => series_Average; set => series_Average = value; }
        public Series Series_IterationTheBest { get => series_IterationTheBest; set => series_IterationTheBest = value; }
        public int Iteration_Limit { get => iteration_Limit; set => iteration_Limit = value; }
        public double Penalty_Factor { get => penalty_Factor; set => penalty_Factor = value; }               
        public double Least_Fitness_Fraction { get => least_Fitness_Fraction; set => least_Fitness_Fraction = value; }
        public double[] Objective_Value { get => objective_Value; set => objective_Value = value; }
        public GA_Mutation_Type Mutation_Type { get => mutation_Type; set => mutation_Type = value; }
        public GA_Optimization_Type Optimization_Type { get => optimization_Type; set => optimization_Type = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number_Of_Genes">number of genes</param>
        /// <param name="optimization_Type">optimization type</param>
        /// <param name="objective_Function">objective function</param>
        public Generic_GA_Solver(int number_Of_Genes,GA_Optimization_Type optimization_Type, Objective_Function<T> objective_Function)
        {
            this.number_Of_Genes = number_Of_Genes;
            this.optimization_Type = optimization_Type;
            this.objective_Function = objective_Function;

            chromosomes = new T[population_Size][];
            so_Far_The_Best_Soulution = new T[number_Of_Genes];


            mutated_Genes = new bool[population_Size][];
            for (int i = 0; i < population_Size; i++)
                mutated_Genes[i] = new bool[number_Of_Genes];

            // construct series
            series_SoFarTheBest = new Series("So far the best solution");
            series_SoFarTheBest.ChartType = SeriesChartType.Line;
            series_SoFarTheBest.Color = Color.Red;
            series_SoFarTheBest.BorderWidth = 2;
            series_Average = new Series("Solutions average");
            series_Average.ChartType = SeriesChartType.Line;
            series_Average.Color = Color.Lime;
            series_Average.BorderWidth = 2;
            series_IterationTheBest = new Series("Iteration the best solution");
            series_IterationTheBest.ChartType = SeriesChartType.Line;
            series_IterationTheBest.Color = Color.Magenta;
            series_IterationTheBest.BorderWidth = 2;
        }
        #endregion

        #region Functions
        // helping function
        public void Set_Fitness_and_Objectives(int total, double least_Fitness_Fraction)
        {
            double o_min = double.MaxValue;
            double o_max = double.MinValue;
            for (int i = 0; i < total; i++)
            {
                if (o_max < objective_Value[i])
                    o_max = objective_Value[i];
                if(o_min > objective_Value[i])
                    o_min = objective_Value[i];
            }
            double beta = Math.Max(least_Fitness_Fraction * (o_max - o_min), 1e-5);

            switch (Optimization_Type)
            {
                case GA_Optimization_Type.Maximization:
                    for (int i = 0; i < total; i++)
                        fitness_Value[i] = beta + (objective_Value[i] - o_min);
                    break;
                case GA_Optimization_Type.Minimization:
                    for (int i = 0; i < total; i++)
                        fitness_Value[i] = beta + (o_max - objective_Value[i]);
                    break;
                default:
                    break;
            }         
        }
        private void Series_Update()
        {
            series_Average.Points.AddXY(iteration_ID, iteration_Average_Objective);
            series_SoFarTheBest.Points.AddXY(Iteration_ID, so_Far_The_Best_Objective_Value);
            series_IterationTheBest.Points.AddXY(iteration_ID, iteration_Best_Objective);
        }
        private void Copy_All_Selection_to_Chromosomes()
        {
            // copy form selection to chromosome
            //Clear_Chromosomes_and_Objectives_Array();
            for (int i = 0; i < population_Size; i++)
            {
                // gene-wise copy
                for (int j = 0; j < number_Of_Genes; j++)
                {
                    chromosomes[i][j] = selected_Chromosomes[i][j];
                }
                objective_Value[i] = selected_Objective_Value[i];
            }
        }
        private void Copy_This_Chromosomes_to_a_Selection(int Chro_index,int Sel_index)
        {
            // gene-wise copy
            for (int j = 0; j < number_Of_Genes; j++)
            {
                selected_Chromosomes[Sel_index][j] = chromosomes[Chro_index][j];
            }
            selected_Objective_Value[Sel_index] =  objective_Function(selected_Chromosomes[Sel_index], true);
            //selected_Objective_Value[Sel_index] = Return_Chromosomes_Violations(selected_Chromosomes[Sel_index]).Sum() ;
        }      
        public void Perform_Selection_Operation()
        {           
            int total = population_Size + number_Of_Crossovered_Children + number_Of_Mutated_Children;
            //Add_Hard_Violation(total,Penatly_Factor);
            Set_Fitness_and_Objectives(total , least_Fitness_Fraction);

            // rearrange indices
            indices = new int[total];
            for (int i = 0; i < total; i++) indices[i] = i;

            // sort fitness from large to small
            Array.Sort(fitness_Value, indices, 0, total);
            Array.Reverse(fitness_Value, 0, total);
            Array.Reverse(indices, 0, total);

            // selection
            if (selection_Type == GA_Selection_Type.Stochastic)
            {
                #region Stochastic Wheel
                double Ratio = 1.0 / fitness_Value.Sum();
                double[] dartboard = new double[total];
                int[] locations = new int[population_Size];
                double sum = 0;
                int darts_counts = 0;
                double dart = rnd.NextDouble();

                // creating darting wheel
                for (int i = 0; i < total; i++)
                {
                    sum += Ratio * fitness_Value[i] * population_Size;
                    dartboard[i] = sum;
                }

                // shooting darts until popsize
                for (int p = 0; p < total; p++)
                {
                    while (dartboard[p] > dart && darts_counts < population_Size) // hit
                    {
                        // select 
                        //Copy_This_Chromosomes_to_a_Selection(p, darts_counts);
                        locations[darts_counts] = p;
                        darts_counts++;
                        dart++;                       
                    }
                }

                // copy
                for (int l = 0; l < locations.Length; l++)
                    Copy_This_Chromosomes_to_a_Selection(indices[locations[l]], l);
                #endregion 
            }
            else // deterministic
            {
                // copy
                for (int i = 0; i < population_Size; i++)
                    Copy_This_Chromosomes_to_a_Selection(indices[i], i);
            }

            //Fit_to_Selection_Then_Drop_Unfit();
        }       
        public virtual int[] Return_Chromosomes_Violations(T[] chrom)
        {
            throw new NotImplementedException();
        }
        public void Fit_to_Selection_Then_Drop_Unfit()
        {
            double selected_Min = selected_Objective_Value.Min();
            double selected_Max = selected_Objective_Value.Max();
            int total = population_Size + number_Of_Crossovered_Children + number_Of_Mutated_Children;
            // update so_far_the_best_solution
            switch (optimization_Type)
            {
                case GA_Optimization_Type.Minimization: 
                    if (so_Far_The_Best_Objective_Value > selected_Min)
                    { 
                        so_Far_The_Best_Objective_Value = selected_Min;
                        so_Far_The_Best_Soulution = selected_Chromosomes[0];
                    }
                    break;
                case GA_Optimization_Type.Maximization:
                    if (so_Far_The_Best_Objective_Value < selected_Max)
                    { 
                        so_Far_The_Best_Objective_Value = selected_Max;
                        so_Far_The_Best_Soulution = selected_Chromosomes[0];
                    }
                    break;
                default:
                    break;
            }
            Copy_All_Selection_to_Chromosomes();

            //// update iteration the best
            //if (optimization_Type == GA_Optimization_Type.Maximization)
            //    iteration_Best_Objective = selected_Max;
            //else
            //    iteration_Best_Objective = selected_Min;
            //iteration_Average_Objective = (objective_Value.Sum() / total);
        }

        private void Update_So_Far_the_Best_and_Iteration_the_Best()
        {
            int total = population_Size + number_Of_Crossovered_Children + number_Of_Mutated_Children;
            int the_Best_Index = 0;
            if (optimization_Type == GA_Optimization_Type.Maximization)
            {
                for (int i = 0; i < total; i++)
                {
                    if (objective_Value[i]> so_Far_The_Best_Objective_Value)
                    {
                        // change so far the best 
                        so_Far_The_Best_Objective_Value = objective_Value[i];
                        the_Best_Index = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < total; i++)
                {
                    if (objective_Value[i] < so_Far_The_Best_Objective_Value)
                    {
                        // change so far the best 
                        so_Far_The_Best_Objective_Value = objective_Value[i];
                        the_Best_Index = i;
                    }
                }
            }

            // copy the solution
            for (int i = 0; i < number_Of_Genes; i++)
            {
                so_Far_The_Best_Soulution[i] = chromosomes[the_Best_Index][i];
            }

            // update iteration the best
            if (optimization_Type == GA_Optimization_Type.Maximization)
                iteration_Best_Objective = objective_Value[the_Best_Index];
            else
                iteration_Best_Objective = objective_Value[the_Best_Index];
            iteration_Average_Objective = (objective_Value.Sum() / total);
        }
        public int[] Shuffle_Indice_Array(int limit)
        {
            int[] arr = new int[limit];
            Random random = new Random();
            for (int i = 0; i < limit; i++)
                arr[i] = i;
            arr = arr.OrderBy(x => random.Next()).ToArray();
            return arr;
        }
        public virtual void Initialize_Population()
        {
            // initialize first population
            throw new NotImplementedException();
        }
        public virtual void Clear_Chromosomes_and_Objectives_Array()
        {
            throw new Exception("");           
        }
        public virtual string Flatten_Solution_to_String(T[] sol)
        {
            string str = " ";
            double row_End;
            for (int i = 0; i < sol.Length; i++)
            {
                row_End = i % Math.Sqrt(number_Of_Genes);
                if (row_End ==0)
                    str += " ";
                str += sol[i].ToString() + " ";                
            }
            str += " ";
            return str;
        }
        #endregion

        #region Crossover & Mutation
        protected void Perform_Crossover_Operation()
        {
            indices = Shuffle_Indice_Array(Population_Size);
            number_Of_Crossovered_Children = (int)(population_Size * crossover_Rate) / 2 * 2;
            if (number_Of_Crossovered_Children % 2 == 1) number_Of_Crossovered_Children--;
            int pair = number_Of_Crossovered_Children / 2;
          
            int father, mother, child_a, child_b;
            for (int p = 0; p < pair; p++)
            {
                int crossover_ID_a = population_Size + 2 * p;
                int crossover_ID_b = population_Size + 2 * p + 1;

                father = indices[p*2];
                mother = indices[p*2 + 1];
                child_a = crossover_ID_a;
                child_b = crossover_ID_b;

                // make crossover
                Generate_Crossovered_Chromosomes(father, mother, child_a, child_b);               
            }
        }
        private void Perform_Mutation_Operation()
        {
            // initial gene pool mutation guide
            for (int i = 0; i < population_Size; i++)
            {
                indices[i] = i;
                for (int g = 0; g < number_Of_Genes; g++)
                    mutated_Genes[i][g] = false;
            }

            if (mutation_Type == GA_Mutation_Type.Gene_Number_Based)
            {
                #region Gene_Number_Based

                int genes_pool = population_Size * number_Of_Genes;
                int number_of_Mutated_Genes_pools = (int)(mutation_Rate * genes_pool);

                // store mutated gene info in guide
                for (int i = 0; i < number_of_Mutated_Genes_pools; i++)
                {
                    int gene_Pool_Location = rnd.Next(genes_pool);
                    int row_ID, col_ID;
                    row_ID = gene_Pool_Location / number_Of_Genes;
                    col_ID = gene_Pool_Location % number_Of_Genes;
                    indices[row_ID] = int.MinValue;
                    mutated_Genes[row_ID][col_ID] = true;
                }

                number_Of_Mutated_Children = 0;
                for (int i = 0; i < population_Size; i++)
                {
                    // select marked chromosome
                    if (indices[i] == int.MinValue)
                    {
                        Generate_Mutated_Chromosomes(i, population_Size + Number_Of_Crossovered_Children + i, mutated_Genes[i]);
                    }
                    number_Of_Mutated_Children++;
                }
                #endregion
            }
            else
            {
                #region Chromosomes_Number_Base
                indices = Shuffle_Indice_Array(Population_Size);
                number_Of_Mutated_Children = (int)(population_Size * mutation_Rate);             
                for (int i = 0; i < number_Of_Mutated_Children; i++)
                {
                    int mutated_ID = population_Size + number_Of_Crossovered_Children + i;                  
                    int gene_position =  rnd.Next(number_Of_Genes);
                    mutated_Genes[indices[i]][gene_position] = true;

                   // make mutants
                   Generate_Mutated_Chromosomes(indices[i], mutated_ID, mutated_Genes[indices[i]]);
                }
                #endregion
            }
        }

        // overrided
        public virtual void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            throw new NotImplementedException();
        }
        public virtual void Generate_Mutated_Chromosomes(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RUN-Time function
        public void Reset()
        {
            // variable reset
            iteration_ID = 0;

            // memory reallocation
            int Three_Time_Size = population_Size * 3;
            indices = new int[Three_Time_Size];
            objective_Value = new double[Three_Time_Size];
            fitness_Value = new double[Three_Time_Size];
            chromosomes = new T[Three_Time_Size][];
            selected_Objective_Value = new double[population_Size];
            selected_Chromosomes = new T[population_Size][];
            for (int r = 0; r < population_Size; r++)
                selected_Chromosomes[r] = new T[number_Of_Genes];            
            for (int r = 0; r < Three_Time_Size; r++)
                chromosomes[r] = new T[number_Of_Genes];

            // set initial solution
            Initialize_Population();

            // compute fitness value
            //for (int i = 0; i < Three_Time_Size; i++)
            //    objective_Value[i] = objective_Function(chromosomes[i]);
            number_Of_Crossovered_Children = 0;
            number_Of_Mutated_Children = 0;

            // set so_fat_the_best to the worst
            if (optimization_Type == GA_Optimization_Type.Maximization)
                so_Far_The_Best_Objective_Value = double.MinValue;
            else
                so_Far_The_Best_Objective_Value = double.MaxValue;           
        }
        public void Run_One_Iteration()
        {
            if (iteration_ID >= iteration_Limit) return;
            if (iteration_ID != 0)
                Copy_All_Selection_to_Chromosomes();
            Perform_Crossover_Operation();
            Perform_Mutation_Operation();
            Update_So_Far_the_Best_and_Iteration_the_Best();
            Perform_Selection_Operation();            
            Series_Update();
            iteration_ID++;
        }



        public void Run_To_End(int Iteration)
        {
            for (int i = 0; i < Iteration; i++)
                Run_One_Iteration();
        }
        #endregion
    }
}
