using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Negate_Operator : Unary_Opertor
    {
        public Negate_Operator()
        {
            Name = "Negate";
        }
        public override double Calculate_Value(double x)
        {
            // return negate operator
            return 1 - x;
        }
    }
}