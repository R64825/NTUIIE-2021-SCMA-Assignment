using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Fuzzy_functions_collections
    {
        #region Data Fields
        protected string[] parameter_Names;
        protected double[] parameter;
        private Fuzzy_display_area fda;
        protected TreeNode parent_Node;
        protected Color series_color;
        protected Series fuzzy_series;
        protected double minimum;
        protected double maximum;
        protected double resolution;
        private bool show_series = true;
        private int series_border_width = 2;
        private string name;

        [Category("Identification"),Description("Name of the function")]
        public string Name 
        { 
            get => name;
            set 
            {
                if (fuzzy_series != null)
                {
                    if (value != "")
                    {
                        name = value;
                        fuzzy_series.Name = value;
                        if (parent_Node!=null)
                        {
                            parent_Node.Text = value;
                        }

                    }
                }
            }
        }
        [Category("Series"), Description("Color of the series")]
        public Color Color 
        { 
            get => series_color;
            set
            {
                    series_color = value;
                    fuzzy_series.Color = value;
            }
        }
        [Category("Series"), Description("Border width of the series")]
        public int Border_width 
        { 
            get => series_border_width;
            set 
            {
                if (value>=0)
                {
                    series_border_width = value;
                    fuzzy_series.BorderWidth = value;
                }              
            }
        }

        [Category("Series"), Description("Show seies or not")]
        public bool Show 
        { 
            get => show_series;
            set
            {
                show_series = value;
                fuzzy_series.Enabled = value;
            } 
        }

        [Browsable(false)]
        public Fuzzy_display_area Fda { get => fda; set => fda = value; }
        

        //protected Fuzzy_display_area FDA 
        //{ get => fDA;
        //    set
        //    {
        //        if (fDA != null)
        //        {
        //            Plot_Graph();
        //            Generate_Series();
        //        }
        //        fDA = value;
        //    }
        //}

        #endregion

        #region Constructor
        public Fuzzy_functions_collections(Fuzzy_display_area FDA)
        {
            this.fda = FDA;
            fuzzy_series = new Series();
            fuzzy_series.ChartType = SeriesChartType.Line;
            fuzzy_series.BorderWidth = 2;
            maximum = FDA.Maximum;
            minimum = FDA.Minimum;
            resolution = FDA.Resolution;
            //fuzzy_series.Color = series_color;
        }

        #endregion


        #region Functions
        public Series Plot_Graph()
        {
            fuzzy_series.ChartArea = fda.Name;  
            return fuzzy_series;
        }

        public string[] Return_Parameters_Names()
        {
            return parameter_Names;
        }
        public void Set_Tree_Node(TreeNode tn)
        {
            parent_Node = tn;
        }

        protected void Parameter_Change()
        {
            if (fuzzy_series!=null)
            {
                //Plot_Graph().ChartArea = FDA.Get_Chart_Area().ToString();
                Plot_Graph();
            }
        }
        public virtual void Generate_Series()
        {
            fuzzy_series.Points.Clear();
            double Min = fda.Minimum;
            double Max = fda.Maximum;
            double Interval = (Max - Min) / resolution;
            for (double i = Min; i < Max + 1; i = i + Interval)
            {
                double p = Get_Function_Value(i);
                fuzzy_series.Points.AddXY(i, p);
            }
        }
        public virtual double Get_Function_Value(double x)
        {
            throw new Exception();
        }
        #endregion

    }
}
