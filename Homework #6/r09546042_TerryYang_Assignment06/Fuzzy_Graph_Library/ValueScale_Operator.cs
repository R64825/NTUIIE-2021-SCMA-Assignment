using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class ValueScale_Operator : Unary_Opertor
    {
        private double scale_Value = 0.5;
        public ValueScale_Operator(double scale_Value)
        {
            this.scale_Value = scale_Value;
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
            return x*scale_Value;
        }
    }
}