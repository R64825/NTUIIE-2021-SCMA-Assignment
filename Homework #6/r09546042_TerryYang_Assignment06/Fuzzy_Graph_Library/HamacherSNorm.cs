using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class HamacherSNorm : Binary_Operaor
    {
        public HamacherSNorm()
        {
            Name = "Hamacher SNorm";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            double p;
            p = (x + y - 2*x * y) / (1 - x * y);
            return p;
        }
    }
}