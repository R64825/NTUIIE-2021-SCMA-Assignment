using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ant_Colony_System_Library
{
    public delegate double Objective_Function(int[] a_Solution);
    public enum Optimization_Type { Minimization, Maximization}
    public enum Pheromone_Update_Type {All_Ants, Only_The_Best }
    public class Ant_Colony_System_For_Sequencing_Problems
    {
        #region Data Field
        Random rnd;
        int number_Of_Cites;
        double[,] pheromone_Matrix;
        double[,] heuristic_Matrix;
        double pheromone_Square_Factor = 1;
        double heuristic_Square_Factor = 3;
        int population_Size = 30;
        double threshold = 0.8;
        int[] candidate_Cites;
        double[] objectives;
        double[] fitness;
        int[][] soultions;
        int[] so_Far_The_Best_Solution;
        double so_Far_The_Best_Objective;
        double iteration_Average_Objective;
        double iteration_the_Best_Objective;
        int iteration_Count;
        int iteration_Limit = 500;
        double initial_Pheromone_Value = 0.001;
        double pheromone_Evaperation_Amount = 0.01;
        double pheromone_Drop_Mulitplier = 0.3;      

        Objective_Function objective_Function;
        Optimization_Type optimization_Type;
        Pheromone_Update_Type pheromone_Update_Type = Pheromone_Update_Type.All_Ants;

        Series series_so_Far_The_Best_Objective;
        Series series_iteration_Average_Objective;
        Series series_iteration_The_Best_Objective;
        #endregion
        #region Properties

        [Browsable(false)]
        public int[][] Soultions { get => soultions; set => soultions = value; }
        [Browsable(false)]
        public double[,] Pheromone_Matrix { get => pheromone_Matrix; set => pheromone_Matrix = value; }
        [Browsable(false)]
        public Series Series_So_Far_The_Best_Objective { get => series_so_Far_The_Best_Objective; set => series_so_Far_The_Best_Objective = value; }
        [Browsable(false)]
        public Series Series_Iteration_Average_Objective { get => series_iteration_Average_Objective; set => series_iteration_Average_Objective = value; }
        [Browsable(false)]
        public Series Series_iteration_The_Best_Objective { get => series_iteration_The_Best_Objective; set => series_iteration_The_Best_Objective = value; }
        [Browsable(false)]
        public int[] So_Far_The_Best_Solution { get => so_Far_The_Best_Solution; set => so_Far_The_Best_Solution = value; }
        [Browsable(false)]
        public double So_Far_The_Best_Objective { get => so_Far_The_Best_Objective; set => so_Far_The_Best_Objective = value; }


        [Category("Model Parameters")]
        public Optimization_Type Optimization_Type { get => optimization_Type; set => optimization_Type = value; }
        [Category("Model Parameters")]
        public int Population { get => population_Size; set => population_Size = value; }
        [Category("Model Parameters")]
        public double Pheromone_Factor { get => pheromone_Square_Factor; set => pheromone_Square_Factor = value; }
        [Category("Model Parameters")]
        public double Heuristic_Factor { get => heuristic_Square_Factor; set => heuristic_Square_Factor = value; }
        [Category("Model Parameters")]
        public double Deterministic_Percentage { get => threshold; set => threshold = value; }


        [Category("Iteration")]
        public int Current_Iteration { get => iteration_Count; set => iteration_Count = value; }
        [Category("Iteration")]
        public int Iteration_Limit { get => iteration_Limit; set => iteration_Limit = value; }


        [Category("Pheromone Matrix")]
        public double Initial_Value { get => initial_Pheromone_Value; set => initial_Pheromone_Value = value; }
        [Category("Pheromone Matrix")]
        public Pheromone_Update_Type Update_Type { get => pheromone_Update_Type; set => pheromone_Update_Type = value; }
        [Category("Pheromone Matrix")]
        public double Drop_Multiplier { get => pheromone_Drop_Mulitplier; set => pheromone_Drop_Mulitplier = value; }
        [Category("Pheromone Matrix")]
        public double Evaperation_Amount { get => pheromone_Evaperation_Amount; set => pheromone_Evaperation_Amount = value; }
        
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
            so_Far_The_Best_Solution = new int[number_Of_Variable];
            for (int ant_ID = 0; ant_ID < population_Size; ant_ID++)            
                soultions[ant_ID] = new int[number_Of_Variable];


            // series
            series_iteration_Average_Objective = new Series();
            series_so_Far_The_Best_Objective = new Series();
            series_iteration_The_Best_Objective = new Series();
            Series_Iteration_Average_Objective.ChartType = SeriesChartType.Line;
            Series_So_Far_The_Best_Objective.ChartType = SeriesChartType.Line;
            series_iteration_The_Best_Objective.ChartType = SeriesChartType.Line;
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
                so_Far_The_Best_Objective = double.MinValue;
            else
                so_Far_The_Best_Objective = double.MaxValue;          

            // reset iteration count
            iteration_Count = 0;

            // series
            series_iteration_Average_Objective.Points.Clear();
            Series_So_Far_The_Best_Objective.Points.Clear();
            series_iteration_The_Best_Objective.Points.Clear();
            series_iteration_Average_Objective.Name = "Iteration_Average";
            Series_So_Far_The_Best_Objective.Name = "So_Far_The_Best";
            series_iteration_The_Best_Objective.Name = "Iteration_The_Best";
            series_iteration_Average_Objective.Color = Color.Green;
            Series_So_Far_The_Best_Objective.Color = Color.Red;
            series_iteration_The_Best_Objective.Color = Color.Blue;
            series_iteration_The_Best_Objective.BorderWidth = 2;
            series_iteration_Average_Objective.BorderWidth = 2;
            Series_So_Far_The_Best_Objective.BorderWidth = 2;
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
                if (so_Far_The_Best_Objective < objecive_Max)
                { 
                    so_Far_The_Best_Objective = objecive_Max;
                    index_Of_the_Best = Array.IndexOf(objectives, objecive_Max);
                    for (int i = 0; i < number_Of_Cites; i++)
                        so_Far_The_Best_Solution[i] = soultions[index_Of_the_Best][i];
                }
                iteration_the_Best_Objective = objecive_Max;
            }
            else
            {
                if (so_Far_The_Best_Objective > objective_Min)
                {
                    index_Of_the_Best = Array.IndexOf(objectives, objective_Min);
                    so_Far_The_Best_Objective = objective_Min;
                    for (int i = 0; i < number_Of_Cites; i++)
                        so_Far_The_Best_Solution[i] = soultions[index_Of_the_Best][i];
                }
                iteration_the_Best_Objective = objective_Min;
            }

            iteration_Average_Objective = objectives.Sum() / (double)population_Size;         
        }
        private void Perform_pheromone_Matrix_Update()
        {
            // dropping pheromone
            int p1;
            int p2;
            if (pheromone_Update_Type == Pheromone_Update_Type.All_Ants)
            {
                // all ants drops 
                for (int ant_ID = 0; ant_ID < population_Size; ant_ID++)
                {
                    for (int i = 0; i < number_Of_Cites; i++)
                    {
                        p1 = soultions[ant_ID][i];                       
                        if (i == number_Of_Cites - 1 )
                            p2 = soultions[ant_ID][0];
                        else
                             p2 = soultions[ant_ID][i + 1];
                        pheromone_Matrix[p1, p2] += pheromone_Drop_Mulitplier;
                        pheromone_Matrix[p2, p1] += pheromone_Drop_Mulitplier;
                    }                    
                }
            }
            else
            {
                // the best ants drops

                // selecting best ants
                double smallest = double.MaxValue;
                double largest = double.MinValue;
                for (int i = 0; i < population_Size; i++)
                {
                    if (smallest > objectives[i])                   
                        smallest = objectives[i];
                    if (largest < objectives[i])
                        largest = objectives[i];
                }
                int index_The_Best;
                if (optimization_Type == Optimization_Type.Maximization)
                    index_The_Best = Array.IndexOf(objectives, largest);
                else
                    index_The_Best = Array.IndexOf(objectives, smallest);

                // dropping
                for (int j = 0; j < number_Of_Cites; j++)
                {
                    p1 = soultions[index_The_Best][j];
                    if (j == number_Of_Cites - 1)
                        p2 = soultions[index_The_Best][0];
                    else
                        p2 = soultions[index_The_Best][j + 1];
                    pheromone_Matrix[p1, p2] += pheromone_Drop_Mulitplier;
                    pheromone_Matrix[p2, p1] += pheromone_Drop_Mulitplier;
                }
            }

            // evaperate pheromone
            for (int i = 0; i < number_Of_Cites; i++)
            {
                for (int j = 0; j < number_Of_Cites; j++)
                {
                    pheromone_Matrix[i, j] -= pheromone_Evaperation_Amount;
                    if (pheromone_Matrix[i, j] < 0)
                        pheromone_Matrix[i, j] = 0;
                }
            }
        }
        
        private void Construct_A_Soultion(int ant_ID, int n_th_Step)
        {
            if (n_th_Step == number_Of_Cites) // last step, record and return
            {
                // record candidate cities to solution
                for (int i = 0; i < number_Of_Cites; i++)                
                    soultions[ant_ID][i] = candidate_Cites[number_Of_Cites - i - 1 ];
                return;
            }
            if (n_th_Step == 0) // first step, reset candidate cities, and rnd starting point, 
            {
                // reset candidate cities
                candidate_Cites = Shuffle_A_Array(number_Of_Cites, number_Of_Cites);

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
            double distance_invese;
            double pheromone_density;
            if (rnd.NextDouble() >= threshold)
            {
                #region Stocastic Selection
                double fitness_Sum_so_far = 0;
                double destination;
                
                // fill in fitness
                for (int i = 0; i < number_Of_Cites - n_th_Step; i++)
                {
                    distance_invese = heuristic_Matrix[city_From, candidate_Cites[i]];
                    pheromone_density = pheromone_Matrix[city_From, candidate_Cites[i]];
                    fitness[i] = Math.Pow(distance_invese, heuristic_Square_Factor) 
                        * Math.Pow(pheromone_density, pheromone_Square_Factor)
                        + fitness_Sum_so_far;
                    fitness_Sum_so_far = fitness[i];
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
                    distance_invese = heuristic_Matrix[city_From, candidate_Cites[i]];
                    pheromone_density = pheromone_Matrix[city_From, candidate_Cites[i]];
                    fitness[i] = Math.Pow(distance_invese, heuristic_Square_Factor)
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
        private void Series_Update()
        {
            series_iteration_Average_Objective.Points.AddXY(iteration_Count, iteration_Average_Objective);
            series_so_Far_The_Best_Objective.Points.AddXY(iteration_Count, so_Far_The_Best_Objective);
            Series_iteration_The_Best_Objective.Points.AddXY(iteration_Count, iteration_the_Best_Objective);
        }
        public string Return_A_Solution(int ant_ID)
        {           
            string str = string.Format("Ant {0:00 }:  ", ant_ID);
            for (int i = 0; i < number_Of_Cites; i++)
            {
                str += soultions[ant_ID][i].ToString();
                str += " ";
            }
            //str += string.Format("    Obj: {0:0.000}", objectives[ant_ID]);
            return str;
        }
        public string Return_Pheromone_Matrix(int row_ID, int deicimal_Count)
        {
            string str = string.Empty;
            double value;
            for (int i = 0; i < number_Of_Cites; i++)
            {
                value = Math.Round(pheromone_Matrix[row_ID, i], deicimal_Count);
                str += string.Format("  {0:0000.000}  ", value);
            }
            return str;
        }
        #endregion
    }
}
