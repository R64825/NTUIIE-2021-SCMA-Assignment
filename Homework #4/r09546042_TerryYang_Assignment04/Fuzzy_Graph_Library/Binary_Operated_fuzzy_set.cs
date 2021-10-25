using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Binary_Operated_fuzzy_set : Fuzzy_functions_collections
    {
        Binary_Operaor the_Operator;
        Fuzzy_functions_collections the_Fuzzy_Set_01;
        Fuzzy_functions_collections the_Fuzzy_Set_02;
        static int count_Index = 1;
        public Binary_Operated_fuzzy_set(Binary_Operaor the_Operator, Fuzzy_functions_collections the_Fuzzy_Set_01,  Fuzzy_functions_collections the_Fuzzy_Set_02) : base(the_Fuzzy_Set_01.Fda)
        {
            this.the_Operator = the_Operator;
            this.the_Fuzzy_Set_01 = the_Fuzzy_Set_01;
            this.the_Fuzzy_Set_02 = the_Fuzzy_Set_02;
            Name = the_Operator.Name + "_" + String.Format("{0:00}", count_Index++) + $"({the_Fuzzy_Set_01.Name}&{the_Fuzzy_Set_02.Name})";
        }

        public override double Get_Function_Value(double x)
        {
            // return operator result
            double p = the_Operator.Calculate_Value(the_Fuzzy_Set_01.Get_Function_Value(x), the_Fuzzy_Set_02.Get_Function_Value(x));
            return p;
        }
    }
}