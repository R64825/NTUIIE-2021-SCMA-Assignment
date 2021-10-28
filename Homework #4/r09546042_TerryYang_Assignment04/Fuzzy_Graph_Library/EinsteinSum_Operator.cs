using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class EinsteinSum_Operator : Binary_Operaor
    {
        public EinsteinSum_Operator()
        {
            Name = "Einstein Sum";
        }
        public override double Calculate_Value(double x, double y)
        {
            return (x + y) / (1.0 + x * y);
        }
    }
}