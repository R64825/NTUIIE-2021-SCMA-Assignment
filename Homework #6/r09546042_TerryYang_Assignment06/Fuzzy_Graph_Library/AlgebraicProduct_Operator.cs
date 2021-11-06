using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class AlgebraicProduct_Operator : Binary_Operaor
    {
        public AlgebraicProduct_Operator()
        {
            Name = "Algebraic Product";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            return x*y;
        }
    }
}