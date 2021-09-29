using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class B_Graph
    {
        Series B_series = new Series();
        public B_Graph(double a, double b, double c, double resolution)
        {
            B_series.ChartType = SeriesChartType.Line;
            B_series.Color = Color.Blue;
            B_series.BorderWidth = 2;
            B_series.Name = "B-series";

            double Front_point = c;
            do
            {
                Front_point--;
            } while (Distribution_Function(Front_point, a, b,c) >= 0.01);

            double Back_point = c;
            do
            {
                Back_point++;
            } while (Distribution_Function(Back_point, a, b, c) >= 0.01);

            for (double i = 0; i < resolution+1; i++)
            {
                double x = Front_point + i * ((Back_point-Front_point) / resolution);
                double p = Distribution_Function(x, a, b,c);
                B_series.Points.AddXY(x, p);
            }
        }

        public double Distribution_Function(double x, double a, double b, double c)
        {
            double p;
            p = 1.0/(1+Math.Pow(Math.Abs((x-c)/a),2.0*b));
            return p;
        }
        public Series Plot_Graph()
        {
            return B_series;
        }
    }
}
