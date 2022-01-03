using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerryYang_GA_Library
{
    public enum Real_Number_Crossover_Type
    { LVD, SVD, MOES, TES, FBMS  }

    public enum Real_Number_Mutation_Type
    { Dynamic_Mutation }
    public class Real_Number_Encoded_GA : Generic_GA_Solver<double>
    {
        #region Datafield
        double[] lower_Bound;
        double[] upper_Bound;
        double degree_Of_Nonuniformity = 1;

        [Category("Crossover")]
        public Real_Number_Crossover_Type Crossover_Type { set; get; } = Real_Number_Crossover_Type.LVD;
        [Category("Mutation")]
        public Real_Number_Mutation_Type Mutation_Type { set; get; } = Real_Number_Mutation_Type.Dynamic_Mutation;

        #endregion

        #region Consturctor
        public Real_Number_Encoded_GA(int number_Of_Genes, double[] lower_Bound, double[] upper_Bound, GA_Optimization_Type optimization_Type, Objective_Function<double> objective_Function)
            : base(number_Of_Genes, optimization_Type, objective_Function)
        {
            this.lower_Bound = lower_Bound;
            this.upper_Bound = upper_Bound;
        }
        #endregion

        #region Overrided Function

        public override void Initialize_Population()
        {
            for (int row = 0; row < population_Size; row++)
            {
                //chromosomes[row] = new byte[number_Of_Genes];
                for (int column = 0; column < number_Of_Genes; column++)                
                {
                    chromosomes[row][column] = lower_Bound[column] + rnd.NextDouble()*(upper_Bound[column] -lower_Bound[column]);
                }
                objective_Value[row] = objective_Function(chromosomes[row]);   
            }
        }
        #region Crossover 
        private void LVD_Crossover(int father, int mother, int child_a, int child_b)
        {
            for (int i = 0; i < number_Of_Genes; i++)
            {
                double b_large;
                double alpha = rnd.NextDouble();
                if (chromosomes[father][i] > chromosomes[mother][i])
                    b_large = chromosomes[father][i];
                else
                    b_large = chromosomes[mother][i];

                chromosomes[child_a][i] = alpha*lower_Bound[i]+(1-alpha)* b_large;
                chromosomes[child_b][i] = alpha * b_large + (1 - alpha) * upper_Bound[i];
            }
            
        }
        private void SVD_Crossover(int father, int mother, int child_a, int child_b)
        {
            for (int i = 0; i < number_Of_Genes; i++)
            {
                double b_small;
                double alpha = rnd.NextDouble();
                if (chromosomes[father][i] < chromosomes[mother][i])
                    b_small = chromosomes[father][i];
                else
                    b_small = chromosomes[mother][i];

                chromosomes[child_a][i] = alpha * lower_Bound[i] + (1.0 - alpha) * b_small;
                chromosomes[child_b][i] = alpha * b_small + (1.0 - alpha) * upper_Bound[i];
            }

        }
        private void MOES_Crossover(int father, int mother, int child_a, int child_b)
        {
            for (int i = 0; i < number_Of_Genes; i++)
            {
                double b_small;
                double b_large;
                double alpha = rnd.NextDouble();
                double u = rnd.NextDouble();
                if (chromosomes[father][i] < chromosomes[mother][i])
                {
                    b_small = chromosomes[father][i];
                    b_large = chromosomes[mother][i];
                }                    
                else
                {
                    b_small = chromosomes[mother][i];
                    b_large = chromosomes[father][i];
                }
                    
                chromosomes[child_a][i] = alpha * b_small + (1.0 - alpha) * b_large;
                if (u>0.5)
                    chromosomes[child_b][i] = alpha * b_large + (1.0 - alpha) * upper_Bound[i];
                else
                    chromosomes[child_b][i] = alpha * lower_Bound[i] + (1.0 - alpha) * b_small;
            }

        }

        private void TES_Crossover(int father, int mother, int child_a, int child_b)
        {
            for (int i = 0; i < number_Of_Genes; i++)
            {
                double b_small;
                double b_large;
                double alpha = rnd.NextDouble();
                double u = rnd.NextDouble();
                if (chromosomes[father][i] < chromosomes[mother][i])
                {
                    b_small = chromosomes[father][i];
                    b_large = chromosomes[mother][i];
                }
                else
                {
                    b_small = chromosomes[mother][i];
                    b_large = chromosomes[father][i];
                }

                chromosomes[child_a][i] = alpha * lower_Bound[i] + (1.0 - alpha) * b_small;
                chromosomes[child_b][i] = alpha * b_large + (1.0 - alpha) * upper_Bound[i];
            }

        }

        private void FBMS_Crossover(int father, int mother, int child_a, int child_b)
        {
            for (int i = 0; i < number_Of_Genes; i++)
            {
                double b_small;
                double b_large;
                double alpha = rnd.NextDouble();
                if (chromosomes[father][i] < chromosomes[mother][i])
                {
                    b_small = chromosomes[father][i];
                    b_large = chromosomes[mother][i];
                }
                else
                {
                    b_small = chromosomes[mother][i];
                    b_large = chromosomes[father][i];
                }

                chromosomes[child_a][i] = alpha * b_small + (1.0 - alpha) * b_large;
                chromosomes[child_b][i] = alpha * b_large + (1.0 - alpha) * b_small;
            }

        }
        #endregion

        #region Mutation
        private void Dynamin_Mutation(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            int Pos = rnd.Next(0, number_Of_Genes);
            double d = rnd.NextDouble();
            double u = rnd.NextDouble();
            double k = chromosomes[before_mutation][Pos];
            double y;
            double new_X ;
            if (d>0.5)
            {
                y = upper_Bound[Pos] - k;
                new_X = k + u * y * Math.Pow((1.0 - (Current_Iteration / Iteration_Limit)), degree_Of_Nonuniformity);
            }
            else
            {
                y = k - lower_Bound[Pos];
                new_X = k - u * y * Math.Pow((1.0 - (Current_Iteration / Iteration_Limit)), degree_Of_Nonuniformity);
            }

            // mutation
            for (int i = 0; i < number_Of_Genes; i++)
            {
                if (i == Pos)
                    chromosomes[after_mutation][i] = chromosomes[before_mutation][i];
                else
                    chromosomes[after_mutation][i] = new_X;
            }           
        }
        #endregion
        public override void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            switch (Crossover_Type)
            {
                case Real_Number_Crossover_Type.LVD:
                    LVD_Crossover(father, mother, child_a, child_b);
                    break;
                case Real_Number_Crossover_Type.SVD:
                    SVD_Crossover(father, mother, child_a, child_b);
                    break;
                case Real_Number_Crossover_Type.MOES:
                    MOES_Crossover(father, mother, child_a, child_b);
                    break;
                case Real_Number_Crossover_Type.TES:
                    TES_Crossover(father, mother, child_a, child_b);
                    break;
                case Real_Number_Crossover_Type.FBMS:
                    FBMS_Crossover(father, mother, child_a, child_b);
                    break;
                default:
                    break;
            }
            objective_Value[child_a] = objective_Function(chromosomes[child_a]);
            objective_Value[child_b] = objective_Function(chromosomes[child_b]);
        }

        public override void Generate_Mutated_Chromosomes(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            switch (Mutation_Type)
            {
                case Real_Number_Mutation_Type.Dynamic_Mutation:

                    break;
                default:
                    break;
            }
            objective_Value[after_mutation] = objective_Function(chromosomes[after_mutation]);
        }
        #endregion
        #region Enum

        #endregion
    }
}
