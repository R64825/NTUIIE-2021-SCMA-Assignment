using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerryYang_GA_Library
{
    public class Real_Number_Encoded_GA : Generic_GA_Solver<double>
    {
        #region Datafield
        double[] lower_Bound;
        double[] upper_Bound;

        #endregion

        #region Consturctor
        public Real_Number_Encoded_GA(int number_Of_Genes, double[] lower_Bound, double[] upper_Bound, GA_Optimization_Type optimization_Type, Objective_Function<double> objective_Function)
            : base(number_Of_Genes, optimization_Type, objective_Function)
        {
            this.lower_Bound = lower_Bound;
            this.upper_Bound = upper_Bound;
        }
        #endregion
        public override void Initialize_Population()
        {
            for (int row = 0; row < population_Size; row++)
            {
                //chromosomes[row] = new byte[number_Of_Genes];
                for (int column = 0; column < number_Of_Genes; column++)
                
                {
                    chromosomes[row][column] = lower_Bound[column] + rnd.NextDouble()*(upper_Bound[column] -lower_Bound[column]);
                }
                    
            }
        }
        #region Enum

        #endregion
    }
}
