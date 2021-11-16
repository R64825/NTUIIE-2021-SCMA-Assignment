using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        int operand_Hash_Code;
        //public virtual event EventHandler Parameter_Changed;
        //[Category("Operator")]
        [CategoryAttribute("Opertor Info")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Unary_Opertor The_Operator { get => the_Operator; set => the_Operator = value; }

        public override double Max_Degree => Calculate_Max_Degree();

        //public Unary_Operated_fuzzy_set(Unary_Opertor the_Operator)
        //{
        //    this.the_Operator = the_Operator;
        //}
        public Unary_Operated_fuzzy_set(Unary_Opertor the_Operator, Fuzzy_functions_collections the_Fuzzy_Set, bool process) : base(the_Fuzzy_Set.Fda)
        {
            this.the_Operator = the_Operator;
            this.the_Fuzzy_Set = the_Fuzzy_Set;
            //the_Fuzzy_Set.Show = false;
        }
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

        public override void Save_Model(StreamWriter sw)
        {
            base.Save_Model(sw);
            Type Operator_Type = the_Operator.GetType();

            sw.WriteLine($"OperatorTypeName:{Operator_Type.FullName}");
            the_Operator.Save_Model(sw);
            sw.WriteLine($"FSHashCode:{the_Operator.GetHashCode()}");
        }

        public override void Read_Model(StreamReader sr)
        {
            base.Read_Model(sr);
            string str;
            str = sr.ReadLine().Trim();
            string type_Name = str.Substring(str.IndexOf(':') + 1);
            Type op_Type = Type.GetType(type_Name);
            the_Operator =  Activator.CreateInstance(op_Type) as Unary_Opertor;
            the_Operator.Read_Model(sr);
            str = sr.ReadLine().Trim();
            operand_Hash_Code = int.Parse(str.Substring(str.IndexOf(':') + 1)) ;

        }

        public override void Reconnect_Fuzzy_Set_Reference(List<Fuzzy_functions_collections> existing_Fuzzy_Sets)
        {
            foreach (Fuzzy_functions_collections fs in existing_Fuzzy_Sets)
            {
                if (fs.Hash_Code_Stored == operand_Hash_Code)
                {
                    the_Fuzzy_Set = fs;
                    break;
                }
            }
            //base.Reconnect_Fuzzy_Set_Reference(existing_Fuzzy_Sets);
        }
    }
}