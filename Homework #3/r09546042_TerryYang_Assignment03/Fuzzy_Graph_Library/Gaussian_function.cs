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
        //private double[] parameters;
        double resolution;
        double mean = 0 + 5*(count_Index - 1);
        double variance = 5;

        #region Parameters
        [Category("Parameters"), Description("Center of the function")]
        public double Mean 
        { 
            get => mean;
            set 
            {
                mean = value;
                Generate_Series(resolution);
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
                Generate_Series(resolution);
                Parameter_Change();
            } 
        }
        #endregion Parameters

        public Gaussian_function(Fuzzy_display_area FDA,double resolution) : base(FDA)
        {
            parameters = new double[2];
            parameters[0] = 0;
            parameters[1] = 5;
            this.resolution = resolution;

            fuzzy_series.Color = Color.Red;
            //fuzzy_series.Name = $"Gaussian_Series_{count_Index++}";
            fuzzy_series.Name = "Gaussian_Series_" + String.Format("{0:00}", count_Index++);
            Series_color = fuzzy_series.Color;

            this.Name = fuzzy_series.Name;

            Generate_Series( resolution);
        }

        public void Generate_Series(double resolution) 
        {
            // generate points to series
            fuzzy_series.Points.Clear();

            double Front_point = mean;
            double Back_point = mean;
            do
            {
                Front_point--;
            } while (Get_Function_Value(Front_point) >= 0.01);

            do
            {
                Back_point++;
            } while (Get_Function_Value(Back_point) >= 0.01);

            for (double i = 0; i < resolution + 1; i++)
            {
                double x = Front_point + i * ((Back_point - Front_point) / resolution);
                double p = Get_Function_Value(x);
                fuzzy_series.Points.AddXY(x, p);
            }
        }

        public double Get_Function_Value(double x)
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
