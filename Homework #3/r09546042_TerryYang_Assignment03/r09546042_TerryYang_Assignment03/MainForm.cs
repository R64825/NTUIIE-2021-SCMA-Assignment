using Fuzzy_Graph_Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace r09546042_TerryYang_Assignment01
{
    public partial class MainForm : Form
    {
        Series T_series;
        Series G_series;
        Series B_series;
        Series S_series;
        Series L_series;
        List<TrackBar> TKB_paras;
        List<NumericUpDown> NUM_paras;

        public MainForm()
        {
            InitializeComponent();
            Main_Chart.Series.Clear();
            Setup_UI();


        }
        public void Setup_UI()
        {
            // group up track_bar & Numerical_Up_Down
            TKB_paras = new List<TrackBar>();
            NUM_paras = new List<NumericUpDown>();

            TKB_paras.Add(TKB_para_01);
            TKB_paras.Add(TKB_para_02);
            TKB_paras.Add(TKB_para_03);
            TKB_paras.Add(TKB_para_04);

            NUM_paras.Add(NUD_parameter_01);
            NUM_paras.Add(NUD_parameter_02);
            NUM_paras.Add(NUD_parameter_03);
            NUM_paras.Add(NUD_parameter_04);

            // setup checkbox as button 
            CB_Plot_graph.Appearance = Appearance.Button;

            LSB_Graph_Type.SelectedIndex = 1;
            LSB_Graph_Type.SelectedIndex = 0;

            //Stream str = r09546042_TerryYang_Assignment03.Properties.Resources.Rick_roll;
            //RecordPlayer rp = new RecordPlayer();
            //rp.Open(new WaveReader(str));
            //rp.Play();

            //SoundPlayer audio = new SoundPlayer(r09546042_TerryYang_Assignment03.Properties.Resources.Rick_roll); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            //audio.Load();
            //audio.Play();
        }
        public Series Get_Selected_Series_Name()
        {
            // return selected series in Tool combo box
            string Graph_Type = TCB_main.Text;
            string Graph_name = Graph_Type + "_Series";
            Series Existied_Series = null;
            Existied_Series = Main_Chart.Series.FindByName(Graph_name);
            return Existied_Series;
        }

        public void Arrange_UI_for_Input(string Graph_Type)
        {
            // hide or show Textbox, label, picture            
            NUD_parameter_04.Visible = true;
            LB_parameter_04.Visible = true;
            TKB_para_04.Visible = true;
            NumericUpDown NUD_res = new NumericUpDown();
            List<NumericUpDown> NUD_parameters = new List<NumericUpDown>();
            switch (Graph_Type)
            {
                case "Triangular":// 3 inputs
                    NUD_parameter_04.Visible = false;
                    LB_parameter_04.Visible = false;
                    TKB_para_04.Visible = false;
                    Triangular_function t = new Triangular_function();
                    LB_parameter_01.Text = t.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = t.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = t.Return_Parameters_Names()[2];

                    NUD_parameter_01.Text = t.Return_parameter_Suggestion()[0].ToString();
                    NUD_parameter_02.Text = t.Return_parameter_Suggestion()[1].ToString();
                    NUD_parameter_03.Text = t.Return_parameter_Suggestion()[2].ToString();

                    NUD_parameters.Add(NUD_parameter_01);
                    NUD_parameters.Add(NUD_parameter_02);
                    NUD_parameters.Add(NUD_parameter_03);

                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Triangular_function;
                    break;

                case "Gaussian":// 2+1 inputs
                    NUD_parameter_04.Visible = false;
                    LB_parameter_04.Visible = false;
                    TKB_para_04.Visible = false;
                    Gaussian_function g = new Gaussian_function();
                    LB_parameter_01.Text = g.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = g.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = g.Return_Parameters_Names()[2];

                    NUD_parameter_01.Text = g.Return_parameter_Suggestion()[0].ToString();
                    NUD_parameter_02.Text = g.Return_parameter_Suggestion()[1].ToString();
                    NUD_parameter_03.Text = g.Return_parameter_Suggestion()[2].ToString();
                    NUD_parameters.Add(NUD_parameter_01);
                    NUD_parameters.Add(NUD_parameter_02);
                    NUD_res = NUD_parameter_03;

                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Gaussian_function;
                    break;

                case "Bell":// 3+1
                    Bell_function b = new Bell_function();
                    LB_parameter_01.Text = b.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = b.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = b.Return_Parameters_Names()[2];
                    LB_parameter_04.Text = b.Return_Parameters_Names()[3];

                    NUD_parameter_02.Text = b.Return_parameter_Suggestion()[1].ToString();
                    NUD_parameter_01.Text = b.Return_parameter_Suggestion()[0].ToString();                   
                    NUD_parameter_03.Text = b.Return_parameter_Suggestion()[2].ToString();
                    NUD_parameter_04.Text = b.Return_parameter_Suggestion()[3].ToString();
                    NUD_parameters.Add(NUD_parameter_01);
                    NUD_parameters.Add(NUD_parameter_02);
                    NUD_parameters.Add(NUD_parameter_03);
                    NUD_res = NUD_parameter_04;

                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Bell_function;
                    break;

                case "Sigmoidal"://2+1
                    NUD_parameter_04.Visible = false;
                    LB_parameter_04.Visible = false;
                    TKB_para_04.Visible = false;
                    Sigmoidal_function s = new Sigmoidal_function();
                    LB_parameter_01.Text = s.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = s.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = s.Return_Parameters_Names()[2];

                    NUD_parameter_02.Text = s.Return_parameter_Suggestion()[1].ToString();
                    NUD_parameter_01.Text = s.Return_parameter_Suggestion()[0].ToString();                   
                    NUD_parameter_03.Text = s.Return_parameter_Suggestion()[2].ToString();
                    NUD_parameters.Add(NUD_parameter_01);
                    NUD_parameters.Add(NUD_parameter_02);
                    NUD_res = NUD_parameter_03;
                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.Sigmoidal_function;
                    break;

                case "LeftRight"://3+1
                    LeftRight_function l = new LeftRight_function();
                    LB_parameter_01.Text = l.Return_Parameters_Names()[0];
                    LB_parameter_02.Text = l.Return_Parameters_Names()[1];
                    LB_parameter_03.Text = l.Return_Parameters_Names()[2];
                    LB_parameter_04.Text = l.Return_Parameters_Names()[3];

                    NUD_parameter_01.Text = l.Return_parameter_Suggestion()[0].ToString();
                    NUD_parameter_02.Text = l.Return_parameter_Suggestion()[1].ToString();
                    NUD_parameter_03.Text = l.Return_parameter_Suggestion()[2].ToString();
                    NUD_parameter_04.Text = l.Return_parameter_Suggestion()[3].ToString();
                    NUD_parameters.Add(NUD_parameter_01);
                    NUD_parameters.Add(NUD_parameter_02);
                    NUD_parameters.Add(NUD_parameter_03);
                    NUD_res = NUD_parameter_04;
                    PB_function.Image = r09546042_TerryYang_Assignment03.Properties.Resources.LeftRight_function;
                    break;

                default:
                    break;
            }
            NUD_res.DecimalPlaces = 0;
            NUD_res.Minimum = 10;
            NUD_res.Maximum = 500;
            for (int i = 0; i < NUD_parameters.Count; i++)
            {
                NUD_parameters[i].DecimalPlaces = 2;
                NUD_parameters[i].Minimum = -100;
                NUD_parameters[i].Maximum = 100;
            }
            Input_Check(Graph_Type);
        }


        private void BTN_Plot_Click(object sender, EventArgs e)
        {
            // on click BTN_Plot
            string Graph_Type = TCB_main.Text;           
            Plot_Series(Graph_Type);
            Input_Check(Graph_Type);
        }

        private void BTN_clear_Click(object sender, EventArgs e)
        {
            // clear selected series in combo box
            if (Get_Selected_Series_Name() != null)
                Main_Chart.Series.Remove(Get_Selected_Series_Name());
        }

        private void TCB_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sync listbox and combobox selection
            LSB_Graph_Type.SelectedIndex = TCB_main.SelectedIndex;
            After_LSB_or_TCB_Change();
        }


        private void LSB_Graph_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sync listbox and combobox selection
            TCB_main.SelectedIndex = LSB_Graph_Type.SelectedIndex;
            After_LSB_or_TCB_Change();
        }
        public void After_LSB_or_TCB_Change()
        {
            //high light selected series
            CB_Plot_graph.Checked = false;

            for (int i = 0; i < Main_Chart.Series.Count; i++)
                Main_Chart.Series[i].MarkerStyle = MarkerStyle.None;

            if (Get_Selected_Series_Name() != null)
                Get_Selected_Series_Name().MarkerStyle = MarkerStyle.Cross;

            String Graph_Type = TCB_main.Text;
            Arrange_UI_for_Input(Graph_Type);
            Input_Check(Graph_Type);
            if (Get_Selected_Series_Name() != null)
                Plot_Series(Graph_Type);
        }
        private void TKB_paras_Scroll(object sender, EventArgs e)
        {
            string Graph_Type = TCB_main.Text;
            Input_Check(Graph_Type);
            for (int i = 0; i < TKB_paras.Count; i++)
            {
                NUM_paras[i].Value = TKB_paras[i].Value;
            }
            Plot_Series(Graph_Type);
        }

        private void NUD_paras_ValueChanged(object sender, EventArgs e)
        {
            string Graph_Type = TCB_main.Text;
            Input_Check(Graph_Type);
            for (int i = 0; i < TKB_paras.Count; i++)
            {
                TKB_paras[i].Minimum = Convert.ToInt32(NUM_paras[i].Minimum);
                TKB_paras[i].Maximum = Convert.ToInt32(NUM_paras[i].Maximum);
                TKB_paras[i].Value = Convert.ToInt32(NUM_paras[i].Value);
            }
            Plot_Series(Graph_Type);
        }

        public void Input_Check(string Graph_Type)
        {
            // Constrain inputs
            switch (Graph_Type)
            {
                case "Triangular":// 3 inputs
                    NUD_parameter_01.Maximum = NUD_parameter_02.Value;
                    NUD_parameter_02.Maximum = NUD_parameter_03.Value;
                    break;

                case "Gaussian":// 2+1 inputs
                    NUD_parameter_02.Minimum = 0;
                    break;

                case "Bell":// 3+1
                    NUD_parameter_01.Minimum = 0;
                    NUD_parameter_02.Minimum = 1;
                    break;

                case "Sigmoidal"://2+1
                     NUD_parameter_01.Minimum = 1;
                     break;

                case "LeftRight"://3+1
                    NUD_parameter_02.Minimum = 0;
                    break;

                default:
                    break;
            }
        }

        public void Plot_Series(string Graph_Type)
        {
            // if BTN_Plot on clik, plot graph
            if (CB_Plot_graph.Checked)
            {
                double parameter_01 = Convert.ToDouble(NUD_parameter_01.Value);
                double parameter_02 = Convert.ToDouble(NUD_parameter_02.Value);
                double parameter_03 = Convert.ToDouble(NUD_parameter_03.Value);
                double parameter_04 = Convert.ToDouble(NUD_parameter_04.Value);

                if (Get_Selected_Series_Name() != null)
                    Main_Chart.Series.Remove(Get_Selected_Series_Name());

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
                Main_Chart.Series[Main_Chart.Series.Count - 1].MarkerStyle = MarkerStyle.Cross;
                Main_Chart.ChartAreas[0].RecalculateAxesScale();
                Main_Chart.ChartAreas[0].AxisX.LabelStyle.Format = "{n2}";
                //Main_Chart.Update();
            }

        }
    }
}
