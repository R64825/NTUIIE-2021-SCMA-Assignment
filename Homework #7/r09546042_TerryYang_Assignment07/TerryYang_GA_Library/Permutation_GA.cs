using System;
using System.Collections.Generic;
using System.Linq;

namespace TerryYang_GA_Library
{
    public enum Permutation_Crossover_Type
    { Parial_Mapped_X, Order_X, Postition_Base_X, Order_Based_X, Cycle_X, Subtour_Exchange }

    public enum Permutation_Mutation_Type
    { Inversion, Insertion, Displacement, Reciprocal_Exchange, Heuristic }
    public class Permutation_GA: Generic_GA_Solver<int>
    {
        #region Datafield
        public Permutation_Crossover_Type Crossover_Type { set; get; } = Permutation_Crossover_Type.Parial_Mapped_X;
        public Permutation_Mutation_Type Permu_Mutation_Type { set; get; } = Permutation_Mutation_Type.Inversion;
        #endregion

        #region Contructor
        public Permutation_GA(int number_Of_Genes, GA_Optimization_Type optimization_Type, Objective_Function<int> objective_Function, Permutation_Crossover_Type Crossover_Type, Permutation_Mutation_Type mutation_Type)
            : base( number_Of_Genes,  optimization_Type, objective_Function)
        {
            this.Crossover_Type = Crossover_Type;
            this.Permu_Mutation_Type = mutation_Type;
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

                objective_Value[row] = objective_Function(chromosomes[row], false);
            }
        }
        #region Crossover Methods
        private void Parial_Mapped_Crossover(int father, int mother, int child_a, int child_b)
        {
            #region Teacher's
            int[] two_Points = Shuffle_A_Array(number_Of_Genes, 2);
            Array.Sort(two_Points);
            int p_min = two_Points[0];
            int p_max = two_Points[1];
            int[] Dad = chromosomes[father];
            int[] Mom = chromosomes[mother];
            int swapping_Length = Math.Abs(p_max - p_min);
            int[] Map = new int[number_Of_Genes];
            for (int i = 0; i < number_Of_Genes; i++)
                Map[i] = -1;

            // construct partial map
            for (int i = p_min; i < p_max + 1; i++)
            {
                if (Dad[i] == Mom[i]) // no mapping
                    continue;
                if (Map[Dad[i]] == -1 && Map[Mom[i]] == -1)
                {
                    // new int found ==> map 
                    Map[Dad[i]] = Mom[i];
                    Map[Mom[i]] = Dad[i];
                }
                else if (Map[Dad[i]] == -1)
                {
                    // this int exist in parent_M
                    Map[Dad[i]] = Map[Mom[i]];
                    Map[Map[Mom[i]]] = Dad[i];
                    Map[Mom[i]] = -2;
                }
                else if (Map[Mom[i]] == -1)
                {
                    // this int exist in parent_M
                    Map[Mom[i]] = Map[Dad[i]];
                    Map[Map[Dad[i]]] = Mom[i];
                    Map[Dad[i]] = -2;
                }
                else
                {
                    // -2 or -3 
                    Map[Map[Mom[i]]] = Map[Dad[i]];
                    Map[Map[Dad[i]]] = Map[Mom[i]];
                    Map[Dad[i]] = -3;
                    Map[Mom[i]] = -3;
                }
            }

            // fill in child
            for (int i = 0; i < number_Of_Genes; i++)
            {
                if (i <= p_max  && i >= p_min)
                {
                    // at swapping area
                    chromosomes[child_b][i] = Dad[i];
                    chromosomes[child_a][i] = Mom[i];
                }
                else
                {
                    // mapping
                    if (Map[Dad[i]] < 0)
                        chromosomes[child_a][i] = Dad[i];

                    else
                        chromosomes[child_a][i] = Map[Dad[i]];


                    if (Map[Mom[i]] < 0)
                        chromosomes[child_b][i] = Mom[i];

                    else
                        chromosomes[child_b][i] = Map[Mom[i]];

                }
            }
            #endregion

            #region Home Made
            //int[] two_Points = Shuffle_A_Array(number_Of_Genes, 2);
            //Array.Sort(two_Points);
            //int p_min = two_Points[0];
            //int p_max = two_Points[1];
            //int swapping_Length = Math.Abs(p_max - p_min) + 1;

            //// record swapping parts

            //int[] swapping_Part_from_F;
            //int[] swapping_Part_from_M;
            //swapping_Part_from_F = new int[swapping_Length];
            //swapping_Part_from_M = new int[swapping_Length];
            //for (int i = 0; i < swapping_Length; i++)
            //{
            //    swapping_Part_from_F[i] = chromosomes[father][p_min + i];
            //    swapping_Part_from_M[i] = chromosomes[mother][p_min + i];
            //}

            //// records partial map
            //int element = swapping_Part_from_F[0];
            //List<int> path = new List<int>();
            //path.Add(element);
            //while (element != -1)
            //{
            //    if (swapping_Part_from_F.Contains(element) == false)
            //    {
            //        element = -1;
            //    }

            //    if (swapping_Part_from_M.Contains(element))
            //    {
            //        path.Add(swapping_Part_from_M.ToList()[].IndexOf(element));
            //    }
            //}

            //List<int> sp_F = swapping_Part_from_F.ToList();
            //List<int> sp_M = swapping_Part_from_M.ToList();

            //for (int i = 0; i < number_Of_Genes; i++)
            //{
            //    if (sp_F.Contains(i) && sp_M.Contains(i))
            //    {
            //        sp_F.Add(sp_M[sp_F.IndexOf(i)]);
            //        sp_M.Add(sp_F[sp_F.IndexOf(i)]);

            //        sp_F.Remove(i);
            //        sp_M.Remove(i);
            //    }
            //}

            //// finding crossover remaining parts
            //int r_F;
            //int r_M;
            //int[] remain_part_for_A;
            //int[] remain_part_for_B;
            //remain_part_for_A = new int[number_Of_Genes - swapping_Length];
            //remain_part_for_B = new int[number_Of_Genes - swapping_Length];
            //r_F = 0;
            //r_M = 0;
            //for (int i = 0; i < number_Of_Genes; i++)
            //{
            //    if (swapping_Part_from_F.Contains(chromosomes[mother][i]) == false)
            //    {
            //        remain_part_for_A[r_F] = chromosomes[mother][i];
            //        r_F++;
            //    }
            //    if (swapping_Part_from_M.Contains(chromosomes[father][i]) == false)
            //    {
            //        remain_part_for_B[r_M] = chromosomes[father][i];
            //        r_M++;
            //    }
            //}
            #endregion

        }
        private void Order_Crossover(int father, int mother, int child_a, int child_b)
        {
            // rnd 2 cut points
            int[] two_Points = Shuffle_A_Array(number_Of_Genes, 2);
            Array.Sort(two_Points);
            int p_min = two_Points[0];
            int p_max = two_Points[1];
            int swapping_Length = Math.Abs(p_max - p_min);

            int[] swapping_Part_from_F;
            int[] swapping_Part_from_M;
            int[] remain_part_for_A;
            int[] remain_part_for_B;

            int s;
            int r;
            int r_F;
            int r_M;

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
        }
        private void Postition_Base_Crossover(int father, int mother, int child_a, int child_b)
        {
            int swapping_Length;
            int[] swapping_Part_from_F;
            int[] swapping_Part_from_M;
            int[] remain_part_for_A;
            int[] remain_part_for_B;

            int s;
            int r;
            int r_F;
            int r_M;

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
        }
        private void Order_Based_Crossover(int father, int mother, int child_a, int child_b)
        {
            int swapping_Length;
            int[] swapping_Part_from_F;
            int[] swapping_Part_from_M;
            int[] remain_part_for_A;
            int[] remain_part_for_B;

            int s;
            int r_F;
            int r_M;
            
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
        }
        private void Cycle_Crossover(int father, int mother, int child_a, int child_b)
        {
            int cut_point = rnd.Next(1, number_Of_Genes);
            List<int> cut_cycle_element_of_F = new List<int>();
            List<int> cut_cycle_indexof_F = new List<int>();

            // finding cycle
            int element_of_F =chromosomes[father][cut_point];
            int element_index_of_F = Array.IndexOf(chromosomes[father] , element_of_F);
            cut_cycle_element_of_F.Add(element_of_F);
            cut_cycle_indexof_F.Add(element_index_of_F);
            while (element_of_F != -1)
            {
                element_index_of_F = Array.IndexOf(chromosomes[mother], cut_cycle_element_of_F.Last());
                element_of_F = chromosomes[father][element_index_of_F];
                
                if (cut_cycle_element_of_F.Contains(element_of_F))
                {
                    element_of_F = -1;
                    break;
                }

                cut_cycle_element_of_F.Add(element_of_F);
                cut_cycle_indexof_F.Add(element_index_of_F);
            }
            int[] cycle_Swapping_Index = cut_cycle_indexof_F.ToArray();
            int swapping_Length = cycle_Swapping_Index.Length;

            // finding swapping part
            int[] swapping_Part_from_F = new int[swapping_Length];
            int[] swapping_Part_from_M = new int[swapping_Length]; ;
            int s_index = 0;
            foreach (int id in cycle_Swapping_Index)
            {
                swapping_Part_from_F[s_index] = chromosomes[father][id];
                swapping_Part_from_M[s_index] = chromosomes[mother][id];
                s_index++;
            }

            // finding remaining part
            int[] remain_part_for_A = new int[number_Of_Genes - swapping_Length];
            int[] remain_part_for_B = new int[number_Of_Genes - swapping_Length];
            int r_index = 0;
            for (int i = 0; i < number_Of_Genes; i++)
            {
                if (cycle_Swapping_Index.Contains(i) == false)
                {
                    remain_part_for_A[r_index] = chromosomes[mother][i];
                    remain_part_for_B[r_index] = chromosomes[father][i];
                    r_index++;
                }
            }

            // fill in child
            r_index = 0;
            s_index = 0;
            for (int i = 0; i < number_Of_Genes; i++)
            {
                if (cycle_Swapping_Index.Contains(i) == true)
                {
                    // swapping part
                    chromosomes[child_a][i] = swapping_Part_from_F[s_index];
                    chromosomes[child_b][i] = swapping_Part_from_M[s_index];
                    s_index++;
                }
                else
                {
                    // remaining part
                    chromosomes[child_a][i] = remain_part_for_A[r_index];
                    chromosomes[child_b][i] = remain_part_for_B[r_index];
                    r_index++;
                }
            }

            #region Cycle crossover

            #endregion
        }
        #endregion

