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

        double left =-5;
        double center = 0;
        double right = 5;

        #region Parameters
        [Category("Parameters")]
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
        [Category("Parameters")]
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
        [Category("Parameters")]
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
            fuzzy_series.Name = "Triangular_Series_"+String.Format("{0:00}", count_Index++) ;
            Series_color = fuzzy_series.Color;

            this.Name = fuzzy_series.Name;

            Generate_Series();
        }

        public void Generate_Series()
        {
            fuzzy_series.Points.Clear();
            fuzzy_series.Points.AddXY(left, 0);
            fuzzy_series.Points.AddXY(center, 1);
            fuzzy_series.Points.AddXY(right, 0);
        }
        public double Get_Function_Value(double x)
        {
            double p;

            if (center <= x && x <= right)
            {
                p = Math.Abs(x - right) / Math.Abs(center - right);
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
