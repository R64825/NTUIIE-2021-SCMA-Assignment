using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Tsukamoto_Fuzzy_System
    {
        Tsukamoto_If_Then_Fuzzy_Rule[] all_Rules;
        public Tsukamoto_Fuzzy_System()
        {

        }

        public void Update_Rule_Sets(List<Tsukamoto_If_Then_Fuzzy_Rule> all_Rules)
        {
            this.all_Rules = all_Rules.ToArray();
        }
    }
}