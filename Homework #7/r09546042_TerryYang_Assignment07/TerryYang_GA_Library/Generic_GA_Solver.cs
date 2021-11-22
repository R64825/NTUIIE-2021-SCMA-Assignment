using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace TerryYang_GA_Library
{
    public enum Optimization_Type { Minimization, Maximization }
    public enum Mutation_Type { Gene_Number_Based, Chromosomes_Number_Based }
    public enum Selection_Type { Deterministic, Stochastic }

    // template class
    public class Generic_GA_Solver<T>
    {
        protected Random rnd = new Random();

        #region Data Field
        // data field
        protected T[][] chromosomes;
        protected double[] objective_Value;
        protected double[] fitness_Value;

        private T[] so_Far_The_Best_Soulution;
        private double so_Far_The_Best_Objective_Value;
        protected int[] indices;

        protected T[][] selected_Chromosomes;
        protected double[] selected_Objectives;
        protected int number_Of_Genes;
        
        protected Objective_Function<T> objective_Function = null;
        protected double less_Fitness_Fraction;

        protected int population_Size = 10;
        protected double crossover_Rate = 0.8;
        protected double mutation_Rate = 0.2;// Gene base, not population size
        private double penatly_Factor = 50;

        Optimization_Type optimization_Type = Optimization_Type.Minimization;
        Mutation_Type mutation_Type = Mutation_Type.Chromosomes_Number_Based;
        Selection_Type selection_Type = Selection_Type.Deterministic;
        public delegate double Objective_Function<S>(S[] a_Solution);

        int iteration_Limit = 200;
        int number_Of_Crossovered_Children;
        int number_Of_Mutated_Children;

        private Series series_SoFarTheBest;
        private Series series_Average;
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
        public Selection_Type Selection_Type1 { get => selection_Type; set => selection_Type = value; }
        public T[] So_Far_The_Best_Soulution { get => so_Far_The_Best_Soulution; set => so_Far_The_Best_Soulution = value; }
        public double So_Far_The_Best_Objective_Value { get => so_Far_The_Best_Objective_Value; set => so_Far_The_Best_Objective_Value = value; }
        public int Iteration_ID { get => iteration_ID; set => iteration_ID = value; }
        public int Number_Of_Crossovered_Children { get => number_Of_Crossovered_Children; set => number_Of_Crossovered_Children = value; }
        public int Number_Of_Mutated_Children { get => number_Of_Mutated_Children; set => number_Of_Mutated_Children = value; }
        public Series Series_SoFarTheBest { get => series_SoFarTheBest; set => series_SoFarTheBest = value; }
        public Series Series_Average { get => series_Average; set => series_Average = value; }
        public int Iteration_Limit { get => iteration_Limit; set => iteration_Limit = value; }
        public double Penatly_Factor { get => penatly_Factor; set => penatly_Factor = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number_Of_Genes">number of genes</param>
        /// <param name="optimization_Type">optimization type</param>
        /// <param name="objective_Function">objective function</param>
        public Generic_GA_Solver(int number_Of_Genes,Optimization_Type optimization_Type, Objective_Function<T> objective_Function)
        {
            this.number_Of_Genes = number_Of_Genes;
            this.optimization_Type = optimization_Type;
            this.objective_Function = objective_Function;

            chromosomes = new T[population_Size][];
            so_Far_The_Best_Soulution = new T[number_Of_Genes];

            // construct series
            series_SoFarTheBest = new Series("So far the best solution");
            series_SoFarTheBest.ChartType = SeriesChartType.Line;
            series_SoFarTheBest.Color = Color.Red;
            series_SoFarTheBest.BorderWidth = 2;
            series_Average = new Series("Solutions average");
            series_Average.ChartType = SeriesChartType.Line;
            series_Average.Color = Color.Lime;
            series_Average.BorderWidth = 2;
        }
        #endregion

        #region Functions
        // helping function
        public virtual void Set_Fitness_and_Objectives(int total)
        {
            throw new Exception();
            
        }
        private void Perform_Series_Update()
        {
            series_Average.Points.AddXY(iteration_ID, objective_Value.Sum() / population_Size);
            series_SoFarTheBest.Points.AddXY(Iteration_ID, so_Far_The_Best_Objective_Value);
        }
        public void Perform_Selection_Operation()
        {           
            int total = population_Size + number_Of_Crossovered_Children + number_Of_Mutated_Children;
            Set_Fitness_and_Objectives(total);
            
            // sort fitness and indices
            indices = new int[total];
            for (int i = 0; i < total; i++)     indices[i] = i;

            // .sort ==> small to large
            Array.Sort(fitness_Value, indices, 0, total);
            switch (optimization_Type)
            {
                case Optimization_Type.Minimization:
                    break;
                case Optimization_Type.Maximization:
                    Array.Reverse(fitness_Value, 0, total);
                    Array.Reverse(indices, 0, total);
                    break;
                default:
                    break;
            }
            // update so far the best solution and objectives
            // the iteration best is indices[0]

            // selection
            if (selection_Type == Selection_Type.Stochastic)
            {
               //...
               // perform stochastic selection
               // black jack wheel spinning
            }

            // update selection(at first place of the array)
            Fit_to_Selection_Then_Drop_Unfit();
        }

        public void Fit_to_Selection_Then_Drop_Unfit()
        {
            // copy gene to selected buffer
            for (int i = 0; i < population_Size; i++)
            {
                // gene-wise copy
                for (int j = 0; j < number_Of_Genes; j++)
                {
                    selected_Chromosomes[i][j] = chromosomes[indices[i]][j];
                }
                selected_Objectives[i] = objective_Value[indices[i]];
            }
           
            // copy back
            Clear_Chromosomes_and_Objectives_Array();
            for (int i = 0; i < population_Size; i++)
            {
                // gene-wise copy
                for (int j = 0; j < number_Of_Genes; j++)
                {
                    chromosomes[i][j] = selected_Chromosomes[i][j];
                }
                objective_Value[i] = selected_Objectives[i];
            }
            so_Far_The_Best_Objective_Value = objective_Value[0];
            so_Far_The_Best_Soulution = chromosomes[0];
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
            string str = "";
            for (int i = 0; i < sol.Length; i++)
                str += sol[i].ToString() + " ";
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
            if (mutation_Type == Mutation_Type.Gene_Number_Based)
            {
                // Gene_Number_Based
                int genes_pool = population_Size * number_Of_Genes;
                int number_of_Mutated_Genes_pools = (int)(mutation_Rate * genes_pool);
                List<int> pos = new List<int>();
                // make mutate genes
                for (int i = 0; i < number_of_Mutated_Genes_pools; i++)
                {
                    int gene_pool_position = rnd.Next(number_of_Mutated_Genes_pools);
                    int row_ID = (int)(gene_pool_position/number_Of_Genes);
                    int col_ID = (int)(gene_pool_position % number_Of_Genes);
                    Generate_Mutated_Chromosomes(row_ID, population_Size + number_Of_Crossovered_Children + i, col_ID);
                    if (pos.Contains(row_ID) == false)  
                        pos.Add(row_ID);
                }

                // count mutated chromosomes
                number_Of_Mutated_Children = pos.Count;
                pos.Clear();
            }
            else
            {
                // Chromosomes_Number_Based
                indices = Shuffle_Indice_Array(Population_Size);
                number_Of_Mutated_Children = (int)(population_Size * mutation_Rate);
                
                for (int i = 0; i < number_Of_Mutated_Children; i++)
                {
                    int mutated_ID = population_Size + number_Of_Crossovered_Children + i;
                    // make mutants
                    int gene_position = rnd.Next(number_Of_Genes);
                    Generate_Mutated_Chromosomes(indices[i], mutated_ID, gene_position);
                    // compute objectives for mutanted child
                    objective_Value[mutated_ID] = objective_Function(chromosomes[mutated_ID]);
                }
            }
        }
        public virtual void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            throw new NotImplementedException();
        }
        public virtual void Generate_Mutated_Chromosomes(int before_mutation, int after_mutation, int gene_position)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RUN-Time function
        // run time function
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
            selected_Objectives = new double[population_Size];
            selected_Chromosomes = new T[population_Size][];
            for (int r = 0; r < population_Size; r++)
                selected_Chromosomes[r] = new T[number_Of_Genes];            
            for (int r = 0; r < Three_Time_Size; r++)
                chromosomes[r] = new T[number_Of_Genes];

            // set initial solution
            Initialize_Population();

            // compute fitness value
            for (int i = 0; i < Three_Time_Size; i++)
            {
                objective_Value[i] = objective_Function(chromosomes[i]);
            }
            number_Of_Crossovered_Children = 0;
            number_Of_Mutated_Children = 0;

            // set so_fat_the_best to the worst
            if (optimization_Type == Optimization_Type.Maximization)
                so_Far_The_Best_Objective_Value = double.MinValue;
            else
                so_Far_The_Best_Objective_Value = double.MaxValue;

            
        }
        public void Run_One_Iteration()
        {
            if (iteration_ID >= iteration_Limit) return;
            Perform_Crossover_Operation();
            Perform_Mutation_Operation();
            Perform_Selection_Operation();
            Perform_Series_Update();
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
