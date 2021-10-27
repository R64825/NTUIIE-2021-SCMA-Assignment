using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class HamacherTNorm : Binary_Operaor
    {
        public HamacherTNorm()
        {
            Name = "Hamacher TNorm";
        }
        public override double Calculate_Value(double x, double y)
        {
            // return Intersection operator
            if (x != 0 && y != 0)
            {
                double p;
                p = (x * y) / (x + y + x * y);
                return p;
            }
            else
                return 0;
        }
    }
}