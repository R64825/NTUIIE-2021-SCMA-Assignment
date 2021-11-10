using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Trapzoidal_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;
        double left;
        double left_point;
        double right_point;
        double right;

        #region Parameters
        [Category("Parameters"), Description("Left point of the function")]
        public double Left
        {
            get => left;
            set
            {
                if (value <= left_point)
                {
                    left = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Center point of the function")]
        public double Left_point
        {
            get => left_point;
            set
            {
                if (value >= left && value <= right_point)
                {
                    left_point = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Center point of the function")]
        public double Right_point
        {
            get => right_point;
            set
            {
                if (value >= left_point && value <= right)
                {
                    right_point = value;
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
                if (value >= right_point)
                {
                    right = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        #endregion Parameters

        public Trapzoidal_function(Fuzzy_display_area FDA) : base(FDA)
        {
            left = -5 + rnd.Next(-1, 1);
            left_point = -1 + rnd.Next(-1, 1);
            right_point = 1 + rnd.Next(-1, 1);
            right = 5 + rnd.Next(-1, 1);

            //fuzzy_series.Color = Color.Green;
            fuzzy_series.Name = "Trapzoidal_" + String.Format("{0:00}", count_Index++);
            Color = fuzzy_series.Color;
            fuzzy_series.ChartType = SeriesChartType.Line;
            this.Name = fuzzy_series.Name;

            Generate_Series();
        }

        public override double Get_Function_Value(double x)
        {
            double p;

            if (right_point <= x && x <= right)
            {
                p = Math.Abs(x - right) / Math.Abs(right_point - right);
            }
            else if (left_point <= x && x <= right_point)
            {
                p = 1;
            }
            else if(left <= x && x <= left_point)
            {
                p = Math.Abs(x - left) / Math.Abs(left_point - left);
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
    }
}