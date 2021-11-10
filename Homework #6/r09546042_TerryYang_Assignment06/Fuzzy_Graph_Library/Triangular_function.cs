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

        double left;
        double center;
        double right;

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
            left = -5 + rnd.Next(-1,1);
            center = 0 + rnd.Next(-1, 1);
            right = 5 + rnd.Next(-1, 1);

            //fuzzy_series.Color = Color.Green;
            fuzzy_series.Name = "Triangular_"+String.Format("{0:00}", count_Index++) ;
            Color = fuzzy_series.Color;
            fuzzy_series.ChartType = SeriesChartType.Line;
            this.Name = fuzzy_series.Name;

            Generate_Series();
        }

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
