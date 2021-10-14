using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Fuzzy_functions
    {
        static public string[] parameter_Names;
        private double[] parameters;
        Series fuzzy_series;

        public Fuzzy_functions()
        {

        }

        public Series Plot_Graph()
        {
            return fuzzy_series;
        }

        public string[] Return_Parameters_Names()
        {
            return parameter_Names;
        }
    }
}
