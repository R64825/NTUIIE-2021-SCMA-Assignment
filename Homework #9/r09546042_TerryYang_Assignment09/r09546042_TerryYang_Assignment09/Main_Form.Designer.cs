
namespace r09546042_TerryYang_Assignment09
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.CB_Animation = new System.Windows.Forms.CheckBox();
            this.BTN_Run_To_End = new System.Windows.Forms.Button();
            this.BTN_Run_One = new System.Windows.Forms.Button();
            this.LST_Problem = new System.Windows.Forms.ListBox();
            this.TC_Model = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTN_Create_ACS_Model = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_GA = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.PPTG_model = new System.Windows.Forms.PropertyGrid();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CT_Model = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBC_Show_result = new System.Windows.Forms.TabControl();
            this.TP_Route = new System.Windows.Forms.TabPage();
            this.CT_Route = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_Phrom_and_Sol = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.LSB_Phromone = new System.Windows.Forms.ListBox();
            this.LSB_Solution = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TS_BTN_Openfile = new System.Windows.Forms.ToolStripButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_SFTSL = new System.Windows.Forms.Label();
            this.GB_Model = new System.Windows.Forms.GroupBox();
            this.LB_SFTBS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.TC_Model.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_Model)).BeginInit();
            this.TBC_Show_result.SuspendLayout();
            this.TP_Route.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_Route)).BeginInit();
            this.TB_Phrom_and_Sol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GB_Model.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1242, 736);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.LB_SFTBS);
            this.splitContainer3.Panel1.Controls.Add(this.GB_Model);
            this.splitContainer3.Panel1.Controls.Add(this.LB_SFTSL);
            this.splitContainer3.Panel1.Controls.Add(this.LST_Problem);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.PPTG_model);
            this.splitContainer3.Size = new System.Drawing.Size(411, 736);
            this.splitContainer3.SplitterDistance = 387;
            this.splitContainer3.TabIndex = 0;
            // 
            // CB_Animation
            // 
            this.CB_Animation.AutoSize = true;
            this.CB_Animation.Location = new System.Drawing.Point(9, 130);
            this.CB_Animation.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CB_Animation.Name = "CB_Animation";
            this.CB_Animation.Size = new System.Drawing.Size(82, 18);
            this.CB_Animation.TabIndex = 6;
            this.CB_Animation.Text = "Animation";
            this.CB_Animation.UseVisualStyleBackColor = true;
            this.CB_Animation.CheckedChanged += new System.EventHandler(this.CB_Animation_CheckedChanged);
            // 
            // BTN_Run_To_End
            // 
            this.BTN_Run_To_End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Run_To_End.Enabled = false;
            this.BTN_Run_To_End.Location = new System.Drawing.Point(168, 110);
            this.BTN_Run_To_End.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTN_Run_To_End.Name = "BTN_Run_To_End";
            this.BTN_Run_To_End.Size = new System.Drawing.Size(216, 38);
            this.BTN_Run_To_End.TabIndex = 5;
            this.BTN_Run_To_End.Text = "Run to end";
            this.BTN_Run_To_End.UseVisualStyleBackColor = true;
            this.BTN_Run_To_End.Click += new System.EventHandler(this.BTN_Run_To_End_Click);
            // 
            // BTN_Run_One
            // 
            this.BTN_Run_One.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Run_One.Enabled = false;
            this.BTN_Run_One.Location = new System.Drawing.Point(168, 64);
            this.BTN_Run_One.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTN_Run_One.Name = "BTN_Run_One";
            this.BTN_Run_One.Size = new System.Drawing.Size(216, 38);
            this.BTN_Run_One.TabIndex = 4;
            this.BTN_Run_One.Text = "Run one";
            this.BTN_Run_One.UseVisualStyleBackColor = true;
            this.BTN_Run_One.Click += new System.EventHandler(this.BTN_Run_One_Click);
            // 
            // LST_Problem
            // 
            this.LST_Problem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LST_Problem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_Problem.FormattingEnabled = true;
            this.LST_Problem.ItemHeight = 26;
            this.LST_Problem.Location = new System.Drawing.Point(13, 34);
            this.LST_Problem.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LST_Problem.Name = "LST_Problem";
            this.LST_Problem.Size = new System.Drawing.Size(388, 82);
            this.LST_Problem.TabIndex = 3;
            // 
            // TC_Model
            // 
            this.TC_Model.Controls.Add(this.tabPage1);
            this.TC_Model.Controls.Add(this.tabPage2);
            this.TC_Model.Location = new System.Drawing.Point(5, 18);
            this.TC_Model.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TC_Model.Name = "TC_Model";
            this.TC_Model.SelectedIndex = 0;
            this.TC_Model.Size = new System.Drawing.Size(140, 80);
            this.TC_Model.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTN_Create_ACS_Model);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage1.Size = new System.Drawing.Size(132, 53);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ACO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTN_Create_ACS_Model
            // 
            this.BTN_Create_ACS_Model.Location = new System.Drawing.Point(6, 7);
            this.BTN_Create_ACS_Model.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTN_Create_ACS_Model.Name = "BTN_Create_ACS_Model";
            this.BTN_Create_ACS_Model.Size = new System.Drawing.Size(120, 38);
            this.BTN_Create_ACS_Model.TabIndex = 0;
            this.BTN_Create_ACS_Model.Text = "Create ACS solver";
            this.BTN_Create_ACS_Model.UseVisualStyleBackColor = true;
            this.BTN_Create_ACS_Model.Click += new System.EventHandler(this.BTN_Create_ACS_Model_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_GA);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage2.Size = new System.Drawing.Size(132, 53);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_GA
            // 
            this.BTN_GA.Location = new System.Drawing.Point(6, 7);
            this.BTN_GA.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTN_GA.Name = "BTN_GA";
            this.BTN_GA.Size = new System.Drawing.Size(120, 38);
            this.BTN_GA.TabIndex = 2;
            this.BTN_GA.Text = "Create GA solver";
            this.BTN_GA.UseVisualStyleBackColor = true;
            this.BTN_GA.Click += new System.EventHandler(this.BTN_GA_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Reset.Enabled = false;
            this.BTN_Reset.Location = new System.Drawing.Point(168, 18);
            this.BTN_Reset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(216, 38);
            this.BTN_Reset.TabIndex = 1;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // PPTG_model
            // 
            this.PPTG_model.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPTG_model.Location = new System.Drawing.Point(0, 0);
            this.PPTG_model.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PPTG_model.Name = "PPTG_model";
            this.PPTG_model.Size = new System.Drawing.Size(411, 345);
            this.PPTG_model.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.CT_Model);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TBC_Show_result);
            this.splitContainer2.Size = new System.Drawing.Size(827, 736);
            this.splitContainer2.SplitterDistance = 481;
            this.splitContainer2.TabIndex = 0;
            // 
            // CT_Model
            // 
            this.CT_Model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.CT_Model.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.CT_Model.Legends.Add(legend1);
            this.CT_Model.Location = new System.Drawing.Point(0, 34);
            this.CT_Model.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CT_Model.Name = "CT_Model";
            this.CT_Model.Size = new System.Drawing.Size(827, 447);
            this.CT_Model.TabIndex = 0;
            this.CT_Model.Text = "chart1";
            // 
            // TBC_Show_result
            // 
            this.TBC_Show_result.Controls.Add(this.TP_Route);
            this.TBC_Show_result.Controls.Add(this.TB_Phrom_and_Sol);
            this.TBC_Show_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBC_Show_result.Location = new System.Drawing.Point(0, 0);
            this.TBC_Show_result.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TBC_Show_result.Name = "TBC_Show_result";
            this.TBC_Show_result.SelectedIndex = 0;
            this.TBC_Show_result.Size = new System.Drawing.Size(827, 251);
            this.TBC_Show_result.TabIndex = 1;
            // 
            // TP_Route
            // 
            this.TP_Route.Controls.Add(this.CT_Route);
            this.TP_Route.Location = new System.Drawing.Point(4, 23);
            this.TP_Route.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TP_Route.Name = "TP_Route";
            this.TP_Route.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TP_Route.Size = new System.Drawing.Size(820, 224);
            this.TP_Route.TabIndex = 0;
            this.TP_Route.Text = "Cites & Routes";
            this.TP_Route.UseVisualStyleBackColor = true;
            // 
            // CT_Route
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.CT_Route.ChartAreas.Add(chartArea2);
            this.CT_Route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CT_Route.Location = new System.Drawing.Point(2, 4);
            this.CT_Route.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CT_Route.Name = "CT_Route";
            this.CT_Route.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.CT_Route.Series.Add(series1);
            this.CT_Route.Size = new System.Drawing.Size(816, 216);
            this.CT_Route.TabIndex = 0;
            this.CT_Route.Text = "chart2";
            // 
            // TB_Phrom_and_Sol
            // 
            this.TB_Phrom_and_Sol.Controls.Add(this.splitContainer4);
            this.TB_Phrom_and_Sol.Location = new System.Drawing.Point(4, 23);
            this.TB_Phrom_and_Sol.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TB_Phrom_and_Sol.Name = "TB_Phrom_and_Sol";
            this.TB_Phrom_and_Sol.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TB_Phrom_and_Sol.Size = new System.Drawing.Size(819, 224);
            this.TB_Phrom_and_Sol.TabIndex = 1;
            this.TB_Phrom_and_Sol.Text = "Pheromone & Solutions";
            this.TB_Phrom_and_Sol.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(2, 4);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.LSB_Phromone);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.LSB_Solution);
            this.splitContainer4.Size = new System.Drawing.Size(815, 216);
            this.splitContainer4.SplitterDistance = 268;
            this.splitContainer4.TabIndex = 0;
            // 
            // LSB_Phromone
            // 
            this.LSB_Phromone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSB_Phromone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSB_Phromone.FormattingEnabled = true;
            this.LSB_Phromone.ItemHeight = 19;
            this.LSB_Phromone.Location = new System.Drawing.Point(0, 0);
            this.LSB_Phromone.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LSB_Phromone.Name = "LSB_Phromone";
            this.LSB_Phromone.Size = new System.Drawing.Size(268, 216);
            this.LSB_Phromone.TabIndex = 1;
            // 
            // LSB_Solution
            // 
            this.LSB_Solution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSB_Solution.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSB_Solution.FormattingEnabled = true;
            this.LSB_Solution.ItemHeight = 19;
            this.LSB_Solution.Location = new System.Drawing.Point(0, 0);
            this.LSB_Solution.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LSB_Solution.Name = "LSB_Solution";
            this.LSB_Solution.Size = new System.Drawing.Size(543, 216);
            this.LSB_Solution.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1242, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_BTN_Openfile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1242, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TS_BTN_Openfile
            // 
            this.TS_BTN_Openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TS_BTN_Openfile.Image = ((System.Drawing.Image)(resources.GetObject("TS_BTN_Openfile.Image")));
            this.TS_BTN_Openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BTN_Openfile.Name = "TS_BTN_Openfile";
            this.TS_BTN_Openfile.Size = new System.Drawing.Size(76, 22);
            this.TS_BTN_Openfile.Text = "Open TSP...";
            this.TS_BTN_Openfile.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LB_SFTSL
            // 
            this.LB_SFTSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_SFTSL.Location = new System.Drawing.Point(14, 302);
            this.LB_SFTSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_SFTSL.Name = "LB_SFTSL";
            this.LB_SFTSL.Size = new System.Drawing.Size(382, 14);
            this.LB_SFTSL.TabIndex = 8;
            this.LB_SFTSL.Text = "So Far The Shorest Length: ";
            // 
            // GB_Model
            // 
            this.GB_Model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Model.Controls.Add(this.CB_Animation);
            this.GB_Model.Controls.Add(this.BTN_Reset);
            this.GB_Model.Controls.Add(this.BTN_Run_To_End);
            this.GB_Model.Controls.Add(this.BTN_Run_One);
            this.GB_Model.Controls.Add(this.TC_Model);
            this.GB_Model.Enabled = false;
            this.GB_Model.Location = new System.Drawing.Point(12, 124);
            this.GB_Model.Name = "GB_Model";
            this.GB_Model.Size = new System.Drawing.Size(389, 165);
            this.GB_Model.TabIndex = 9;
            this.GB_Model.TabStop = false;
            this.GB_Model.Text = "Solver";
            // 
            // LB_SFTBS
            // 
            this.LB_SFTBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_SFTBS.Location = new System.Drawing.Point(15, 325);
            this.LB_SFTBS.Name = "LB_SFTBS";
            this.LB_SFTBS.Size = new System.Drawing.Size(378, 50);
            this.LB_SFTBS.TabIndex = 10;
            this.LB_SFTBS.Text = "So Far The Best Solution: ";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 760);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Main_Form";
            this.Text = "TSP Solver(ACO, GA)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.TC_Model.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CT_Model)).EndInit();
            this.TBC_Show_result.ResumeLayout(false);
            this.TP_Route.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CT_Route)).EndInit();
            this.TB_Phrom_and_Sol.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GB_Model.ResumeLayout(false);
            this.GB_Model.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PropertyGrid PPTG_model;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CT_Model;
        private System.Windows.Forms.DataVisualization.Charting.Chart CT_Route;
        private System.Windows.Forms.ToolStripButton TS_BTN_Openfile;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Create_ACS_Model;
        private System.Windows.Forms.TabControl TC_Model;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TBC_Show_result;
        private System.Windows.Forms.TabPage TP_Route;
        private System.Windows.Forms.TabPage TB_Phrom_and_Sol;
        private System.Windows.Forms.ListBox LST_Problem;
        private System.Windows.Forms.Button BTN_Run_One;
        private System.Windows.Forms.ListBox LSB_Solution;
        private System.Windows.Forms.ListBox LSB_Phromone;
        private System.Windows.Forms.Button BTN_Run_To_End;
        private System.Windows.Forms.CheckBox CB_Animation;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button BTN_GA;
        private System.Windows.Forms.Label LB_SFTSL;
        private System.Windows.Forms.Label LB_SFTBS;
        private System.Windows.Forms.GroupBox GB_Model;
    }
}

