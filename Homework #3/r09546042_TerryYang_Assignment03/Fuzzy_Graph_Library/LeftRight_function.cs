using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class LeftRight_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Alpha","Beta", "Center", "resolution" };
        public double[] parameter_Suggestion = new double[] { 10, 10,0, 100 };
        double[] parameters;

        double para_alpah = 10;
        double para_beta = 10;
        double para_c = 0;
        public LeftRight_function() : base()
        {

        }
        public LeftRight_function(Fuzzy_display_area FDA, double resolution) : base(FDA)
        {
            fuzzy_series.Color = Color.Orange;
            fuzzy_series.Name = $"LeftRight_Series_{count_Index++}";
            this.Name = fuzzy_series.Name;

            double Front_point = para_c;
            double Back_point = para_c;

            do
            {
                Front_point--;
            } while (Get_Function_Value(Front_point) >= 0.01);

            do
            {
                Back_point++;
            } while (Get_Function_Value(Back_point) >= 0.01);

            for (double i = 0; i < resolution + 1; i++)
            {
                double x = Front_point + i * ((Back_point - Front_point) / resolution);
                double p = Get_Function_Value(x);
                fuzzy_series.Points.AddXY(x, p);
            }
        }

        public double Get_Function_Value(double x)
        {
            double p;
            if (x >= para_c)
            {
                p = Math.Exp(-1.0 * Math.Pow((x - para_c) / para_beta, 3));
            }
            else
            {
                p = Math.Sqrt(Math.Max(0, 1 - Math.Pow((x - para_c) / para_alpah, 2)));
            }
            return p;
        }


        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
