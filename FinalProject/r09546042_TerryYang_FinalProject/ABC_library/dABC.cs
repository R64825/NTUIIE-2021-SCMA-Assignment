using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using COP;

namespace ABC_library
{
    //public delegate double COP_Objective_Function(double[] solution);
    public class Directed_Artificial_Bee_Colony
    {
        #region Date Field
        // hyper parameter
        int num_Of_Pop = 20;
        double ratio_Of_Employed = 0.5;
        double ratio_Of_Onlooker = 0.5;
        double least_Fitness_Fraction = 0.1;

        Random rnd;
        int[] indices;
        int[][] direct;
        double[][] source_Loc;
        double[][] source_Loc_OL;
        double[][] bees;
        int[] trial_Counter;

        double[] obj_Bee;
        double[] obj_Source;
        double[] obj_Source_OL;
        double[] fittness;

        int num_Of_Food;
        int num_Of_Employed;
        int num_Of_Onlooker;
        int num_Of_Dim;

        int trial_Limit;

        COP.OptimizationType optimization_Type = OptimizationType.Minimization;
        COP_Objective_Function the_Objective_Function;

        // indication
        double iter_Average;
        double iter_Best_Obj;
        double so_Far_Best_OBJ;
        double[] so_Far_Best_Sol;

        // iteration
        int iteration_Count = 0;
        int iteration_Limit = 300;

        double[] lower_Bound;
        double[] upper_Bound;

        // series
        private ChartArea ca;
        private Series series_SoFarTheBest;
        private Series series_Average;
        private Series series_IterationTheBest;
        #endregion

        #region Properties
        [Category("Model Parameters")]
        public int Population_Size
        {
            get => num_Of_Pop;
            set { if (value >= 1) num_Of_Pop = value; }
        }
        [Category("Model Parameters")]
        public double Employed_Bee_Ratio
        {
            get => ratio_Of_Employed;
            set
            {
                if (value <= 1.0 && value >= 0.0)
                    ratio_Of_Employed = value;
                ratio_Of_Onlooker = 1.0 - value;
            }
        }
        [Category("Model Parameters")]
        public double Onlooker_Bee_Ratio
        {
            get => ratio_Of_Onlooker;
            set
            {
                if (value <= 1.0 && value >= 0.0)
                    ratio_Of_Onlooker = value;
                ratio_Of_Employed = 1.0 - value;
            }
        }
        [Category("Model Parameters")]
        public double Least_Fitness_Fraction
        {
            get => least_Fitness_Fraction;
            set { if (value >= 0.1 && value <= 0.5) least_Fitness_Fraction = value; }
        }
        [Category("Iteration")]
        public int Current_Iteration { get => iteration_Count; set => iteration_Count = value; }
        [Category("Iteration")]
        public int Iteration_Limit { get => iteration_Limit; set => iteration_Limit = value; }
        [Browsable(false)]
        public Series Series_SoFarTheBest { get => series_SoFarTheBest; set => series_SoFarTheBest = value; }
        [Browsable(false)]
        public Series Series_Average { get => series_Average; set => series_Average = value; }
        [Browsable(false)]
        public Series Series_IterationTheBest { get => series_IterationTheBest; set => series_IterationTheBest = value; }
        [Browsable(false)]
        public double[][] Bees { get => bees; set => bees = value; }
        [Browsable(false)]
        public double[][] Food_Source_Location { get => source_Loc; set => source_Loc = value; }
        [Browsable(false)]
        public double So_Far_Best_OBJ { get => so_Far_Best_OBJ; set => so_Far_Best_OBJ = value; }
        [Browsable(false)]
        public double[] So_Far_Best_Sol { get => so_Far_Best_Sol; set => so_Far_Best_Sol = value; }

        #endregion

