using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Tsukamoto_If_Then_Fuzzy_Rule
    {
        Fuzzy_functions_collections[] antecedent;
        Fuzzy_functions_collections conclusion_FS;

        public Fuzzy_functions_collections[] Antecedent { get => antecedent; set => antecedent = value; }
        public Tsukamoto_If_Then_Fuzzy_Rule(List<Fuzzy_functions_collections> antecedent, Fuzzy_functions_collections conclusion_FS)
        {
            this.antecedent = new Fuzzy_functions_collections[antecedent.Count];
            this.antecedent = antecedent.ToArray();
            this.conclusion_FS = conclusion_FS;
        }

        public double Get_Min_Weight(double[] inputs)
        {
            // get min degree
            double[] weights = new double[antecedent.Length];
            for (int a = 0; a < antecedent.Length; a++)
            {
                weights[a] = antecedent[a].Get_Function_Value(inputs[a]);
            }
            return weights.Min();
        }
        public double Get_Z(double weight)
        {
            double z;
            z = conclusion_FS.Get_Function_Value(weight);
            return z;
        }
    }
}