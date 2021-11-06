using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Intersection_Operator:Binary_Operaor
    {
        public Intersection_Operator()
        {
            Name = "Intersection";
        }
        public override double Calculate_Value(double x,double y)
        {
            // return Intersection operator
            if (x <= y)
                return x;
            else
                return y;
        }
    }
}