using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class ValueCut_Operator : Unary_Opertor
    {
        private double cut_Value = 0.5;
        public ValueCut_Operator()
        {
            Name = "Value Cut";
        }

        public double Cut_Value 
        {   
            get => cut_Value;
            set 
            {
                if (value>=0 && value<=1)
                {
                    cut_Value = value;
                    Send_Parameter_Changed_Event();
                }

            }
        }

        public override double Calculate_Value(double x)
        {
            if (x>cut_Value)
                return cut_Value;
            else
                return x;
        }
    }
}