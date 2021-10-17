using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class LeftRight_function
    {
        Series LeftRight_Series = new Series();
        double para_alpah;
        double para_beta;
        double para_c;
        public LeftRight_function(double para_alpah, double para_beta, double para_c, double resolution)
        {
            this.para_alpah = para_alpah;
            this.para_beta = para_beta;
            this.para_c = para_c;

            LeftRight_Series.ChartType = SeriesChartType.Line;
            LeftRight_Series.Color = Color.Orange;
            LeftRight_Series.BorderWidth = 2;
            LeftRight_Series.Name = "LeftRight_Series";

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
                LeftRight_Series.Points.AddXY(x, p);
            }
        }

        public double Get_Function_Value(double x)
        {
            double p;
            if (x>=para_c)
            {
                p = Math.Exp(-1.0 * Math.Pow((x - para_c) / para_beta, 3));
            }
            else
            {
                p = Math.Sqrt(Math.Max(0, 1 - Math.Pow((x - para_c) / para_alpah, 2)));
            }
            return p;
        }
        public Series Plot_Graph()
        {
            return LeftRight_Series;
        }
    }
}
