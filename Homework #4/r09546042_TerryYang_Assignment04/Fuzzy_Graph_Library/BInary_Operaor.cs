using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Binary_Operaor
    {
        double[] parameters;
        public event EventHandler Parameter_Changed;
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
        protected void Send_Parameter_Changed_Event()
        {
            if (Parameter_Changed != null)
                Parameter_Changed(this, null);

        }
        public virtual double Calculate_Value(double x, double y)
        {
            throw new Exception();
        }
    }
}