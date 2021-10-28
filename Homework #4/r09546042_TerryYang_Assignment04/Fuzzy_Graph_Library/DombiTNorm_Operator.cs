using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class DombiTNorm_Operator : Binary_Operaor
    {
        private double k = 1;
        public DombiTNorm_Operator()
        {
            Name = "Dombi TNorm";
        }

        public double K_value 
        { get => k;
            set 
            {
                if (k>=0)
                {
                    k = value;                  
                    Send_Parameter_Changed_Event();
                }
            }
        }

        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            double a = Math.Pow(((1 / x) - 1), k);
            double b = Math.Pow(((1 / y) - 1), k);
            double c = Math.Pow((a + b), (1 / k));
            return 1.0/(1+c);
        }
    }
}