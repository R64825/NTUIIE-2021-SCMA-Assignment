using System;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ant_Colony_System_Library
{
    public delegate double Objective_Function(int[] a_Solution);
    public enum Optimization_Type { Minimization, Maximization}
    public class Ant_Colony_System_For_Sequencing_Problems
    {
        #region Data Field
        Random rnd;
        int number_Of_Cites;
        double[,] pheromone_Matrix;
        double[,] heuristic_Matrix;
        double pheromone_Square_Factor = 2.0;
        double heuristic_Square_Factor = 1.0;
        int population_Size = 30;
        double threshold = 0.7;
        int[] candidate_Cites;
        double[] objectives;
        double[] fitness;
        int[][] soultions;
        int[] So_Far_The_Best_Solution;
        double So_Far_The_Best_Objective;
        double iteration_Average_Objective;
        int iteration_Count;
        int iteration_Limit;
        double initial_Pheromone_Value = 0.1;
        double pheromone_Evaperation_Rate = 0.01;
        double pheromone_Drop_Rate = 0.3;

        public event EventHandler So_Far_The_Best_Update;

        Objective_Function objective_Function;
        Optimization_Type optimization_Type;


        Series Series_so_Far_The_Best_Objective;
        Series Series_iteration_Average_Objective;
        public int[][] Soultions { get => soultions; set => soultions = value; }
        public int Population_Size { get => population_Size; set => population_Size = value; }
        public double[,] Pheromone_Matrix { get => pheromone_Matrix; set => pheromone_Matrix = value; }
        public Series Series_So_Far_The_Best_Objective { get => Series_so_Far_The_Best_Objective; set => Series_so_Far_The_Best_Objective = value; }
        public Series Series_Iteration_Average_Objective { get => Series_iteration_Average_Objective; set => Series_iteration_Average_Objective = value; }
        #endregion



        #region Constructor
        public Ant_Colony_System_For_Sequencing_Problems(int number_Of_Variable, double[,] heuristic_Matrix, 
            Optimization_Type optimization_Type, Objective_Function objective_Function)
        {           
            // assigning variables
            this.number_Of_Cites = number_Of_Variable;
            this.heuristic_Matrix = heuristic_Matrix;
            this.optimization_Type = optimization_Type;
            this.objective_Function = objective_Function;

            // reallocate memory
            rnd = new Random();
            pheromone_Matrix = new double[number_Of_Variable, number_Of_Variable];
            candidate_Cites = new int[number_Of_Variable];
            fitness = new double[number_Of_Variable];            
            soultions = new int[population_Size][];
            objectives = new double[population_Size];
            for (int ant_ID = 0; ant_ID < population_Size; ant_ID++)            
                soultions[ant_ID] = new int[number_Of_Variable];
        }
        #endregion

        #region Run-Time Functions
        public void Reset()
        {
            // Create initial pheromone matrix
            for (int i = 0; i < number_Of_Cites; i++)            
                for (int j = 0; j < number_Of_Cites; j++)                
                    pheromone_Matrix[i, j] = initial_Pheromone_Value;

            // Create initial solution
            for (int i = 0; i < population_Size; i++)
            {
                candidate_Cites = Shuffle_A_Array(number_Of_Cites, number_Of_Cites);
                for (int j = 0; j < number_Of_Cites; j++)                
                    soultions[i][j] = candidate_Cites[j];                
            }

            // reset so far the best
            if (optimization_Type == Optimization_Type.Maximization)
                So_Far_The_Best_Objective = double.MinValue;
            else
                So_Far_The_Best_Objective = double.MaxValue;

            // clear series
            Series_iteration_Average_Objective = new Series();
            Series_so_Far_The_Best_Objective = new Series();
            Series_iteration_Average_Objective.Points.Clear();
            Series_So_Far_The_Best_Objective.Points.Clear();

            // reset iteration count
            iteration_Count = 0;            
        }
        public void Run_One_Iteration()
        {
            Perform_All_Solutions_Construction();
            Perform_so_Far_the_Best_Update();
            Perform_pheromone_Matrix_Update();
            Series_Update();
            iteration_Count++;
            // update so far the best soultion
            // find the iteration best soultion ID and objective value
            // if the iteration best is better than so far the best
            // variable - wise copy the iteration best to so far the best 
            // fire so far the best update event
            // Drop pheromone value on pheromone matrix following the ACS rule
        }



        public void Run_To_End()
        {
            for (int i = 0; i < iteration_Limit; i++)            
                Run_One_Iteration();     
        }
        #endregion

        #region ACO
        private void Perform_All_Solutions_Construction()
        {
            for (int i = 0; i < population_Size; i++)
            {
                Construct_A_Soultion(i, 0);
                objectives[i] = objective_Function(soultions[i]);
            }
        }
        private void Perform_so_Far_the_Best_Update()
        {
            double objective_Min = objectives[0];
            double objecive_Max = objectives[0];
            for (int i = 1; i < population_Size; i++)
            {
                if (objective_Min > objectives[i])
                    objective_Min = objectives[i];
                if (objecive_Max < objectives[i])
                    objecive_Max = objectives[i];
            }

            int index_Of_the_Best;
            if (optimization_Type == Optimization_Type.Maximization)
            {
                if (So_Far_The_Best_Objective < objecive_Max)
                { 
                    So_Far_The_Best_Objective = objecive_Max;
                    index_Of_the_Best = Array.IndexOf(objectives, objecive_Max);
                    for (int i = 0; i < number_Of_Cites; i++)
                        So_Far_The_Best_Solution[i] = soultions[index_Of_the_Best][i];
                } 
            }
            else
            {
                if (So_Far_The_Best_Objective > objective_Min)
                {
                    index_Of_the_Best = Array.IndexOf(objectives, objective_Min);
                    So_Far_The_Best_Objective = objective_Min;
                    for (int i = 0; i < number_Of_Cites; i++)
                        So_Far_The_Best_Solution[i] = soultions[index_Of_the_Best][i];
                }                   
            }

            iteration_Average_Objective = objectives.Sum() / (double)population_Size;
        }
        private void Perform_pheromone_Matrix_Update()
        {
            throw new NotImplementedException();
        }
        private void Series_Update()
        {
            Series_iteration_Average_Objective.Points.AddXY(iteration_Count, iteration_Average_Objective);
            Series_so_Far_The_Best_Objective.Points.AddXY(iteration_Count, So_Far_The_Best_Objective);
        }
        private void Construct_A_Soultion(int ant_ID, int n_th_Step)
        {
            if (n_th_Step == number_Of_Cites) // last step, record and return
            {
                // record candidate cities to solution
                for (int i = 0; i < number_Of_Cites; i++)                
                    soultions[ant_ID][i] = candidate_Cites[number_Of_Cites - i-1];
                return;
            }
            if (n_th_Step == 0) // first step, reset candidate cities, and rnd starting point, 
            {
                // reset candidate cities
                for (int i = 0; i < number_Of_Cites; i++)                
                    candidate_Cites[i] = soultions[ant_ID][i];

                // swap first city with last candidate
                int first_City = rnd.Next(0, number_Of_Cites);
                int index_of_city_To_in_solution = Array.IndexOf(soultions[ant_ID], first_City);
                (candidate_Cites[index_of_city_To_in_solution], candidate_Cites[number_Of_Cites - 1]) 
                    = (candidate_Cites[number_Of_Cites - 1], candidate_Cites[index_of_city_To_in_solution]);

                // find the next step
                n_th_Step++;
                Construct_A_Soultion(ant_ID, n_th_Step);
                return;
            }
            int city_From = candidate_Cites[number_Of_Cites - n_th_Step];
            int city_to_Index = 0;
            int city_To;
            double distance;
            double pheromone_density;
            if (rnd.NextDouble() >= threshold)
            {
                #region Stocastic Selection
                double fitness_Sum_so_far = 0;
                double destination;
                
                // fill in fitness
                for (int i = 0; i < number_Of_Cites - n_th_Step; i++)
                {
                    distance = 1.0 / heuristic_Matrix[city_From, candidate_Cites[i]];
                    pheromone_density = pheromone_Matrix[city_From, candidate_Cites[i]];
                    fitness[i] = Math.Pow(distance, heuristic_Square_Factor) 
                        * Math.Pow(pheromone_density, pheromone_Square_Factor)
                        + fitness_Sum_so_far;
                    fitness_Sum_so_far += fitness[i];
                }

                // randomly select
                destination = rnd.NextDouble() * fitness_Sum_so_far;
                while (fitness[city_to_Index] <= destination)               
                    city_to_Index++;
                
                                    
                #endregion
            }
            else
            {
                #region Determind Selection
                double largest_Fitness;
                // fill in fitness
                for (int i = 0; i < number_Of_Cites - n_th_Step; i++)
                {
                    distance = 1.0 / heuristic_Matrix[city_From, candidate_Cites[i]];
                    pheromone_density = pheromone_Matrix[city_From, candidate_Cites[i]];
                    fitness[i] = Math.Pow(distance, heuristic_Square_Factor)
                        * Math.Pow(pheromone_density, pheromone_Square_Factor);
                }

                // Determind select
                largest_Fitness = fitness[0];
                for (int i = 0; i < number_Of_Cites - n_th_Step; i++)                
                    if (largest_Fitness < fitness[i])                    
                        largest_Fitness = fitness[i];


                city_to_Index = Array.IndexOf(fitness, largest_Fitness);
                #endregion
            }
            city_To = candidate_Cites[city_to_Index];
           
            // swap city to  with the end element
            int index_of_city_To = Array.IndexOf(candidate_Cites, city_To);
            (candidate_Cites[index_of_city_To], candidate_Cites[number_Of_Cites - n_th_Step -1]) 
                = (candidate_Cites[number_Of_Cites -1  - n_th_Step], candidate_Cites[index_of_city_To]);

            // find the next step
            n_th_Step++;
            Construct_A_Soultion(ant_ID, n_th_Step);
        }
        #endregion

        #region Helping Functions
        public int[] Shuffle_A_Array(int n, int take)
        {
            int[] arr = Enumerable.Range(0, n).OrderBy(x => rnd.Next()).Take(take).ToList().ToArray();
            return arr;
        }
        #endregion
    }
}
