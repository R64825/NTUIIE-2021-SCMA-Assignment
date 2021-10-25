using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Binary_Operaor
    {
        double[] parameters;
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public virtual double Calculate_Value(double x, double y)
        {
            throw new Exception();
        }
    }
}