        #region Constructor
        public Directed_Artificial_Bee_Colony(COP.COPBenchmark Cp)
        {
            // define objective function
            the_Objective_Function = Cp.GetObjectiveValue;

            // define dimension
            num_Of_Dim = Cp.Dimension;

            // reset so far the best
            so_Far_Best_Sol = new double[num_Of_Dim];
            if (Cp.OptimizationGoal == OptimizationType.Maximization)
                optimization_Type = OptimizationType.Maximization;
            else
                optimization_Type = OptimizationType.Minimization;



            // read upper and lower bound
            lower_Bound = new double[num_Of_Dim];
            upper_Bound = new double[num_Of_Dim];
            lower_Bound = Cp.LowerBound;
            upper_Bound = Cp.UpperBound;

            // series
            series_Average = new Series("Iteration_Average");
            series_IterationTheBest = new Series("Iteration_The_Best");
            series_SoFarTheBest = new Series("So_Far_The_Best");
            series_Average.Color = Color.Green;
            series_SoFarTheBest.Color = Color.Red;
            series_IterationTheBest.Color = Color.Blue;
            series_IterationTheBest.ChartType = SeriesChartType.Line;
            series_Average.ChartType = SeriesChartType.Line;
            series_SoFarTheBest.ChartType = SeriesChartType.Line;
            series_IterationTheBest.BorderWidth = 2;
            series_Average.BorderWidth = 2;
            series_SoFarTheBest.BorderWidth = 2;

            // misc
            indices = new int[num_Of_Food];
            rnd = new Random();
        }
        #endregion

        #region Run Time Function
        public void Reset()
        {
            // define all numbers
            num_Of_Onlooker = Convert.ToInt16((double)num_Of_Pop * ratio_Of_Onlooker);
            num_Of_Employed = Convert.ToInt16((double)num_Of_Pop * ratio_Of_Employed);
            num_Of_Food = num_Of_Employed;

            trial_Limit = num_Of_Pop * num_Of_Dim / 2;

            // allocate bees and nectar memory                     
            bees = new double[num_Of_Pop][];
            for (int p = 0; p < num_Of_Pop; p++)
                bees[p] = new double[num_Of_Dim];
            source_Loc = new double[num_Of_Food][];
            for (int f = 0; f < num_Of_Food; f++)
                source_Loc[f] = new double[num_Of_Dim];
            source_Loc_OL = new double[num_Of_Onlooker][];
            for (int ol = 0; ol < num_Of_Onlooker; ol++)
                source_Loc_OL[ol] = new double[num_Of_Dim];

            obj_Bee = new double[num_Of_Pop];
            obj_Source = new double[num_Of_Food];
            obj_Source_OL = new double[num_Of_Onlooker];
            fittness = new double[num_Of_Food];

            trial_Counter = new int[num_Of_Food];
            for (int d = 0; d < num_Of_Food; d++)
                trial_Counter[d] = 0;

            // initilize food source & employed bees
            for (int n = 0; n < num_Of_Food; n++)
            {
                for (int dim = 0; dim < num_Of_Dim; dim++)
                {
                    source_Loc[n][dim] = lower_Bound[dim] +
                               (upper_Bound[dim] - lower_Bound[dim]) * rnd.NextDouble();
                    bees[n][dim] = source_Loc[n][dim];
                }
                obj_Source[n] = the_Objective_Function(source_Loc[n]);
                obj_Bee[n] = obj_Source[n];
            }

            // reset so far the best
            // reset so far the best
            if (optimization_Type == OptimizationType.Maximization)
                so_Far_Best_OBJ = double.MinValue;
            else
                so_Far_Best_OBJ = double.MaxValue;

            // reset series
            series_Average.Points.Clear();
            series_SoFarTheBest.Points.Clear();
            series_IterationTheBest.Points.Clear();

            Update_The_Best_Source();
            iteration_Count = 0;
        }
        public void Run_One_Iteration()
        {
            Employed_Bees_Phase();
            Onlookers_Bees_Phase();
            Scout_Bees_Phase();

            Update_The_Best_Source();
            Update_Series();
            iteration_Count++;
        }
        public void Run_To_End()
        {
            for (int i = iteration_Count; i < iteration_Limit; i++)
                Run_One_Iteration();
        }
        #endregion

