using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using COP;

namespace Particle_Swamp_Optimizer
{    
    
    public delegate double COP_Objective_Function(double[] solution);

    public class Particle_Swamp_Optimizer_Solver
    {
        #region Data Field
        Random rnd = new Random();
        COP.OptimizationType optimization_Type = OptimizationType.Minimization;
        int number_Of_Variables;
        int number_Of_Particles = 20;
        int iteration = 0;
        int iteration_Limit = 300;
        double[][] positions;
        double[] objectives;
        double[][] self_Best_Position;
        double[] self_Best_Objectives;

        double[] so_Far_the_Best_Position;
        double so_Far_the_Best_Objective;

        double self_Factor = 0.5;
        double social_Factor = 0.5;

        double[] lower_Bound, upper_Bound;
        COP_Objective_Function the_Objective_Function;
        COPBenchmark the_CP = null;
        double iteration_Average;
        double iteration_Best;

        Series series_so_Far_The_Best_Objective;
        Series series_iteration_Average_Objective;
        Series series_iteration_The_Best_Objective;

        #endregion
        // define public properties for those modifiable parameters

        #region Properties
        [Browsable(false)]
        public double[][] Positions { get => positions; set => positions = value; }
        [Category("Parameters")]
        public int Number_Of_Particles { get => number_Of_Particles; set => number_Of_Particles = value; }
        [Category("Parameters")]
        public double Self_Factor { get => self_Factor; set => self_Factor = value; }
        [Category("Parameters")]
        public double Social_Factor { get => social_Factor; set => social_Factor = value; }
        [Category("Iteration")]
        public int Current_Iteration { get => iteration; set => iteration = value; }
        [Category("Iteration")]
        public int Iteration_Limit { get => iteration_Limit; set => iteration_Limit = value; }
        [Browsable(false)]
        public Series Series_so_Far_The_Best_Objective { get => series_so_Far_The_Best_Objective; set => series_so_Far_The_Best_Objective = value; }
        [Browsable(false)]
        public Series Series_iteration_Average_Objective { get => series_iteration_Average_Objective; set => series_iteration_Average_Objective = value; }
        [Browsable(false)]
        public Series Series_iteration_The_Best_Objective { get => series_iteration_The_Best_Objective; set => series_iteration_The_Best_Objective = value; }
        [Browsable(false)]
        public double[] So_Far_the_Best_Position { get => so_Far_the_Best_Position; set => so_Far_the_Best_Position = value; }
        [Browsable(false)]
        public double So_Far_the_Best_Objective { get => so_Far_the_Best_Objective; set => so_Far_the_Best_Objective = value; }
        #endregion

        #region Constructor
        public Particle_Swamp_Optimizer_Solver(COP.COPBenchmark Cp)
        {
            the_CP = Cp;
            number_Of_Variables = Cp.Dimension;
            lower_Bound = Cp.LowerBound;
            upper_Bound = Cp.UpperBound;
            optimization_Type = Cp.OptimizationGoal;
            the_Objective_Function = Cp.GetObjectiveValue;

            so_Far_the_Best_Position = new double[number_Of_Variables];
            self_Best_Objectives = new double[number_Of_Particles];

            // series
            series_iteration_Average_Objective = new Series();
            series_so_Far_The_Best_Objective = new Series();
            series_iteration_The_Best_Objective = new Series();
            series_so_Far_The_Best_Objective.ChartType = SeriesChartType.Line;
            series_iteration_Average_Objective.ChartType = SeriesChartType.Line;
            series_iteration_The_Best_Objective.ChartType = SeriesChartType.Line;
        }
        #endregion

        #region PSO Fucntions     

        private void Move_All_Particles_to_New_Positions()
        {
            double alpha;
            double beta;
            double diff_self;
            double diff_group;
            double velocity;
            double new_Pos;
            for (int p = 0; p < Number_Of_Particles; p++)
            {
                for (int i = 0; i < number_Of_Variables; i++)
                {
                    alpha = social_Factor * rnd.NextDouble();
                    beta = self_Factor * rnd.NextDouble();
                    diff_self = self_Best_Position[p][i] - positions[p][i];
                    diff_group = so_Far_the_Best_Position[i] - positions[p][i];
                    velocity = alpha * (diff_group) + beta * (diff_self);
                    new_Pos = positions[p][i] + velocity;

                    // check constrains
                    if (new_Pos > upper_Bound[i])
                        new_Pos = upper_Bound[i];
                    else if(new_Pos < lower_Bound[i])
                        new_Pos = lower_Bound[i];

                    // move point
                    positions[p][i] = new_Pos;
                }

                // update objective
                objectives[p] = the_Objective_Function(positions[p]);
            }

            iteration++;
        }

