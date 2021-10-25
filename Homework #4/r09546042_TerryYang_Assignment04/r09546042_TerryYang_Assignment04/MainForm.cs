using Fuzzy_Graph_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace r09546042_TerryYang_Assignment01
{
    public partial class MainForm : Form
    {
        Fuzzy_functions_collections fs1;
        Fuzzy_functions_collections fs2;

        public MainForm()
        {
            InitializeComponent();
            Main_Chart.Series.Clear();
            Setup_UI();          
        }
        public void Setup_UI()
        {
            Main_Chart.ChartAreas[0].Visible = false;

            toolTip1.SetToolTip(TV_Display, "Press enter to delete");
            toolTip1.SetToolTip(BTN_add_area, "Add chartarea");
            toolTip1.SetToolTip(BTN_add_Pri_function, "Add primary fuzzy set");
            toolTip1.SetToolTip(BTN_add_Unary_function, "Add Unary operated fuzzy set");
            toolTip1.SetToolTip(BTN_add_Binary_function, "Add Binary operated fuzzy set");
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "提示訊息";
        }      

        private void BTN_add_area_Click(object sender, EventArgs e)
        {
            // add new FDA to tree view, and chart area to main chart
            Fuzzy_display_area FDA = new Fuzzy_display_area(Main_Chart);
            TreeNode tn = new TreeNode(FDA.Name);
            tn.Name = FDA.Name;
            tn.Tag = FDA;
            FDA.Set_Tree_Node(tn);

            TV_Display.Nodes.Add(tn);
        }

        public ChartArea Get_Chart_Area_by_Xaxis_Title(string title)
        {
            // return the correct chart area via tree view
            ChartArea selected_Chart_Area = new ChartArea(); ;
            for (int i = 0; i < Main_Chart.ChartAreas.Count; i++)
            {
                if (Main_Chart.ChartAreas[i].AxisX.Title == title)
                {
                    selected_Chart_Area = Main_Chart.ChartAreas[i];
                }
            }
            return selected_Chart_Area;
        }
        public Series Get_Series_by_name(string name)
        {
            // return the correct series via tree view
            Series selected_Series = new Series();
            selected_Series = Main_Chart.Series.FindByName(name);
            return selected_Series;
        }

        private void TV_Display_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(TV_Display.SelectedNode.Tag.ToString());
            if (TV_Display.SelectedNode.Tag.ToString() == "Fuzzy_Graph_Library.Fuzzy_display_area")
            {
                GB_PFS.Enabled = true;
                GB_BO.Enabled = false;
                GB_UO.Enabled = false;
            }
            else
            {
                GB_PFS.Enabled = false;
                GB_BO.Enabled = true;
                GB_UO.Enabled = true;
            }


            // SNAC Tree view and property gird view
            PPGV_parameters.SelectedObject = e.Node.Tag;

            // text on indecator
            LB_indecator.Text = TV_Display.SelectedNode.Text;

            // highlight selected chart area 
            for (int i = 0; i < Main_Chart.ChartAreas.Count; i++)
            {
                Main_Chart.ChartAreas[i].BackColor = Color.White;
                
            }
            if (Get_Chart_Area_by_Xaxis_Title(TV_Display.SelectedNode.Text) != null)
                Get_Chart_Area_by_Xaxis_Title(TV_Display.SelectedNode.Text).BackColor = Color.LightGray;

            // highlight selected series 
            for (int i = 0; i < Main_Chart.Series.Count; i++)
            {
                Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;
                Main_Chart.Series[i].BorderWidth = 2;
            }
            if (Get_Series_by_name(TV_Display.SelectedNode.Text) != null)
            {
                Get_Series_by_name(TV_Display.SelectedNode.Text).MarkerStyle = MarkerStyle.Cross;
                Get_Series_by_name(TV_Display.SelectedNode.Text).BorderWidth = 3;
            }
                     
        }

        private void BTN_add_function_Click(object sender, EventArgs e)
        {
            // add function button click, than plot series
            if (TV_Display.SelectedNode == null)
                return;
            Fuzzy_display_area FDA = TV_Display.SelectedNode.Tag as Fuzzy_display_area;
            if (FDA == null)
                return;
            TreeNode TN = new TreeNode();
            Fuzzy_functions_collections FFC = new Fuzzy_functions_collections(FDA);
            string Graph_Type = CB_fuzzy_type.Text;
            switch (Graph_Type)
            {
                case "Triangular":
                    FFC = new Triangular_function(FDA);
                    break;

                case "Gaussian":
                    FFC = new Gaussian_function(FDA);
                    break;

                case "Bell":
                    FFC = new Bell_function(FDA);
                    break;

                case "Sigmoidal":
                    FFC = new Sigmoidal_function(FDA);
                    break;
                case "LeftRight":
                    FFC = new LeftRight_function(FDA);
                    break;
                case "S-shape":
                    FFC = new S_shape_function(FDA);
                    break;
                case "Z-shape":
                    FFC = new Z_shape_function(FDA);
                    break;
                default:
                    //New_series = null;
                    break;
            }
            Main_Chart.Series.Add(FFC.Plot_Graph());
            TN.Tag = FFC;
            FFC.Set_Tree_Node(TN);
            TN.Text = FFC.Name;
            TV_Display.SelectedNode.Nodes.Add(TN);

            FDA.Get_Chart_Area().RecalculateAxesScale();
            FDA.Get_Chart_Area().AxisX.LabelStyle.Format = "{n2}";
            Main_Chart.Update();
        }


        private void PPGV_parameters_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //Delete_Exist_Series();
            //Plot_Series();
        }

        private void BTN_add_Unary_function_Click(object sender, EventArgs e)
        {
            if (TV_Display.SelectedNode == null)
                return;
            //Fuzzy_display_area FDA = TV_Display.SelectedNode.Tag as Fuzzy_display_area;
            Fuzzy_functions_collections fs = TV_Display.SelectedNode.Tag as Fuzzy_functions_collections;
            if (fs == null)
                return;
            TreeNode TN = new TreeNode();
            Unary_Operaor uo = new Unary_Operaor() ;
            string Unary_type = CB_Unary_type.Text;
            switch (Unary_type)
            {
                case "Negate":
                    uo = new Negate_Operator();
                    break;

                case "Very":
                    uo = new Concentration_Operator();
                    break;
                case "Extremely":
                    uo = new Extremely_Operator();
                    break;
                case "More_or_less":
                    uo = new Dilation_Operator();
                    break;
                case "Intensification":
                    uo = new Intensification_Operator();
                    break;
                default:
                    //New_series = null;
                    break;
            }
            Unary_Operated_fuzzy_set uofs = new Unary_Operated_fuzzy_set(uo, fs);
            uofs.Generate_Series();
            Main_Chart.Series.Add(uofs.Plot_Graph());
            //negated_fs.Plot_Graph();
            TreeNode tn = new TreeNode(uofs.Name);
            tn.Name = uofs.Name;
            tn.Tag = uofs;
            uofs.Set_Tree_Node(tn);
            fs.Fda.Parent_Node.Nodes.Add(tn);

            fs.Fda.Get_Chart_Area().RecalculateAxesScale();
            fs.Fda.Get_Chart_Area().AxisX.LabelStyle.Format = "{n2}";
            Main_Chart.Update();
        }

        private void TV_Display_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyChar == (char)Keys.Enter)
            {
                // delete selecte area or series in tree and chart
                TreeNode seleted_Node = TV_Display.SelectedNode;
                if (seleted_Node != null)
                {
                    TV_Display.Nodes.Remove(seleted_Node);
                    Main_Chart.ChartAreas.Remove(Get_Chart_Area_by_Xaxis_Title(seleted_Node.Text));
                    Main_Chart.Series.Remove(Get_Series_by_name(seleted_Node.Text));
                }

                if (TV_Display.Nodes.Count == 0)
                {
                    // disable GB
                    GB_PFS.Enabled = false;
                    GB_BO.Enabled = false;
                    GB_UO.Enabled = false;
                }
            }
        }

        private void BTN_add_Binary_function_Click(object sender, EventArgs e)
        {
            if (fs1 == null || fs2 == null)
                return;
            //Fuzzy_display_area FDA = TV_Display.SelectedNode.Tag as Fuzzy_display_area;
            TreeNode TN = new TreeNode();
            Binary_Operaor bo = new Binary_Operaor();
            string Binary_type = CB_Binary_type.Text;
            switch (Binary_type)
            {
                case "Intersection":
                    bo = new Intersection_Operator();
                    break;

                case "Union":
                    bo = new Union_Operator();
                    break;

                case "Subtraction":
                    bo = new Subtraction_Operator();
                    break;
                default:
                    
                    //New_series = null;
                    break;
            }
            Binary_Operated_fuzzy_set bofs = new Binary_Operated_fuzzy_set(bo, fs1,fs2);
            bofs.Generate_Series();
            Main_Chart.Series.Add(bofs.Plot_Graph());
            //negated_fs.Plot_Graph();
            TreeNode tn = new TreeNode(bofs.Name);
            tn.Name = bofs.Name;
            tn.Tag = bofs;
            bofs.Set_Tree_Node(tn);
            fs1.Fda.Parent_Node.Nodes.Add(tn);

            fs1.Fda.Get_Chart_Area().RecalculateAxesScale();
            fs1.Fda.Get_Chart_Area().AxisX.LabelStyle.Format = "{n2}";
            Main_Chart.Update();

            BTN_assign_fs_01.Text = "Series_01";
            BTN_assign_fs_02.Text = "Series_02";
            BTN_assign_fs_01.Enabled = true;
            BTN_add_Binary_function.Enabled = false;
        }

        private void BTN_assign_fs_01_Click(object sender, EventArgs e)
        {
            fs1 = TV_Display.SelectedNode.Tag as Fuzzy_functions_collections;
            BTN_assign_fs_01.Text = fs1.Name;
            BTN_assign_fs_01.Enabled = false;
        }

        private void BTN_assign_fs_02_Click(object sender, EventArgs e)
        {
            fs2 = TV_Display.SelectedNode.Tag as Fuzzy_functions_collections;
            BTN_assign_fs_02.Text = fs2.Name;
            BTN_assign_fs_02.Enabled = false;
            BTN_add_Binary_function.Enabled = true;
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            // delete selecte area or series in tree and chart
            TreeNode seleted_Node = TV_Display.SelectedNode;
            if (seleted_Node != null)
            {
                TV_Display.Nodes.Remove(seleted_Node);
                Main_Chart.ChartAreas.Remove(Get_Chart_Area_by_Xaxis_Title(seleted_Node.Text));
                Main_Chart.Series.Remove(Get_Series_by_name(seleted_Node.Text));
            }

            if (TV_Display.Nodes.Count == 0)
            {
                // disable GB
                GB_PFS.Enabled = false;
                GB_BO.Enabled = false;
                GB_UO.Enabled = false;
            }
        }
    }
}
