using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Bell_function
    {
        Series Bell_Series = new Series();
        double Variation;
        double Flatness;
        double Center;

        public Bell_function(double Variation, double Flatness, double Center, double resolution)
        {
            this.Variation = Variation;
            this.Flatness = Flatness;
            this.Center = Center;

            Bell_Series.ChartType = SeriesChartType.Line;
            Bell_Series.Color = Color.Blue;
            Bell_Series.BorderWidth = 2;
            Bell_Series.Name = "Bell_Series";

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

            for (double i = 0; i < resolution+1; i++)
            {
                double x = Front_point + i * ((Back_point-Front_point) / resolution);
                double p = Get_Function_Value(x);
                Bell_Series.Points.AddXY(x, p);
            }
        }

        public double Get_Function_Value(double x)
        {
            double p;
            p = 1.0/(1+Math.Pow(Math.Abs((x- Center) /Variation),2.0* Flatness));
            return p;
        }
        public Series Plot_Graph()
        {
            return Bell_Series;
        }
    }
}