        private void Update_so_Far_the_Best_Position()
        {
            // update self best 
            for (int p = 0; p < Number_Of_Particles; p++)
            {
                bool self_update = false;
                bool so_far_the_best_update = false;
                switch (optimization_Type)
                {
                    case OptimizationType.Minimization:
                        if (objectives[p] < self_Best_Objectives[p])
                            self_update = true;
                        if (objectives[p] < so_Far_the_Best_Objective)
                            so_far_the_best_update = true;
                        break;
                    case OptimizationType.Maximization:
                        if (objectives[p] > self_Best_Objectives[p])
                            self_update = true;
                        if (objectives[p] > so_Far_the_Best_Objective)
                            so_far_the_best_update = true;
                        break;
                    case OptimizationType.GoalMatching:
                        break;
                    default:
                        break;
                }
                if (self_update)
                {
                    self_Best_Objectives[p] = objectives[p];
                    for (int d = 0; d < number_Of_Variables; d++)
                        self_Best_Position[p][d] = positions[p][d];
                }

                if (so_far_the_best_update)
                {
                    so_Far_the_Best_Objective = objectives[p];
                    for (int d = 0; d < number_Of_Variables; d++)
                        so_Far_the_Best_Position[d] = positions[p][d];
                }
            }

            // update series point
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int p = 0; p < Number_Of_Particles; p++)
            {
                sum += objectives[p];
                //bool update = false;
                if (optimization_Type == OptimizationType.Minimization)
                    if (min > objectives[p])
                        min = objectives[p];

                    else
                    if (max < objectives[p])
                        max = objectives[p];
            }

            iteration_Average = objectives.Sum() / (double)Number_Of_Particles;
            if (optimization_Type == OptimizationType.Minimization)
                iteration_Best = min;
            else
                iteration_Best = max;

            // Evaluate the objectives of all new positions ans update
            // self best position and objective, if new position is better
            // calculate so for the best solution and objectives if iteration best is better than so far the best 
        }
        private void Update_Series()
        {
            series_iteration_Average_Objective.Points.AddXY(iteration, iteration_Average);
            series_so_Far_The_Best_Objective.Points.AddXY(iteration, so_Far_the_Best_Objective);
            series_iteration_The_Best_Objective.Points.AddXY(iteration, iteration_Best);
        }
        public string Flatten_Position(double[] pos)
        {
            string str = string.Empty;
            for (int d = 0; d < number_Of_Variables; d++)
            {
                str += Math.Round( pos[d],3).ToString() + ", ";
            }
            return str;
        }
        #endregion

        #region Run Time Function
        public void Reset()
        {
            so_Far_the_Best_Position = new double[number_Of_Variables];
            self_Best_Objectives = new double[number_Of_Particles];

            // optimization type
            if (optimization_Type == OptimizationType.Maximization) so_Far_the_Best_Objective = double.MinValue;
            else so_Far_the_Best_Objective = double.MaxValue;

            // allocate or reallocate memory
            positions = new double[number_Of_Particles][];
            objectives = new double[Number_Of_Particles];
            self_Best_Position = new double[Number_Of_Particles][];
            for (int i = 0; i < number_Of_Particles; i++)
            { 
                positions[i] = new double[number_Of_Variables];
                self_Best_Position[i] = new double[number_Of_Variables];
            }
                

            // randomly assign initial positions & calculate the objectives 
            for (int p = 0; p < number_Of_Particles; p++)
            {
                for (int i = 0; i < number_Of_Variables; i++)
                    positions[p][i] = lower_Bound[i] + rnd.NextDouble() * (upper_Bound[i] - lower_Bound[i]);                    
                self_Best_Objectives[p] = so_Far_the_Best_Objective;
                objectives[p] = the_Objective_Function(positions[p]);
            }



            // series
            series_iteration_Average_Objective.Points.Clear();
            series_so_Far_The_Best_Objective.Points.Clear();
            series_iteration_The_Best_Objective.Points.Clear();
            series_iteration_Average_Objective.Name = "Iteration_Average";
            series_so_Far_The_Best_Objective.Name = "So_Far_The_Best";
            series_iteration_The_Best_Objective.Name = "Iteration_The_Best";
            series_iteration_Average_Objective.Color = Color.Green;
            series_so_Far_The_Best_Objective.Color = Color.Red;
            series_iteration_The_Best_Objective.Color = Color.Blue;
            series_iteration_The_Best_Objective.BorderWidth = 2;
            series_iteration_Average_Objective.BorderWidth = 2;
            series_so_Far_The_Best_Objective.BorderWidth = 2;

            Update_so_Far_the_Best_Position();
        }
        public void Run_One_Iteration()
        {
            Move_All_Particles_to_New_Positions();
            Update_so_Far_the_Best_Position();
            Update_Series();            
        }
        public void Run_To_End()
        {
            for (int i = iteration; i < iteration_Limit; i++)
                Run_One_Iteration();           
        }
        #endregion
    }


}
