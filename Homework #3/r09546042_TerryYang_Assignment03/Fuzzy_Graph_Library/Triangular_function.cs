using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Triangular_function : Fuzzy_functions
    {
        //data fields
        static public string[] parameter_Names = new string[] { "Left", "Center", "Right" };
        static public double[] parameter_Suggestion = new double[] { -5, 0, 5 };
        private double[] parameters;
        Series fuzzy_series = new Series();

        double Left;
        double Center;
        double Right;
        public Triangular_function()
        {
            //null construction function
        }
        public Triangular_function(double Left, double Center, double Right)
        {
            this.Left = Left;
            this.Center = Center;
            this.Right = Right;

            Parameters = new double[3];
            Parameters[0] = Left;
            Parameters[1] = Center;
            Parameters[2] = Right;

            fuzzy_series.ChartType = SeriesChartType.Line;
            fuzzy_series.Color = Color.Green;
            fuzzy_series.BorderWidth = 2;
            fuzzy_series.Name = "Triangular_Series";

            fuzzy_series.Points.AddXY(Left, 0);
            fuzzy_series.Points.AddXY(Center, 1);
            fuzzy_series.Points.AddXY(Right, 0);
        }

        public double[] Parameters
        { get => parameters; 
            set => parameters = value; }

        public double Get_Function_Value(double x)
        {
            double p;

            if (Center <= x && x <= Right)
            {
                p = Math.Abs(x - Right) / Math.Abs(Center - Right);
            }
            else if (Left <= x && x <= Center)
            {
                p = Math.Abs(Left - x) / Math.Abs(Left - Center);
            }
            else
            {
                p = 0;
            }
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
