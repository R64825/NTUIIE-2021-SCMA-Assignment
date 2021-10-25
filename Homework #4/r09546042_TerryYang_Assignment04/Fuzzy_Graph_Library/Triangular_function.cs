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
    public class Triangular_function : Fuzzy_functions_collections
    {
        //data fields
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Left", "Center", "Right" };
        public double[] parameter_Suggestion = new double[] { -5, 0, 5 };
        double[] parameters;

        double left =-5 + 5 * (count_Index - 1);
        double center = 0 + 5*(count_Index - 1);
        double right = 5 + 5 * (count_Index - 1);

        #region Parameters
        [Category("Parameters"), Description("Left point of the function")]
        public double Left
        {
            get => left;
            set
            {
                if (value <= center)
                {
                    left = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Center point of the function")]
        public double Center
        {
            get => center;
            set
            {
                if (value >=left && value<=right)
                {
                    center = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Right point of the function")]
        public double Right
        {
            get => right;
            set
            {
                if (value >= center)
                {
                    right = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        #endregion Parameters

        public Triangular_function(Fuzzy_display_area FDA) : base(FDA)
        {
            parameters = new double[3];
            parameters[0] = left;
            parameters[1] = center;
            parameters[2] = right;
            
            fuzzy_series.Color = Color.Green;
            fuzzy_series.Name = "Triangular_"+String.Format("{0:00}", count_Index++) ;
            Color = fuzzy_series.Color;

            this.Name = fuzzy_series.Name;

            Generate_Series();
        }

        //public void Generate_Series()
        //{
        //    double Min = FDA.Minimum;
        //    double Max = FDA.Maximum;
        //    double Interval = (Max - Min) / resolution;
        //    //fuzzy_series.Points.Clear();
        //    //fuzzy_series.Points.AddXY(FDA.Minimum, 0);
        //    //fuzzy_series.Points.AddXY(left, 0);
        //    //fuzzy_series.Points.AddXY(center, 1);
        //    //fuzzy_series.Points.AddXY(right, 0);
        //    //fuzzy_series.Points.AddXY(FDA.Maximum, 0);

        //    for (double i = Min; i < Max + 1; i = i + Interval)
        //    {
        //        double p = Get_Function_Value(i);
        //        fuzzy_series.Points.AddXY(i, p);
        //    }
        //}
        public override double Get_Function_Value(double x)
        {
            double p;

            if (center <= x && x <= right)
            {
                p = Math.Abs(x-right) / Math.Abs(center - right);
            }
            else if (left <= x && x <= center)
            {
                p = Math.Abs(left - x) / Math.Abs(left - center);
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
