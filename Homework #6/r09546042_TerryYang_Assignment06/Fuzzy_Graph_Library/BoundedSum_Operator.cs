using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class BoundedSum_Operator : Binary_Operaor
    {
        public BoundedSum_Operator()
        {
            Name = "Bounded Sum";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            double p = Math.Min(1, (x + y));
            return p;
        }
    }
}