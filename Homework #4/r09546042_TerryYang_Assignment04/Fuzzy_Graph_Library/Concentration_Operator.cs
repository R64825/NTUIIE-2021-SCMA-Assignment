using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Concentration_Operator : Unary_Operaor
    {
        public Concentration_Operator()
        {
            Name = "Very";
        }
        public override double Calculate_Value(double x)
        {
            // return Concentration operator
            return x * x;
        }
    }
}