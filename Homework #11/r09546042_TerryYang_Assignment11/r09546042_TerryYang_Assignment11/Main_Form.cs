using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r09546042_TerryYang_Assignment11
{
    public partial class Main_Form : Form
    {
        BbackPropagationMLP the_MLP;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void BTN_Reset_NN_Click(object sender, EventArgs e)
        {
            int[] hidden_Neurons = new int[LSB_Layers.Items.Count];
            for (int i = 0; i < hidden_Neurons.Length; i++)
                hidden_Neurons[i] = int.Parse(LSB_Layers.Items[i].ToString());
            the_MLP = new BbackPropagationMLP();
            the_MLP.ResetWeightsAndInitialCondition(hidden_Neurons);

            PPTG.SelectedObject = the_MLP;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            
        }

        private void BTN_Train_One_Click(object sender, EventArgs e)
        {
            the_MLP.TrainAnEpoch();
            // update the RMSE progress line
        }

        private void BTN_Run_To_End_Click(object sender, EventArgs e)
        {
            the_MLP.Train_To_End();
            int[,] confusing_Table;
            float correctneww = the_MLP.TestingClassification(out confusing_Table);

            // display results on the form
        }
    }
}
