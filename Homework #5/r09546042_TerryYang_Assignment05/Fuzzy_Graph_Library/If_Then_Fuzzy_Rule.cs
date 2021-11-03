using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class If_Then_Fuzzy_Rule
    {
        List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>();
        Fuzzy_functions_collections conclusion_FS;
        List<Fuzzy_functions_collections> Intersectings = new List<Fuzzy_functions_collections>();
        Unary_Operated_fuzzy_set result;
        int antecedent_Count;
        double mininum;

        //Series inferencing_Result;
        public If_Then_Fuzzy_Rule(List<Fuzzy_functions_collections> antecedent, Fuzzy_functions_collections conclusion_FS)
        {
            // antecedent = 因, conclusion_FS = 果
            this.antecedent = antecedent;
            this.conclusion_FS = conclusion_FS;

            mininum = conclusion_FS.Max_Degree;
            antecedent_Count = antecedent.Count;

            Unary_Opertor uo = new ValueCut_Operator(0.5);
            result = new Unary_Operated_fuzzy_set(uo, conclusion_FS);
        }
        public Unary_Operated_fuzzy_set Fuzzy_In_Fuzzy_Out_Inferencing(List<Fuzzy_functions_collections> conditions, bool cut_or_not)
        {
            // to return minimum degree after intersectin all conditions
            for (int i = 0; i < antecedent_Count; i++)
            {
                // intersecting  
                Intersectings.Add(  conditions[i] & antecedent[i] );
            }

            for (int i = 0; i < antecedent_Count; i++)
            {
                // find minimum degree in results
                if (Intersectings[i].Max_Degree< mininum)
                {
                    mininum = Intersectings[i].Max_Degree;
                }
            }

            // cut
            if (cut_or_not == true)
            {
                result = mininum - conclusion_FS;
            }
            else
            {
                result = mininum * conclusion_FS;
            }
            
            result.Set_Series(Color.FromArgb(128, Color.Gray), SeriesChartType.Area);
            return result;
        }
    }
}