using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class ValueScale_Operator : Unary_Opertor
    {
        private double scale_Value = 0.5;
        public ValueScale_Operator()
        {
            Name = "Value Scale";
        }

        public double Scale_Value
        {
            get => scale_Value;
            set
            {
                if (scale_Value >0)
                {
                    scale_Value = value;
                    Send_Parameter_Changed_Event();
                }
            }
        }

        public override double Calculate_Value(double x)
        {
            return Math.Pow(x,1.0/scale_Value);
        }
    }
}