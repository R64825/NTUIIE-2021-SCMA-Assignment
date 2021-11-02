using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class BoundedProduct_Operator : Binary_Operaor
    {
        public BoundedProduct_Operator()
        {
            Name = "Bounded Product";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            double p;
            p = Math.Max(0, (x + y - 1));
            return p;
        }
    }
}