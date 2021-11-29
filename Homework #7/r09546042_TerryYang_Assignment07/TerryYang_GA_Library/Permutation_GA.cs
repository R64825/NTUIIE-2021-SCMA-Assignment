using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerryYang_GA_Library
{
    public enum Permutation_Crossover_Operator
    { Parial_Mapped_X, Order_X, Postition_Base_X, Order_Based_X, Cycle_X, Subtour_Exchange }

    public enum Permutation_Mutation_Operator
    { Inversion }
    public class Permutation_GA: Generic_GA_Solver<int>
    {
        #region Datafield
        public Permutation_Crossover_Operator Crossover_Operator { set; get; } = Permutation_Crossover_Operator.Parial_Mapped_X;
        public Permutation_Mutation_Operator Mutation_Operator { set; get; } = Permutation_Mutation_Operator.Inversion;

        #endregion

        #region Contructor
        public Permutation_GA(int number_Of_Genes, GA_Optimization_Type optimization_Type, Objective_Function<int> objective_Function)
            : base( number_Of_Genes,  optimization_Type, objective_Function)
        {

        }
        #endregion


        #region Overrided Function
        public override void Initialize_Population()
        {
            for (int row = 0; row < population_Size; row++)
            {
                //chromosomes[row] = new byte[number_Of_Genes];
                for (int column = 0; column < number_Of_Genes; column++)
                    //chromosomes[row][column] = rnd.NextDouble();

                objective_Value[row] = objective_Function(chromosomes[row]);
            }
        }

        public override void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            int[] map; // partial map
            int i1 = rnd.Next(number_Of_Genes);
            int i2 = rnd.Next(number_Of_Genes);

            int temp;
            if (i1>i2)
            {
                temp = i1;
                i1 = i2;
                i2 = temp;
            }


            switch (Crossover_Operator)
            {
                case Permutation_Crossover_Operator.Parial_Mapped_X:
                    //for (int i = 0; i < number_Of_Genes; i++) map[i] = -1;
                    //for (int i = i1; i < i2; i++)// construct partial map first
                    //{
                    //    if(chromosomes[father][i])
                    //}

                    break;
                case Permutation_Crossover_Operator.Order_X:
                    break;
                case Permutation_Crossover_Operator.Postition_Base_X:
                    break;
                case Permutation_Crossover_Operator.Order_Based_X:
                    break;
                case Permutation_Crossover_Operator.Cycle_X:
                    break;
                case Permutation_Crossover_Operator.Subtour_Exchange:
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}
