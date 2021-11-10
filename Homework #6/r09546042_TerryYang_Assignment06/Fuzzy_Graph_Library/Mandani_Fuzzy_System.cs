using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Mandani_Fuzzy_System
    {
        // data members
        Mandani_If_Then_Fuzzy_Rule[] all_Rules;
        private bool cut_or_not = true;

        public bool Cut_or_not { get => cut_or_not; set => cut_or_not = value; }
        public Defuzzification Defuzzy_Type { set; get; }=Defuzzification.COA;

        public Mandani_Fuzzy_System()//(List <Mandani_If_Then_Fuzzy_Rule> all_Rules)
        {
            
        }

        public void Update_Rule_Sets(List<Mandani_If_Then_Fuzzy_Rule> all_Rules)
        { 
            this.all_Rules = all_Rules.ToArray(); 
        }
        public Fuzzy_functions_collections Crisp_In_Fuzzy_Out_Ingerencing(double[] conditions)
        {
            //all_Rules = new If_Then_Fuzzy_Rule[]
            for (int r = 0; r < all_Rules.Length; r++)
            {
                //xx = all_Rules[r].Cripy_In_Fuzzy_Out_Inferencing(conditions,);

            }
            return null;
        }

        public double Crisp_In_Crisp_Out_Inferencing(double[] conditions)
        {
            // loop though all rules to get united output (cut or scale) fuzzy sets
            // then return defuzzy value
            Fuzzy_functions_collections resulted_Fuzzy_set = Crisp_In_Fuzzy_Out_Ingerencing(conditions);
            switch (Defuzzy_Type)
            {
                case Defuzzification.COA:
                    return resulted_Fuzzy_set.COA;
                case Defuzzification.BOA:
                    break;
                default:
                    break;
            }
            return 0.0;
        }

        
    }
}