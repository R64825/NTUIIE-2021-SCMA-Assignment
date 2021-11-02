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
            toolTip1.SetToolTip(BTN_delete, "Delete chartarea");
            toolTip1.SetToolTip(BTN_add_Pri_function, "Add primary fuzzy set");
            toolTip1.SetToolTip(BTN_add_Unary_function, "Add Unary operated fuzzy set");
            toolTip1.SetToolTip(BTN_add_Binary_function, "Add Binary operated fuzzy set");
            toolTip1.SetToolTip(BTN_assign_fs_01, "Select current fuzzy set");
            toolTip1.SetToolTip(BTN_assign_fs_02, "Select current fuzzy set");
            toolTip1.SetToolTip(BTN_cancel_selection, "Cancel Selection");
            toolTip1.SetToolTip(PPGV_parameters, "Selection Property");
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "提示訊息";

            ImageList ImageList_for_TV = new ImageList();
            ImageList_for_TV.Images.Add("CA", r09546042_TerryYang_Assignment05.Properties.Resources.Chart_Area);
            ImageList_for_TV.Images.Add("FS", r09546042_TerryYang_Assignment05.Properties.Resources.Fuzzy_Set);
            ImageList_for_TV.Images.Add("UN", r09546042_TerryYang_Assignment05.Properties.Resources.Unary);
            ImageList_for_TV.Images.Add("BN", r09546042_TerryYang_Assignment05.Properties.Resources.Binary);
            TV_Display.ImageList = ImageList_for_TV;
        }      

        private void BTN_add_area_Click(object sender, EventArgs e)
        {
            // add new FDA to tree view, and chart area to main chart
            Fuzzy_display_area FDA = new Fuzzy_display_area(Main_Chart);
            TreeNode tn = new TreeNode(FDA.Name);

            tn.ImageKey = "CA";
            tn.SelectedImageKey = "CA";

            tn.Name = FDA.Name;
            tn.Tag = FDA;
            FDA.Set_Tree_Node(tn);
            TV_Display.SelectedNode.Nodes.Add(tn);

            // data gird view
                       
            DGV_Rules.Columns.Add(FDA.Name, FDA.Name);
            DGV_Rules.Columns[DGV_Rules.Columns.Count - 1].Tag = FDA;
            if (TV_Display.SelectedNode.Index == 0)
            {
                DGV_Conditions.Columns.Add(FDA.Name, FDA.Name);
                if (DGV_Conditions.RowCount == 0) DGV_Conditions.Rows.Add();
            }
            DGV_Rules.Columns[DGV_Rules.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //DGV_Conditions.Columns[DGV_Rules.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            Fuzzy_display_area fda = (TV_Display.SelectedNode.Tag as Fuzzy_display_area);
            //MessageBox.Show(TV_Display.SelectedNode.Level.ToString() );
            if (TV_Display.SelectedNode.Level == 0)
            {
                // select input output universe
                BTN_add_area.Enabled = true;
                BTN_delete.Enabled = false;
                return;
            }             
            else if (TV_Display.SelectedNode.Level == 1)
            {
                // select area
                GB_PFS.Enabled = true;
                GB_BO.Enabled = false;
                GB_UO.Enabled = false;
                BTN_add_area.Enabled = false;
                BTN_delete.Enabled = true;
            }
            else
            {
                // select Fuzzy set
                GB_PFS.Enabled = false;
                GB_BO.Enabled = true;
                GB_UO.Enabled = true;
                BTN_add_area.Enabled = false;
                BTN_delete.Enabled = true;
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
            TN.ImageKey = "FS";
            TN.SelectedImageKey = "FS";
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
            Unary_Operated_fuzzy_set uofs = null;
            Unary_Opertor uo = new Unary_Opertor() ;
            string Unary_type = CB_Unary_type.Text;
            switch (Unary_type)
            {
                case "Negate":
                    uo = new Negate_Operator();
                    break;
                case "Very":
                    uofs =  ~ fs;
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
                case "Diminish":
                    uo = new Diminish_Operator();
                    break;                  
                case "Value Cut":
                    uofs =  0.5-fs;
                    uo = new ValueCut_Operator(0.5);
                    break;
                case "Value Scale":
                    uo = new ValueScale_Operator();
                    break;
                default:
                    //New_series = null;
                    break;
            }
            //Unary_Operated_fuzzy_set uofs = new Unary_Operated_fuzzy_set(uo, fs);
            if (uofs == null)
                return;
            uofs.Generate_Series();
            if (Main_Chart.Series.FindByName(uofs.Plot_Graph().Name)!=null)
                Main_Chart.Series.Remove(Main_Chart.Series.FindByName((uofs.Plot_Graph().Name)));
            Main_Chart.Series.Add(uofs.Plot_Graph());
            //negated_fs.Plot_Graph();
            TreeNode TN = new TreeNode(uofs.Name);
            TN.ImageKey = "UN";
            TN.SelectedImageKey = "UN";
            TN.Name = uofs.Name;
            TN.Tag = uofs;
            uofs.Set_Tree_Node(TN);
            fs.Fda.Parent_Node.Nodes.Add(TN);

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
            Fuzzy_functions_collections fs1 = BTN_assign_fs_01.Tag as Fuzzy_functions_collections;
            Fuzzy_functions_collections fs2 = BTN_assign_fs_02.Tag as Fuzzy_functions_collections;   
            if (fs1 == null || fs2 == null)
                return;
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
                case "Bounded Sum":
                    bo = new BoundedSum_Operator();
                    break;
                case "Logical Sum":
                    bo = new LogicalSum_Operator();
                    break;
                case "Algebraic Sum":
                    bo = new AlgebraicSum_Operator();
                    break;
                case "Drastic Sum":
                    bo = new DrasticSum_Operator();
                    break;
                case "Einstein Sum":
                    bo = new EinsteinSum_Operator();
                    break;
                case "Bounded Product":
                    bo = new BoundedProduct_Operator();
                    break;
                case "Logical Product":
                    bo = new LogicalProduct_Operator();
                    break;
                case "Algebraic Product":
                    bo = new AlgebraicProduct_Operator();
                    break;
                case "Drastic Product":
                    bo = new DrasticProduct_Operator();
                    break;
                case "Einstein Product":
                    bo = new EinsteinProduct_Operator();
                    break;
                case "Hamacher TNorm":
                    bo = new HamacherTNorm();
                    break;
                case "Hamacher SNorm":
                    bo = new HamacherSNorm();
                    break;
                case "Dombi TNorm":
                    bo = new DombiTNorm_Operator();
                    break;                  
                default:
                    //New_series = null;
                    break;
            }
            Binary_Operated_fuzzy_set bofs = new Binary_Operated_fuzzy_set(bo, fs1, fs2);
            bofs.Generate_Series();
            Main_Chart.Series.Add(bofs.Plot_Graph());
            //negated_fs.Plot_Graph();
            TreeNode tn = new TreeNode(bofs.Name);
            tn.ImageKey = "BN";
            tn.SelectedImageKey = "BN";
            tn.Name = bofs.Name;
            tn.Tag = bofs;
            bofs.Set_Tree_Node(tn);
            fs1.Fda.Parent_Node.Nodes.Add(tn);

            fs1.Fda.Get_Chart_Area().RecalculateAxesScale();
            fs1.Fda.Get_Chart_Area().AxisX.LabelStyle.Format = "{n2}";
            Main_Chart.Update();
        }

        private void BTN_assign_fs_01_Click(object sender, EventArgs e)
        {
            TreeNode selected_node = TV_Display.SelectedNode;
            BTN_assign_fs_01.Tag = selected_node.Tag as Fuzzy_functions_collections;
            BTN_assign_fs_01.Text = selected_node.Text;
            BTN_assign_fs_01.Enabled = false;

            Fuzzy_functions_collections fs1 = BTN_assign_fs_01.Tag as Fuzzy_functions_collections;
            Fuzzy_functions_collections fs2 = BTN_assign_fs_02.Tag as Fuzzy_functions_collections;

            if (fs1 != null && fs2 != null)
            {
                if (fs1.Fda != fs2.Fda)
                {
                    MessageBox.Show("Please selecte 2 fuzzy sets that in the same chart area!");
                    return;
                }
                BTN_add_Binary_function.Enabled = true;
            }
        }
        private void BTN_assign_fs_02_Click(object sender, EventArgs e)
        {
            TreeNode selected_node = TV_Display.SelectedNode;
            BTN_assign_fs_02.Tag = selected_node.Tag as Fuzzy_functions_collections;
            BTN_assign_fs_02.Text = selected_node.Text;
            BTN_assign_fs_02.Enabled = false;

            Fuzzy_functions_collections fs1 = BTN_assign_fs_01.Tag as Fuzzy_functions_collections;
            Fuzzy_functions_collections fs2 = BTN_assign_fs_02.Tag as Fuzzy_functions_collections;

            if (fs1 != null && fs2 != null)
            {
                if (fs1.Fda != fs2.Fda)
                {
                    MessageBox.Show("Please selecte 2 fuzzy sets that in the same chart area!");
                    return;
                }
                BTN_add_Binary_function.Enabled = true;
            }         
        }
        private void BTN_cancel_selection_Click(object sender, EventArgs e)
        {
            BTN_assign_fs_01.Tag = null;
            BTN_assign_fs_02.Tag = null;
            BTN_assign_fs_01.Enabled = true;
            BTN_assign_fs_02.Enabled = true;

            BTN_assign_fs_01.Text = "Set_01";
            BTN_assign_fs_02.Text = "Set_02";

            BTN_add_Binary_function.Enabled = false;
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

        private void BTN_Add_Rules_Click(object sender, EventArgs e)
        {
            DGV_Rules.Rows.Add(); 
        }

        private void DGV_Rules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fuzzy_functions_collections target = TV_Display.SelectedNode.Tag as Fuzzy_functions_collections;
            if (target == null) return;

            // check column fda
            if (DGV_Rules.Columns[e.ColumnIndex].Tag != target.Fda) return;
            DGV_Rules.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = target.Name;
        }

        private void BTN_Inference_Click(object sender, EventArgs e)
        {
            List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>();
            If_Then_Fuzzy_Rule a_Rule = new If_Then_Fuzzy_Rule(antecedent, );
        }
    }
}
