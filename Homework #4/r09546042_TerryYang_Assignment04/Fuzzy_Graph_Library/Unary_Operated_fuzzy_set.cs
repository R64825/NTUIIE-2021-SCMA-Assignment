using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Unary_Operated_fuzzy_set : Fuzzy_functions_collections
    {
        Unary_Operaor the_Operator;
        Fuzzy_functions_collections the_Fuzzy_Set;
        static int count_Index = 1;
        public Unary_Operated_fuzzy_set(Unary_Operaor the_Operator, Fuzzy_functions_collections the_Fuzzy_Set) : base(the_Fuzzy_Set.Fda)
        {
            this.the_Operator = the_Operator;
            this.the_Fuzzy_Set = the_Fuzzy_Set;

            Name = the_Operator.Name+"_" + String.Format("{0:00}", count_Index++)+$"({the_Fuzzy_Set.Name})";
        }

        public override double Get_Function_Value(double x)
        {
            // return operator result
            double p = the_Operator.Calculate_Value(the_Fuzzy_Set.Get_Function_Value(x));
            return p;
        }
    }
}