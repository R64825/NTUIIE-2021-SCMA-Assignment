
namespace r09546042_TerryYang_Assignment07
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tool_Strip = new System.Windows.Forms.ToolStrip();
            this.TSDDBTN_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TBC_main = new System.Windows.Forms.TabControl();
            this.TP_Problem = new System.Windows.Forms.TabPage();
            this.GB_GeneratedProblem = new System.Windows.Forms.GroupBox();
            this.DGV_Problem = new System.Windows.Forms.DataGridView();
            this.GB_ProblemSetting = new System.Windows.Forms.GroupBox();
            this.NUD_maximum = new System.Windows.Forms.NumericUpDown();
            this.NUD_minimum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Number_of_Jobs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_proGenerate = new System.Windows.Forms.Button();
            this.TP_Settings = new System.Windows.Forms.TabPage();
            this.GB_Optimization = new System.Windows.Forms.GroupBox();
            this.RDB_Mini = new System.Windows.Forms.RadioButton();
            this.RDB_Maxi = new System.Windows.Forms.RadioButton();
            this.GB_Mutation = new System.Windows.Forms.GroupBox();
            this.RDB_Chrom_Base = new System.Windows.Forms.RadioButton();
            this.RDB_Genes_Base = new System.Windows.Forms.RadioButton();
            this.GB_Action = new System.Windows.Forms.GroupBox();
            this.NUD_Iteration = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.BTN_Run_one = new System.Windows.Forms.Button();
            this.BTN_Run_to_end = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.GB_Animation = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TKB_Animation = new System.Windows.Forms.TrackBar();
            this.CKB_Show_animation = new System.Windows.Forms.CheckBox();
            this.GB_Selection = new System.Windows.Forms.GroupBox();
            this.RDB_Deterministic = new System.Windows.Forms.RadioButton();
            this.RDB_Stochastic = new System.Windows.Forms.RadioButton();
            this.GB_Parameter = new System.Windows.Forms.GroupBox();
            this.NUD_Least_Fitness_Fraction = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_mutaterate = new System.Windows.Forms.NumericUpDown();
            this.NUD_crossrate = new System.Windows.Forms.NumericUpDown();
            this.NUD_population = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GB_GA_encoding = new System.Windows.Forms.GroupBox();
            this.NUD_Penalty_Factor = new System.Windows.Forms.NumericUpDown();
            this.CB_Permutation_Mutat_Type = new System.Windows.Forms.ComboBox();
            this.CB_Permutation_Cross_Type = new System.Windows.Forms.ComboBox();
            this.CB_Binary_Cross_Type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RDB_Permutation = new System.Windows.Forms.RadioButton();
            this.RDB_Binary = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.LTB_HCV = new System.Windows.Forms.ListBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.TB_shortest_time = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.LTB_BOV = new System.Windows.Forms.ListBox();
            this.TB_BOV = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.LTB_Population = new System.Windows.Forms.ListBox();
            this.Chart_Main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSL_model_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSL_Iteration = new System.Windows.Forms.ToolStripStatusLabel();
            this.TM_GA = new System.Windows.Forms.Timer(this.components);
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Tool_Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TBC_main.SuspendLayout();
            this.TP_Problem.SuspendLayout();
            this.GB_GeneratedProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Problem)).BeginInit();
            this.GB_ProblemSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_minimum)).BeginInit();
            this.TP_Settings.SuspendLayout();
            this.GB_Optimization.SuspendLayout();
            this.GB_Mutation.SuspendLayout();
            this.GB_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Iteration)).BeginInit();
            this.GB_Animation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_Animation)).BeginInit();
            this.GB_Selection.SuspendLayout();
            this.GB_Parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Least_Fitness_Fraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_mutaterate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_crossrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_population)).BeginInit();
            this.GB_GA_encoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Penalty_Factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Main)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tool_Strip
            // 
            this.Tool_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDDBTN_File});
            this.Tool_Strip.Location = new System.Drawing.Point(0, 24);
            this.Tool_Strip.Name = "Tool_Strip";
            this.Tool_Strip.Size = new System.Drawing.Size(1249, 25);
            this.Tool_Strip.TabIndex = 1;
            this.Tool_Strip.Text = "toolStrip1";
            // 
            // TSDDBTN_File
            // 
            this.TSDDBTN_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSDDBTN_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TSDDBTN_File.Image = ((System.Drawing.Image)(resources.GetObject("TSDDBTN_File.Image")));
            this.TSDDBTN_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDBTN_File.Name = "TSDDBTN_File";
            this.TSDDBTN_File.Size = new System.Drawing.Size(39, 22);
            this.TSDDBTN_File.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TBC_main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1249, 845);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 2;
            // 
            // TBC_main
            // 
            this.TBC_main.Controls.Add(this.TP_Problem);
            this.TBC_main.Controls.Add(this.TP_Settings);
            this.TBC_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBC_main.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBC_main.Location = new System.Drawing.Point(0, 0);
            this.TBC_main.Name = "TBC_main";
            this.TBC_main.SelectedIndex = 0;
            this.TBC_main.Size = new System.Drawing.Size(402, 845);
            this.TBC_main.TabIndex = 0;
            // 
            // TP_Problem
            // 
            this.TP_Problem.Controls.Add(this.GB_GeneratedProblem);
            this.TP_Problem.Controls.Add(this.GB_ProblemSetting);
            this.TP_Problem.Controls.Add(this.BTN_proGenerate);
            this.TP_Problem.Location = new System.Drawing.Point(4, 24);
            this.TP_Problem.Name = "TP_Problem";
            this.TP_Problem.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Problem.Size = new System.Drawing.Size(394, 817);
            this.TP_Problem.TabIndex = 0;
            this.TP_Problem.Text = "Problem";
            this.TP_Problem.UseVisualStyleBackColor = true;
            // 
            // GB_GeneratedProblem
            // 
            this.GB_GeneratedProblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_GeneratedProblem.Controls.Add(this.DGV_Problem);
            this.GB_GeneratedProblem.Location = new System.Drawing.Point(8, 128);
            this.GB_GeneratedProblem.Name = "GB_GeneratedProblem";
            this.GB_GeneratedProblem.Size = new System.Drawing.Size(380, 668);
            this.GB_GeneratedProblem.TabIndex = 9;
            this.GB_GeneratedProblem.TabStop = false;
            this.GB_GeneratedProblem.Text = "Generated Problem";
            // 
            // DGV_Problem
            // 
            this.DGV_Problem.AllowUserToAddRows = false;
            this.DGV_Problem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Problem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Problem.Location = new System.Drawing.Point(3, 19);
            this.DGV_Problem.Name = "DGV_Problem";
            this.DGV_Problem.RowTemplate.Height = 24;
            this.DGV_Problem.Size = new System.Drawing.Size(374, 646);
            this.DGV_Problem.TabIndex = 0;
            // 
            // GB_ProblemSetting
            // 
            this.GB_ProblemSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_ProblemSetting.Controls.Add(this.NUD_maximum);
            this.GB_ProblemSetting.Controls.Add(this.NUD_minimum);
            this.GB_ProblemSetting.Controls.Add(this.label4);
            this.GB_ProblemSetting.Controls.Add(this.label3);
            this.GB_ProblemSetting.Controls.Add(this.CB_Number_of_Jobs);
            this.GB_ProblemSetting.Controls.Add(this.label2);
            this.GB_ProblemSetting.Location = new System.Drawing.Point(6, 6);
            this.GB_ProblemSetting.Name = "GB_ProblemSetting";
            this.GB_ProblemSetting.Size = new System.Drawing.Size(295, 116);
            this.GB_ProblemSetting.TabIndex = 8;
            this.GB_ProblemSetting.TabStop = false;
            this.GB_ProblemSetting.Text = "Problem Settings";
            // 
            // NUD_maximum
            // 
            this.NUD_maximum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_maximum.DecimalPlaces = 1;
            this.NUD_maximum.Location = new System.Drawing.Point(92, 80);
            this.NUD_maximum.Name = "NUD_maximum";
            this.NUD_maximum.Size = new System.Drawing.Size(197, 23);
            this.NUD_maximum.TabIndex = 1;
            this.NUD_maximum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NUD_minimum
            // 
            this.NUD_minimum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_minimum.DecimalPlaces = 1;
            this.NUD_minimum.Location = new System.Drawing.Point(92, 50);
            this.NUD_minimum.Name = "NUD_minimum";
            this.NUD_minimum.Size = new System.Drawing.Size(197, 23);
            this.NUD_minimum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum:";
            // 
            // CB_Number_of_Jobs
            // 
            this.CB_Number_of_Jobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Number_of_Jobs.FormattingEnabled = true;
            this.CB_Number_of_Jobs.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.CB_Number_of_Jobs.Location = new System.Drawing.Point(193, 18);
            this.CB_Number_of_Jobs.Name = "CB_Number_of_Jobs";
            this.CB_Number_of_Jobs.Size = new System.Drawing.Size(96, 23);
            this.CB_Number_of_Jobs.TabIndex = 4;
            this.CB_Number_of_Jobs.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Job/Machine:";
            // 
            // BTN_proGenerate
            // 
            this.BTN_proGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_proGenerate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_proGenerate.Location = new System.Drawing.Point(311, 13);
            this.BTN_proGenerate.Name = "BTN_proGenerate";
            this.BTN_proGenerate.Size = new System.Drawing.Size(77, 107);
            this.BTN_proGenerate.TabIndex = 7;
            this.BTN_proGenerate.Text = "Gnerate";
            this.BTN_proGenerate.UseVisualStyleBackColor = true;
            this.BTN_proGenerate.Click += new System.EventHandler(this.BTN_proGenerate_Click);
            // 
            // TP_Settings
            // 
            this.TP_Settings.Controls.Add(this.GB_Optimization);
            this.TP_Settings.Controls.Add(this.GB_Mutation);
            this.TP_Settings.Controls.Add(this.GB_Action);
            this.TP_Settings.Controls.Add(this.GB_Animation);
            this.TP_Settings.Controls.Add(this.GB_Selection);
            this.TP_Settings.Controls.Add(this.GB_Parameter);
            this.TP_Settings.Controls.Add(this.GB_GA_encoding);
            this.TP_Settings.Location = new System.Drawing.Point(4, 24);
            this.TP_Settings.Name = "TP_Settings";
            this.TP_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Settings.Size = new System.Drawing.Size(394, 817);
            this.TP_Settings.TabIndex = 1;
            this.TP_Settings.Text = "GA settings";
            this.TP_Settings.UseVisualStyleBackColor = true;
            // 
            // GB_Optimization
            // 
            this.GB_Optimization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Optimization.Controls.Add(this.RDB_Mini);
            this.GB_Optimization.Controls.Add(this.RDB_Maxi);
            this.GB_Optimization.Location = new System.Drawing.Point(5, 439);
            this.GB_Optimization.Name = "GB_Optimization";
            this.GB_Optimization.Size = new System.Drawing.Size(385, 50);
            this.GB_Optimization.TabIndex = 6;
            this.GB_Optimization.TabStop = false;
            this.GB_Optimization.Text = "Optimization";
            // 
            // RDB_Mini
            // 
            this.RDB_Mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RDB_Mini.AutoSize = true;
            this.RDB_Mini.Checked = true;
            this.RDB_Mini.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Mini.Location = new System.Drawing.Point(200, 15);
            this.RDB_Mini.Name = "RDB_Mini";
            this.RDB_Mini.Size = new System.Drawing.Size(96, 25);
            this.RDB_Mini.TabIndex = 3;
            this.RDB_Mini.TabStop = true;
            this.RDB_Mini.Text = "Minimum";
            this.RDB_Mini.UseVisualStyleBackColor = true;
            // 
            // RDB_Maxi
            // 
            this.RDB_Maxi.AutoSize = true;
            this.RDB_Maxi.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Maxi.Location = new System.Drawing.Point(15, 15);
            this.RDB_Maxi.Name = "RDB_Maxi";
            this.RDB_Maxi.Size = new System.Drawing.Size(98, 25);
            this.RDB_Maxi.TabIndex = 2;
            this.RDB_Maxi.Text = "Maximum";
            this.RDB_Maxi.UseVisualStyleBackColor = true;
            // 
            // GB_Mutation
            // 
            this.GB_Mutation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Mutation.Controls.Add(this.RDB_Chrom_Base);
            this.GB_Mutation.Controls.Add(this.RDB_Genes_Base);
            this.GB_Mutation.Location = new System.Drawing.Point(5, 389);
            this.GB_Mutation.Name = "GB_Mutation";
            this.GB_Mutation.Size = new System.Drawing.Size(385, 50);
            this.GB_Mutation.TabIndex = 5;
            this.GB_Mutation.TabStop = false;
            this.GB_Mutation.Text = "Mutation";
            // 
            // RDB_Chrom_Base
            // 
            this.RDB_Chrom_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RDB_Chrom_Base.AutoSize = true;
            this.RDB_Chrom_Base.Checked = true;
            this.RDB_Chrom_Base.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Chrom_Base.Location = new System.Drawing.Point(200, 15);
            this.RDB_Chrom_Base.Name = "RDB_Chrom_Base";
            this.RDB_Chrom_Base.Size = new System.Drawing.Size(159, 25);
            this.RDB_Chrom_Base.TabIndex = 1;
            this.RDB_Chrom_Base.TabStop = true;
            this.RDB_Chrom_Base.Text = "Chromosome base";
            this.RDB_Chrom_Base.UseVisualStyleBackColor = true;
            // 
            // RDB_Genes_Base
            // 
            this.RDB_Genes_Base.AutoSize = true;
            this.RDB_Genes_Base.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Genes_Base.Location = new System.Drawing.Point(15, 15);
            this.RDB_Genes_Base.Name = "RDB_Genes_Base";
            this.RDB_Genes_Base.Size = new System.Drawing.Size(100, 25);
            this.RDB_Genes_Base.TabIndex = 0;
            this.RDB_Genes_Base.Text = "Gene base";
            this.RDB_Genes_Base.UseVisualStyleBackColor = true;
            // 
            // GB_Action
            // 
            this.GB_Action.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Action.Controls.Add(this.NUD_Iteration);
            this.GB_Action.Controls.Add(this.label13);
            this.GB_Action.Controls.Add(this.BTN_Run_one);
            this.GB_Action.Controls.Add(this.BTN_Run_to_end);
            this.GB_Action.Controls.Add(this.BTN_Reset);
            this.GB_Action.Location = new System.Drawing.Point(5, 589);
            this.GB_Action.Name = "GB_Action";
            this.GB_Action.Size = new System.Drawing.Size(383, 202);
            this.GB_Action.TabIndex = 4;
            this.GB_Action.TabStop = false;
            this.GB_Action.Text = "Action";
            // 
            // NUD_Iteration
            // 
            this.NUD_Iteration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Iteration.Location = new System.Drawing.Point(117, 170);
            this.NUD_Iteration.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUD_Iteration.Name = "NUD_Iteration";
            this.NUD_Iteration.Size = new System.Drawing.Size(260, 23);
            this.NUD_Iteration.TabIndex = 1;
            this.NUD_Iteration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Iteration limit:";
            // 
            // BTN_Run_one
            // 
            this.BTN_Run_one.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Run_one.Enabled = false;
            this.BTN_Run_one.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Run_one.Location = new System.Drawing.Point(5, 70);
            this.BTN_Run_one.Name = "BTN_Run_one";
            this.BTN_Run_one.Size = new System.Drawing.Size(372, 40);
            this.BTN_Run_one.TabIndex = 2;
            this.BTN_Run_one.Text = "Run one iteration";
            this.BTN_Run_one.UseVisualStyleBackColor = true;
            this.BTN_Run_one.Click += new System.EventHandler(this.BTN_Run_one_Click);
            // 
            // BTN_Run_to_end
            // 
            this.BTN_Run_to_end.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Run_to_end.Enabled = false;
            this.BTN_Run_to_end.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Run_to_end.Location = new System.Drawing.Point(5, 120);
            this.BTN_Run_to_end.Name = "BTN_Run_to_end";
            this.BTN_Run_to_end.Size = new System.Drawing.Size(372, 40);
            this.BTN_Run_to_end.TabIndex = 1;
            this.BTN_Run_to_end.Text = "Run to end";
            this.BTN_Run_to_end.UseVisualStyleBackColor = true;
            this.BTN_Run_to_end.Click += new System.EventHandler(this.BTN_Run_to_end_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Reset.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Reset.Location = new System.Drawing.Point(5, 20);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(372, 40);
            this.BTN_Reset.TabIndex = 0;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // GB_Animation
            // 
            this.GB_Animation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Animation.Controls.Add(this.label12);
            this.GB_Animation.Controls.Add(this.TKB_Animation);
            this.GB_Animation.Controls.Add(this.CKB_Show_animation);
            this.GB_Animation.Location = new System.Drawing.Point(5, 489);
            this.GB_Animation.Name = "GB_Animation";
            this.GB_Animation.Size = new System.Drawing.Size(384, 97);
            this.GB_Animation.TabIndex = 3;
            this.GB_Animation.TabStop = false;
            this.GB_Animation.Text = "Animation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Animation interval:";
            // 
            // TKB_Animation
            // 
            this.TKB_Animation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TKB_Animation.Location = new System.Drawing.Point(9, 46);
            this.TKB_Animation.Minimum = 1;
            this.TKB_Animation.Name = "TKB_Animation";
            this.TKB_Animation.Size = new System.Drawing.Size(369, 45);
            this.TKB_Animation.TabIndex = 1;
            this.TKB_Animation.Value = 1;
            // 
            // CKB_Show_animation
            // 
            this.CKB_Show_animation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CKB_Show_animation.AutoSize = true;
            this.CKB_Show_animation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_Show_animation.Location = new System.Drawing.Point(236, 15);
            this.CKB_Show_animation.Name = "CKB_Show_animation";
            this.CKB_Show_animation.Size = new System.Drawing.Size(142, 25);
            this.CKB_Show_animation.TabIndex = 0;
            this.CKB_Show_animation.Text = "Show animation";
            this.CKB_Show_animation.UseVisualStyleBackColor = true;
            this.CKB_Show_animation.CheckedChanged += new System.EventHandler(this.CKB_Show_animation_CheckedChanged);
            // 
            // GB_Selection
            // 
            this.GB_Selection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Selection.Controls.Add(this.RDB_Deterministic);
            this.GB_Selection.Controls.Add(this.RDB_Stochastic);
            this.GB_Selection.Location = new System.Drawing.Point(5, 339);
            this.GB_Selection.Name = "GB_Selection";
            this.GB_Selection.Size = new System.Drawing.Size(384, 50);
            this.GB_Selection.TabIndex = 2;
            this.GB_Selection.TabStop = false;
            this.GB_Selection.Text = "Selection";
            // 
            // RDB_Deterministic
            // 
            this.RDB_Deterministic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RDB_Deterministic.AutoSize = true;
            this.RDB_Deterministic.Checked = true;
            this.RDB_Deterministic.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Deterministic.Location = new System.Drawing.Point(200, 15);
            this.RDB_Deterministic.Name = "RDB_Deterministic";
            this.RDB_Deterministic.Size = new System.Drawing.Size(120, 25);
            this.RDB_Deterministic.TabIndex = 1;
            this.RDB_Deterministic.TabStop = true;
            this.RDB_Deterministic.Text = "Deterministic";
            this.RDB_Deterministic.UseVisualStyleBackColor = true;
            // 
            // RDB_Stochastic
            // 
            this.RDB_Stochastic.AutoSize = true;
            this.RDB_Stochastic.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Stochastic.Location = new System.Drawing.Point(15, 15);
            this.RDB_Stochastic.Name = "RDB_Stochastic";
            this.RDB_Stochastic.Size = new System.Drawing.Size(98, 25);
            this.RDB_Stochastic.TabIndex = 0;
            this.RDB_Stochastic.Text = "Stochastic";
            this.RDB_Stochastic.UseVisualStyleBackColor = true;
            // 
            // GB_Parameter
            // 
            this.GB_Parameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Parameter.Controls.Add(this.NUD_Least_Fitness_Fraction);
            this.GB_Parameter.Controls.Add(this.label1);
            this.GB_Parameter.Controls.Add(this.NUD_mutaterate);
            this.GB_Parameter.Controls.Add(this.NUD_crossrate);
            this.GB_Parameter.Controls.Add(this.NUD_population);
            this.GB_Parameter.Controls.Add(this.label11);
            this.GB_Parameter.Controls.Add(this.label10);
            this.GB_Parameter.Controls.Add(this.label9);
            this.GB_Parameter.Location = new System.Drawing.Point(5, 210);
            this.GB_Parameter.Name = "GB_Parameter";
            this.GB_Parameter.Size = new System.Drawing.Size(384, 128);
            this.GB_Parameter.TabIndex = 1;
            this.GB_Parameter.TabStop = false;
            this.GB_Parameter.Text = "Parameters";
            // 
            // NUD_Least_Fitness_Fraction
            // 
            this.NUD_Least_Fitness_Fraction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Least_Fitness_Fraction.DecimalPlaces = 3;
            this.NUD_Least_Fitness_Fraction.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NUD_Least_Fitness_Fraction.Location = new System.Drawing.Point(171, 99);
            this.NUD_Least_Fitness_Fraction.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUD_Least_Fitness_Fraction.Name = "NUD_Least_Fitness_Fraction";
            this.NUD_Least_Fitness_Fraction.Size = new System.Drawing.Size(207, 23);
            this.NUD_Least_Fitness_Fraction.TabIndex = 16;
            this.NUD_Least_Fitness_Fraction.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Least Fitness Fraction:";
            // 
            // NUD_mutaterate
            // 
            this.NUD_mutaterate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_mutaterate.DecimalPlaces = 3;
            this.NUD_mutaterate.Location = new System.Drawing.Point(171, 70);
            this.NUD_mutaterate.Name = "NUD_mutaterate";
            this.NUD_mutaterate.Size = new System.Drawing.Size(207, 23);
            this.NUD_mutaterate.TabIndex = 14;
            this.NUD_mutaterate.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // NUD_crossrate
            // 
            this.NUD_crossrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_crossrate.DecimalPlaces = 3;
            this.NUD_crossrate.Location = new System.Drawing.Point(171, 45);
            this.NUD_crossrate.Name = "NUD_crossrate";
            this.NUD_crossrate.Size = new System.Drawing.Size(207, 23);
            this.NUD_crossrate.TabIndex = 13;
            this.NUD_crossrate.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // NUD_population
            // 
            this.NUD_population.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_population.Location = new System.Drawing.Point(171, 20);
            this.NUD_population.Name = "NUD_population";
            this.NUD_population.Size = new System.Drawing.Size(207, 23);
            this.NUD_population.TabIndex = 2;
            this.NUD_population.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mutation Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Crossover Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Population Size:";
            // 
            // GB_GA_encoding
            // 
            this.GB_GA_encoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_GA_encoding.Controls.Add(this.NUD_Penalty_Factor);
            this.GB_GA_encoding.Controls.Add(this.CB_Permutation_Mutat_Type);
            this.GB_GA_encoding.Controls.Add(this.CB_Permutation_Cross_Type);
            this.GB_GA_encoding.Controls.Add(this.CB_Binary_Cross_Type);
            this.GB_GA_encoding.Controls.Add(this.label8);
            this.GB_GA_encoding.Controls.Add(this.label7);
            this.GB_GA_encoding.Controls.Add(this.label6);
            this.GB_GA_encoding.Controls.Add(this.label5);
            this.GB_GA_encoding.Controls.Add(this.RDB_Permutation);
            this.GB_GA_encoding.Controls.Add(this.RDB_Binary);
            this.GB_GA_encoding.Location = new System.Drawing.Point(5, 5);
            this.GB_GA_encoding.Name = "GB_GA_encoding";
            this.GB_GA_encoding.Size = new System.Drawing.Size(381, 202);
            this.GB_GA_encoding.TabIndex = 0;
            this.GB_GA_encoding.TabStop = false;
            this.GB_GA_encoding.Text = "GA encoding";
            // 
            // NUD_Penalty_Factor
            // 
            this.NUD_Penalty_Factor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Penalty_Factor.Location = new System.Drawing.Point(156, 80);
            this.NUD_Penalty_Factor.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_Penalty_Factor.Name = "NUD_Penalty_Factor";
            this.NUD_Penalty_Factor.Size = new System.Drawing.Size(219, 23);
            this.NUD_Penalty_Factor.TabIndex = 2;
            this.NUD_Penalty_Factor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CB_Permutation_Mutat_Type
            // 
            this.CB_Permutation_Mutat_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Permutation_Mutat_Type.FormattingEnabled = true;
            this.CB_Permutation_Mutat_Type.Items.AddRange(new object[] {
            "Inversion Mutation",
            "Insertion Mutation",
            "Displacement Mutation",
            "Reciprocla Exchange Mutation",
            "Heuristic"});
            this.CB_Permutation_Mutat_Type.Location = new System.Drawing.Point(129, 170);
            this.CB_Permutation_Mutat_Type.Name = "CB_Permutation_Mutat_Type";
            this.CB_Permutation_Mutat_Type.Size = new System.Drawing.Size(246, 23);
            this.CB_Permutation_Mutat_Type.TabIndex = 8;
            this.CB_Permutation_Mutat_Type.Text = "Inversion Mutation";
            // 
            // CB_Permutation_Cross_Type
            // 
            this.CB_Permutation_Cross_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Permutation_Cross_Type.FormattingEnabled = true;
            this.CB_Permutation_Cross_Type.Items.AddRange(new object[] {
            "Partial-mapped Crossover",
            "Order Crossover",
            "Position-based Crossover",
            "Order-based Crossover",
            "Cycle Crossover",
            "Subtour Exchange"});
            this.CB_Permutation_Cross_Type.Location = new System.Drawing.Point(129, 140);
            this.CB_Permutation_Cross_Type.Name = "CB_Permutation_Cross_Type";
            this.CB_Permutation_Cross_Type.Size = new System.Drawing.Size(246, 23);
            this.CB_Permutation_Cross_Type.TabIndex = 7;
            this.CB_Permutation_Cross_Type.Text = "Partial-mapped Crossover";
            // 
            // CB_Binary_Cross_Type
            // 
            this.CB_Binary_Cross_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Binary_Cross_Type.FormattingEnabled = true;
            this.CB_Binary_Cross_Type.Items.AddRange(new object[] {
            "One Point Cut",
            "Two Points Cut",
            "N Points Cut"});
            this.CB_Binary_Cross_Type.Location = new System.Drawing.Point(129, 50);
            this.CB_Binary_Cross_Type.Name = "CB_Binary_Cross_Type";
            this.CB_Binary_Cross_Type.Size = new System.Drawing.Size(246, 23);
            this.CB_Binary_Cross_Type.TabIndex = 6;
            this.CB_Binary_Cross_Type.Text = "One Point Cut";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mutation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Crossover:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Penalty Factor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Crossover:";
            // 
            // RDB_Permutation
            // 
            this.RDB_Permutation.AutoSize = true;
            this.RDB_Permutation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Permutation.Location = new System.Drawing.Point(5, 110);
            this.RDB_Permutation.Name = "RDB_Permutation";
            this.RDB_Permutation.Size = new System.Drawing.Size(114, 25);
            this.RDB_Permutation.TabIndex = 1;
            this.RDB_Permutation.TabStop = true;
            this.RDB_Permutation.Text = "Permutation";
            this.RDB_Permutation.UseVisualStyleBackColor = true;
            // 
            // RDB_Binary
            // 
            this.RDB_Binary.AutoSize = true;
            this.RDB_Binary.Checked = true;
            this.RDB_Binary.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Binary.Location = new System.Drawing.Point(5, 20);
            this.RDB_Binary.Name = "RDB_Binary";
            this.RDB_Binary.Size = new System.Drawing.Size(72, 25);
            this.RDB_Binary.TabIndex = 0;
            this.RDB_Binary.TabStop = true;
            this.RDB_Binary.Text = "Binary";
            this.RDB_Binary.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Chart_Main);
            this.splitContainer2.Size = new System.Drawing.Size(843, 845);
            this.splitContainer2.SplitterDistance = 374;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox11);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox10);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox8);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox9);
            this.splitContainer3.Size = new System.Drawing.Size(843, 374);
            this.splitContainer3.SplitterDistance = 220;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.LTB_HCV);
            this.groupBox11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(3, 227);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(214, 144);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Hard constrain vilolation";
            // 
            // LTB_HCV
            // 
            this.LTB_HCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTB_HCV.FormattingEnabled = true;
            this.LTB_HCV.ItemHeight = 21;
            this.LTB_HCV.Location = new System.Drawing.Point(5, 28);
            this.LTB_HCV.Name = "LTB_HCV";
            this.LTB_HCV.Size = new System.Drawing.Size(202, 109);
            this.LTB_HCV.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.TB_shortest_time);
            this.groupBox10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(3, 158);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(214, 63);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Shortest time";
            // 
            // TB_shortest_time
            // 
            this.TB_shortest_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_shortest_time.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_shortest_time.Location = new System.Drawing.Point(5, 25);
            this.TB_shortest_time.Name = "TB_shortest_time";
            this.TB_shortest_time.Size = new System.Drawing.Size(202, 23);
            this.TB_shortest_time.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.LTB_BOV);
            this.groupBox8.Controls.Add(this.TB_BOV);
            this.groupBox8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(214, 148);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Best objective value";
            // 
            // LTB_BOV
            // 
            this.LTB_BOV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTB_BOV.FormattingEnabled = true;
            this.LTB_BOV.ItemHeight = 21;
            this.LTB_BOV.Location = new System.Drawing.Point(5, 52);
            this.LTB_BOV.Name = "LTB_BOV";
            this.LTB_BOV.Size = new System.Drawing.Size(202, 88);
            this.LTB_BOV.TabIndex = 1;
            // 
            // TB_BOV
            // 
            this.TB_BOV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_BOV.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BOV.Location = new System.Drawing.Point(5, 25);
            this.TB_BOV.Name = "TB_BOV";
            this.TB_BOV.Size = new System.Drawing.Size(202, 23);
            this.TB_BOV.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.LTB_Population);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(619, 374);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Population";
            // 
            // LTB_Population
            // 
            this.LTB_Population.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTB_Population.FormattingEnabled = true;
            this.LTB_Population.HorizontalScrollbar = true;
            this.LTB_Population.ItemHeight = 21;
            this.LTB_Population.Location = new System.Drawing.Point(6, 29);
            this.LTB_Population.Name = "LTB_Population";
            this.LTB_Population.Size = new System.Drawing.Size(607, 319);
            this.LTB_Population.TabIndex = 1;
            // 
            // Chart_Main
            // 
            this.Chart_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.Chart_Main.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.Chart_Main.Legends.Add(legend1);
            this.Chart_Main.Location = new System.Drawing.Point(0, 0);
            this.Chart_Main.Name = "Chart_Main";
            this.Chart_Main.Size = new System.Drawing.Size(843, 442);
            this.Chart_Main.TabIndex = 0;
            this.Chart_Main.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_model_status,
            this.TSL_Iteration});
            this.statusStrip1.Location = new System.Drawing.Point(0, 872);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1249, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSL_model_status
            // 
            this.TSL_model_status.AutoSize = false;
            this.TSL_model_status.BackColor = System.Drawing.Color.MistyRose;
            this.TSL_model_status.Name = "TSL_model_status";
            this.TSL_model_status.Size = new System.Drawing.Size(250, 17);
            // 
            // TSL_Iteration
            // 
            this.TSL_Iteration.AutoSize = false;
            this.TSL_Iteration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TSL_Iteration.Name = "TSL_Iteration";
            this.TSL_Iteration.Size = new System.Drawing.Size(150, 17);
            // 
            // TM_GA
            // 
            this.TM_GA.Tick += new System.EventHandler(this.TM_GA_Tick);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 894);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Tool_Strip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Binary & Permutation Encoding GA for Job Assignment Problems";
            this.Tool_Strip.ResumeLayout(false);
            this.Tool_Strip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TBC_main.ResumeLayout(false);
            this.TP_Problem.ResumeLayout(false);
            this.GB_GeneratedProblem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Problem)).EndInit();
            this.GB_ProblemSetting.ResumeLayout(false);
            this.GB_ProblemSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_minimum)).EndInit();
            this.TP_Settings.ResumeLayout(false);
            this.GB_Optimization.ResumeLayout(false);
            this.GB_Optimization.PerformLayout();
            this.GB_Mutation.ResumeLayout(false);
            this.GB_Mutation.PerformLayout();
            this.GB_Action.ResumeLayout(false);
            this.GB_Action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Iteration)).EndInit();
            this.GB_Animation.ResumeLayout(false);
            this.GB_Animation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_Animation)).EndInit();
            this.GB_Selection.ResumeLayout(false);
            this.GB_Selection.PerformLayout();
            this.GB_Parameter.ResumeLayout(false);
            this.GB_Parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Least_Fitness_Fraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_mutaterate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_crossrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_population)).EndInit();
            this.GB_GA_encoding.ResumeLayout(false);
            this.GB_GA_encoding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Penalty_Factor)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Main)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip Tool_Strip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl TBC_main;
        private System.Windows.Forms.TabPage TP_Problem;
        private System.Windows.Forms.TabPage TP_Settings;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Main;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Problem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox GB_ProblemSetting;
        private System.Windows.Forms.ComboBox CB_Number_of_Jobs;
        private System.Windows.Forms.Button BTN_proGenerate;
        private System.Windows.Forms.GroupBox GB_GeneratedProblem;
        private System.Windows.Forms.GroupBox GB_GA_encoding;
        private System.Windows.Forms.ComboBox CB_Permutation_Mutat_Type;
        private System.Windows.Forms.ComboBox CB_Permutation_Cross_Type;
        private System.Windows.Forms.ComboBox CB_Binary_Cross_Type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RDB_Permutation;
        private System.Windows.Forms.RadioButton RDB_Binary;
        private System.Windows.Forms.GroupBox GB_Parameter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GB_Animation;
        private System.Windows.Forms.GroupBox GB_Selection;
        private System.Windows.Forms.RadioButton RDB_Deterministic;
        private System.Windows.Forms.RadioButton RDB_Stochastic;
        private System.Windows.Forms.GroupBox GB_Action;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BTN_Run_one;
        private System.Windows.Forms.Button BTN_Run_to_end;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar TKB_Animation;
        private System.Windows.Forms.CheckBox CKB_Show_animation;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox TB_shortest_time;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TB_BOV;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown NUD_maximum;
        private System.Windows.Forms.NumericUpDown NUD_minimum;
        private System.Windows.Forms.NumericUpDown NUD_population;
        private System.Windows.Forms.NumericUpDown NUD_mutaterate;
        private System.Windows.Forms.NumericUpDown NUD_crossrate;
        private System.Windows.Forms.NumericUpDown NUD_Iteration;
        private System.Windows.Forms.Timer TM_GA;
        private System.Windows.Forms.GroupBox GB_Mutation;
        private System.Windows.Forms.RadioButton RDB_Chrom_Base;
        private System.Windows.Forms.RadioButton RDB_Genes_Base;
        private System.Windows.Forms.NumericUpDown NUD_Penalty_Factor;
        private System.Windows.Forms.GroupBox GB_Optimization;
        private System.Windows.Forms.RadioButton RDB_Mini;
        private System.Windows.Forms.RadioButton RDB_Maxi;
        private System.Windows.Forms.ListBox LTB_Population;
        private System.Windows.Forms.NumericUpDown NUD_Least_Fitness_Fraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LTB_BOV;
        private System.Windows.Forms.ListBox LTB_HCV;
        private System.Windows.Forms.ToolStripStatusLabel TSL_model_status;
        private System.Windows.Forms.ToolStripStatusLabel TSL_Iteration;
        private System.Windows.Forms.ToolStripDropDownButton TSDDBTN_File;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

