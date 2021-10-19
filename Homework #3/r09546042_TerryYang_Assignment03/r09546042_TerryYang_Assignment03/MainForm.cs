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
        }
       

        //private void TCB_main_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //sync listbox and combobox selection
        //    //LSB_Graph_Type.SelectedIndex = TCB_main.SelectedIndex;
        //    After_LSB_or_TCB_Change();
        //}


        //private void LSB_Graph_Type_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //sync listbox and combobox selection
        //    //TCB_main.SelectedIndex = LSB_Graph_Type.SelectedIndex;
        //    After_LSB_or_TCB_Change();
        //}
        //public void After_LSB_or_TCB_Change()
        //{
        //    //high light selected series
        //    //CB_Plot_graph.Checked = false;

        //    for (int i = 0; i < Main_Chart.Series.Count; i++)
        //        Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;

        //    //if (Get_Selected_Series_Name() != null)
        //    //    Get_Selected_Series_Name().MarkerStyle = MarkerStyle.Cross;

        //    //String Graph_Type = TCB_main.Text;
        //    //Arrange_UI_for_Input(Graph_Type);
        //    //Input_Check(Graph_Type);
        //    //if (Get_Selected_Series_Name() != null)
        //        //Plot_Series(Graph_Type);
        //}

        public void Plot_Series()
        {
            //if (Get_Selected_Series_Name() != null)
            //    Main_Chart.Series.Remove(Get_Selected_Series_Name());
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
                    FFC = new Gaussian_function(FDA, FDA.Resolution);                    
                    break;

                case "Bell":
                    FFC = new Bell_function(FDA, FDA.Resolution);
                    break;

                case "Sigmoidal":
                    FFC = new Sigmoidal_function(FDA, FDA.Resolution);
                    break;

                case "LeftRight":
                    FFC = new LeftRight_function(FDA, FDA.Resolution);
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

            //Main_Chart.Series[Main_Chart.Series.Count - 1].MarkerStyle = MarkerStyle.Cross;
            FDA.Get_Chart_Area().RecalculateAxesScale();
            FDA.Get_Chart_Area().AxisX.LabelStyle.Format = "{n2}";
            Main_Chart.Update();
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
        private void BTN_delete_area_Click(object sender, EventArgs e)
        {
            // delete selecte area or series in tree and chart
            TreeNode seleted_Node = TV_Display.SelectedNode;
            if (seleted_Node != null)
            {
                TV_Display.Nodes.Remove(seleted_Node);
                Main_Chart.ChartAreas.Remove(Get_Chart_Area_by_Xaxis_Title(seleted_Node.Text));
                Main_Chart.Series.Remove(Get_Series_by_name(seleted_Node.Text));
            }
        }

        private void TV_Display_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // SNAC Tree view and property gird view
            PPGV_parameters.SelectedObject = e.Node.Tag;

            // highlight selected chart area 
            for (int i = 0; i < Main_Chart.ChartAreas.Count; i++)
            {
                Main_Chart.ChartAreas[i].BackColor = Color.White;
            }
            if (Get_Chart_Area_by_Xaxis_Title(TV_Display.SelectedNode.Text) == null)
                return;
            else
                Get_Chart_Area_by_Xaxis_Title(TV_Display.SelectedNode.Text).BackColor = Color.LightGray;

            // highlight selected series 
            for (int i = 0; i < Main_Chart.Series.Count; i++)
            {
                Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;
            }
            if (Get_Series_by_name(TV_Display.SelectedNode.Text) == null)
                return;
            else
                Get_Series_by_name(TV_Display.SelectedNode.Text).MarkerStyle = MarkerStyle.Cross;
        }

        private void BTN_add_function_Click(object sender, EventArgs e)
        {
            // add function button click, than plot series
            Plot_Series();
        }


        private void PPGV_parameters_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //Delete_Exist_Series();
            //Plot_Series();
        }

        private void CB_fuzzy_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            LSB_fuzzy_type.SelectedIndex = CB_fuzzy_type.SelectedIndex;
            // swtich function pic via combo box
            switch (CB_fuzzy_type.Text)
            {
                case "Triangular":
                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Triangular_function;
                    break;
                case "Bell":
                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Bell_function;
                    break;
                case "Gaussian":
                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Gaussian_function;
                    break;
                case "Sigmoidal":
                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Sigmoidal_function;
                    break;
                case "LeftRight":
                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.LeftRight_function;
                    break;
                default:
                    break;
            }
        }

        private void LSB_fuzzy_type_SelectedIndexChanged(object sender, EventArgs e)
        {
              CB_fuzzy_type.SelectedIndex = LSB_fuzzy_type.SelectedIndex;
        }
    }
}
