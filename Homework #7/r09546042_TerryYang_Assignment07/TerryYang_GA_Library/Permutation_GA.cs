using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerryYang_GA_Library
{
    public enum Permutation_Crossover_Type
    { Parial_Mapped_X, Order_X, Postition_Base_X, Order_Based_X, Cycle_X, Subtour_Exchange }

    public enum Permutation_Mutation_Type
    { Inversion }
    public class Permutation_GA: Generic_GA_Solver<int>
    {
        #region Datafield
        public Permutation_Crossover_Type Crossover_Type { set; get; } = Permutation_Crossover_Type.Parial_Mapped_X;
        public Permutation_Mutation_Type Mutation_Type { set; get; } = Permutation_Mutation_Type.Inversion;
        #endregion

        #region Contructor
        public Permutation_GA(int number_Of_Genes, GA_Optimization_Type optimization_Type, Objective_Function<int> objective_Function, Permutation_Crossover_Type Crossover_Type)
            : base( number_Of_Genes,  optimization_Type, objective_Function)
        {
            this.Crossover_Type = Crossover_Type;            
        }
        #endregion

        #region Helping Function

        public int[] Shuffle_A_Array(int n, int take)
        {
            int[] arr = Enumerable.Range(0, n).OrderBy(x => rnd.Next()).Take(take).ToList().ToArray();
            return arr;
        }
        #endregion

        #region Overrided Function
        public override void Initialize_Population()
        {
            for (int row = 0; row < population_Size; row++)
            {
                for (int column = 0; column < number_Of_Genes; column++)
                    chromosomes[row] = Shuffle_A_Array(number_Of_Genes, number_Of_Genes);

                objective_Value[row] = objective_Function(chromosomes[row], true);
            }
        }

        public override void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            int[] map; // partial map

            // rnd 2 cut points
            int[] two_Points = Shuffle_A_Array(number_Of_Genes,2);
            int p_min = two_Points[0];
            int p_max = two_Points[1]+1;
            int swapping_Length = Math.Abs(p_max - p_min);
            if (p_min>p_max)
            {
                // swap P_min & P_max
                p_max = p_min+ p_max;
                p_min = p_max - p_min;
                p_max = p_max - p_min;
            }
            int[] swapping_Part_from_F;
            int[] swapping_Part_from_M;
            int[] remain_part_for_A;
            int[] remain_part_for_B;

            int s;
            int r;
            int r_F;
            int r_M;
            switch (Crossover_Type)
            {
                case Permutation_Crossover_Type.Parial_Mapped_X:
                    //for (int i = 0; i < number_Of_Genes; i++) map[i] = -1;
                    //for (int i = i1; i < i2; i++)// construct partial map first
                    //{
                    //    if(chromosomes[father][i])
                    //}

                    break;
                case Permutation_Crossover_Type.Order_X:

                    #region Order Crossover
                    // record swapping parts
                    swapping_Part_from_F = new int[swapping_Length];
                    swapping_Part_from_M = new int[swapping_Length];
                    for (int i = 0; i < swapping_Length; i++)
                    {
                        swapping_Part_from_F[i] = chromosomes[father][p_min + i];
                        swapping_Part_from_M[i] = chromosomes[mother][p_min + i];
                    }

                    // finding crossover remaining parts
                    remain_part_for_A = new int[number_Of_Genes - swapping_Length];
                    remain_part_for_B = new int[number_Of_Genes - swapping_Length];
                    r_F = 0;
                    r_M = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (swapping_Part_from_F.Contains(chromosomes[ mother][i]) == false)
                        {
                            remain_part_for_A[r_F] = chromosomes[mother][i];
                            r_F++;
                        }
                        if (swapping_Part_from_M.Contains(chromosomes[ father][i]) == false)
                        {
                            remain_part_for_B[r_M] = chromosomes[father][i];
                            r_M++;
                        }
                    }

                    // fill in the child chromosomes
                    r = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (i < p_min || i >= p_max)
                        {
                            // at remaining regeion
                            chromosomes[child_a][i] = remain_part_for_A[r];
                            chromosomes[child_b][i] = remain_part_for_B[r];
                            r++;
                        }
                        else
                        {
                            // at swapping regeion
                            chromosomes[child_a][i] = chromosomes[father][i];
                            chromosomes[child_b][i] = chromosomes[mother][i];
                        }
                    }
                    #endregion

                    break;

                case Permutation_Crossover_Type.Postition_Base_X:

                    #region postition base crossover
                    // determind how many cut points 1 
                    int[] cut_points = Shuffle_A_Array(number_Of_Genes, rnd.Next(1, number_Of_Genes));
                    swapping_Length = cut_points.Length;
                    Array.Sort(cut_points);

                    // record swapping parts
                    swapping_Part_from_F = new int[swapping_Length];
                    swapping_Part_from_M = new int[swapping_Length];
                    for (int i = 0; i < swapping_Length; i++)
                    {
                        swapping_Part_from_F[i] = chromosomes[father][cut_points[i]];
                        swapping_Part_from_M[i] = chromosomes[mother][cut_points[i]];
                    }

                    // finding crossover remaining parts
                    remain_part_for_A = new int[number_Of_Genes - swapping_Length];
                    remain_part_for_B = new int[number_Of_Genes - swapping_Length];
                    r_F = 0;
                    r_M = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (swapping_Part_from_F.Contains(chromosomes[mother][i]) == false)
                        {
                            remain_part_for_A[r_F] = chromosomes[mother][i];
                            r_F++;
                        }
                        if (swapping_Part_from_M.Contains(chromosomes[father][i]) == false)
                        {
                            remain_part_for_B[r_M] = chromosomes[father][i];
                            r_M++;
                        }
                    }

                    s = 0;
                    r = 0;
                    // fill in child chromosomes
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (cut_points.Contains(i) == true)
                        {
                            // swap part
                            chromosomes[child_a][i] = swapping_Part_from_F[s];
                            chromosomes[child_b][i] = swapping_Part_from_M[s];
                            s++;
                        }
                        else
                        {
                            // remaining part
                            chromosomes[child_a][i] = remain_part_for_A[r];
                            chromosomes[child_b][i] = remain_part_for_B[r];
                            r++;
                        }
                    }
                    #endregion

                    break;
                case Permutation_Crossover_Type.Order_Based_X:

                    #region Order Base Crossover
                    // determind how many cut points 1 
                    int[] cut_points_1 = Shuffle_A_Array(number_Of_Genes, rnd.Next(1, number_Of_Genes));
                    swapping_Length = cut_points_1.Length;
                    int[] cut_points_2 = new int[swapping_Length];
                    Array.Sort(cut_points_1);

                    // finding swapping parts 1;
                    swapping_Part_from_F = new int[cut_points_1.Length];
                    swapping_Part_from_M = new int[cut_points_1.Length];
                    s = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (cut_points_1.Contains(i))
                        {
                            swapping_Part_from_F[s] = chromosomes[father][i];
                            s++;
                        }
                    }

                    // finding cut points 2
                    int id = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (swapping_Part_from_F.Contains(chromosomes[mother][i]) == true)
                        {
                            cut_points_2[id] = i;
                            id++;
                        }
                    }

                    // swapping parts 2;
                    s = 0;
                    for (int i = 0; i < cut_points_2.Length; i++)
                    {
                        swapping_Part_from_M[s] = chromosomes[mother][cut_points_2[i]];
                        s++;
                    }

                    // finding crossover remaining parts
                    remain_part_for_A = new int[number_Of_Genes - swapping_Length];
                    remain_part_for_B = new int[number_Of_Genes - swapping_Length];
                    r_F = 0;
                    r_M = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (swapping_Part_from_F.Contains(chromosomes[mother][i]) == false)
                        {
                            remain_part_for_A[r_F] = chromosomes[mother][i];
                            r_F++;
                        }
                        if (swapping_Part_from_M.Contains(chromosomes[father][i]) == false)
                        {
                            remain_part_for_B[r_M] = chromosomes[father][i];
                            r_M++;
                        }
                    }

                    // fill in swap part
                    r_F = 0;
                    r_M = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (cut_points_1.Contains(i) == true)
                        {
                            // fill child b with swap part M in cut point 1
                            chromosomes[child_b][i] = swapping_Part_from_M[r_M];
                            r_M++;
                        }
                        if (cut_points_2.Contains(i) == true)
                        {
                            //fill child a with swap part F in cut point 2
                            chromosomes[child_a][i] = swapping_Part_from_F[r_F];
                            r_F++;
                        }
                    }

                    // fill in remaining part
                    r_F = 0;
                    r_M = 0;
                    for (int i = 0; i < number_Of_Genes; i++)
                    {
                        if (cut_points_1.Contains(i) == false)
                        {
                            // fill child b with swap part M in cut point 1
                            chromosomes[child_b][i] = remain_part_for_B[r_M];
                            r_M++;
                        }
                        if (cut_points_2.Contains(i) == false)
                        {
                            //fill child a with swap part F in cut point 2
                            chromosomes[child_a][i] = remain_part_for_A[r_F];
                            r_F++;
                        }
                    }
                    #endregion
                    break;
                case Permutation_Crossover_Type.Cycle_X:
                    #region Cycle crossover

                    #endregion
                    break;
                case Permutation_Crossover_Type.Subtour_Exchange:
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}
