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
        double[] parameters;

        double sharpness = 1;
        double center = 0;
        double resolution;
        #region Parameters
        [Category("Parameters")]
        public double Center
        {
            get => center;
            set
            {
                center = value;
                Generate_Series(resolution);
                Parameter_Change();
            }
        }
        [Category("Parameters")]
        public double Sharpness
        {
            get => sharpness;
            set
            {
                //if (value > 0)
                //{
                //    sharpness = value;
                //}
                sharpness = value;
                Generate_Series(resolution);
                Parameter_Change();
            }
        }
        #endregion Parameters

        public Sigmoidal_function(Fuzzy_display_area FDA, double resolution) : base(FDA)
        {
            //this.para_a = para_a;
            //this.para_c = para_c;

            fuzzy_series.Color = Color.Magenta;
            //fuzzy_series.Name = $"Sigmoidal_Series_{count_Index++}";
            fuzzy_series.Name = "Sigmoidal_Series_" + String.Format("{0:00}", count_Index++);
            Series_color = fuzzy_series.Color;

            this.Name = fuzzy_series.Name;
            this.resolution = resolution;

            Generate_Series(resolution);
        }
        public void Generate_Series(double resolution)
        {
            // generate points to series
            fuzzy_series.Points.Clear();

            double Front_point = center;
            double Back_point = center;

            //do
            //{
            //    Front_point--;
            //} while (Get_Function_Value(Front_point) >= 0.01 );

            //do
            //{
            //    Back_point++;
            //} while (Get_Function_Value(Back_point) <= 0.99);
            do
            {
                Front_point--;
            } while (Get_Function_Value(Front_point) >= 0.01 && Get_Function_Value(Front_point) <= 0.99);

            do
            {
                Back_point++;
            } while (Get_Function_Value(Back_point) >= 0.01 && Get_Function_Value(Back_point) <= 0.99);

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
            p = 1 / (1 + Math.Exp(-sharpness * (x - center)));
            return p;
        }

        public double[] Return_parameter_Suggestion()
        {
            return parameter_Suggestion;
        }
    }
}
