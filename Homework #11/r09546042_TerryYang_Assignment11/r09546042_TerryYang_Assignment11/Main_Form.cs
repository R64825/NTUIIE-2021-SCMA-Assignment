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

namespace r09546042_TerryYang_Assignment11
{
    public partial class Main_Form : Form
    {
        BbackPropagationMLP the_MLP;
        Series series_RMSE;
        int[] n;
        public Main_Form()
        {
            InitializeComponent();
        }
        #region Update UI

        public void Update_UI()
        {
            splitContainer2.Panel2.Refresh();
            Main_Chart.ChartAreas[0].RecalculateAxesScale();

            LB_RMSE.Text = "RMSE: " + Math.Round(the_MLP.RMSE, 3).ToString();
        }

        public void Update_Test_Classification_UI()
        {
            float correctneww = the_MLP.TestingClassification();
            string str = string.Empty;

            for (int i = 0; i < the_MLP.Dimension_Target; i++)
            {
                for (int j = 0; j < the_MLP.Dimension_Target; j++)
                {
                    str += the_MLP.ConfusingTable[i, j].ToString() + " ";
                }
                str += "\n ";
            }

            LB_Test.Text = "Correctness: " + Math.Round((correctneww / the_MLP.Number_of_Testing_Data), 3).ToString() + "\n"
                + $"({correctneww}/{the_MLP.Number_of_Testing_Data})" + "\n" + "\n"
                + "Confusion matrix:" + "\n" + str;
        }
        #endregion

        #region BTN Event
        private void BTN_Reset_NN_Click(object sender, EventArgs e)
        {
            int[] number_of_Layer = new int[LSB_Layers.Items.Count];
            for (int i = 0; i < LSB_Layers.Items.Count; i++)
                number_of_Layer[i] = int.Parse(LSB_Layers.Items[i].ToString());
            the_MLP.Reset_Weights_And_Initial_Condition(number_of_Layer);

            series_RMSE = the_MLP.Series_RMSE;
            Main_Chart.Series.Clear();
            Main_Chart.Series.Add(series_RMSE);
            PPTG.SelectedObject = the_MLP;
            splitContainer2.Panel2.Refresh();

            Update_UI();
            Update_Test_Classification_UI();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            the_MLP = new BbackPropagationMLP();
            the_MLP.Read_Data(dlg.FileName);

            PPTG.SelectedObject = the_MLP;
        }

        private void BTN_Train_One_Click(object sender, EventArgs e)
        {
            the_MLP.TrainAnEpoch();
            Update_UI();
            //Test_Classification_UI()
            // update the RMSE progress line
        }

        private void BTN_Run_To_End_Click(object sender, EventArgs e)
        {
            
            if (CB_Animation.Checked && the_MLP.Nn_Finished == false)
            {
                Timer.Enabled = true;
            }
            else
            {
                the_MLP.Train_To_End();
            }
            Update_UI();
            Update_Test_Classification_UI();
            // display results on the form
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = MLP_Print_DOC;
            if (dlg.ShowDialog() != DialogResult.OK) return;

        }
        private void BTN_Classification_Click(object sender, EventArgs e)
        {
            Update_Test_Classification_UI();
        }
        #endregion




        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            if (the_MLP == null) return;
            the_MLP.Draw_MLP(e.Graphics,e.ClipRectangle);
        }

        private void NUD_Layer_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Layer.Value>LSB_Layers.Items.Count)
            {
                LSB_Layers.Items.Add("4");
            }
            else if(NUD_Layer.Value < LSB_Layers.Items.Count)
            {
                LSB_Layers.Items.RemoveAt(LSB_Layers.Items.Count-1);
            }
            
        }

        private void NUD_Node_ValueChanged(object sender, EventArgs e)
        {
            if (LSB_Layers.SelectedItem == null) return;
            LSB_Layers.Items[ LSB_Layers.SelectedIndex] = NUD_Node.Value.ToString();
        }

        private void LSB_Layers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LSB_Layers.SelectedItem == null) return;
            NUD_Node.Value = decimal.Parse( LSB_Layers.SelectedItem.ToString());
        }

        private void MLP_Print_DOC_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (the_MLP == null) return;
            the_MLP.Draw_MLP(e.Graphics, e.PageBounds);
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (the_MLP.Nn_Finished == false)
            {
                the_MLP.TrainAnEpoch();

                Main_Chart.ChartAreas[0].RecalculateAxesScale();
                LB_RMSE.Text = "RMSE: " + Math.Round(the_MLP.RMSE, 3).ToString();
                //Update_UI();
            }
            else
            {
                Timer.Enabled = false;
                CB_Animation.Checked = false;
                Update_UI();
                Update_Test_Classification_UI();
            }
        }

        private void CB_Animation_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Animation.Checked == false)
            {
                Timer.Enabled = false;
            }
        }
    }
}