        #region Mutation Methods
        private void Inversion_Mutation(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            int[] two_points = Shuffle_A_Array(number_Of_Genes, 2);
            Array.Sort(two_points);
            int p1 = two_points[0];
            int p2 = two_points[1];
            int inversed_Length = (p2 - p1);

            // find inverse part
            int[] inversed_Part = new int[inversed_Length];
            for (int i = 0; i < inversed_Length; i++)
            {
                inversed_Part[i] = chromosomes[before_mutation][p2 - i - 1];
            }
            //inversed_Part.Reverse();

            // fiil child
            int r_index = 0;
            for (int i = 0; i < number_Of_Genes; i++)
            {
                if (i >= p1 && i < p2)
                {
                    // mutate this part
                    chromosomes[after_mutation][i] = inversed_Part[r_index];
                    r_index++;
                }
                else
                {
                    chromosomes[after_mutation][i] = chromosomes[before_mutation][i];
                }

            }

        }
        private void Insertion_Mutation(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            int[] two_Points = Shuffle_A_Array(number_Of_Genes, 2);
            int mutation_Point = two_Points[0];
            int insertion_Point = two_Points[1];

            // copy
            for (int i = 0; i < number_Of_Genes; i++)
                chromosomes[after_mutation][i] = chromosomes[before_mutation][i];

            // insert
            (chromosomes[after_mutation][mutation_Point], chromosomes[after_mutation][insertion_Point])
                = (chromosomes[before_mutation][insertion_Point], chromosomes[before_mutation][mutation_Point]);

        }
        private void Displacement_Mutation(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            int[] two_points = Shuffle_A_Array(number_Of_Genes, 2);
            Array.Sort(two_points);
            int p1 = two_points[0];
            int p2 = two_points[1];
            int displacement_Length = (p2 - p1);

            // find displacement Part 
            int[] displacement_Part = new int[displacement_Length];
            for (int i = 0; i < displacement_Length; i++)
            {
                displacement_Part[i] = chromosomes[before_mutation][p1+i];
            }

            // find remaining part
            int[] remaining_Part = new int[number_Of_Genes - displacement_Length];
            int r_index = 0;
            for (int i = 0; i < number_Of_Genes; i++)
            {
                if (displacement_Part.Contains(chromosomes[before_mutation][i]) == false)
                {
                    remaining_Part[r_index] = chromosomes[before_mutation][i];
                    r_index++;
                }
            }

            // find insertion point
            int insert_Point = rnd.Next(0, (number_Of_Genes - displacement_Length));



            // fill in child
            int d_index = 0;
            r_index = 0;
            for (int i = 0; i < number_Of_Genes; i++)
            {
                if (i == insert_Point)
                {
                    // insert displacement part here
                    for (int j = i; j < i + displacement_Length; j++)
                    {
                        chromosomes[after_mutation][j] = displacement_Part[d_index];
                        d_index++;
                    }
                    i = i + displacement_Length - 1;
                }
                else
                {
                    // fill remaining part
                    chromosomes[after_mutation][i] = remaining_Part[r_index];
                    r_index++;
                }

            }
        }
        private void Reciprocal_Exchange_Mutation(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            int[] two_points = Shuffle_A_Array(number_Of_Genes, 2);
            Array.Sort(two_points);
            int p1 = two_points[0];
            int p2 = two_points[1];

            // fill in child
            for (int n = 0; n < number_Of_Genes; n++)
            {
                if (n == p1)
                {
                    // mutation
                    chromosomes[after_mutation][n] = chromosomes[before_mutation][p2];
                }
                else if (n == p2)
                {
                    // mutation
                    chromosomes[after_mutation][n] = chromosomes[before_mutation][p1];
                }
                else
                {
                    chromosomes[after_mutation][n] = chromosomes[before_mutation][n];
                }               
            }
        }
        private void Heuristic_Mutation(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {

        }
        #endregion crossover & mutation override

        public override void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            switch (Crossover_Type)
            {
                case Permutation_Crossover_Type.Parial_Mapped_X:
                    Parial_Mapped_Crossover(father, mother, child_a, child_b);
                    break;
                case Permutation_Crossover_Type.Order_X:
                    Order_Crossover(father, mother, child_a, child_b);
                    break;
                case Permutation_Crossover_Type.Postition_Base_X:
                    Postition_Base_Crossover(father, mother, child_a, child_b);
                    break;
                case Permutation_Crossover_Type.Order_Based_X:
                    Order_Based_Crossover( father,  mother,  child_a,  child_b);
                    break;
                case Permutation_Crossover_Type.Cycle_X:
                    Cycle_Crossover(father, mother, child_a, child_b);
                    break;
                case Permutation_Crossover_Type.Subtour_Exchange:
                    break;
                default:
                    break;
            }
            objective_Value[child_a] = objective_Function(chromosomes[child_a], false);
            objective_Value[child_b] = objective_Function(chromosomes[child_b], false);
        }
        
        public override void Generate_Mutated_Chromosomes(int before_mutation, int after_mutation, bool[] mutated_Flag)
        {
            switch (Permu_Mutation_Type)
            {
                case Permutation_Mutation_Type.Inversion:
                    Inversion_Mutation(before_mutation, after_mutation, mutated_Flag);
                    break;
                case Permutation_Mutation_Type.Insertion:
                    Insertion_Mutation(before_mutation, after_mutation, mutated_Flag);
                    break;
                case Permutation_Mutation_Type.Displacement:
                    Displacement_Mutation(before_mutation, after_mutation, mutated_Flag);
                    break;
                case Permutation_Mutation_Type.Reciprocal_Exchange:
                    Reciprocal_Exchange_Mutation(before_mutation, after_mutation, mutated_Flag);
                    break;
                case Permutation_Mutation_Type.Heuristic:
                    Heuristic_Mutation(before_mutation, after_mutation, mutated_Flag);
                    break;
                default:
                    break;
            }
            objective_Value[after_mutation] = objective_Function(chromosomes[after_mutation], false);
        }
        #endregion
    }
}
