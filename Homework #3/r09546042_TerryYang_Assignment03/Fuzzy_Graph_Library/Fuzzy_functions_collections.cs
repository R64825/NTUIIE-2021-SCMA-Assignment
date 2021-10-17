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
        protected Fuzzy_display_area FDA;
        protected TreeNode parent_Node;
        protected Color series_color;
        protected Series fuzzy_series;
        private int series_width=2;
        private string name;

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
        [Category("Series")]
        public Color Series_color 
        { 
            get => series_color;
            set
            {
                    series_color = value;
                    fuzzy_series.Color = value;
            }
        }
        [Category("Series")]
        public int Series_width 
        { 
            get => series_width;
            set 
            {
                if (value>=0)
                {
                    series_width = value;
                    fuzzy_series.BorderWidth = value;
                }              
            }
        }

        #endregion

        #region Constructor
        public Fuzzy_functions_collections(Fuzzy_display_area FDA)
        {
            this.FDA = FDA;
            fuzzy_series = new Series();
            fuzzy_series.ChartType = SeriesChartType.Line;
            fuzzy_series.BorderWidth = 2;
            //fuzzy_series.Color = series_color;
        }

        public Fuzzy_functions_collections()
        {
            
        }
        #endregion


        #region Functions
        public Series Plot_Graph()
        {
            fuzzy_series.ChartArea = FDA.Name;  
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

        //public void Generate_Series()
        //{
            
        //}
        #endregion

    }
}
