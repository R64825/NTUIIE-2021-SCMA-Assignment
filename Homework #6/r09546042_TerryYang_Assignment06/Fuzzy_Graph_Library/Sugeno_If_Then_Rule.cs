using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Sugeno_If_Then_Fuzzy_Rule
    {
        Fuzzy_functions_collections[] antecedent;
        int conclusion_Equation_ID;

        public Sugeno_If_Then_Fuzzy_Rule(List<Fuzzy_functions_collections> antecedent, int conclusion_Equation_ID)
        {
            this.antecedent = new Fuzzy_functions_collections[antecedent.Count];
            this.antecedent = antecedent.ToArray();
            this.conclusion_Equation_ID = conclusion_Equation_ID;
        }

        public Fuzzy_functions_collections[] Antecedent { get => antecedent; set => antecedent = value; }

        public static double GetOutputValue(double[] inputs, int equationID)
        {
            switch (equationID)
            {
                case 0: // Y=0.1X+6.4
                    return 0.1 * inputs[0] + 6.4;
                case 1: // Y=0.5X+4
                    return 0.5 * inputs[0] + 4;
                case 2: // Y=0.5X+4
                    return inputs[0] - 2;
                case 3: // Y=0.5X+4
                    return -inputs[0] + inputs[1] + 1;
                case 4: // Y=0.5X+4
                    return -inputs[1] + 3;
                case 5: // Y=0.5X+4
                    return -inputs[0] + 3;
                case 6: // Y=0.5X+4
                    return inputs[0] + inputs[1] + 2;
                default:
                    return double.NaN;
            }
        }
        public double Get_Min_Weight(double[] inputs)// inputs = (x,z)
        {
            // to get min FS degree
            double[] weights = new double[antecedent.Length];
            for (int a = 0; a < antecedent.Length; a++)
            {
                weights[a] = antecedent[a].Get_Function_Value(inputs[a]);
            }
            return weights.Min();
        }
        public double Get_Y(double[] inputs)
        {
            double y;
            y = GetOutputValue(inputs, conclusion_Equation_ID);
            return y;
        }
        
        
        
    }
}