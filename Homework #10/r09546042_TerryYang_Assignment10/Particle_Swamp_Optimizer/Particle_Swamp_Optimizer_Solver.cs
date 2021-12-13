using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COP;

namespace Particle_Swamp_Optimizer
{    
    
    public delegate double COP_Objective_Function(double solution);

    public class Particle_Swamp_Optimizer_Solver
    {
        #region Data Field
        Random rnd = new Random();
        COP.OptimizationType optimization_Type = OptimizationType.Minimization;
        int number_Of_Variables;
        int number_Of_Particles = 10;
        double[][] positions;
        double []objectives;
        double[][] self_Best_Position;
        double []self_Best_Objectives;

        double[] so_Far_the_Best_Position;
        double so_Far_the_Best_Objective;

        double self_Factor = 0.5;
        double social_Factor = 0.5;

        double[] lower_Bound, upper_Bound;
        COP_Objective_Function the_Objective_Function;

        public double[][] Positions { get => positions; set => positions = value; }
        #endregion
        // define public properties for those modifiable parameters

        #region Properties

        #endregion

        #region Constructor
        public Particle_Swamp_Optimizer_Solver(COP.COPBenchmark Cp)
        {
            number_Of_Variables = Cp.Dimension;
            lower_Bound = Cp.LowerBound;
            upper_Bound = Cp.UpperBound;
            optimization_Type = Cp.OptimizationGoal;

        }
        public Particle_Swamp_Optimizer_Solver(int number_Of_Variable, double[] lower_Bound, double[] upper_Bound,
             COP.OptimizationType optimization_Type, COP_Objective_Function objective_Function)
        {
            this.number_Of_Variables = number_Of_Variable;
            this.lower_Bound = lower_Bound;
            this.upper_Bound = upper_Bound;
            this.optimization_Type = optimization_Type;
            this.the_Objective_Function = objective_Function;

            so_Far_the_Best_Position = new double[number_Of_Variables];
        }
        #endregion

        #region Argorithm Fucntions     
        
        private void Move_All_Particles_to_New_Positions()
        {
            // Use 
            throw new NotImplementedException();
        }

        private void Update_so_Far_the_Best_Position()
        {
            // Evaluate the objectives of all new positions ans update
            // self best position and objective, if new position is better
            // calculate so for the best solution and objectives if iteration best is better than so far the best 
            throw new NotImplementedException();
        }


        #endregion

        #region Run Time Function
        public void Reset()
        {
            if (positions == null || positions.Length != number_Of_Particles)
            {
                // allocate or reallocate memory
                positions = new double[number_Of_Particles][];
                for (int i = 0; i < number_Of_Particles; i++)
                {
                    positions[i] = new double[number_Of_Variables];
                    //...
                }
                if (optimization_Type == OptimizationType.Maximization) so_Far_the_Best_Objective = double.MinValue;
                else so_Far_the_Best_Objective = double.MaxValue;

                // randomly assign initial positions, 
                for (int i = 0; i < number_Of_Particles; i++)
                {
                    for (int j = 0; j < number_Of_Variables; j++)                 
                        positions[i][j] = lower_Bound[j] + rnd.NextDouble() * (upper_Bound[j] - lower_Bound[j]);
                    if (optimization_Type == OptimizationType.Minimization)
                        self_Best_Objectives[i] = double.MaxValue;
                    else
                        self_Best_Objectives[i] = double.MinValue;
                    
                }
            }
        }
        public void Run_One_Iteration()
        {
            Move_All_Particles_to_New_Positions();
            Update_so_Far_the_Best_Position();
        }
        public void Run_To_End()
        {

        }
        #endregion
    }


}
