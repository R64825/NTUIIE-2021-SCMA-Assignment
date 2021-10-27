using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Extremely_Operator : Unary_Opertor
    {
        public Extremely_Operator()
        {
            Name = "Extremely";
        }
        public override double Calculate_Value(double x)
        {
            // return Concentration operator
            return Math.Pow(x,8);
        }
    }
}