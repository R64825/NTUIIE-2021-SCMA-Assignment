using System;
using System.Collections.Generic;
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
        protected Series fuzzy_series;
        protected Fuzzy_display_area FDA;
        protected TreeNode parent_Node;
        private string name;

        public string Name 
        { 
            get => name;
            set 
            {
                if (fuzzy_series!= null)
                {
                    name = fuzzy_series.Name;
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
        #endregion

    }
}
