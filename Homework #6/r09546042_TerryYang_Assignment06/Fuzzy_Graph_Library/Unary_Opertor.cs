using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Unary_Opertor
    {
        double[] parameters;
        public event EventHandler Parameter_Changed;
        private string name;
        public string Name
        { get => name;
            set => name = value;
        }

        protected void Send_Parameter_Changed_Event()
        {
            if (Parameter_Changed!= null)
                Parameter_Changed(this, null);          
        }
        public virtual double Calculate_Value(double x)
        {
            throw new Exception();
        }

        internal void Save_Model(StreamWriter sw)
        {
            sw.WriteLine($"OperatorName{name}");
            if (parameters != null)
            {
                sw.WriteLine($"NumberOfParmeters:{parameters.Length}");
                foreach (double p in parameters)
                {
                    sw.WriteLine($"ParameterValue:{p}");
                }
            }else sw.WriteLine($"NumberOfParmeters:0");
        }

        internal void Read_Model(StreamReader sr)
        {
            string str = sr.ReadLine().Trim();
            name = str.Substring(str.IndexOf(':') + 1);

            int number_Of_Parameters;
            str = sr.ReadLine().Trim();
            number_Of_Parameters = int.Parse(str.Substring(str.IndexOf(':') + 1));
            if (number_Of_Parameters>0)
            {
                parameters = new double[number_Of_Parameters];
                for (int i = 0; i < number_Of_Parameters; i++)
                {
                    str = sr.ReadLine().Trim();
                    parameters[i] = double.Parse(str.Substring(str.IndexOf(':') + 1));
                }
            }
        }
    }
}