using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class EinsteinProduct_Operator : Binary_Operaor
    {
        public EinsteinProduct_Operator()
        {
            Name = "Einstein Product";
        }
        public override double Calculate_Value(double x, double y)
        {
            return x*y / (2.0-((x+y-x*y)));
        }
    }
}