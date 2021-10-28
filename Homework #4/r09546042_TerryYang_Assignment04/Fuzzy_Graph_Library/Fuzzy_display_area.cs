﻿using System;
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
    public class Fuzzy_display_area
    {
        static int current_Index = 1;
        string name = "Area_";
        int resolution = 100;
        double minimum = -10;
        double maximum = 10;
        TreeNode parent_Node;
        ChartArea this_Chart_Area;
        Legend this_Legend;
        public virtual event EventHandler Parameter_Changed;
        public string Name
        {
            get 
            {
                return this_Chart_Area.AxisX.Title;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                    this_Chart_Area.Name = value;
                    this_Chart_Area.AxisX.Title = value;
                    parent_Node.Text = value;
                    if (Parameter_Changed != null)
                        Parameter_Changed(this, null);
                }
                    
            }
        }
        [Category("Parameters"), Description("Left point of the function")]
        public int Resolution 
        {
            get => resolution;
            set 
            {
                if(resolution>=10 && resolution<=10000)
                    resolution = value;
                if (Parameter_Changed != null)
                    Parameter_Changed(this, null);
            } 
        }
        [Category("Parameters"), Description("Left point of the function")]
        public double Minimum
        {
            get => minimum;
            set
            {
                if (minimum < maximum)
                { 
                    minimum = value;
                    this_Chart_Area.AxisX.Minimum = value;
                    if (Parameter_Changed != null)
                        Parameter_Changed(this, null);
                }
            }
        }
        [Category("Parameters"), Description("Left point of the function")]
        public double Maximum
        {
            get => maximum;
            set
            {
                if (maximum > minimum)
                { 
                    maximum = value;
                    this_Chart_Area.AxisX.Maximum = value;
                    if (Parameter_Changed != null)
                        Parameter_Changed(this, null);
                }
            }
        }
        [Browsable(false)]
        public TreeNode Parent_Node { get => parent_Node; set => parent_Node = value; }

        public Fuzzy_display_area(Chart CT)
        {           
            name = name + String.Format("{0:00}", current_Index++);
            this_Chart_Area = new ChartArea(name);
            this_Chart_Area.AxisX.Enabled = AxisEnabled.True;
            this_Chart_Area.AxisX.Title = name;
            this_Chart_Area.AxisX.Maximum = maximum;
            this_Chart_Area.AxisX.Minimum = minimum;
            this_Chart_Area.AxisY.Minimum = 0;
            this_Chart_Area.AxisY.Maximum = 1.2;
            CT.ChartAreas.Add(this_Chart_Area);

            this_Legend = new Legend(name);
            this_Legend.Docking = Docking.Top;
            this_Legend.DockedToChartArea=CT.ChartAreas.Last().Name; 
            this_Legend.Alignment = System.Drawing.StringAlignment.Far;
            //this_Legend.IsDockedInsideChartArea = false;
            this_Legend.BackColor = Color.Transparent;
            CT.Legends.Add(this_Legend);
            
        }



        public void Set_Tree_Node(TreeNode tn)
        {
            parent_Node = tn;
        }
        public ChartArea Get_Chart_Area()
        {
            return this_Chart_Area;
        }
        public Legend Get_Legend()
        {
            return this_Legend;
        }
    }
}
