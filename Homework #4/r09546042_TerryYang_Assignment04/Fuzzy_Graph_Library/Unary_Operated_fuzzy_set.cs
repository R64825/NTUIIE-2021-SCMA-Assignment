using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Unary_Operated_fuzzy_set : Fuzzy_functions_collections
    {
        public Unary_Opertor the_Operator;
        Fuzzy_functions_collections the_Fuzzy_Set;
        static int count_Index = 1;
        private int the_Index;
        //public virtual event EventHandler Parameter_Changed;
        //[Category("Operator")]
        [CategoryAttribute("Opertor Info")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Unary_Opertor The_Operator { get => the_Operator; set => the_Operator = value; }

        public Unary_Operated_fuzzy_set(Unary_Opertor the_Operator, Fuzzy_functions_collections the_Fuzzy_Set) : base(the_Fuzzy_Set.Fda)
        {
            this.the_Operator = the_Operator;
            this.the_Fuzzy_Set = the_Fuzzy_Set;
            the_Fuzzy_Set.FFC_Parameter_Changed += Upper_FFC_Parameter_Change;
            the_Operator.Parameter_Changed += Upper_FFC_Parameter_Change;
            the_Index = count_Index;
            Name = the_Operator.Name+"_" + String.Format("{0:00}", count_Index++)+$"({the_Fuzzy_Set.Name})";

            //the_Fuzzy_Set.Show = false;
        }
        protected void Upper_FFC_Parameter_Change(object sender, EventArgs e)
        {
            Name = the_Operator.Name + "_" + String.Format("{0:00}", the_Index) + $"({the_Fuzzy_Set.Name})";
            if (fuzzy_series.Name != "")
                Generate_Series();
        }
        public override double Get_Function_Value(double x)
        {
            // return operator result
            double p = the_Operator.Calculate_Value(the_Fuzzy_Set.Get_Function_Value(x));
            return p;
        }
    }
}