using COP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Particle_Swamp_Optimizer;

namespace r09546042_TerryYang_Assignment10
{
    public partial class Main_Form : Form
    {
        COPBenchmark the_Problem;
        Particle_Swamp_Optimizer_Solver my_Solver;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void TS_BTN_Open_file_Click(object sender, EventArgs e)
        {
            the_Problem = COPBenchmark.LoadAProblemFromAFile();
            the_Problem.DisplayOnPanel(splitContainer1.Panel1);
            the_Problem.DisplayObjectiveGraphics(splitContainer2.Panel2);
        }

        private void BTN_Create_PSO_Solver_Click(object sender, EventArgs e)
        {
            my_Solver = new Particle_Swamp_Optimizer_Solver(the_Problem);
            PPTG_Solver.SelectedObject = my_Solver;
        }

        private void BTN_Reset_Solver_Click(object sender, EventArgs e)
        {
            my_Solver.Reset();
            the_Problem.DisplaySolutionsOnGraphics(my_Solver.Positions);
        }
    }
}
