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
    public class Sigmoidal_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;       
        public string[] parameter_Names = new string[] { "Sharpness", "Center", "resolution" };
        public double[] parameter_Suggestion = new double[] { 1, 0, 100 };

        double sharpness;
        double center;
        #region Parameters
        [Category("Parameters"), Description("Center point of the function")]
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
        [Category("Parameters"), Description("Sharpness of the function")]
        public double Sharpness
        {
            get => sharpness;
            set
            {
                sharpness = value;  
                Generate_Series();
                Parameter_Change();
            }
        }
        #endregion Parameters

        public Sigmoidal_function(Fuzzy_display_area FDA) : base(FDA)
        {
             sharpness = Random_Value(3);
            center = Random_Value(5);
            //fuzzy_series.Color = Color.Magenta;
            fuzzy_series.Name = "Sigmoidal_" + String.Format("{0:00}", count_Index++);
            Color = fuzzy_series.Color;

            this.Name = fuzzy_series.Name;
            Generate_Series();
        }

        public override bool Is_Monotonic => true;
        public override double Get_Function_Value(double x)
        {
            double p;
            p = 1 / (1 + Math.Exp(-sharpness * (x - center)));
            return p;
        }

        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
