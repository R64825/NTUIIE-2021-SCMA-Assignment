using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Sugeon_Fuzzy_System
    {
        public bool Output_Averaged { get; set; } = true;
        public int Equation_ID { get; set; } = 0;
        public Sugeno_If_Then_Fuzzy_Rule[] All_Rules { get => all_Rules; set => all_Rules = value; }

        List<double> results = new List<double>();
        Sugeno_If_Then_Fuzzy_Rule[] all_Rules;

        public Sugeon_Fuzzy_System()
        {

        }
        public void Update_Rule_Sets(List<Sugeno_If_Then_Fuzzy_Rule> all_Rules)
        {
            this.all_Rules = new Sugeno_If_Then_Fuzzy_Rule[all_Rules.Count];
            this.all_Rules = all_Rules.ToArray();
        }
        public double Crisp_In_Crisp_Out_Inferencing(double[] inputs)
        {
            double[] weights = new double[all_Rules.Length];
            double[] y = new double[all_Rules.Length];
            double weights_Times_y = 0;
            double weighted_Result;

            for (int r = 0; r < all_Rules.Length; r++)
            {
                weights[r] = all_Rules[r].Get_Min_Weight(inputs);
                y[r] = all_Rules[r].Get_Y(inputs);
            }

            for (int w = 0; w < weights.Length; w++)
            {
                weights_Times_y += weights[w] * y[w];
            }
            weighted_Result = weights_Times_y / weights.Sum();

            return weighted_Result;

        }
    }
}