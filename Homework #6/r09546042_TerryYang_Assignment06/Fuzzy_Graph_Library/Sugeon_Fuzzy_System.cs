using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Sugeon_Fuzzy_System
    {
        public bool Output_Averaged { get; set; } = true;
        Sugeno_If_Then_Fuzzy_Rule[] all_Rules;

        public Sugeon_Fuzzy_System()
        {

        }
        public void Update_Rule_Sets(List<Sugeno_If_Then_Fuzzy_Rule> all_Rules)
        {
            this.all_Rules = all_Rules.ToArray();
        }
    }
}