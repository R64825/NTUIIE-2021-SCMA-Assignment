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
        DataGridViewColumn last_Column;

        Mandani_Fuzzy_System MFS ;
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
            toolTip1.SetToolTip(DGV_Rules, "Setting inference rules");
            toolTip1.SetToolTip(DGV_Conditions, "Setting inference conditions");
            toolTip1.SetToolTip(BTN_Inference, "Generate inference area");
            toolTip1.SetToolTip(BTN_Add_Rules, "Add inference rule");
            toolTip1.SetToolTip(BTN_Delete_Rules, "Delete inference rule");
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "提示訊息";

            ImageList ImageList_for_TV = new ImageList();
            ImageList_for_TV.Images.Add("IN", r09546042_TerryYang_Assignment06.Properties.Resources.input);
            ImageList_for_TV.Images.Add("OU", r09546042_TerryYang_Assignment06.Properties.Resources.output);
            ImageList_for_TV.Images.Add("CA", r09546042_TerryYang_Assignment06.Properties.Resources.Chart_Area);
            ImageList_for_TV.Images.Add("FS", r09546042_TerryYang_Assignment06.Properties.Resources.Fuzzy_Set);
            ImageList_for_TV.Images.Add("UN", r09546042_TerryYang_Assignment06.Properties.Resources.Unary);
            ImageList_for_TV.Images.Add("BN", r09546042_TerryYang_Assignment06.Properties.Resources.Binary);
            TV_Display.ImageList = ImageList_for_TV;

            TV_Display.Nodes[0].ImageKey = "IN";
            TV_Display.Nodes[0].SelectedImageKey = "IN";

            TV_Display.Nodes[1].ImageKey = "OU";
            TV_Display.Nodes[1].SelectedImageKey = "OU";
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
            if (TV_Display.SelectedNode.Index == 0)
            {
                // select on input universe
                DGV_Rules.Columns.Add(FDA.Name, FDA.Name);
                DGV_Rules.Columns[DGV_Rules.Columns.Count - 1].Tag = FDA;

                DGV_Conditions.Columns.Add(FDA.Name, FDA.Name);
                DGV_Conditions.Columns[DGV_Conditions.Columns.Count - 1].Tag = FDA;
                if (DGV_Conditions.RowCount == 0) DGV_Conditions.Rows.Add();

                if(last_Column!=null) last_Column.DisplayIndex = DGV_Rules.ColumnCount - 1;
            }
            if (TV_Display.SelectedNode.Index == 1)
            {
                // select on output universe
                DGV_Rules.Columns.Add(FDA.Name, FDA.Name);
                DGV_Rules.Columns[DGV_Rules.Columns.Count - 1].Tag = FDA;
                DGV_Rules.Columns[DGV_Rules.Columns.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;

                last_Column = new DataGridViewColumn();
                last_Column = DGV_Rules.Columns[DGV_Rules.Columns.Count - 1];
            }
            DGV_Rules.Columns[DGV_Rules.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            GB_Rules.Enabled = true;
            GB_Conditions.Enabled = true;

            if (TV_Display.SelectedNode.Level == 0)
            {
                // select input output universe
                BTN_add_area.Enabled = true;
                BTN_delete.Enabled = false;
                if (TV_Display.SelectedNode.Index == 1 && TV_Display.SelectedNode.Nodes.Count != 0)
                {
                    //select output universe
                    //ban
                    BTN_add_area.Enabled = false;
                    BTN_delete.Enabled = false;
                }
                //return;
            }
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
            //MessageBox.Show(TV_Display.SelectedNode.Index.ToString());
            if (TV_Display.SelectedNode.Level == 0)
            {
                // select input output universe
                BTN_add_area.Enabled = true;
                BTN_delete.Enabled = false;

                
                if (TV_Display.SelectedNode.Index == 1 && TV_Display.SelectedNode.Nodes.Count!=0)
                {
                    //select output universe
                    //ban
                    BTN_add_area.Enabled = false;
                    BTN_delete.Enabled = false;
                }
                //return;
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
            Unary_Opertor uo = null;
            string Unary_type = CB_Unary_type.Text;
            switch (Unary_type)
            {
                case "Negate":
                    uofs = !fs;
                    break;
                case "Very":
                    uofs =  ~ fs;
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
                    break;
                case "Value Scale":
                    uofs = 0.5*fs;
                    break;
                default:
                    //New_series = null;
                    break;
            }
            if (uofs == null)
                uofs = new Unary_Operated_fuzzy_set(uo, fs);
            //if (uofs == null)
            //    return;
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
            Binary_Operated_fuzzy_set bofs = null;
            Binary_Operaor bo = null;
            string Binary_type = CB_Binary_type.Text;
            switch (Binary_type)
            {
                case "Intersection":
                    bofs = fs1 & fs2;
                    break;
                case "Union":
                    bofs = fs1 | fs2;
                    break;
                case "Subtraction":
                    bofs = fs1 / fs2;
                    break;
                case "Bounded Sum":
                    bofs = fs1 ^ fs2; 
                    break;
                case "Logical Sum":
                    bo = new LogicalSum_Operator();
                    break;
                case "Algebraic Sum":
                    bofs = fs1 < fs2;
                    break;
                case "Drastic Sum":
                    bo = new DrasticSum_Operator();
                    break;
                case "Einstein Sum":
                    bo = new EinsteinSum_Operator();
                    break;
                case "Bounded Product":
                    bofs = fs1 % fs2;
                    break;
                case "Logical Product":
                    bo = new LogicalProduct_Operator();
                    break;
                case "Algebraic Product":
                    bofs = fs1 > fs2;
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
                    bofs = fs1 + fs2;
                    break;                  
                default:
                    //New_series = null;
                    break;
            }
            if (bofs == null)
                bofs = new Binary_Operated_fuzzy_set(bo, fs1, fs2);           
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
                if (seleted_Node.Level ==0)
                {
                    // area
                    Main_Chart.ChartAreas.Remove(Get_Chart_Area_by_Xaxis_Title(seleted_Node.Text));
                    // fuzzy set
                    Main_Chart.Series.Remove(Get_Series_by_name(seleted_Node.Text));


                    // grid view
                    if (DGV_Rules.Columns[seleted_Node.Text] != null)
                        DGV_Rules.Columns.Remove(seleted_Node.Text);
                    if (DGV_Conditions.Columns[seleted_Node.Text]!=null)
                        DGV_Conditions.Columns.Remove(seleted_Node.Text);
                }          
            }

            if (TV_Display.Nodes[0].Nodes.Count==0 || TV_Display.Nodes[1].Nodes.Count == 0)
            {
                // disable GB
                GB_PFS.Enabled = false;
                GB_BO.Enabled = false;
                GB_UO.Enabled = false;

                //GB_Rules.Enabled = false;
                //GB_Conditions.Enabled = false;
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (DGV_Rules.Columns[e.ColumnIndex].Tag != target.Fda) return;
            DGV_Rules.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = target;
        }

        private void DGV_Conditions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fuzzy_functions_collections target = TV_Display.SelectedNode.Tag as Fuzzy_functions_collections;
            if (target == null) return;

            // check column fda
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (DGV_Conditions.Columns[e.ColumnIndex].Tag != target.Fda) return;
            DGV_Conditions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = target;
        }
        private void BTN_Inference_Click(object sender, EventArgs e)
        {
            List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>(); 
            List<Fuzzy_functions_collections> coditions = new List<Fuzzy_functions_collections>();
            Fuzzy_functions_collections conclusion_FS = null;
            If_Then_Fuzzy_Rule a_Rule = null;
            Fuzzy_functions_collections result = null;
            int con_index = last_Column.Index;

            for (int i = 0; i < DGV_Rules.RowCount; i++)
            {
                // for every row
                antecedent.Clear();
                coditions.Clear();
                conclusion_FS = (Fuzzy_functions_collections)DGV_Rules.Rows[i].Cells[con_index].Value;
                for (int j = 0; j < DGV_Rules.ColumnCount ; j++)
                {
                    // read antecedent
                    antecedent.Add(DGV_Rules.Rows[i].Cells[j].Value as Fuzzy_functions_collections);                   
                }
                for (int j = 0; j < DGV_Conditions.ColumnCount; j++)
                {
                    // read condition
                    coditions.Add(DGV_Conditions.Rows[0].Cells[j].Value as Fuzzy_functions_collections);
                }               
                antecedent.RemoveAt(con_index);
                a_Rule = new If_Then_Fuzzy_Rule(antecedent, conclusion_FS);
                result = a_Rule.Fuzzy_In_Fuzzy_Out_Inferencing(coditions, RDB_Cut.Checked);

                result.Generate_Series();
                Main_Chart.Series.Add(result.Plot_Graph());

            }
        }

        private void BTN_Delete_Rules_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.DGV_Rules.SelectedRows)
            {
                DGV_Rules.Rows.RemoveAt(item.Index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<If_Then_Fuzzy_Rule> all_Rules = new List<If_Then_Fuzzy_Rule>();
            List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>();
            List<Fuzzy_functions_collections> coditions = new List<Fuzzy_functions_collections>();
            Fuzzy_functions_collections conclusion_FS = null;
            If_Then_Fuzzy_Rule a_Rule = null;
            int con_index = last_Column.Index;

            // read all rules
            for (int i = 0; i < DGV_Rules.RowCount; i++)
            {
                // for every row
                antecedent.Clear();
                coditions.Clear();
                conclusion_FS = (Fuzzy_functions_collections)DGV_Rules.Rows[i].Cells[con_index].Value;
                for (int j = 0; j < DGV_Rules.ColumnCount; j++)
                {
                    // read antecedent
                    antecedent.Add(DGV_Rules.Rows[i].Cells[j].Value as Fuzzy_functions_collections);
                }
                for (int j = 0; j < DGV_Conditions.ColumnCount; j++)
                {
                    // read condition
                    coditions.Add(DGV_Conditions.Rows[0].Cells[j].Value as Fuzzy_functions_collections);
                }
                antecedent.RemoveAt(con_index);
                a_Rule = new If_Then_Fuzzy_Rule(antecedent, conclusion_FS);
                all_Rules.Add(a_Rule);
            }

            MFS = new Mandani_Fuzzy_System(all_Rules);



            int d1 = 30, d2 = 40;
            surface1.Clear();
            surface1.NumXValues = d1;
            surface1.NumZValues = d2;
            double[] inputs = new double[2];

            for (double x = -10.0; x < 10.0; x = x +0.1)
            {
                inputs[0] = x;
                for (double z = -5.0; z < 5.0; z = z + 0.05)
                {
                    inputs[1] = z;
                    double y = MFS.Crisp_In_Crisp_Out_Ingerencing(inputs, Defuzzification.COA);
                    surface1.Add(x,y,z);
                }
            }
        }
    }
}
