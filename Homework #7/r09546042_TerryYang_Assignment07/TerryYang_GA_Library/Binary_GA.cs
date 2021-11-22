using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerryYang_GA_Library
{
    public class Binary_GA: Generic_GA_Solver<byte>
    {
        #region Data Field
        int number_Of_Cuts;
        #endregion
        #region Property
        #endregion
        public int Number_Of_Cuts { get => number_Of_Cuts; set => number_Of_Cuts = value; }

        #region Constructor
        public Binary_GA(int number_Of_Genes, Optimization_Type optimization_Type, Objective_Function<byte> objective_Function) 
            : base(number_Of_Genes, optimization_Type, objective_Function)
        {

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

        public override void Generate_Crossovered_Chromosomes(int father, int mother, int child_a, int child_b)
        {
            // one point cut
            int Cut_Point = rnd.Next(number_Of_Genes);
            for (int j = 0; j < number_Of_Genes; j++)
            {
                if (j<Cut_Point)
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
        public override void Generate_Mutated_Chromosomes(int before_mutation, int after_mutation)
        {
            int mutation_Point = rnd.Next(number_Of_Genes);
            for (int i = 0; i < number_Of_Genes; i++)
            {
                chromosomes[after_mutation][i] = chromosomes[before_mutation][i];
                if (i == mutation_Point)
                {
                    if (Get_Byte_Value_as_Double(chromosomes[before_mutation][i]) == 1)                    
                        chromosomes[after_mutation][i]=0;       
                    else
                        chromosomes[after_mutation][i]=1;
                }
            }
            
        }
        #endregion
    }
}
