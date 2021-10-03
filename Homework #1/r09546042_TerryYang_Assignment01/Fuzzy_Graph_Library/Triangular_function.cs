using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Triangular_function
    {
        Series Triangular_Series = new Series();
        double Left;
        double Peak;
        double Right;

        public Triangular_function(double Left, double Peak, double Right)
        {
            this.Left = Left;
            this.Peak = Peak;
            this.Right = Right;

            Triangular_Series.ChartType = SeriesChartType.Line;
            Triangular_Series.Color = Color.Green;
            Triangular_Series.BorderWidth = 2;
            Triangular_Series.Name = "Triangular_Series";

            //double Front_point = Left;
            //double Back_point = Right;
            //double res = 1000;

            //for (int i = 0; i < res+1; i++)
            //{
            //    double x = Left + Math.Abs(Right - Left)*i / res;
            //    Triangular_Series.Points.AddXY(x, Get_Function_Value(x));
            //}
            Triangular_Series.Points.AddXY(Left, 0);
            Triangular_Series.Points.AddXY(Peak, 1);
            Triangular_Series.Points.AddXY(Right, 0);
        }
        public double Get_Function_Value(double x)
        {
            double p;

            if (Peak <= x && x <= Right)
            {
                p = Math.Abs(x - Right) / Math.Abs(Peak - Right);
            }
            else if (Left <= x && x <= Peak)
            {
                p = Math.Abs(Left- x) / Math.Abs(Left - Peak);
            }
            else
            {
                p = 0;
            }
            return p;
        }

        public Series Plot_Graph()
        {
            return Triangular_Series;
        }
    }
}
