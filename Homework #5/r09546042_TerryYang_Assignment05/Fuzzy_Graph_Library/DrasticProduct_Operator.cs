using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class DrasticProduct_Operator : Binary_Operaor
    {
        public DrasticProduct_Operator()
        {
            Name = "Drastic Product";
        }
        public override double Calculate_Value(double x, double y)
        {
            if (x == 1)
                return y;
            else if (y == 1)
                return x;
            else
                return 0.0;
        }
    }
}