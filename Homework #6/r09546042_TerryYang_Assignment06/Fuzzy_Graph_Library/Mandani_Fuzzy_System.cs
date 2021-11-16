using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Mandani_Fuzzy_System
    {
        // data members
        List<Fuzzy_functions_collections> results = new List<Fuzzy_functions_collections>();
        List<Mandani_If_Then_Fuzzy_Rule> all_Rules = new List<Mandani_If_Then_Fuzzy_Rule>();
        Fuzzy_functions_collections inference_Result_Fuzzy_Set = null;
        bool cut_Or_Not = true;
        public List<Mandani_If_Then_Fuzzy_Rule> All_Rules { get => all_Rules;  }

        private bool cut_or_not = true;

        public bool Cut_or_not { get => cut_or_not; set => cut_or_not = value; }
        public Defuzzification Defuzzy_Type { set; get; }=Defuzzification.COA;

        public Mandani_Fuzzy_System()//(List <Mandani_If_Then_Fuzzy_Rule> all_Rules)
        {
            
        }

        public void Update_Rule_Sets(List<Mandani_If_Then_Fuzzy_Rule> all_Rules)
        { 
            this.all_Rules = all_Rules; 
        }

        public Fuzzy_functions_collections Crisp_In_Fuzzy_Out_Inferencing(double[] location)
        {
            // merge all FS to get final inference_Result_Fuzzy_Set
            results.Clear();
            for (int r = 0; r < all_Rules.Count; r++)
            {
                results.Add(all_Rules[r].Get_Inferenced_Fuzzy_Set(location, cut_Or_Not));
            }

            // merge all inferenced fuzzy set
            for (int i = 0; i < all_Rules.Count; i++)
            {
                if (i == 0)
                    inference_Result_Fuzzy_Set = results[0];
                inference_Result_Fuzzy_Set = inference_Result_Fuzzy_Set | results[i];
            }
            
            return inference_Result_Fuzzy_Set;
        }

        public double Crisp_In_Crisp_Out_Inferencing(double[] location, bool cut_Or_Not)
        {
            // loop though all rules to get united output (cut or scale) fuzzy sets
            // then return defuzzy value
            this.cut_Or_Not = cut_Or_Not;
            Fuzzy_functions_collections resulted_Fuzzy_set = Crisp_In_Fuzzy_Out_Inferencing(location);
            switch (Defuzzy_Type)
            {
                case Defuzzification.COA:
                    return resulted_Fuzzy_set.COA;
                case Defuzzification.BOA:
                    return resulted_Fuzzy_set.BOA;
                case Defuzzification.MOM:
                    return resulted_Fuzzy_set.MOM;
                case Defuzzification.LOM:
                    return resulted_Fuzzy_set.LOM;
                case Defuzzification.SOM:
                    return resulted_Fuzzy_set.SOM;
                default:
                    return double.NaN;
            }
        }

        public void Save_Model(StreamWriter sw)
        {
            sw.WriteLine($"UseCut:{cut_or_not}");
            sw.WriteLine($"Defuzzification:{(int)Defuzzy_Type}");
            sw.WriteLine($"NumberOfRules:{all_Rules.Count}");

            for (int i = 0; i < all_Rules.Count; i++)
            {
                all_Rules[i].Save_Model(sw);
            }
        }

        public void Read_Model(StreamReader sr)
        {
            string str;
            str = sr.ReadLine().Trim();
            cut_or_not = bool.Parse(str.Substring(str.IndexOf(':') + 1));

            str = sr.ReadLine().Trim();
            Defuzzy_Type = (Defuzzification)(int.Parse(str.Substring(str.IndexOf(':') + 1)));

            int number_Of_Rules;
            str = sr.ReadLine().Trim();
            number_Of_Rules = int.Parse(str.Substring(str.IndexOf(':') + 1));

            for (int i = 0; i < number_Of_Rules; i++)
            {
                all_Rules[i].Read_Model(sr);
            }
        }
    }
}