        #region Bee Phase
        public void Employed_Bees_Phase()
        {
            // Allocate Food Source to Employed Bees
            for (int nf = 0; nf < num_Of_Food; nf++)
                for (int d = 0; d < num_Of_Dim; d++)
                    bees[nf][d] = source_Loc[nf][d];

            // Send Employed Bees
            double v;
            double phi;
            int mut_pos;
            int neib;
            bool get_Better;
            for (int EB_id = 0; EB_id < num_Of_Employed; EB_id++)
            {
                // random value
                mut_pos = Shuffle_Indices_Array(num_Of_Dim, 1)[0]; // rnd dimension
                neib = Shuffle_Indices_Array(num_Of_Food, 1)[0]; // rnd food source
                phi = 2 * rnd.NextDouble() - 1.0; // [-1, 1]

                // calculate v
                v = source_Loc[EB_id][mut_pos] + (source_Loc[EB_id][mut_pos] - source_Loc[neib][mut_pos]) * phi;
                if (v > upper_Bound[mut_pos]) v = upper_Bound[mut_pos];
                if (v < lower_Bound[mut_pos]) v = lower_Bound[mut_pos];

                // update bees
                bees[EB_id][mut_pos] = v;
                obj_Bee[EB_id] = the_Objective_Function(bees[EB_id]);



                //update food source or not
                get_Better = false;
                if (optimization_Type == OptimizationType.Maximization)
                {
                    if (obj_Bee[EB_id] > obj_Source[EB_id])
                        get_Better = true;
                }
                else
                {
                    if (obj_Bee[EB_id] < obj_Source[EB_id])
                        get_Better = true;
                }

                if (get_Better)
                {
                    // bee override food
                    source_Loc[EB_id][mut_pos] = bees[EB_id][mut_pos];

                    obj_Source[EB_id] = obj_Bee[EB_id];

                    // update trial counter
                    trial_Counter[EB_id] = 0;
                }
                else
                {
                    // food override bee
                    bees[EB_id][mut_pos] = source_Loc[EB_id][mut_pos];

                    obj_Bee[EB_id] = obj_Source[EB_id];

                    // update trial counter
                    trial_Counter[EB_id] += 1;
                }
            }
        }

        public void Onlookers_Bees_Phase()
        {
            Set_Fitness();
            int[] locations = Sthocastic_Wheel();
            double v;
            double phi;
            int mut_pos;
            int neib;
            bool get_Better;
            int loc_Id;

            for (int OB_id = num_Of_Employed; OB_id < num_Of_Employed + locations.Length; OB_id++)
            {
                loc_Id = OB_id - num_Of_Employed;
                // random value
                mut_pos = Shuffle_Indices_Array(num_Of_Dim, 1)[0]; // rnd dimension               
                neib = Shuffle_Indices_Array(num_Of_Food, 1)[0]; // rnd food source
                phi = 2 * rnd.NextDouble() - 1.0; // [-1, 1]

                // send onlooker bee
                for (int d = 0; d < num_Of_Dim; d++)
                    bees[OB_id][d] = bees[locations[loc_Id]][d];

                obj_Source_OL[loc_Id] = the_Objective_Function(bees[OB_id]);

                // calculate v
                v = source_Loc[locations[loc_Id]][mut_pos] + (source_Loc[locations[loc_Id]][mut_pos] - source_Loc[neib][mut_pos]) * phi;
                if (v > upper_Bound[mut_pos]) v = upper_Bound[mut_pos];
                if (v < lower_Bound[mut_pos]) v = lower_Bound[mut_pos];
                bees[OB_id][mut_pos] = v;
                obj_Bee[OB_id] = the_Objective_Function(bees[OB_id]);

                //update food source or not
                get_Better = false;
                if (optimization_Type == OptimizationType.Maximization)
                {
                    if (obj_Bee[OB_id] > obj_Source_OL[loc_Id])
                        get_Better = true;
                }
                else
                {
                    if (obj_Bee[OB_id] < obj_Source_OL[loc_Id])
                        get_Better = true;
                }


                if (get_Better)
                {
                    // bee override food
                    source_Loc[locations[loc_Id]][mut_pos] = bees[OB_id][mut_pos];
                    obj_Source[locations[loc_Id]] = obj_Bee[OB_id];

                    // update trial counter
                    trial_Counter[locations[loc_Id]] = 0;
                }
                else
                {
                    // food override bee
                    bees[OB_id][mut_pos] = source_Loc[locations[loc_Id]][mut_pos];
                    obj_Bee[OB_id] = obj_Source[locations[loc_Id]];

                    // update trial counter
                    trial_Counter[locations[loc_Id]] += 1;
                }
            }
        }

