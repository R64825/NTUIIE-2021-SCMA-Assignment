using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Fuzzy_Graph_Library;


namespace r09546042_TerryYang_Assignment01
{
    public partial class MainForm : Form
    {
        Series T_series;
        Series G_series;
        Series B_series;
        Series S_series;
        Series L_series;
        public MainForm()
        {
            InitializeComponent();
            Main_Chart.Series.Clear();
        }

        
        public Series Get_Selected_Series_Name()
        {
            // return selected series in list box
            string Graph_Type = TCB_main.Text;
            string Graph_name = Graph_Type + "_Series";
            Series Existied_Series=null;
            Existied_Series = Main_Chart.Series.FindByName(Graph_name);
            return Existied_Series;
        }
       
        public void Arrange_UI_for_Input(string Graph_Type)
        {
            // hide or show Textbox, label, picture 
            TB_parameter_01.Visible = true;
            TB_parameter_02.Visible = true;
            TB_parameter_03.Visible = true;
            TB_parameter_04.Visible = true;

            LB_parameter_01.Visible = true;
            LB_parameter_02.Visible = true;
            LB_parameter_03.Visible = true;
            LB_parameter_04.Visible = true;

            switch (Graph_Type)
            {
                case "Triangular":// 3 inputs
                    TB_parameter_04.Visible = false;
                    LB_parameter_04.Visible = false;
                    Triangular_function t = new Triangular_function();
                    LB_parameter_01.Text = t.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = t.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = t.Return_Parameters_Names()[2];

                    TB_parameter_01.Text = t.Return_parameter_Suggestion()[0].ToString();
                    TB_parameter_02.Text = t.Return_parameter_Suggestion()[1].ToString();
                    TB_parameter_03.Text = t.Return_parameter_Suggestion()[2].ToString();

                    PB_function.Image = r09546042_TerryYang_Assignment02.Properties.Resources.Triangular_function;
                    break;

                case "Gaussian":// 2+1 inputs
                    TB_parameter_04.Visible = false;
                    LB_parameter_04.Visible = false;
                    Gaussian_function g = new Gaussian_function();
                    LB_parameter_01.Text = g.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = g.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = g.Return_Parameters_Names()[2];

                    TB_parameter_01.Text = g.Return_parameter_Suggestion()[0].ToString();
                    TB_parameter_02.Text = g.Return_parameter_Suggestion()[1].ToString();
                    TB_parameter_03.Text = g.Return_parameter_Suggestion()[2].ToString();

                    PB_function.Image = r09546042_TerryYang_Assignment02.Properties.Resources.Gaussian_function;
                    break;

                case "Bell":// 3+1
                    Bell_function b = new Bell_function();
                    LB_parameter_01.Text = b.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = b.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = b.Return_Parameters_Names()[2];
                    LB_parameter_04.Text = b.Return_Parameters_Names()[3];

                    TB_parameter_01.Text = b.Return_parameter_Suggestion()[0].ToString();
                    TB_parameter_02.Text = b.Return_parameter_Suggestion()[1].ToString();
                    TB_parameter_03.Text = b.Return_parameter_Suggestion()[2].ToString();
                    TB_parameter_04.Text = b.Return_parameter_Suggestion()[3].ToString();

                    PB_function.Image = r09546042_TerryYang_Assignment02.Properties.Resources.Bell_function;
                    break;

                case "Sigmoidal"://2+1
                    TB_parameter_04.Visible = false;
                    LB_parameter_04.Visible = false;
                    Sigmoidal_function s = new Sigmoidal_function();
                    LB_parameter_01.Text = s.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = s.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = s.Return_Parameters_Names()[2];

                    TB_parameter_01.Text = s.Return_parameter_Suggestion()[0].ToString();
                    TB_parameter_02.Text = s.Return_parameter_Suggestion()[1].ToString();
                    TB_parameter_03.Text = s.Return_parameter_Suggestion()[2].ToString();
                    PB_function.Image = r09546042_TerryYang_Assignment02.Properties.Resources.Sigmoidal_function;
                    break;

                case "LeftRight"://3+1
                    LeftRight_function l = new LeftRight_function();
                    LB_parameter_01.Text = l.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = l.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = l.Return_Parameters_Names()[2];
                    LB_parameter_04.Text = l.Return_Parameters_Names()[3];

                    TB_parameter_01.Text = l.Return_parameter_Suggestion()[0].ToString();
                    TB_parameter_02.Text = l.Return_parameter_Suggestion()[1].ToString();
                    TB_parameter_03.Text = l.Return_parameter_Suggestion()[2].ToString();
                    TB_parameter_04.Text = l.Return_parameter_Suggestion()[3].ToString();
                    PB_function.Image = r09546042_TerryYang_Assignment02.Properties.Resources.LeftRight_function;
                    break;

                default:
                    //New_series = null;
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double parameter_01 = Convert.ToDouble( TB_parameter_01.Text);
            double parameter_02 = Convert.ToDouble(TB_parameter_02.Text);
            double parameter_03 = Convert.ToDouble(TB_parameter_03.Text);
            double parameter_04 = Convert.ToDouble(TB_parameter_04.Text);


            if (Get_Selected_Series_Name() != null)
                Main_Chart.Series.Remove(Get_Selected_Series_Name());

            string Graph_Type = TCB_main.Text;
            switch (Graph_Type)
            {
                case "Triangular":
                    Triangular_function T = new Triangular_function(parameter_01, parameter_02, parameter_03);
                    T_series = T.Plot_Graph();
                    Main_Chart.Series.Add(T_series);
                    break;

                case "Gaussian":
                    Gaussian_function G = new Gaussian_function(parameter_01, parameter_02, parameter_03);
                    G_series = G.Plot_Graph();
                    Main_Chart.Series.Add(G_series);
                    break;

                case "Bell":
                    Bell_function B = new Bell_function(parameter_01, parameter_02, parameter_03, parameter_04);
                    B_series = B.Plot_Graph();
                    Main_Chart.Series.Add(B_series);
                    break;

                case "Sigmoidal":
                    Sigmoidal_function S = new Sigmoidal_function(parameter_01, parameter_02, parameter_03);
                    S_series = S.Plot_Graph();
                    Main_Chart.Series.Add(S_series);
                    break;

                case "LeftRight":
                    LeftRight_function L = new LeftRight_function(parameter_01, parameter_02, parameter_03, parameter_04);
                    L_series = L.Plot_Graph();
                    Main_Chart.Series.Add(L_series);
                    break;

                default:
                    //New_series = null;
                    break;
            }
            Main_Chart.Series[Main_Chart.Series.Count-1].MarkerStyle = MarkerStyle.Cross;
            Main_Chart.ChartAreas[0].RecalculateAxesScale();
            Main_Chart.Update();
        }

        private void BTN_clear_Click(object sender, EventArgs e)
        {
            if (Get_Selected_Series_Name() != null)
                Main_Chart.Series.Remove(Get_Selected_Series_Name());
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LSB_Graph_Type.SelectedIndex = TCB_main.SelectedIndex;

            for (int i = 0; i < Main_Chart.Series.Count; i++)
                Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;

            if (Get_Selected_Series_Name() != null)
                Get_Selected_Series_Name().MarkerStyle = MarkerStyle.Cross;

            Arrange_UI_for_Input(TCB_main.Text);
        }


        private void LSB_Graph_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            TCB_main.SelectedIndex = LSB_Graph_Type.SelectedIndex;

            for (int i = 0; i < Main_Chart.Series.Count; i++)
                Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;

            if (Get_Selected_Series_Name() != null)
                Get_Selected_Series_Name().MarkerStyle = MarkerStyle.Cross;

            Arrange_UI_for_Input(TCB_main.Text);
        }
    }
}
