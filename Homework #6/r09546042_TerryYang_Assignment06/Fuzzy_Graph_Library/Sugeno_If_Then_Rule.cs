using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Sugeno_If_Then_Fuzzy_Rule
    {
        List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>();
        int conclusion_Equation_ID;

        public static double GetOutputValue(double[] inputs, int equationID)
        {
            switch (equationID)
            {
                case 0: // Y=0.1X+6.4
                    return 0.1 * inputs[0] + 6.4;
                    break;
                case 1: // Y=0.5X+4
                    return 0.5 * inputs[0] + 4;
                    break;
                default:
                    return 0.0;
            }
        }
        public double Fuzzy_In_Crispy_Out_Inferencing(List<Fuzzy_functions_collections> conditions, bool cut_or_not)
        {
            return 0;
        }

        public double Crispy_In_Crispy_Out_Inferencing(double [] conditions, out double strength)
        {
            double weighted_Result = 0;
            strength = 0;

            double output_Value =  GetOutputValue(conditions, conclusion_Equation_ID);

            return weighted_Result;
        }
    }
}