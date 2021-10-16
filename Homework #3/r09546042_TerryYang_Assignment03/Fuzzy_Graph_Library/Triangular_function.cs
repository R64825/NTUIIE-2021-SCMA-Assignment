using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Triangular_function : Fuzzy_functions_collections
    {
        //data fields
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Left", "Center", "Right" };
        public double[] parameter_Suggestion = new double[] { -5, 0, 5 };
        double[] parameters;

        double Left =-5;
        double Center = 0;
        double Right = 5;

        public Triangular_function(Fuzzy_display_area FDA) : base(FDA)
        {
            Parameters = new double[3];
            Parameters[0] = Left;
            Parameters[1] = Center;
            Parameters[2] = Right;

            fuzzy_series.Color = Color.Green;
            fuzzy_series.Name = $"Triangular_Series_{count_Index++}";

            this.Name = fuzzy_series.Name;

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
