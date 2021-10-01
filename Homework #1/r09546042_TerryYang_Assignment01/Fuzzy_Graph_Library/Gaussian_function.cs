using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Gaussian_function
    {
        Series Gaussian_Series = new Series();
        double Mean;
        double Variance;

        public Gaussian_function(double Mean, double Variance, double resolution)
        {
            this.Mean = Mean;
            this.Variance = Variance;

            Gaussian_Series.ChartType = SeriesChartType.Line;
            Gaussian_Series.Color = Color.Red;
            Gaussian_Series.BorderWidth = 2;
            Gaussian_Series.Name = "G-series";

            double Front_point = Mean;
            do
            {
                Front_point--;
            } while (Get_Function_Value(Front_point) >= 0.01);

            double Back_point = Mean;
            do
            {
                Back_point++;
            } while (Get_Function_Value(Back_point) >= 0.01);

            for (double i = 0; i < resolution+1; i++)
            {
                double x = Front_point + i * ((Back_point-Front_point) / resolution);
                double p = Get_Function_Value(x);
                Gaussian_Series.Points.AddXY(x, p);
            }
        }

        public double Get_Function_Value(double x) 
        {
            double p;
            p = Math.Exp(-(Math.Pow((x-Mean),2)/(2*Math.Pow(Variance,2))));
            return p;
        }
        public Series Plot_Graph()
        {
            return Gaussian_Series;
        }


    }
}
