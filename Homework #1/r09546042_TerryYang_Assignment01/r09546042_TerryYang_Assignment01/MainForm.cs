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
        public MainForm()
        {
            InitializeComponent();
            Main_Chart.Series.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TB_a.Text);
            double b = Convert.ToDouble(TB_b.Text);
            double c = Convert.ToDouble(TB_c.Text);

            double mean = Convert.ToDouble(TB_mean.Text);
            double sigma = Convert.ToDouble(TB_sigma.Text);
            double resolution = Convert.ToDouble(TB_res.Text);

            double a_01 = Convert.ToDouble(TB_a_01.Text);
            double b_01 = Convert.ToDouble(TB_b_01.Text);
            double c_01 = Convert.ToDouble(TB_c_01.Text);
            double resolution_01 = Convert.ToDouble(TB_res_01.Text);

            string Graph_Type = tabControl1.SelectedTab.Name;
            string Type_char = Graph_Type.Substring(0, 1);

            Series Existied_Series;
            Existied_Series = Main_Chart.Series.FindByName(Type_char+"-series");
            if (Existied_Series != null)
                Main_Chart.Series.Remove(Existied_Series);

            switch (Graph_Type)
            {
                case "T_graph":
                    T_Graph T = new T_Graph(a, b, c);
                    T_series = T.Plot_Graph();
                    Main_Chart.Series.Add(T_series);
                    break;

                case "G_graph":
                    G_Graph G = new G_Graph(mean, sigma, resolution);
                    G_series = G.Plot_Graph();
                    Main_Chart.Series.Add(G_series);
                    break;

                case "B_graph":
                    B_Graph B = new B_Graph(a_01, b_01, c_01, resolution_01);
                    B_series = B.Plot_Graph();
                    Main_Chart.Series.Add(B_series);
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
            string Graph_Type = tabControl1.SelectedTab.Name;
            string Type_char = Graph_Type.Substring(0, 1);

            Series Existied_Series;
            Existied_Series = Main_Chart.Series.FindByName(Type_char + "-series");
            if (Existied_Series != null)
                Main_Chart.Series.Remove(Existied_Series);
        }
    }
}
