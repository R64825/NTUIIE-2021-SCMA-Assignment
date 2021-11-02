using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Union_Operator : Binary_Operaor
    {
        public Union_Operator()
        {
            Name = "Union";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            if (x <= y)
                return y;
            else
                return x;
        }
    }
}