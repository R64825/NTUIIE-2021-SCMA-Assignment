using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Diminish_Operator:Unary_Opertor
    {
        public Diminish_Operator()
        {
            Name = "Diminish";
        }
        public override double Calculate_Value(double x)
        {
            // return Concentration operator
            if (0 <= x && x <= 0.5)
                return 1 - 2 * (Math.Pow((1 - x), 2));
            else
                return 2 * (Math.Pow(x, 2));
        }
    }
}
