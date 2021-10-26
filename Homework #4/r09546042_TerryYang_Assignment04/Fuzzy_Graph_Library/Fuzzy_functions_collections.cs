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
        public event EventHandler FFC_Parameter_Changed;
        //public event EventHandler Parameter_Changed;
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
                        Parameter_Change();
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
                Parameter_Change();
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
                    Parameter_Change();
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
                Parameter_Change();
            } 
        }

        [Browsable(false)]
        public Fuzzy_display_area Fda { get => fda; set => fda = value; }
        
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
            FDA.Parameter_Changed += FDA_Parameter_Change;           
        }

        #endregion


        #region Functions
        public Series Plot_Graph()
        {
            fuzzy_series.ChartArea = fda.Name;  
            return fuzzy_series;
        }

        protected void FDA_Parameter_Change(object sender, EventArgs e)
        {
            if (fuzzy_series.Name != "")
            {
                Generate_Series();
            }
        }


        public string[] Return_Parameters_Names()
        {
            return parameter_Names;
        }
        public void Set_Tree_Node(TreeNode tn)
        {
            parent_Node = tn;
        }

        protected virtual void Parameter_Change()
        {
            if (fuzzy_series!=null)
            {
                //Plot_Graph().ChartArea = FDA.Get_Chart_Area().ToString();
                Generate_Series();
                Plot_Graph();
            }
            if (FFC_Parameter_Changed != null)
                FFC_Parameter_Changed(this, null);
        }
        public virtual void Generate_Series()
        {
            fuzzy_series.Points.Clear();
            double Min = fda.Minimum;
            double Max = fda.Maximum;
            double resolution = fda.Resolution;
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
