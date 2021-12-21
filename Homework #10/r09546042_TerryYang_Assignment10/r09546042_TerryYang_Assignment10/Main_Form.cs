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
        Particle_Swamp_Optimizer_Solver PSO_Solver;
        public Main_Form()
        {
            InitializeComponent();
        }

        public void Reset_UI()
        {
            CT_Main.Series.Clear();
            Pro_Bar.Minimum = 0;
            Pro_Bar.Maximum = PSO_Solver.Iteration_Limit;
            Pro_Bar.Value = 0;
        }
        public void Update_UI()
        {
            CT_Main.ChartAreas[0].RecalculateAxesScale();
            if (the_Problem == null) return;
            the_Problem.DisplaySolutionsOnGraphics(PSO_Solver.Positions);
            LB_SFTBS.Text = "Solution: " + PSO_Solver.Flatten_Position(PSO_Solver.So_Far_the_Best_Position);
            LB_SFTBV.Text = "Objective: " + Math.Round( PSO_Solver.So_Far_the_Best_Objective,3).ToString();
            Pro_Bar.Value = PSO_Solver.Current_Iteration;
        }
        private void TS_BTN_Open_file_Click(object sender, EventArgs e)
        {
            the_Problem = COPBenchmark.LoadAProblemFromAFile();
            if (the_Problem == null) return;
            the_Problem.DisplayOnPanel(splitContainer1.Panel1);
            the_Problem.DisplayObjectiveGraphics(splitContainer3.Panel2);
            //Reset_UI();

            // enable
            GB_Model.Enabled = true;
            GB_Action.Enabled = true;
        }

        private void BTN_Create_PSO_Solver_Click(object sender, EventArgs e)
        {
            PSO_Solver = new Particle_Swamp_Optimizer_Solver(the_Problem);
            PPTG_Solver.SelectedObject = PSO_Solver;
            Update_UI();

            BTN_Reset_Solver.Enabled = true;
        }

        private void BTN_Reset_Solver_Click(object sender, EventArgs e)
        {
            PSO_Solver.Reset();

            // add series
            Reset_UI();
            CT_Main.Series.Add(PSO_Solver.Series_iteration_Average_Objective);
            CT_Main.Series.Add(PSO_Solver.Series_iteration_The_Best_Objective);
            CT_Main.Series.Add(PSO_Solver.Series_so_Far_The_Best_Objective);

            BTN_Run_One.Enabled = true;
            BTN_Run_to_End.Enabled = true;
            Update_UI();
        }

        private void BTN_Run_One_Click(object sender, EventArgs e)
        {
            if (PSO_Solver.Current_Iteration < PSO_Solver.Iteration_Limit)
            {
                PSO_Solver.Run_One_Iteration();
                BTN_Create_PSO_Solver.Enabled = false;
                BTN_Reset_Solver.Enabled = false;
            }
            else
            {
                BTN_Create_PSO_Solver.Enabled = true;
                BTN_Reset_Solver.Enabled = false;
                BTN_Run_One.Enabled = false;
                BTN_Run_to_End.Enabled = false;
            }
            Update_UI();           
        }

        private void BTN_Run_to_End_Click(object sender, EventArgs e)
        {
            if (CB_Animation.Checked)
            {
                Timer.Enabled = true;
                BTN_Create_PSO_Solver.Enabled = false;
                BTN_Reset_Solver.Enabled = false;
            }
            else
            {
                PSO_Solver.Run_To_End();
                BTN_Create_PSO_Solver.Enabled = true;
                BTN_Reset_Solver.Enabled = false;
                BTN_Run_One.Enabled = false;
                BTN_Run_to_End.Enabled = false;
            }
            Update_UI();

            
        }

        private void CB_Animation_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Animation.Checked == false)
            {
                Timer.Enabled = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (PSO_Solver.Current_Iteration < PSO_Solver.Iteration_Limit )
            {
                PSO_Solver.Run_One_Iteration();               
            }
            else if (PSO_Solver.Current_Iteration == PSO_Solver.Iteration_Limit)
            {
                Timer.Enabled = false;
                CB_Animation.Checked = false;

                BTN_Create_PSO_Solver.Enabled = true;
                BTN_Reset_Solver.Enabled = false;
                BTN_Run_One.Enabled = false;
                BTN_Run_to_End.Enabled = false;
            }
            Update_UI();
        }

        private void NUD_Interval_ValueChanged(object sender, EventArgs e)
        {
            
            Timer.Interval = decimal.ToInt32(NUD_Interval.Value);
        }
    }
}
