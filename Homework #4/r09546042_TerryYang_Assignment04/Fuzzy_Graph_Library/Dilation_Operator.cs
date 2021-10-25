using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Dilation_Operator : Unary_Operaor
    {
        public Dilation_Operator()
        {
            Name = "Less";
        }
        public override double Calculate_Value(double x)
        {
            // return Concentration operator
            return Math.Pow(x,0.5);
        }
    }
}