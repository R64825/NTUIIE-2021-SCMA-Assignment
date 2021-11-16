using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Tsukamoto_Fuzzy_System
    {
        List<double> results = new List<double>();
        Tsukamoto_If_Then_Fuzzy_Rule[] all_Rules;

        public Tsukamoto_If_Then_Fuzzy_Rule[] All_Rules { get => all_Rules; set => all_Rules = value; }

        public Tsukamoto_Fuzzy_System()
        {

        }

        public void Update_Rule_Sets(List<Tsukamoto_If_Then_Fuzzy_Rule> all_Rules)
        {
            this.all_Rules = new Tsukamoto_If_Then_Fuzzy_Rule[all_Rules.Count];
            this.all_Rules = all_Rules.ToArray();
        }

        public double Crisp_In_Crisp_Out_Inferencing(double[] inputs)
        {
            double[] weights = new double[all_Rules.Length];
            double[] z = new double[all_Rules.Length];
            double weights_Times_z = 0;
            double weighted_Result;

            for (int r = 0; r < all_Rules.Length; r++)
            {
                weights[r] = all_Rules[r].Get_Min_Weight(inputs);
                z[r] = all_Rules[r].Get_Z(weights[r]);
            }

            for (int w = 0; w < weights.Length; w++)
            {
                weights_Times_z += weights[w] * z[w];
            }
            weighted_Result = weights_Times_z / weights.Sum();

            if (weights.Sum() == 0)
                return 0;
            else
                return weighted_Result;
        }
    }
}