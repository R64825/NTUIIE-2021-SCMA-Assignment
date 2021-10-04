using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Sigmoidal_function : Fuzzy_functions
    {
        static public string[] parameter_Names = new string[] { "Sharpness", "Center", "resolution" };
        static public double[] parameter_Suggestion = new double[] { 0.5, 0, 100 };
        private double[] parameters;
        Series fuzzy_series = new Series();

        double para_a;
        double para_c;

        public Sigmoidal_function()
        {

        }
        public Sigmoidal_function(double para_a, double para_c, double resolution)
        {
            this.para_a = para_a;
            this.para_c = para_c;

            fuzzy_series.ChartType = SeriesChartType.Line;
            fuzzy_series.Color = Color.Magenta;
            fuzzy_series.BorderWidth = 2;
            fuzzy_series.Name = "Sigmoidal_Series";

            double Front_point = para_c;
            double Back_point = para_c;

            do
            {
                Front_point--;
            } while (Get_Function_Value(Front_point) >= 0.01);

            do
            {
                Back_point++;
            } while (Get_Function_Value(Back_point) <= 0.99);

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
            p = 1 / (1 + Math.Exp(-para_a * (x - para_c)));
            return p;
        }
        public Series Plot_Graph()
        {
            return fuzzy_series;
        }
        public string[] Return_Parameters_Names()
        {
            return parameter_Names;
        }

        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
