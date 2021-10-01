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
            Triangular_Series.Name = "T-series";

            Triangular_Series.Points.AddXY(Left, 0);
            Triangular_Series.Points.AddXY(Peak, 1);
            Triangular_Series.Points.AddXY(Right, 0);
        }
        public double Get_Function_Value(double x)
        {
            double p;

            if (Peak <= x && x <= Right)
            {
                p = (x - Left) / (Peak - Left);
            }
            else if (Left <= x && x <= Peak)
            {
                p = (1+Peak- x) / (Right- Peak);
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
