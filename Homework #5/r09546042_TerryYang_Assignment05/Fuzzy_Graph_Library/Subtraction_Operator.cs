using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Subtraction_Operator : Binary_Operaor
    {
        public Subtraction_Operator()
        {
            Name = "Subtraction";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            if (x <= y)
                return y-x;
            else
                return x-y;
        }
    }
}