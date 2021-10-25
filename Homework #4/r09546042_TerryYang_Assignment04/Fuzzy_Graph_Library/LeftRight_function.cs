using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class LeftRight_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Alpha","Beta", "Center", "resolution" };
        public double[] parameter_Suggestion = new double[] { 10, 10,0, 100 };

        double alpha = 10;
        double beta = 10;
        double center = 0 + 5 * (count_Index - 1);

        #region Parameters
        [Category("Parameters"), Description("Left part of the function")]
        public double Alpha
        {
            get => alpha;
            set
            {
                alpha = value;
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Right part of the function")]
        public double Beta
        {
            get => beta;
            set
            {
                if (value >= 0)
                {
                    beta = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Center of the function")]
        public double Center
        {
            get => center;
            set
            {
                center = value;
                Generate_Series();
                Parameter_Change();
            }
        }
        #endregion Parameters
        public LeftRight_function(Fuzzy_display_area FDA) : base(FDA)
        {
            fuzzy_series.Color = Color.Orange;
            //fuzzy_series.Name = $"LeftRight_Series_{count_Index++}";
            fuzzy_series.Name = "LeftRight_" + String.Format("{0:00}", count_Index++);
            Color = fuzzy_series.Color;

            this.Name = fuzzy_series.Name;

            Generate_Series();
        }

        //public void Generate_Series(double resolution)
        //{
        //    // generate points to series
        //    fuzzy_series.Points.Clear();
        //    double Front_point = center;
        //    double Back_point = center;

        //    do
        //    {
        //        Front_point--;
        //    } while (Get_Function_Value(Front_point) >= 0.01);

        //    do
        //    {
        //        Back_point++;
        //    } while (Get_Function_Value(Back_point) >= 0.01);

        //    for (double i = 0; i < resolution + 1; i++)
        //    {
        //        double x = Front_point + i * ((Back_point - Front_point) / resolution);
        //        double p = Get_Function_Value(x);
        //        fuzzy_series.Points.AddXY(x, p);
        //    }
        //}
        public override double Get_Function_Value(double x)
        {
            double p;
            if (x >= center)
            {
                p = Math.Exp(-1.0 * Math.Pow((x - center) / beta, 3));
            }
            else
            {
                p = Math.Sqrt(Math.Max(0, 1 - Math.Pow((x - center) / alpha, 2)));
            }
            return p;
        }


        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
