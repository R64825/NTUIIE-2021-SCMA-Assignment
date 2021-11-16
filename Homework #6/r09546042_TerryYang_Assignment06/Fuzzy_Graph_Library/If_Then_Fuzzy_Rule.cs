using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Mandani_If_Then_Fuzzy_Rule
    {
        Fuzzy_functions_collections[] antecedent;
        List<int> antecedent_Hash_Code = new List<int>();
        int Conclusion_FS_Hash_Code;

        Fuzzy_functions_collections conclusion_FS;
        List<Fuzzy_functions_collections> Intersectings = new List<Fuzzy_functions_collections>();
        Unary_Operated_fuzzy_set result;
        int antecedent_Count;
        double mininum;

        public Fuzzy_functions_collections Conclusion_FS { get => conclusion_FS; set => conclusion_FS = value; }
        public Fuzzy_functions_collections[] Antecedent { get => antecedent; set => antecedent = value; }

        //Series inferencing_Result;
        public Mandani_If_Then_Fuzzy_Rule(List<Fuzzy_functions_collections> antecedent, Fuzzy_functions_collections conclusion_FS)
        {
            // antecedent = 因, conclusion_FS = 果
            this.antecedent = new Fuzzy_functions_collections[antecedent.Count];
            this.antecedent = antecedent.ToArray();
            this.conclusion_FS = conclusion_FS;

            mininum = conclusion_FS.Max_Degree;
            antecedent_Count = antecedent.Count;

            Unary_Opertor uo = new ValueCut_Operator(0.5);
            result = new Unary_Operated_fuzzy_set(uo, conclusion_FS);
        }
        public Unary_Operated_fuzzy_set Fuzzy_In_Fuzzy_Out_Inferencing(List<Fuzzy_functions_collections> conditions, bool cut_or_not)
        {
            // Inferencing
            // to return minimum degree after intersectin all conditions
            for (int i = 0; i < antecedent_Count; i++)
                // intersecting  
                Intersectings.Add(  conditions[i] & antecedent[i] );

            for (int i = 0; i < antecedent_Count; i++)
            {
                // find minimum degree in results
                if (Intersectings[i].Max_Degree< mininum)
                    mininum = Intersectings[i].Max_Degree;
            }

            // cut
            if (cut_or_not == true)
            {
                ValueCut_Operator c = new ValueCut_Operator(mininum);
                result = new Unary_Operated_fuzzy_set(c, conclusion_FS, true);// mininum - conclusion_FS;
            }                
            else
                result = mininum * conclusion_FS;
            
            result.Set_Series(Color.FromArgb(128, Color.Gray), SeriesChartType.Area);
            return result;
        }

        internal void Save_Model(StreamWriter sw)
        {
            sw.WriteLine($"NumberOfRules:{antecedent.Length}");
            foreach (Fuzzy_functions_collections fs in antecedent)
            {
                sw.WriteLine($"AntcedentFSCode:{fs.GetHashCode()}");
            }
            sw.WriteLine($"ConclusionFSCode{conclusion_FS.GetHashCode()}"); 
        }
        internal void Read_Model(StreamReader sr)
        {
            int number_Of_Antecedent;
            string str = sr.ReadLine().Trim();
            number_Of_Antecedent = int.Parse(str.Substring(str.IndexOf(':') + 1));

            antecedent_Hash_Code.Clear();
            for (int i = 0; i < number_Of_Antecedent; i++)
            {
                str = sr.ReadLine().Trim();
                antecedent_Hash_Code.Add(int.Parse(str.Substring(str.IndexOf(':') + 1)));
            }
            str = sr.ReadLine().Trim();
            Conclusion_FS_Hash_Code = int.Parse(str.Substring(str.IndexOf(':') + 1));

        }
        public Fuzzy_functions_collections Cripy_In_Fuzzy_Out_Inferencing(double location, bool cut_or_not)
        {
            // one antecedent
            // Defuzzification
            Fuzzy_functions_collections result = null ;
            double cut_Value;
            double min_Of_Antecedent = double.MaxValue;
            for (int i = 0; i < antecedent.Length; i++)
            {
                if (min_Of_Antecedent>antecedent[i].Get_Function_Value(location))
                {
                    min_Of_Antecedent = antecedent[i].Get_Function_Value(location);
                }
            }
            cut_Value = min_Of_Antecedent;
            ValueCut_Operator c = new ValueCut_Operator(cut_Value);
            result = new Unary_Operated_fuzzy_set(c, conclusion_FS);
            return result;
        }
        public double Get_Min_Degree(double[] inputs)
        {
            // return min degree in all antecedent
            double min_Of_Antecedent = double.MaxValue;
            for (int a = 0; a < antecedent.Length; a++)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (antecedent[a].Get_Function_Value(inputs[i]) <= min_Of_Antecedent)
                        min_Of_Antecedent = antecedent[a].Get_Function_Value(inputs[i]);
                }
            }
            return min_Of_Antecedent;
        }

        public Fuzzy_functions_collections Get_Inferenced_Fuzzy_Set(double[] inputs , bool cut_or_not)
        {
            // return inferenced fuzzy set
            Fuzzy_functions_collections result = null;
            double min_Of_Antecedent = Get_Min_Degree(inputs);

            ValueCut_Operator c = new ValueCut_Operator(min_Of_Antecedent);
            result = new Unary_Operated_fuzzy_set(c, conclusion_FS,true);
            return result;
        }

    }
}