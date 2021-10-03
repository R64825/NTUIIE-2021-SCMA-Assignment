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
            string Graph_Type = TC_main.SelectedTab.Name;
            Series Existied_Series;
            Existied_Series = Main_Chart.Series.FindByName(Graph_Type);
            return Existied_Series;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tri_a = Convert.ToDouble(TB_a.Text);
            double tri_b = Convert.ToDouble(TB_b.Text);
            double tri_c = Convert.ToDouble(TB_c.Text);

            double gas_mean = Convert.ToDouble(TB_mean.Text);
            double gas_sigma = Convert.ToDouble(TB_sigma.Text);
            double res_gas = Convert.ToDouble(TB_res.Text);

            double bel_a = Convert.ToDouble(TB_a_01.Text);
            double bel_b = Convert.ToDouble(TB_b_01.Text);
            double bel_c = Convert.ToDouble(TB_c_01.Text);
            double res_bel = Convert.ToDouble(TB_res_01.Text);

            double sig_a = Convert.ToDouble(TB_sig_a.Text);
            double sig_c = Convert.ToDouble(TB_sig_c.Text);
            double res_sig = Convert.ToDouble(TB_sig_res.Text);

            double Lef_c = Convert.ToDouble(TB_lef_c.Text);
            double Lef_alpha = Convert.ToDouble(TB_lef_alpha.Text);
            double Lef_beta = Convert.ToDouble(TB_lef_beta.Text);
            double res_Lef = Convert.ToDouble(TB_lef_res.Text);


            if (Get_Selected_Series_Name() != null)
                Main_Chart.Series.Remove(Get_Selected_Series_Name());

            string Graph_Type = TC_main.SelectedTab.Name;
            switch (Graph_Type)
            {
                case "Triangular_Series":
                    if (tri_a > tri_b || tri_b > tri_c)
                    {
                        MessageBox.Show("Condition: a<b<c is needed");
                    }
                    else
                    {
                        Triangular_function T = new Triangular_function(tri_a, tri_b, tri_c);
                        T_series = T.Plot_Graph();
                        Main_Chart.Series.Add(T_series);
                    }
                    break;

                case "Gaussian_Series":
                    if (gas_sigma <= 0)
                    {
                        MessageBox.Show("Condition: sigma≥0 is needed");
                    }
                    else
                    {
                        Gaussian_function G = new Gaussian_function(gas_mean, gas_sigma, res_gas);
                        G_series = G.Plot_Graph();
                        Main_Chart.Series.Add(G_series);
                    }

                    break;

                case "Bell_Series":
                    if (bel_a == 0)
                    {
                        MessageBox.Show("Condition: a≠0 is needed");
                    }
                    else if (bel_b <= 0)
                    {
                        MessageBox.Show("Condition: b≥0 is needed");
                    }
                    else
                    {
                        Bell_function B = new Bell_function(bel_a, bel_b, bel_c, res_bel);
                        B_series = B.Plot_Graph();
                        Main_Chart.Series.Add(B_series);
                    }
                    break;

                case "Sigmoidal_Series":
                    Sigmoidal_function S = new Sigmoidal_function(sig_a, sig_c, res_sig);
                    S_series = S.Plot_Graph();
                    Main_Chart.Series.Add(S_series);
                    break;

                case "LeftRight_Series":
                    LeftRight_function L = new LeftRight_function(Lef_alpha, Lef_beta, Lef_c, res_Lef);
                    L_series = L.Plot_Graph();
                    Main_Chart.Series.Add(L_series);
                    break;

                default:
                    //New_series = null;
                    break;
            }
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
            TC_main.SelectedIndex = TCB_main.SelectedIndex;

            for (int i = 0; i < Main_Chart.Series.Count; i++)
                Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;

            if (Get_Selected_Series_Name() != null)
                Get_Selected_Series_Name().MarkerStyle = MarkerStyle.Cross;
        }


        private void TC_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            TCB_main.SelectedIndex = TC_main.SelectedIndex;

            for (int i = 0; i < Main_Chart.Series.Count; i++)
                Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;

            if (Get_Selected_Series_Name() != null)
                Get_Selected_Series_Name().MarkerStyle = MarkerStyle.Cross;
        }
    }
}
