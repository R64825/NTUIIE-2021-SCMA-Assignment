using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Ant_Colony_System_Library;


namespace r09546042_TerryYang_Assignment09
{
    public partial class Form1 : Form
    {       
        Ant_Colony_System_For_Sequencing_Problems ACS = null;
        int number_Of_Cites;
        double[,] from_To_Distances;
        double[,] coordinates;
        double[,] distance_Inversed;
        int[] so_Far_The_Best_Routh;
        public event EventHandler event_;

        public Form1()
        {
            InitializeComponent();
        }

        public double Get_The_Routh_Length(int [] route)
        {
            // use from-to matrix to calculate length
            
            return 0.0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(dlg.FileName);
            number_Of_Cites = int.Parse(sr.ReadLine());
            coordinates = new double[number_Of_Cites, 2];
            char[] seps = { ' ', ',' };
            for (int i = 0; i < number_Of_Cites; i++)
            {
                string[] items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                coordinates[i, 0] = double.Parse(items[1]);
                coordinates[i, 1] = double.Parse(items[2]);
                DataPoint dp = new DataPoint(coordinates[i, 0], coordinates[i, 2]);
                dp.Label = (i + 1).ToString();

                chart1.Series[0].Points.Add(dp);
            }
            for (int s = 0; s < number_Of_Cites; s++)
                for (int t = 0; t < number_Of_Cites; t++)
                {
                    // distance invers
                }
            // show the cites in the chart
            chart1.Series[0]

            sr.Close();
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ACS.Reset();
            event_ += ACS.So_Far_The_Best_Update;
        }
    }
}
