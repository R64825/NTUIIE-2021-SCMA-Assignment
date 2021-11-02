using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class If_Then_Fuzzy_Rule
    {
        List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>();
        Fuzzy_functions_collections conclusion_FS;

        public If_Then_Fuzzy_Rule(List<Fuzzy_functions_collections> antecedent, Fuzzy_functions_collections conclusion_FS)
        {
            this.antecedent = antecedent;
            this.conclusion_FS = conclusion_FS;
        }
        public Fuzzy_functions_collections Fuzzy_In_Fuzzy_Out_Inferencing(List<Fuzzy_functions_collections> condition)
        {
            Fuzzy_functions_collections result;
            int antecedent_Count = antecedent.Count;
            return null;
        }
    }
}