        public void Scout_Bees_Phase()
        {
            // if trial > limit, than random generate new sol.            
            for (int f = 0; f < num_Of_Food; f++)
            {
                if (trial_Counter[f] > trial_Limit)
                {
                    for (int d = 0; d < num_Of_Dim; d++)
                    {
                        source_Loc[f][d] = lower_Bound[d] +
                                   (upper_Bound[d] - lower_Bound[d]) * rnd.NextDouble();
                        bees[f][d] = source_Loc[f][d];
                    }
                    obj_Source[f] = the_Objective_Function(source_Loc[f]);
                    obj_Bee[f] = obj_Source[f];
                }
            }
        }
        #endregion


        #region Helping Function
        private int[] Shuffle_Indices_Array(int n, int take)
        {
            int[] arr = new int[n];
            arr = Enumerable.Range(0, n).OrderBy(x => rnd.Next()).Take(take).ToList().ToArray();
            return arr;
        }
        public int[] Sthocastic_Wheel()
        {
            double Ratio = 1.0 / fittness.Sum();
            double[] dartboard = new double[num_Of_Employed];
            int[] locations = new int[num_Of_Onlooker];
            double sum = 0;
            int darts_counts = 0;
            double dart = rnd.NextDouble();

            // creating darting wheel
            for (int i = 0; i < num_Of_Employed; i++)
            {
                sum += Ratio * fittness[i] * num_Of_Onlooker;
                dartboard[i] = sum;
            }

            // shooting darts until popsize
            for (int p = 0; p < num_Of_Employed; p++)
            {
                while (dartboard[p] > dart && darts_counts < num_Of_Onlooker) // hit
                {
                    // select 
                    //Copy_This_Chromosomes_to_a_Selection(p, darts_counts);
                    locations[darts_counts] = p;
                    darts_counts++;
                    dart++;
                }
            }

            return locations;
        }
        public void Set_Fitness()
        {
            double o_min = double.MaxValue;
            double o_max = double.MinValue;
            for (int i = 0; i < num_Of_Food; i++)
            {
                if (o_max < obj_Source[i])
                    o_max = obj_Source[i];
                if (o_min > obj_Source[i])
                    o_min = obj_Source[i];
            }
            double beta = Math.Max(least_Fitness_Fraction * (o_max - o_min), 1e-5);

            switch (optimization_Type)
            {
                case OptimizationType.Maximization:
                    for (int i = 0; i < num_Of_Food; i++)
                        fittness[i] = beta + (obj_Source[i] - o_min);
                    break;
                case OptimizationType.Minimization:
                    for (int i = 0; i < num_Of_Food; i++)
                        fittness[i] = beta + (o_max - obj_Source[i]);
                    break;
                default:
                    break;
            }
        }
        public void Update_The_Best_Source()
        {
            // rearrange indices
            indices = new int[num_Of_Food];
            for (int i = 0; i < num_Of_Food; i++) indices[i] = i;

            // sort fitness from large to small
            Set_Fitness();
            Array.Sort(fittness, indices, 0, num_Of_Food);
            Array.Reverse(fittness, 0, num_Of_Food);
            Array.Reverse(indices, 0, num_Of_Food);

            // update iteration the best & maybe so far the best
            bool update = false;
            iter_Best_Obj = obj_Source[indices[0]];

            if (optimization_Type == OptimizationType.Maximization)
            {
                if (iter_Best_Obj > so_Far_Best_OBJ)
                    update = true;
            }
            else
            {
                if (iter_Best_Obj < so_Far_Best_OBJ)
                    update = true;
            }

            if (update)
            {
                for (int dim = 0; dim < num_Of_Dim; dim++)
                {
                    so_Far_Best_Sol[dim] = bees[indices[0]][dim];
                }
                so_Far_Best_OBJ = iter_Best_Obj;
            }

            // preserve top fittness
            if (iter_Best_Obj != so_Far_Best_OBJ)
            {
                int i = 1;
            }
        }
        public void Update_Series()
        {
            iter_Average = obj_Source.Sum() / (double)num_Of_Food;

            series_Average.Points.AddXY(iteration_Count, iter_Average);
            series_SoFarTheBest.Points.AddXY(iteration_Count, so_Far_Best_OBJ);
            series_IterationTheBest.Points.AddXY(iteration_Count, iter_Best_Obj);
        }
        public string Flatten_Solution(double[] sol)
        {
            string str = string.Empty;
            for (int d = 0; d < num_Of_Dim; d++)
            {
                str += Math.Round(sol[d], 3).ToString() + ", ";
            }
            return str;
        }
        #endregion
    }
}
