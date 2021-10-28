using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Fuzzy_Graph_Library
{
    public class Z_shape_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Variation", "Flatness", "Center", "resolution" };
        public double[] parameter_Suggestion = new double[] { 2, 1, 0, 100 };
        double[] parameters;

        double l;
        double r;

        #region Parameters
        [Category("Parameters"), Description("Center of the function")]
        public double L
        {
            get => l;
            set
            {
                l = value;
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Variance of the function")]
        public double R
        {
            get => r;
            set
            {
                if (value > 0)
                {
                    r = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Flatness of the function")]

        #endregion Parameters
        public Z_shape_function(Fuzzy_display_area FDA) : base(FDA)
        {
            l = 2 + rnd.Next(-1, 5);
            r = 1 + rnd.Next(0, 5);
            //fuzzy_series.Color = Color.Black;
            fuzzy_series.Name = "Z-sharp_" + String.Format("{0:00}", count_Index++);
            Color = fuzzy_series.Color;
            this.Name = fuzzy_series.Name;
            Generate_Series();
        }

        public override double Get_Function_Value(double x)
        {
            double p = 0;
            if (x <= l)
                p = 1-0;
            else if (l < x && x <= (l + r) / 2.0)
                p = 1-(2 * Math.Pow(((x - l) / (r - l)), 2));
            else if ((l + r) / 2.0 <= x && x <= r)
                p = 1-(1 - 2 * Math.Pow(((r - x) / (r - l)), 2));
            else if (r < x)
                p = 1-1;
            return p;
        }
    }
}