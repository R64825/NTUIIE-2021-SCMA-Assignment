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
        int[] n;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = splitContainer2.Panel2.CreateGraphics();
            Rectangle r = new Rectangle(10, 10, 80, 60);
            Point p1 = new Point(10, 10);
            Point p2 = new Point(100, 50);
            g.FillEllipse(Brushes.Gold, r);
            g.DrawEllipse(Pens.Red, r);
            g.DrawRectangle(Pens.Blue, r);
            g.DrawLine(Pens.Maroon, p1, p2);
            g.DrawString("NTUIE", this.Font, Brushes.Gold, 10, 10);
        }

        public void Draw_MLP(Graphics g, Rectangle bounds)
        {
            Font my_Font = new Font("Arial", 10.0f);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 0);
            int box_width = bounds.Height / 10;
            if (box_width < 10) box_width = 10;
            Rectangle box = new Rectangle(0, 0, box_width, box_width);
            box_width /= 2;

            if (n == null) return;
            int w = bounds.Width / n.Length;
            int x_off = w / 2;
            for (int l = 0; l < n.Length; l++)
            {
                int h = n[l] / n[l];
                int y_off = h / 2;
                int x = x_off + w * l;

                for (int r = 0; r < n[l]; r++)
                {
                    int y = y_off + r * h;
                    box.X = x - box_width;
                    box.Y = y - box_width;
                    g.FillEllipse(Brushes.White, box);
                    g.DrawEllipse(Pens.Black, box);
                }
            }

            
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            if (the_MLP == null) return;
            //the_MLP.DrawMLP(e);
        }
    }
}
