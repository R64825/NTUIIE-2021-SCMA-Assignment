using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class DrasticSum_Operator : Binary_Operaor
    {
        public DrasticSum_Operator()
        {
            Name = "Drastic Sum";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            if (x == 0)
                return y;
            else if (y == 0)
                return x;
            else
                return 1.0;
        }
    }
}