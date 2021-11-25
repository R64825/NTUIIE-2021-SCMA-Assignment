using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerryYang_GA_Library
{
    public enum Binary_Crossover_Type
    {
        One_Point_Cut, Two_Point_Cut, N_Point_Cut
    }
    public class Binary_GA: Generic_GA_Solver<byte>
    {
        #region Data Field
        int number_Of_Cuts;
        int[] cut_Points;
        Binary_Crossover_Type crossover_Type = Binary_Crossover_Type.One_Point_Cut;      
        #endregion

        #region Property
        public Binary_Crossover_Type Crossover_Type { get => crossover_Type; set => crossover_Type = value; }
        //public int Number_Of_Cuts { get => number_Of_Cuts; set => number_Of_Cuts = value; }
        #endregion





        #region Constructor
        public Binary_GA(int number_Of_Genes, GA_Optimization_Type optimization_Type, Objective_Function<byte> objective_Function, Binary_Crossover_Type crossover_Type) 
            : base(number_Of_Genes, optimization_Type, objective_Function)
        {
            this.crossover_Type = crossover_Type;
            cut_Points = new int[number_Of_Genes];
        }
        #endregion

        #region Helping Function
        private double Get_Byte_Value_as_Double(byte b)
        {
            if (b == 1)
                return 1;
            else
                return 0;                   
        }

        private bool Return_Revered_Flag(bool flag)
        {
            if (flag)
                return false;
            else
                return true;
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
                    chromosomes[row][column] = (byte)rnd.Next(2);
                }
                objective_Value[row] = objective_Function(chromosomes[row]);
            }
        }

        public override void Set_Fitness_and_Objectives(int total, double alpha)
        {
            double o_min, o_max;
            o_max = objective_Value.Max();
            o_min = objective_Value.Min();
            double beta = Math.Max(alpha*(o_max-o_min), 1e-5);

            switch (Optimization_Type)
            {
                case GA_Optimization_Type.Maximization:
                    for (int i = 0; i < total; i++)
                        fitness_Value[i] = beta +(objective_Value[i] - o_min);
                    break;
                case GA_Optimization_Type.Minimization:
                    for (int i = 0; i < total; i++)
                        fitness_Value[i] = beta + (o_max -objective_Value[i]);
                    break;
                default:
                    break;
            }
        }
        public override void Generate_Mutated_Chromosomes(int before_mutation, int after_mutation, bool [] mutated_Flag)
        {
            //int mutation_Point = rnd.Next(number_Of_Genes);
            for (int i = 0; i < number_Of_Genes; i++)
            {
                chromosomes[after_mutation][i] = chromosomes[before_mutation][i];
                if (mutated_Flag[i])
                {
                    if (Get_Byte_Value_as_Double(chromosomes[before_mutation][i]) == 1)
                        chromosomes[after_mutation][i] = 0;
                    else
                        chromosomes[after_mutation][i] = 1;
                }
            }
            // compared objectives for crossoverd child
            objective_Value[after_mutation] = objective_Function(chromosomes[after_mutation]);
        }
        public override void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            // crossover type
            switch (Crossover_Type)
            {
                case Binary_Crossover_Type.One_Point_Cut:
                    #region OnePointCut
                    // one point cut
                    cut_Points[0] = rnd.Next(number_Of_Genes);
                    for (int j = 0; j < number_Of_Genes; j++)
                    {
                        if (j < cut_Points[0])
                        {
                            chromosomes[child_a][j] = chromosomes[father][j];
                            chromosomes[child_b][j] = chromosomes[mother][j];
                        }
                        else
                        {
                            chromosomes[child_b][j] = chromosomes[father][j];
                            chromosomes[child_a][j] = chromosomes[mother][j];
                        }
                    }
                    #endregion
                    break;
                case Binary_Crossover_Type.Two_Point_Cut:
                    #region TwoPointCut
                    // two point cut
                    cut_Points[0] = rnd.Next(number_Of_Genes);
                    cut_Points[1] = rnd.Next(number_Of_Genes);
                    Array.Sort(cut_Points, 0, 2);
                    for (int j = 0; j < number_Of_Genes; j++)
                    {
                        if (cut_Points[0] <= j && j < cut_Points[1])
                        {
                            chromosomes[child_a][j] = chromosomes[father][j];
                            chromosomes[child_b][j] = chromosomes[mother][j];
                        }
                        else
                        {
                            chromosomes[child_b][j] = chromosomes[father][j];
                            chromosomes[child_a][j] = chromosomes[mother][j];
                        }
                    }
                    #endregion
                    break;
                case Binary_Crossover_Type.N_Point_Cut:
                    #region NPointCut
                    // n point cut
                    int number_Of_Cuts = rnd.Next(number_Of_Genes);
                    bool flag = false;

                    // assign n cutpoints
                    //cut_Points = new int[number_Of_Cuts];
                    cut_Points = Enumerable.Range(0, number_Of_Genes-1).OrderBy(x => rnd.Next()).Take(number_Of_Cuts).ToList().ToArray();

                    Array.Sort(cut_Points, 0, number_Of_Cuts);

                    for (int j = 0; j < number_Of_Genes; j++)
                    {
                        if (cut_Points.Contains(j))
                            flag = Return_Revered_Flag(flag);

                        if (flag)
                        {
                            chromosomes[child_a][j] = chromosomes[father][j];
                            chromosomes[child_b][j] = chromosomes[mother][j];
                        }
                        else
                        {
                            chromosomes[child_b][j] = chromosomes[father][j];
                            chromosomes[child_a][j] = chromosomes[mother][j];
                        }
                    }
                    #endregion
                    break;
                default:
                    break;
            }
            // compared objectives for crossoverd child
            objective_Value[child_a] = objective_Function(chromosomes[child_a]);
            objective_Value[child_b] = objective_Function(chromosomes[child_b]);
        }
        public override void Clear_Chromosomes_and_Objectives_Array()
        {
            for (int i = 0; i < 3*population_Size; i++)
            {
                for (int j = 0; j < number_Of_Genes; j++)
                {
                    chromosomes[i][j] = 0;
                }
                objective_Value[i] = 0;
            }
        }
        
        #endregion
    }
}
