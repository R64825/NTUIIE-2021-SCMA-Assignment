using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Sigmoidal_function
    {
        Series Sigmoidal_Series = new Series();
        double para_a;
        double para_c;
        public Sigmoidal_function(double para_a, double para_c, double resolution)
        {
            this.para_a = para_a;
            this.para_c = para_c;

            Sigmoidal_Series.ChartType = SeriesChartType.Line;
            Sigmoidal_Series.Color = Color.Magenta;
            Sigmoidal_Series.BorderWidth = 2;
            Sigmoidal_Series.Name = "Sigmoidal_Series";

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
                Sigmoidal_Series.Points.AddXY(x, p);
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
            return Sigmoidal_Series;
        }
    }
}
