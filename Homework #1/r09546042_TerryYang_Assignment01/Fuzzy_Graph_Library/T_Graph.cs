using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class T_Graph
    {
        Series T_series = new Series();
        public T_Graph(double a, double b, double c)
        {
            T_series.ChartType = SeriesChartType.Line;
            T_series.Color = Color.Green;
            T_series.BorderWidth = 2;
            T_series.Name = "T-series";

            T_series.Points.AddXY(a, 0);
            T_series.Points.AddXY(b, 1);
            T_series.Points.AddXY(c, 0);
        }

        public Series Plot_Graph()
        {
            return T_series;
        }
    }
}
