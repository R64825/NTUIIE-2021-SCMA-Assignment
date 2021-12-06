using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant_Colony_System_Library
{
    public delegate double Objective_Function(int[] a_Solution);
    public enum Optimization_Type { Minimization, Maximization}
    public class Ant_Colony_System_For_Sequencing_Problems
    {
        #region Data Field
        int number_Of_Variable;
        double[,] pheromone_Matrix;
        double[,] heuristic_Matrix;
        double pheromone_Factor = 1.0;
        double heuristic_Factor = 3.0;
        int population_Size = 30;
        int[] candidate_Variables;
        double[] objectives;
        double[] fitness;
        int[][] soultions;
        int[] So_Far_The_Best_Solution;
        double So_Far_The_Best_Objective;
        int iteration_Count;
        int iteration_Limit;
        double initial_Pheromone_Value = 0.001;

        public event EventHandler So_Far_The_Best_Update;

        Objective_Function objective_Function;
        Optimization_Type optimization_Type;
        #endregion



        #region Constructor
        public Ant_Colony_System_For_Sequencing_Problems(int number_Of_Variable, double[,] heuristic_Matrix, 
            Optimization_Type optimization_Type, Objective_Function objective_Function)
        {
            this.number_Of_Variable = number_Of_Variable;
            this.heuristic_Matrix = heuristic_Matrix;
            this.optimization_Type = optimization_Type;
            this.objective_Function = objective_Function;

            // Create pheromone matrix
            pheromone_Matrix = new double[number_Of_Variable, number_Of_Variable];
            candidate_Variables = new int[number_Of_Variable];
            fitness = new double[number_Of_Variable]; 
        }
        #endregion

        #region Run-Time Functions
        public void Reset()
        {
            // reallocate memory
            soultions = new int[population_Size][];
            for (int ant_ID = 0; ant_ID < population_Size; ant_ID++)
            {
                soultions[ant_ID] = new int[number_Of_Variable];
            }
            objectives = new double[population_Size];
        }
        public void Run_One_Iteration()
        { }

        public void Run_To_End()
        {
            for (int i = 0; i < population_Size; i++)
            {
                Construct_A_Soultion(i);
                objectives[i] = objective_Function(soultions[i]);
            }

            // update so far the best soultion
            // find the iteration best soultion ID and objective value
            // if the iteration best is better than so far the best
            // variable - wise copy the iteration best to so far the best 
            // fire so far the best update event

            // Drop pheromone value on pheromone matrix following the ACS rule
        }
        #endregion

        #region ACO
        private void Construct_A_Soultion(int ant_ID)
        {
            // 
            // solution[i][j] = ...
        }
        #endregion
    }
}
