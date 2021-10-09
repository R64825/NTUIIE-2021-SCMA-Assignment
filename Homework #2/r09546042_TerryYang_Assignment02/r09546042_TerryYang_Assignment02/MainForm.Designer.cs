
namespace r09546042_TerryYang_Assignment01
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BTN_plot = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.LSB_Graph_Type = new System.Windows.Forms.ListBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.TKB_para_04 = new System.Windows.Forms.TrackBar();
            this.TKB_para_03 = new System.Windows.Forms.TrackBar();
            this.TKB_para_02 = new System.Windows.Forms.TrackBar();
            this.TKB_para_01 = new System.Windows.Forms.TrackBar();
            this.NUD_parameter_04 = new System.Windows.Forms.NumericUpDown();
            this.NUD_parameter_03 = new System.Windows.Forms.NumericUpDown();
            this.NUD_parameter_02 = new System.Windows.Forms.NumericUpDown();
            this.NUD_parameter_01 = new System.Windows.Forms.NumericUpDown();
            this.LB_parameter_01 = new System.Windows.Forms.Label();
            this.LB_parameter_04 = new System.Windows.Forms.Label();
            this.LB_parameter_03 = new System.Windows.Forms.Label();
            this.LB_parameter_02 = new System.Windows.Forms.Label();
            this.PB_function = new System.Windows.Forms.PictureBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BTN_clear = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TCB_main = new System.Windows.Forms.ToolStripComboBox();
            this.CB_Plot_graph = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_function)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Chart
            // 
            this.Main_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX2.MinorGrid.Interval = 1D;
            chartArea1.AxisY.Maximum = 1.2D;
            chartArea1.AxisY.Title = "Y";
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            this.Main_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(0, 27);
            this.Main_Chart.Name = "Main_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Size = new System.Drawing.Size(617, 577);
            this.Main_Chart.TabIndex = 0;
            this.Main_Chart.Text = "chart1";
            title1.Name = "Fuzzy membership function";
            this.Main_Chart.Titles.Add(title1);
            // 
            // BTN_plot
            // 
            this.BTN_plot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_plot.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_plot.Location = new System.Drawing.Point(2, 542);
            this.BTN_plot.Name = "BTN_plot";
            this.BTN_plot.Size = new System.Drawing.Size(128, 59);
            this.BTN_plot.TabIndex = 1;
            this.BTN_plot.Text = "Plot Graph";
            this.BTN_plot.UseVisualStyleBackColor = true;
            this.BTN_plot.Visible = false;
            this.BTN_plot.Click += new System.EventHandler(this.BTN_Plot_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BTN_plot);
            this.splitContainer1.Panel2.Controls.Add(this.Main_Chart);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(929, 604);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 3;
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(308, 604);
            this.splitContainer2.SplitterDistance = 538;
            this.splitContainer2.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer4.Size = new System.Drawing.Size(308, 538);
            this.splitContainer4.SplitterDistance = 161;
            this.splitContainer4.TabIndex = 30;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.LSB_Graph_Type);
            this.splitContainer5.Size = new System.Drawing.Size(308, 161);
            this.splitContainer5.SplitterDistance = 40;
            this.splitContainer5.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graph Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSB_Graph_Type
            // 
            this.LSB_Graph_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSB_Graph_Type.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LSB_Graph_Type.FormattingEnabled = true;
            this.LSB_Graph_Type.ItemHeight = 21;
            this.LSB_Graph_Type.Items.AddRange(new object[] {
            "Triangular",
            "Gaussian",
            "Bell",
            "Sigmoidal",
            "LeftRight"});
            this.LSB_Graph_Type.Location = new System.Drawing.Point(0, 0);
            this.LSB_Graph_Type.Name = "LSB_Graph_Type";
            this.LSB_Graph_Type.Size = new System.Drawing.Size(308, 117);
            this.LSB_Graph_Type.TabIndex = 29;
            this.LSB_Graph_Type.SelectedIndexChanged += new System.EventHandler(this.LSB_Graph_Type_SelectedIndexChanged);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer6.Size = new System.Drawing.Size(308, 373);
            this.splitContainer6.SplitterDistance = 59;
            this.splitContainer6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parameters:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.TKB_para_04);
            this.splitContainer7.Panel1.Controls.Add(this.TKB_para_03);
            this.splitContainer7.Panel1.Controls.Add(this.TKB_para_02);
            this.splitContainer7.Panel1.Controls.Add(this.TKB_para_01);
            this.splitContainer7.Panel1.Controls.Add(this.NUD_parameter_04);
            this.splitContainer7.Panel1.Controls.Add(this.NUD_parameter_03);
            this.splitContainer7.Panel1.Controls.Add(this.NUD_parameter_02);
            this.splitContainer7.Panel1.Controls.Add(this.NUD_parameter_01);
            this.splitContainer7.Panel1.Controls.Add(this.LB_parameter_01);
            this.splitContainer7.Panel1.Controls.Add(this.LB_parameter_04);
            this.splitContainer7.Panel1.Controls.Add(this.LB_parameter_03);
            this.splitContainer7.Panel1.Controls.Add(this.LB_parameter_02);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.PB_function);
            this.splitContainer7.Size = new System.Drawing.Size(308, 310);
            this.splitContainer7.SplitterDistance = 165;
            this.splitContainer7.TabIndex = 38;
            // 
            // TKB_para_04
            // 
            this.TKB_para_04.Location = new System.Drawing.Point(201, 131);
            this.TKB_para_04.Name = "TKB_para_04";
            this.TKB_para_04.Size = new System.Drawing.Size(104, 45);
            this.TKB_para_04.TabIndex = 44;
            this.TKB_para_04.Visible = false;
            this.TKB_para_04.Scroll += new System.EventHandler(this.TKB_paras_Scroll);
            // 
            // TKB_para_03
            // 
            this.TKB_para_03.Location = new System.Drawing.Point(201, 92);
            this.TKB_para_03.Name = "TKB_para_03";
            this.TKB_para_03.Size = new System.Drawing.Size(104, 45);
            this.TKB_para_03.TabIndex = 43;
            this.TKB_para_03.Scroll += new System.EventHandler(this.TKB_paras_Scroll);
            // 
            // TKB_para_02
            // 
            this.TKB_para_02.Location = new System.Drawing.Point(201, 51);
            this.TKB_para_02.Name = "TKB_para_02";
            this.TKB_para_02.Size = new System.Drawing.Size(104, 45);
            this.TKB_para_02.TabIndex = 42;
            this.TKB_para_02.Scroll += new System.EventHandler(this.TKB_paras_Scroll);
            // 
            // TKB_para_01
            // 
            this.TKB_para_01.Location = new System.Drawing.Point(201, 12);
            this.TKB_para_01.Name = "TKB_para_01";
            this.TKB_para_01.Size = new System.Drawing.Size(104, 45);
            this.TKB_para_01.TabIndex = 41;
            this.TKB_para_01.Scroll += new System.EventHandler(this.TKB_paras_Scroll);
            // 
            // NUD_parameter_04
            // 
            this.NUD_parameter_04.Location = new System.Drawing.Point(115, 131);
            this.NUD_parameter_04.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_parameter_04.Name = "NUD_parameter_04";
            this.NUD_parameter_04.Size = new System.Drawing.Size(80, 22);
            this.NUD_parameter_04.TabIndex = 40;
            this.NUD_parameter_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_parameter_04.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUD_parameter_04.Visible = false;
            this.NUD_parameter_04.ValueChanged += new System.EventHandler(this.NUD_paras_ValueChanged);
            // 
            // NUD_parameter_03
            // 
            this.NUD_parameter_03.DecimalPlaces = 1;
            this.NUD_parameter_03.Location = new System.Drawing.Point(115, 93);
            this.NUD_parameter_03.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUD_parameter_03.Name = "NUD_parameter_03";
            this.NUD_parameter_03.Size = new System.Drawing.Size(80, 22);
            this.NUD_parameter_03.TabIndex = 39;
            this.NUD_parameter_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_parameter_03.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_parameter_03.ValueChanged += new System.EventHandler(this.NUD_paras_ValueChanged);
            // 
            // NUD_parameter_02
            // 
            this.NUD_parameter_02.DecimalPlaces = 1;
            this.NUD_parameter_02.Location = new System.Drawing.Point(115, 51);
            this.NUD_parameter_02.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUD_parameter_02.Name = "NUD_parameter_02";
            this.NUD_parameter_02.Size = new System.Drawing.Size(80, 22);
            this.NUD_parameter_02.TabIndex = 38;
            this.NUD_parameter_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_parameter_02.ValueChanged += new System.EventHandler(this.NUD_paras_ValueChanged);
            // 
            // NUD_parameter_01
            // 
            this.NUD_parameter_01.DecimalPlaces = 1;
            this.NUD_parameter_01.Location = new System.Drawing.Point(115, 13);
            this.NUD_parameter_01.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUD_parameter_01.Name = "NUD_parameter_01";
            this.NUD_parameter_01.Size = new System.Drawing.Size(80, 22);
            this.NUD_parameter_01.TabIndex = 37;
            this.NUD_parameter_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_parameter_01.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.NUD_parameter_01.ValueChanged += new System.EventHandler(this.NUD_paras_ValueChanged);
            // 
            // LB_parameter_01
            // 
            this.LB_parameter_01.AutoSize = true;
            this.LB_parameter_01.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_parameter_01.Location = new System.Drawing.Point(18, 12);
            this.LB_parameter_01.Name = "LB_parameter_01";
            this.LB_parameter_01.Size = new System.Drawing.Size(44, 21);
            this.LB_parameter_01.TabIndex = 29;
            this.LB_parameter_01.Text = "Left:";
            // 
            // LB_parameter_04
            // 
            this.LB_parameter_04.AutoSize = true;
            this.LB_parameter_04.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_parameter_04.Location = new System.Drawing.Point(18, 132);
            this.LB_parameter_04.Name = "LB_parameter_04";
            this.LB_parameter_04.Size = new System.Drawing.Size(87, 21);
            this.LB_parameter_04.TabIndex = 35;
            this.LB_parameter_04.Text = "resolution:";
            this.LB_parameter_04.Visible = false;
            // 
            // LB_parameter_03
            // 
            this.LB_parameter_03.AutoSize = true;
            this.LB_parameter_03.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_parameter_03.Location = new System.Drawing.Point(18, 92);
            this.LB_parameter_03.Name = "LB_parameter_03";
            this.LB_parameter_03.Size = new System.Drawing.Size(54, 21);
            this.LB_parameter_03.TabIndex = 31;
            this.LB_parameter_03.Text = "Right:";
            // 
            // LB_parameter_02
            // 
            this.LB_parameter_02.AutoSize = true;
            this.LB_parameter_02.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_parameter_02.Location = new System.Drawing.Point(18, 52);
            this.LB_parameter_02.Name = "LB_parameter_02";
            this.LB_parameter_02.Size = new System.Drawing.Size(63, 21);
            this.LB_parameter_02.TabIndex = 30;
            this.LB_parameter_02.Text = "Center:";
            // 
            // PB_function
            // 
            this.PB_function.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_function.Image = global::r09546042_TerryYang_Assignment02.Properties.Resources.Triangular_function;
            this.PB_function.Location = new System.Drawing.Point(0, 0);
            this.PB_function.Name = "PB_function";
            this.PB_function.Size = new System.Drawing.Size(308, 141);
            this.PB_function.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_function.TabIndex = 37;
            this.PB_function.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.CB_Plot_graph);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.BTN_clear);
            this.splitContainer3.Size = new System.Drawing.Size(308, 62);
            this.splitContainer3.SplitterDistance = 188;
            this.splitContainer3.TabIndex = 2;
            // 
            // BTN_clear
            // 
            this.BTN_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_clear.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_clear.Location = new System.Drawing.Point(0, 0);
            this.BTN_clear.Name = "BTN_clear";
            this.BTN_clear.Size = new System.Drawing.Size(116, 62);
            this.BTN_clear.TabIndex = 2;
            this.BTN_clear.Text = "Clear";
            this.BTN_clear.UseVisualStyleBackColor = true;
            this.BTN_clear.Click += new System.EventHandler(this.BTN_clear_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TCB_main});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(617, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TCB_main
            // 
            this.TCB_main.Items.AddRange(new object[] {
            "Triangular",
            "Gaussian",
            "Bell",
            "Sigmoidal",
            "LeftRight"});
            this.TCB_main.Name = "TCB_main";
            this.TCB_main.Size = new System.Drawing.Size(121, 23);
            this.TCB_main.Text = "Triangular";
            this.TCB_main.SelectedIndexChanged += new System.EventHandler(this.TCB_main_SelectedIndexChanged);
            // 
            // CB_Plot_graph
            // 
            this.CB_Plot_graph.AutoSize = true;
            this.CB_Plot_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Plot_graph.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_Plot_graph.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CB_Plot_graph.Location = new System.Drawing.Point(0, 0);
            this.CB_Plot_graph.Name = "CB_Plot_graph";
            this.CB_Plot_graph.Size = new System.Drawing.Size(188, 62);
            this.CB_Plot_graph.TabIndex = 2;
            this.CB_Plot_graph.Text = "Plot Graph";
            this.CB_Plot_graph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_Plot_graph.UseVisualStyleBackColor = true;
            this.CB_Plot_graph.Click += new System.EventHandler(this.BTN_Plot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 604);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainForm";
            this.Text = "Fuzzy Graph Plotting";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKB_para_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_parameter_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_function)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.Button BTN_plot;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button BTN_clear;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ListBox LSB_Graph_Type;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Label LB_parameter_04;
        private System.Windows.Forms.Label LB_parameter_01;
        private System.Windows.Forms.Label LB_parameter_02;
        private System.Windows.Forms.Label LB_parameter_03;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripComboBox TCB_main;
        private System.Windows.Forms.PictureBox PB_function;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.NumericUpDown NUD_parameter_04;
        private System.Windows.Forms.NumericUpDown NUD_parameter_03;
        private System.Windows.Forms.NumericUpDown NUD_parameter_02;
        private System.Windows.Forms.NumericUpDown NUD_parameter_01;
        private System.Windows.Forms.TrackBar TKB_para_01;
        private System.Windows.Forms.TrackBar TKB_para_04;
        private System.Windows.Forms.TrackBar TKB_para_03;
        private System.Windows.Forms.TrackBar TKB_para_02;
        private System.Windows.Forms.CheckBox CB_Plot_graph;
    }
}

