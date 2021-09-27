using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class G_Graph
    {
        Series G_series = new Series();
        public G_Graph(double mean, double variance, double resolution)
        {
            G_series.ChartType = SeriesChartType.Line;
            G_series.Color = Color.Red;
            G_series.BorderWidth = 2;
            G_series.Name = "G-series";

            double Front_point = mean;
            do
            {
                Front_point--;
            } while (Normal_Function(Front_point, mean,variance) >= 0.01);

            double Back_point = mean;
            do
            {
                Back_point++;
            } while (Normal_Function(Back_point, mean, variance) >= 0.01);

            for (double i = 0; i < resolution+1; i++)
            {
                double x = Front_point + i * ((Back_point-Front_point) / resolution);
                double p = Normal_Function(x, mean, variance);
                G_series.Points.AddXY(x, p);
            }
        }

        public double Normal_Function(double x, double mean, double variance) 
        {
            double p;
            p = Math.Exp(-(Math.Pow((x-mean),2)/(2*Math.Pow(variance,2))));
            return p;
        }
        public Series Plot_Graph()
        {
            return G_series;
        }
    }
}
