
namespace r09546042_TerryYang_FinalProject
{
    partial class Mainform
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.CT_Main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GB_SFTB = new System.Windows.Forms.GroupBox();
            this.LB_SFTBS = new System.Windows.Forms.Label();
            this.LB_SFTBV = new System.Windows.Forms.Label();
            this.GB_Model = new System.Windows.Forms.GroupBox();
            this.RDB_ABC = new System.Windows.Forms.RadioButton();
            this.RDB_GA = new System.Windows.Forms.RadioButton();
            this.RDB_PSO = new System.Windows.Forms.RadioButton();
            this.GB_Action = new System.Windows.Forms.GroupBox();
            this.NUD_Interval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Animation = new System.Windows.Forms.CheckBox();
            this.BTN_Reset_Solver = new System.Windows.Forms.Button();
            this.BTN_Run_One = new System.Windows.Forms.Button();
            this.BTN_Run_to_End = new System.Windows.Forms.Button();
            this.BTN_Create_Solver = new System.Windows.Forms.Button();
            this.PPTG_Solver = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_Openfile = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Pro_Bar = new System.Windows.Forms.ToolStripProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_Main)).BeginInit();
            this.GB_SFTB.SuspendLayout();
            this.GB_Model.SuspendLayout();
            this.GB_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Interval)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1271, 651);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GB_SFTB);
            this.splitContainer2.Panel2.Controls.Add(this.GB_Model);
            this.splitContainer2.Panel2.Controls.Add(this.GB_Action);
            this.splitContainer2.Panel2.Controls.Add(this.PPTG_Solver);
            this.splitContainer2.Size = new System.Drawing.Size(963, 651);
            this.splitContainer2.SplitterDistance = 601;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.CT_Main);
            this.splitContainer3.Size = new System.Drawing.Size(601, 651);
            this.splitContainer3.SplitterDistance = 322;
            this.splitContainer3.TabIndex = 0;
            // 
            // CT_Main
            // 
            this.CT_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.CT_Main.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.CT_Main.Legends.Add(legend1);
            this.CT_Main.Location = new System.Drawing.Point(3, 52);
            this.CT_Main.Name = "CT_Main";
            this.CT_Main.Size = new System.Drawing.Size(595, 267);
            this.CT_Main.TabIndex = 0;
            this.CT_Main.Text = "chart1";
            // 
            // GB_SFTB
            // 
            this.GB_SFTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_SFTB.Controls.Add(this.LB_SFTBS);
            this.GB_SFTB.Controls.Add(this.LB_SFTBV);
            this.GB_SFTB.Location = new System.Drawing.Point(3, 332);
            this.GB_SFTB.Name = "GB_SFTB";
            this.GB_SFTB.Size = new System.Drawing.Size(343, 87);
            this.GB_SFTB.TabIndex = 12;
            this.GB_SFTB.TabStop = false;
            this.GB_SFTB.Text = "So Far The Best";
            // 
            // LB_SFTBS
            // 
            this.LB_SFTBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_SFTBS.ForeColor = System.Drawing.Color.ForestGreen;
            this.LB_SFTBS.Location = new System.Drawing.Point(5, 50);
            this.LB_SFTBS.Name = "LB_SFTBS";
            this.LB_SFTBS.Size = new System.Drawing.Size(330, 40);
            this.LB_SFTBS.TabIndex = 1;
            this.LB_SFTBS.Text = "Solution:";
            // 
            // LB_SFTBV
            // 
            this.LB_SFTBV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_SFTBV.ForeColor = System.Drawing.Color.Brown;
            this.LB_SFTBV.Location = new System.Drawing.Point(5, 25);
            this.LB_SFTBV.Name = "LB_SFTBV";
            this.LB_SFTBV.Size = new System.Drawing.Size(330, 25);
            this.LB_SFTBV.TabIndex = 0;
            this.LB_SFTBV.Text = "Objective: ";
            // 
            // GB_Model
            // 
            this.GB_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Model.Controls.Add(this.RDB_ABC);
            this.GB_Model.Controls.Add(this.RDB_GA);
            this.GB_Model.Controls.Add(this.RDB_PSO);
            this.GB_Model.Enabled = false;
            this.GB_Model.Location = new System.Drawing.Point(3, 52);
            this.GB_Model.Name = "GB_Model";
            this.GB_Model.Size = new System.Drawing.Size(343, 51);
            this.GB_Model.TabIndex = 9;
            this.GB_Model.TabStop = false;
            this.GB_Model.Text = "Model";
            // 
            // RDB_ABC
            // 
            this.RDB_ABC.AutoSize = true;
            this.RDB_ABC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_ABC.Location = new System.Drawing.Point(125, 21);
            this.RDB_ABC.Name = "RDB_ABC";
            this.RDB_ABC.Size = new System.Drawing.Size(54, 23);
            this.RDB_ABC.TabIndex = 7;
            this.RDB_ABC.Text = "ABC";
            this.RDB_ABC.UseVisualStyleBackColor = true;
            // 
            // RDB_GA
            // 
            this.RDB_GA.AutoSize = true;
            this.RDB_GA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_GA.Location = new System.Drawing.Point(73, 21);
            this.RDB_GA.Name = "RDB_GA";
            this.RDB_GA.Size = new System.Drawing.Size(46, 23);
            this.RDB_GA.TabIndex = 6;
            this.RDB_GA.Text = "GA";
            this.RDB_GA.UseVisualStyleBackColor = true;
            // 
            // RDB_PSO
            // 
            this.RDB_PSO.AutoSize = true;
            this.RDB_PSO.Checked = true;
            this.RDB_PSO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_PSO.Location = new System.Drawing.Point(14, 21);
            this.RDB_PSO.Name = "RDB_PSO";
            this.RDB_PSO.Size = new System.Drawing.Size(53, 23);
            this.RDB_PSO.TabIndex = 5;
            this.RDB_PSO.TabStop = true;
            this.RDB_PSO.Text = "PSO";
            this.RDB_PSO.UseVisualStyleBackColor = true;
            // 
            // GB_Action
            // 
            this.GB_Action.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Action.Controls.Add(this.NUD_Interval);
            this.GB_Action.Controls.Add(this.label1);
            this.GB_Action.Controls.Add(this.CB_Animation);
            this.GB_Action.Controls.Add(this.BTN_Reset_Solver);
            this.GB_Action.Controls.Add(this.BTN_Run_One);
            this.GB_Action.Controls.Add(this.BTN_Run_to_End);
            this.GB_Action.Controls.Add(this.BTN_Create_Solver);
            this.GB_Action.Enabled = false;
            this.GB_Action.Location = new System.Drawing.Point(3, 109);
            this.GB_Action.Name = "GB_Action";
            this.GB_Action.Size = new System.Drawing.Size(343, 217);
            this.GB_Action.TabIndex = 11;
            this.GB_Action.TabStop = false;
            this.GB_Action.Text = "Action";
            // 
            // NUD_Interval
            // 
            this.NUD_Interval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Interval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUD_Interval.Location = new System.Drawing.Point(201, 185);
            this.NUD_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Interval.Name = "NUD_Interval";
            this.NUD_Interval.Size = new System.Drawing.Size(136, 22);
            this.NUD_Interval.TabIndex = 12;
            this.NUD_Interval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_Interval.ValueChanged += new System.EventHandler(this.NUD_Interval_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Interval: ";
            // 
            // CB_Animation
            // 
            this.CB_Animation.AutoSize = true;
            this.CB_Animation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Animation.Location = new System.Drawing.Point(10, 184);
            this.CB_Animation.Name = "CB_Animation";
            this.CB_Animation.Size = new System.Drawing.Size(94, 23);
            this.CB_Animation.TabIndex = 9;
            this.CB_Animation.Text = "Animation";
            this.CB_Animation.UseVisualStyleBackColor = true;
            this.CB_Animation.CheckedChanged += new System.EventHandler(this.CB_Animation_CheckedChanged);
            // 
            // BTN_Reset_Solver
            // 
            this.BTN_Reset_Solver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Reset_Solver.Enabled = false;
            this.BTN_Reset_Solver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Reset_Solver.Location = new System.Drawing.Point(6, 61);
            this.BTN_Reset_Solver.Name = "BTN_Reset_Solver";
            this.BTN_Reset_Solver.Size = new System.Drawing.Size(331, 35);
            this.BTN_Reset_Solver.TabIndex = 2;
            this.BTN_Reset_Solver.Text = "Reset";
            this.BTN_Reset_Solver.UseVisualStyleBackColor = true;
            this.BTN_Reset_Solver.Click += new System.EventHandler(this.BTN_Reset_Solver_Click);
            // 
            // BTN_Run_One
            // 
            this.BTN_Run_One.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Run_One.Enabled = false;
            this.BTN_Run_One.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Run_One.Location = new System.Drawing.Point(7, 102);
            this.BTN_Run_One.Name = "BTN_Run_One";
            this.BTN_Run_One.Size = new System.Drawing.Size(330, 35);
            this.BTN_Run_One.TabIndex = 3;
            this.BTN_Run_One.Text = "Run One";
            this.BTN_Run_One.UseVisualStyleBackColor = true;
            this.BTN_Run_One.Click += new System.EventHandler(this.BTN_Run_One_Click);
            // 
            // BTN_Run_to_End
            // 
            this.BTN_Run_to_End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Run_to_End.Enabled = false;
            this.BTN_Run_to_End.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Run_to_End.Location = new System.Drawing.Point(7, 143);
            this.BTN_Run_to_End.Name = "BTN_Run_to_End";
            this.BTN_Run_to_End.Size = new System.Drawing.Size(330, 35);
            this.BTN_Run_to_End.TabIndex = 4;
            this.BTN_Run_to_End.Text = "Run to end";
            this.BTN_Run_to_End.UseVisualStyleBackColor = true;
            this.BTN_Run_to_End.Click += new System.EventHandler(this.BTN_Run_to_End_Click);
            // 
            // BTN_Create_Solver
            // 
            this.BTN_Create_Solver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Create_Solver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Create_Solver.Location = new System.Drawing.Point(6, 20);
            this.BTN_Create_Solver.Name = "BTN_Create_Solver";
            this.BTN_Create_Solver.Size = new System.Drawing.Size(331, 35);
            this.BTN_Create_Solver.TabIndex = 0;
            this.BTN_Create_Solver.Text = "Create solver";
            this.BTN_Create_Solver.UseVisualStyleBackColor = true;
            this.BTN_Create_Solver.Click += new System.EventHandler(this.BTN_Create_Solver_Click);
            // 
            // PPTG_Solver
            // 
            this.PPTG_Solver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PPTG_Solver.Location = new System.Drawing.Point(3, 425);
            this.PPTG_Solver.Name = "PPTG_Solver";
            this.PPTG_Solver.Size = new System.Drawing.Size(352, 201);
            this.PPTG_Solver.TabIndex = 10;
            this.PPTG_Solver.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PPTG_Solver_PropertyValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Openfile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1271, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_Openfile
            // 
            this.BTN_Openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Openfile.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Openfile.Image")));
            this.BTN_Openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Openfile.Name = "BTN_Openfile";
            this.BTN_Openfile.Size = new System.Drawing.Size(52, 22);
            this.BTN_Openfile.Text = "Open...";
            this.BTN_Openfile.Click += new System.EventHandler(this.BTN_Openfile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pro_Bar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1271, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Pro_Bar
            // 
            this.Pro_Bar.Name = "Pro_Bar";
            this.Pro_Bar.Size = new System.Drawing.Size(100, 16);
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 651);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "ABC demo";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CT_Main)).EndInit();
            this.GB_SFTB.ResumeLayout(false);
            this.GB_Model.ResumeLayout(false);
            this.GB_Model.PerformLayout();
            this.GB_Action.ResumeLayout(false);
            this.GB_Action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Interval)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart CT_Main;
        private System.Windows.Forms.ToolStripButton BTN_Openfile;
        private System.Windows.Forms.GroupBox GB_SFTB;
        private System.Windows.Forms.Label LB_SFTBS;
        private System.Windows.Forms.Label LB_SFTBV;
        private System.Windows.Forms.GroupBox GB_Model;
        private System.Windows.Forms.RadioButton RDB_ABC;
        private System.Windows.Forms.RadioButton RDB_GA;
        private System.Windows.Forms.RadioButton RDB_PSO;
        private System.Windows.Forms.GroupBox GB_Action;
        private System.Windows.Forms.NumericUpDown NUD_Interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_Animation;
        private System.Windows.Forms.Button BTN_Reset_Solver;
        private System.Windows.Forms.Button BTN_Run_One;
        private System.Windows.Forms.Button BTN_Run_to_End;
        private System.Windows.Forms.Button BTN_Create_Solver;
        private System.Windows.Forms.PropertyGrid PPTG_Solver;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripProgressBar Pro_Bar;
    }
}

