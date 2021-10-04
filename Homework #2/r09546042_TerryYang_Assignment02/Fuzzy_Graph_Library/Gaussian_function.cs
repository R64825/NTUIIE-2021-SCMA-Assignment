using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Gaussian_function : Fuzzy_functions
    {
        static public string[] parameter_Names = new string[] { "Mean", "Variance", "resolution" };
        static public double[] parameter_Suggestion = new double[] { 0, 5, 100 };
        private double[] parameters;
        Series fuzzy_series = new Series();

        double Mean;
        double Variance;
        public Gaussian_function()
        {

        }
        public Gaussian_function(double Mean, double Variance, double resolution)
        {
            this.Mean = Mean;
            this.Variance = Variance;

            fuzzy_series.ChartType = SeriesChartType.Line;
            fuzzy_series.Color = Color.Red;
            fuzzy_series.BorderWidth = 2;
            fuzzy_series.Name = "Gaussian_Series";

            double Front_point = Mean;
            double Back_point = Mean;
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
            p = Math.Exp(-(Math.Pow((x - Mean), 2) / (2 * Math.Pow(Variance, 2))));
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
