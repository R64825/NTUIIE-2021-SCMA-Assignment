using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Diminish_Operator:Unary_Opertor
    {
        public Diminish_Operator()
        {
            Name = "Diminish";
        }
        public override double Calculate_Value(double x)
        {
            double p;
            if (0 <= x && x <= 0.5)
            {
                return Math.Pow(x*0.5,0.5);
            }
            else
            {              
                return 1-Math.Pow((1-x)/2,0.5);
            }               
        }
    }
}
