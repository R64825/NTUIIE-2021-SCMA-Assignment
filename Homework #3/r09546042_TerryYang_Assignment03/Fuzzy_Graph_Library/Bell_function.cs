using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Bell_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Variation", "Flatness", "Center", "resolution" };
        public double[] parameter_Suggestion = new double[] { 2,1, 0, 100 };
        double[] parameters;

        double Variation = 2;
        double Flatness = 1;
        double Center = 0;

        public Bell_function() : base()
        {

        }
        public Bell_function(Fuzzy_display_area FDA, double resolution) : base(FDA)
        {

            fuzzy_series.Color = Color.Blue;
            fuzzy_series.Name = $"Bell_Series_{count_Index++}";
            this.Name = fuzzy_series.Name;

            double Front_point = Center;
            double Back_point = Center;

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
            p = 1.0 / (1 + Math.Pow(Math.Abs((x - Center) / Variation), 2.0 * Flatness));
            return p;
        }

        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
