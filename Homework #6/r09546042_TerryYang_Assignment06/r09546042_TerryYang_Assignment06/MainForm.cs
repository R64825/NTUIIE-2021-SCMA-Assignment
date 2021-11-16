using Fuzzy_Graph_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace r09546042_TerryYang_Assignment01
{
    public partial class MainForm : Form
    {
        DataGridViewColumn last_Column;
        TabPage one_D;
        TabPage two_D;

        Mandani_Fuzzy_System MFS = new Mandani_Fuzzy_System();
        Sugeon_Fuzzy_System SFS = new Sugeon_Fuzzy_System();
        Tsukamoto_Fuzzy_System TFS = new Tsukamoto_Fuzzy_System();

        Fuzzy_functions_collections inference_Result_Fuzzy_Set;
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

            TB_1D = TBC_Defuzzy.TabPages[1];
            TB_2D = TBC_Defuzzy.TabPages[0];
            TBC_Defuzzy.TabPages.Remove(TB_1D);
            TBC_Defuzzy.TabPages.Remove(TB_2D);
            TBC_main.TabPages.Remove(TP_Sugeon_Conclusion);
            PPGV_System.SelectedObject = MFS;
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

        public void Read_DGV_Rules()
        {
            int con_index = last_Column.Index;
            List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>();
            if (RB_MFS.Checked)
            {
                #region Read Mandani Rules              
                Fuzzy_functions_collections conclusion_FS = null;
                Mandani_If_Then_Fuzzy_Rule a_Rule = null;
                List<Mandani_If_Then_Fuzzy_Rule> rules = new List<Mandani_If_Then_Fuzzy_Rule>();

                for (int i = 0; i < DGV_Rules.RowCount; i++)
                {
                    // read rule to list
                    antecedent.Clear();
                    conclusion_FS = (Fuzzy_functions_collections)DGV_Rules.Rows[i].Cells[con_index].Value;
                    for (int j = 0; j < DGV_Rules.ColumnCount; j++)
                    {
                        // read antecedent
                        antecedent.Add(DGV_Rules.Rows[i].Cells[j].Value as Fuzzy_functions_collections);
                    }
                    antecedent.RemoveAt(con_index);
                    a_Rule = new Mandani_If_Then_Fuzzy_Rule(antecedent, conclusion_FS);
                    rules.Add(a_Rule);
                }
                MFS.Update_Rule_Sets(rules);

                #endregion
            }
            else if (RB_SFS.Checked)
            {
                #region Read Sugeno Rules
                List<int> conclusion_FS = new List<int>();
                Sugeno_If_Then_Fuzzy_Rule a_Rule = null;
                List<Sugeno_If_Then_Fuzzy_Rule> rules = new List<Sugeno_If_Then_Fuzzy_Rule>();
                for (int i = 0; i < DGV_Rules.RowCount; i++)
                {
                    // read rule to list
                    antecedent.Clear();
                    conclusion_FS.Add((int)DGV_Rules.Rows[i].Cells[con_index].Value);
                    for (int j = 0; j < DGV_Rules.ColumnCount; j++)
                    {
                        // read antecedent
                        antecedent.Add(DGV_Rules.Rows[i].Cells[j].Value as Fuzzy_functions_collections);
                    }
                    antecedent.RemoveAt(con_index);
                    a_Rule = new Sugeno_If_Then_Fuzzy_Rule(antecedent, conclusion_FS[i]);
                    rules.Add(a_Rule);
                }

                SFS.Update_Rule_Sets(rules);
                #endregion
            }
            else 
            {
                #region Read Tsukamoto Rules
                Fuzzy_functions_collections conclusion_FS = null;
                Tsukamoto_If_Then_Fuzzy_Rule a_Rule = null;
                List<Tsukamoto_If_Then_Fuzzy_Rule> rules = new List<Tsukamoto_If_Then_Fuzzy_Rule>();

                for (int i = 0; i < DGV_Rules.RowCount; i++)
                {

                    // read rule to list
                    antecedent.Clear();
                    conclusion_FS = (Fuzzy_functions_collections)DGV_Rules.Rows[i].Cells[con_index].Value;
                    for (int j = 0; j < DGV_Rules.ColumnCount; j++)
                    {
                        // read antecedent
                        antecedent.Add(DGV_Rules.Rows[i].Cells[j].Value as Fuzzy_functions_collections);
                    }
                    antecedent.RemoveAt(con_index);
                    a_Rule = new Tsukamoto_If_Then_Fuzzy_Rule(antecedent, conclusion_FS);
                    rules.Add(a_Rule);
                }

                TFS.Update_Rule_Sets(rules);
                #endregion
            }
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
                //BTN_add_equation.Enabled = false;
                
                if (TV_Display.SelectedNode.Index == 1 && TV_Display.SelectedNode.Nodes.Count!=0)
                {
                    //select output universe
                    //ban
                    BTN_add_area.Enabled = false;
                    BTN_delete.Enabled = false;
                    //BTN_add_equation.Enabled = true;
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
                if (TV_Display.SelectedNode.Parent.Index == 1)
                    //select on output area
                    BTN_add_equation.Enabled = true;
                else BTN_add_equation.Enabled = false;
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

        


        private void PPGV_parameters_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //Delete_Exist_Series();
            //Plot_Series();
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
       

        private void DGV_Rules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fuzzy_functions_collections target;
            if (RB_SFS.Checked)
            {
                // adding equation to DGV
                string str = TV_Display.SelectedNode.Text.ToString();
                if (str.Contains(":"))
                {
                    str = TV_Display.SelectedNode.Tag.ToString();
                    int equation_ID = int.Parse(str);
                    // check column fda
                    if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                    DGV_Rules.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = equation_ID;
                }
                else
                {
                     target = TV_Display.SelectedNode.Tag as Fuzzy_functions_collections;
                    if (target == null) return;

                    // check column fda
                    if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                    if (DGV_Rules.Columns[e.ColumnIndex].Tag != target.Fda) return;
                    DGV_Rules.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = target;
                }
            }

             target = TV_Display.SelectedNode.Tag as Fuzzy_functions_collections;
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


        #region BTN
        private void BTN_Inference_Click(object sender, EventArgs e)
        {
            if (RB_MFS.Checked)
            {
                #region MFS
                List<Fuzzy_functions_collections> antecedent = new List<Fuzzy_functions_collections>();
                List<Fuzzy_functions_collections> coditions = new List<Fuzzy_functions_collections>();
                Fuzzy_functions_collections conclusion_FS = null;
                Mandani_If_Then_Fuzzy_Rule a_Rule = null;
                List<Fuzzy_functions_collections> result = new List<Fuzzy_functions_collections>();
                int con_index = last_Column.Index;

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
                    a_Rule = new Mandani_If_Then_Fuzzy_Rule(antecedent, conclusion_FS);
                    result.Add(a_Rule.Fuzzy_In_Fuzzy_Out_Inferencing(coditions, RDB_Cut.Checked));
                    // adding fuzzy sets in to list
                    result[i].Generate_Series();

                }

                for (int i = 0; i < result.Count; i++)
                {
                    // generate final fuzzy set by union list
                    if (i == 0) inference_Result_Fuzzy_Set = result[0];
                    inference_Result_Fuzzy_Set = inference_Result_Fuzzy_Set | result[i];
                }

                // add final fuzzy set
                inference_Result_Fuzzy_Set.Set_Series(Color.FromArgb(128, Color.Gray), SeriesChartType.Area);
                inference_Result_Fuzzy_Set.Name = "Inference";
                Main_Chart.Series.Add(inference_Result_Fuzzy_Set.Plot_Graph());
                #endregion
            }
            else if (RB_SFS.Checked)
            {
                #region SFS
                #endregion
            }
        }

        private void BTN_Delete_Rules_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.DGV_Rules.SelectedRows)
            {
                DGV_Rules.Rows.RemoveAt(item.Index);
            }
        }

       
        private void BTN_Add_Rules_Click(object sender, EventArgs e)
        {
            DGV_Rules.Rows.Add();
        }
        private void BTN_add_equation_Click(object sender, EventArgs e)
        {
            int equation_ID = listBox1.SelectedIndex;

            TreeNode TN = new TreeNode($"equation {equation_ID}");
            TN.ImageKey = "FS";
            TN.SelectedImageKey = "FS";

            TN.Tag = equation_ID;
            TN.Text = listBox1.Items[equation_ID].ToString();
            TV_Display.SelectedNode.Nodes.Add(TN);
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
                    uofs = ~fs;
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
                    uofs = 0.5 - fs;
                    break;
                case "Value Scale":
                    uofs = 0.5 * fs;
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
            if (Main_Chart.Series.FindByName(uofs.Plot_Graph().Name) != null)
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
                if (seleted_Node.Level == 0)
                {
                    // area
                    Main_Chart.ChartAreas.Remove(Get_Chart_Area_by_Xaxis_Title(seleted_Node.Text));
                    // fuzzy set
                    Main_Chart.Series.Remove(Get_Series_by_name(seleted_Node.Text));


                    // grid view
                    if (DGV_Rules.Columns[seleted_Node.Text] != null)
                        DGV_Rules.Columns.Remove(seleted_Node.Text);
                    if (DGV_Conditions.Columns[seleted_Node.Text] != null)
                        DGV_Conditions.Columns.Remove(seleted_Node.Text);
                }
            }

            if (TV_Display.Nodes[0].Nodes.Count == 0 || TV_Display.Nodes[1].Nodes.Count == 0)
            {
                // disable GB
                GB_PFS.Enabled = false;
                GB_BO.Enabled = false;
                GB_UO.Enabled = false;

                //GB_Rules.Enabled = false;
                //GB_Conditions.Enabled = false;
            }

            // arrange defuzzy chart
            if (TV_Display.Nodes[0].Nodes.Count == 1)
            {
                TBC_Defuzzy.TabPages.Clear();
                TBC_Defuzzy.TabPages.Add(TB_1D);
            }
            else if (TV_Display.Nodes[0].Nodes.Count == 2)
            {
                TBC_Defuzzy.TabPages.Clear();
                TBC_Defuzzy.TabPages.Add(TB_2D);
            }
            else
            {
                TBC_Defuzzy.TabPages.Clear();
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
                case "Trapzoidal":
                    FFC = new Trapzoidal_function(FDA);
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

                if (last_Column != null) last_Column.DisplayIndex = DGV_Rules.ColumnCount - 1;
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
            }

            // arrange defuzzy chart
            if (TV_Display.Nodes[0].Nodes.Count == 1)
            {
                TBC_Defuzzy.TabPages.Clear();
                TBC_Defuzzy.TabPages.Add(TB_1D);
            }
            else if (TV_Display.Nodes[0].Nodes.Count == 2)
            {
                TBC_Defuzzy.TabPages.Clear();
                TBC_Defuzzy.TabPages.Add(TB_2D);
            }
            else
            {
                TBC_Defuzzy.TabPages.Clear();
            }
        }
        
        private void BTN_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            Save_Model(dlg.FileName);
        }
        private void BTN_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            Open_Model(dlg.FileName);
        }
        #endregion


        #region Model Save and Read
        public void Save_Model(string file_path)
        {
            StreamWriter sw = new StreamWriter(file_path);
            if (RB_MFS.Checked)
                sw.WriteLine($"Model:Mandani");
            else if(RB_SFS.Checked)
                sw.WriteLine($"Model:Sugeon");
            else
                sw.WriteLine($"Model:Tsukamoto");

            // store universe and  FS via treeview
            int Input_Uni_number = TV_Display.Nodes[0].Nodes.Count;
            sw.WriteLine($"NumberOfInputUniverse:{Input_Uni_number}");
            Fuzzy_display_area FDA;
            for (int i = 0; i < Input_Uni_number; i++)
            {
                FDA = TV_Display.Nodes[0].Nodes[i].Tag as Fuzzy_display_area;
                FDA.Save_Model(sw);

                int FS_number = TV_Display.Nodes[0].Nodes[i].Nodes.Count;
                sw.WriteLine($"NumberOfFuzzySets:{FS_number}");
                for (int j = 0; j < FS_number; j++)
                {
                    Fuzzy_functions_collections ffc = TV_Display.Nodes[0].Nodes[i].Nodes[j].Tag as Fuzzy_functions_collections;
                    Type type_Of_FFC = ffc.GetType();
                    sw.WriteLine($"FSTypeName:{type_Of_FFC}");

                    ffc.Save_Model(sw);
                }
            }
            // example fo MFS
            // creat rule array to update rules of fuzzy system
            List<Mandani_If_Then_Fuzzy_Rule> m_rules = new List<Mandani_If_Then_Fuzzy_Rule>() ;
            // loop though dgv to set rule
            MFS.Update_Rule_Sets(m_rules);
            MFS.Save_Model(sw);
            // save condition info for the user

            sw.Close();
        }
        public void Open_Model(string file_path)
        {
            StreamReader sr = new StreamReader(file_path);
            string str;
            string model_Type;
            str=sr.ReadLine().Trim();
            model_Type=str.Substring(str.IndexOf(':')+1);

            switch (model_Type)
            {
                case "Mandani":
                    RB_MFS.Checked = true;
                    break;
                case "Sugeon":
                    RB_SFS.Checked = true;
                    break;
                case "Tsukamoto":
                    RB_TFS.Checked = true;
                    break;
                default:
                    break;
            }
            int Input_Uni_number;
            str = sr.ReadLine().Trim();
            Input_Uni_number = int.Parse(str.Substring(str.IndexOf(':') + 1));
            TV_Display.Nodes[0].Nodes.Clear();
            Fuzzy_display_area FDA;
            for (int i = 0; i < Input_Uni_number; i++)
            {
                FDA = new Fuzzy_display_area(Main_Chart);
                TreeNode tn = new TreeNode("");
                FDA.Set_Tree_Node(tn);
                TV_Display.Nodes[0].Nodes.Add(tn);

                FDA.Read_Model(sr);
                //tn.Text = FDA.Name;

                str = sr.ReadLine().Trim();
                int FS_number = int.Parse(str.Substring(str.IndexOf(':') + 1));
                for (int j = 0; j < FS_number; j++)
                {
                    str = sr.ReadLine().Trim();
                    str = str.Substring(str.IndexOf(':') + 1); // fs type name
                    // instance a particular type of FS
                    Assembly asmb = Assembly.LoadFrom("Fuzzy_Graph_Library.dll");
                    Type type_Of_FFC = asmb.GetType(str);
                    Fuzzy_functions_collections ffc = (Fuzzy_functions_collections) Activator.CreateInstance(type_Of_FFC, FDA);
                    // create tree node
                    TreeNode a_Node = new TreeNode(ffc.Name);
                    TV_Display.Nodes[0].Nodes[i].Nodes.Add(a_Node);
                    ffc.Set_Tree_Node(a_Node);


                    ffc.Read_Model(sr);
                }

            }
            // ask MFS to read its data
            MFS.Read_Model(sr);
            // populate DGV 

            sr.Close();
        }

        #endregion

        private void RB_MFS_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_MFS.Checked)
            {
                PPGV_System.SelectedObject = MFS;
                TBC_main.TabPages.Remove(TP_Sugeon_Conclusion);
            }

            Chart_Defuzzy.Series.Clear();

        }

        private void RB_SFS_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SFS.Checked)
            {
                PPGV_System.SelectedObject = SFS;
                TBC_main.TabPages.Add(TP_Sugeon_Conclusion);
            }
            Chart_Defuzzy.Series.Clear();

        }

        private void RB_TFS_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_TFS.Checked)
            {
                PPGV_System.SelectedObject = TFS;
                TBC_main.TabPages.Remove(TP_Sugeon_Conclusion);
            }

            Chart_Defuzzy.Series.Clear();

        }

        private void BTN_Defuzzy_Click(object sender, EventArgs e)
        {
            Fuzzy_display_area fda;
            Series s = new Series();
            s.ChartType = SeriesChartType.Line;
            s.BorderWidth = 2;
            s.Color = Color.Red;
            Read_DGV_Rules();

            if (RB_MFS.Checked)
            {
                #region Mandani
                // read rules
                List<Fuzzy_functions_collections> results = new List<Fuzzy_functions_collections>();     
                double value;
                
                fda = MFS.All_Rules[0].Antecedent[0].Fda;
                for (double j = fda.Minimum; j < fda.Maximum; j = j + fda.Incensement)
                {
                    results.Clear();
                    
                    double[] d = new double[1];
                    d[0] = j;
                    value =  MFS.Crisp_In_Crisp_Out_Inferencing(d,RDB_Cut.Checked);
                   
                    s.Points.AddXY(j, value);
                }
                switch (MFS.Defuzzy_Type)
                {
                    case Defuzzification.COA:
                        s.Color = Color.Green;
                        break;
                    case Defuzzification.BOA:
                        s.Color = Color.Red;
                        break;
                    case Defuzzification.MOM:
                        s.Color = Color.Yellow;
                        break;
                    case Defuzzification.SOM:
                        s.Color = Color.Blue;
                        break;
                    case Defuzzification.LOM:
                        s.Color = Color.Magenta;
                        break;
                    default:
                        break;
                }               
                s.Name = MFS.Defuzzy_Type.ToString();
                if (Chart_Defuzzy.Series.FindByName(s.Name) != null) Chart_Defuzzy.Series.Remove(Chart_Defuzzy.Series.FindByName(s.Name));
                Chart_Defuzzy.Series.Add(s);
                #endregion
            }
            else if (RB_SFS.Checked)
            {    
                #region Sugenon
                double value;
                fda = SFS.All_Rules[0].Antecedent[0].Fda;
                for (double j = fda.Minimum; j < fda.Maximum; j = j + fda.Incensement)
                {
                    double[] input = new double[1];
                    input[0] = j;
                    value = SFS.Crisp_In_Crisp_Out_Inferencing(input);
                    // switch type

                    s.Points.AddXY(j, value);
                }
                s.Name = "Sugeon";
                #endregion
            }
            else
            {
                #region Tsukamoto
                // read rules
                
                List<double> results = new List<double>();
                int con_index = last_Column.Index;
                double value;


                fda = TFS.All_Rules[0].Antecedent[0].Fda;

                for (double j = fda.Minimum; j < fda.Maximum; j = j + fda.Incensement)
                {
                    double[] input = new double[1];
                    input[0] = j;
                    value = TFS.Crisp_In_Crisp_Out_Inferencing(input);
                    // switch type

                    s.Points.AddXY(j, value);
                }
                s.Name = "Tsukamoto";
                #endregion
            }
            if (Chart_Defuzzy.Series.FindByName(s.Name) != null) Chart_Defuzzy.Series.Remove(Chart_Defuzzy.Series.FindByName(s.Name));
            Chart_Defuzzy.Series.Add(s);
            Chart_Defuzzy.Update();
            Chart_Defuzzy.Invalidate();
            Chart_Defuzzy.ChartAreas[0].RecalculateAxesScale();
        }

        private void BTN_Two_D_Defuzzy_Click(object sender, EventArgs e)
        {
            Fuzzy_display_area fda_01 = null;
            Fuzzy_display_area fda_02 = null;
            double[] d = new double[2];
            Read_DGV_Rules();
            if (RB_MFS.Checked)
            {
                #region MFS
                // read rules               
                List<Fuzzy_functions_collections> results = new List<Fuzzy_functions_collections>();
                double value;
                fda_01 = MFS.All_Rules[0].Antecedent[0].Fda;
                fda_02 = MFS.All_Rules[0].Antecedent[1].Fda;
                for (double x = fda_01.Minimum; x < fda_01.Maximum; x = x + 10 * fda_01.Incensement)
                {
                    for (double z = fda_02.Minimum; z < fda_02.Maximum; z = z + 10 * fda_02.Incensement)
                    {
                        
                        d[0] = x;
                        d[1] = z;
                        value = MFS.Crisp_In_Crisp_Out_Inferencing(d, RDB_Cut.Checked);

                        surface1.Add(x, value, z);
                    }

                }
                //surface1.Color = Color.Red;

                #endregion
            }
            else if (RB_SFS.Checked)
            {
                #region SFS
                // read rules               
                double value;

                fda_01 = SFS.All_Rules[0].Antecedent[0].Fda;
                fda_02 = SFS.All_Rules[0].Antecedent[1].Fda;
                for (double x = fda_01.Minimum; x < fda_01.Maximum; x = x + 10 * fda_01.Incensement)
                {
                    for (double z = fda_02.Minimum; z < fda_02.Maximum; z = z + 10 * fda_02.Incensement)
                    {
                        d[0] = x;
                        d[1] = z;
                        value = SFS.Crisp_In_Crisp_Out_Inferencing(d);
                        surface1.Add(x, value, z);
                    }

                }
                #endregion
            }
            else
            {
                #region TFS
                double value;

                fda_01 = TFS.All_Rules[0].Antecedent[0].Fda;
                fda_02 = TFS.All_Rules[0].Antecedent[1].Fda;
                for (double x = fda_01.Minimum; x < fda_01.Maximum; x = x + 10 * fda_01.Incensement)
                {
                    for (double z = fda_02.Minimum; z < fda_02.Maximum; z = z + 10 * fda_02.Incensement)
                    {
                        d[0] = x;
                        d[1] = z;
                        value = TFS.Crisp_In_Crisp_Out_Inferencing(d);
                        surface1.Add(x, value, z);
                    }

                }
                #endregion
            }
            surface1.NumXValues = fda_01.Resolution;
            surface1.NumZValues = fda_02.Resolution;
            TChart.Series.Add(surface1);
            TChart.Invalidate();
            TChart.Update();
            
        }
    }
}
