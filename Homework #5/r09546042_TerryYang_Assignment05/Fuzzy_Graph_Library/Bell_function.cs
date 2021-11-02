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
    public class Bell_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Variation", "Flatness", "Center", "resolution" };
        public double[] parameter_Suggestion = new double[] { 2,1, 0, 100 };
        double[] parameters;

        double variation;
        double flatness;
        double center;
        #region Parameters
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
        [Category("Parameters"), Description("Variance of the function")]
        public double Variation
        {
            get => variation;
            set
            {
                if (value > 0)
                {
                    variation = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Flatness of the function")]
        public double Flatness
        {
            get => flatness;
            set
            {
                if (value > 0)
                {
                    flatness = value;
                }
                Generate_Series();
                Parameter_Change();
            }
        }
        #endregion Parameters
        public Bell_function(Fuzzy_display_area FDA) : base(FDA)
        {
            variation = 2 + rnd.Next(0, 5); 
            flatness = 1 + rnd.Next(0, 5); 
            center = 0 + rnd.Next(-2, 2); 
            //fuzzy_series.Color = Color.Blue;
            fuzzy_series.Name = "Bell_" + String.Format("{0:00}", count_Index++);
            //fuzzy_series.Name = $"Bell_Series_{count_Index++}";
            Color = fuzzy_series.Color;
            this.Name = fuzzy_series.Name;
            Generate_Series();
        }       
        public override double Get_Function_Value(double x)
        {
            double p;
            p = 1.0 / (1 + Math.Pow(Math.Abs((x - center) / variation), 2.0 * flatness));
            return p;
        }

        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
