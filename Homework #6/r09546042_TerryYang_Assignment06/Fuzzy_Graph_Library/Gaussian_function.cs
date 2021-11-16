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
    public class Gaussian_function : Fuzzy_functions_collections
    {
        static int count_Index = 1;
        public string[] parameter_Names = new string[] { "Mean", "Variance", "resolution" };
        public double[] parameter_Suggestion = new double[] { 0, 5, 100 };
        public double[] parameters;
        double mean;
        double variance;

        #region Parameters
        [Category("Parameters"), Description("Center of the function")]
        public double Mean 
        { 
            get => mean;
            set 
            {
                mean = value;
                Generate_Series();
                Parameter_Change();
            }
        }
        [Category("Parameters"), Description("Variance of the function")]
        public double Variance 
        { 
            get => variance;
            set
            {
                if (value>0)
                {
                    variance = value;
                }
                Generate_Series();
                Parameter_Change();
            } 
        }
        #endregion Parameters

        public Gaussian_function(Fuzzy_display_area FDA) : base(FDA)
        {
            parameters = new double[2];
            parameters[0] = 0;
            parameters[1] = 5;
            mean = Random_Value(5);
            variance = Random_Value(2);
            //fuzzy_series.Color = Color.Red;
            fuzzy_series.Name = "Gaussian_" + String.Format("{0:00}", count_Index++);
            Color = fuzzy_series.Color;

            this.Name = fuzzy_series.Name;

            Generate_Series();
        }

        //public void Generate_Series(double resolution) 
        //{
        //    fuzzy_series.Points.Clear();
        //    double Min = FDA.Minimum;
        //    double Max = FDA.Maximum;
        //    double Interval = (Max - Min) / resolution;
        //    for (double i = Min; i < Max + 1; i=i+Interval)
        //    {
        //        double p = Get_Function_Value(i);
        //        fuzzy_series.Points.AddXY(i, p);
        //    }
        //}

        public override double Get_Function_Value(double x)
        {
            double p;
            p = Math.Exp(-(Math.Pow((x - mean), 2) / (2 * Math.Pow(variance, 2))));
            return p;
        }

        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
