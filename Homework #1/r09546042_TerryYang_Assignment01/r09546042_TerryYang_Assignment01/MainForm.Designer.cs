
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BTN_plot = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TC_main = new System.Windows.Forms.TabControl();
            this.Triangular_Series = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_c = new System.Windows.Forms.TextBox();
            this.TB_b = new System.Windows.Forms.TextBox();
            this.TB_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gaussian_Series = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TB_res = new System.Windows.Forms.TextBox();
            this.TB_sigma = new System.Windows.Forms.TextBox();
            this.TB_mean = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bell_Series = new System.Windows.Forms.TabPage();
            this.TB_res_01 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TB_c_01 = new System.Windows.Forms.TextBox();
            this.TB_b_01 = new System.Windows.Forms.TextBox();
            this.TB_a_01 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BTN_clear = new System.Windows.Forms.Button();
            this.Sigmoidal_Series = new System.Windows.Forms.TabPage();
            this.TB_sig_res = new System.Windows.Forms.TextBox();
            this.TB_sig_c = new System.Windows.Forms.TextBox();
            this.TB_sig_a = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LeftRight_Series = new System.Windows.Forms.TabPage();
            this.TB_lef_res = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_lef_beta = new System.Windows.Forms.TextBox();
            this.TB_lef_alpha = new System.Windows.Forms.TextBox();
            this.TB_lef_c = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TCB_main = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.TC_main.SuspendLayout();
            this.Triangular_Series.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Gaussian_Series.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Bell_Series.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.Sigmoidal_Series.SuspendLayout();
            this.LeftRight_Series.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Chart
            // 
            this.Main_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.Title = "X";
            chartArea5.AxisX2.MinorGrid.Interval = 1D;
            chartArea5.AxisY.Title = "Y";
            chartArea5.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea5);
            this.Main_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend5);
            this.Main_Chart.Location = new System.Drawing.Point(0, 0);
            this.Main_Chart.Name = "Main_Chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.Main_Chart.Series.Add(series5);
            this.Main_Chart.Size = new System.Drawing.Size(530, 450);
            this.Main_Chart.TabIndex = 0;
            this.Main_Chart.Text = "chart1";
            // 
            // BTN_plot
            // 
            this.BTN_plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_plot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_plot.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_plot.Location = new System.Drawing.Point(0, 0);
            this.BTN_plot.Name = "BTN_plot";
            this.BTN_plot.Size = new System.Drawing.Size(163, 70);
            this.BTN_plot.TabIndex = 1;
            this.BTN_plot.Text = "Plot Graph";
            this.BTN_plot.UseVisualStyleBackColor = true;
            this.BTN_plot.Click += new System.EventHandler(this.button1_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.Main_Chart);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
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
            this.splitContainer2.Panel1.Controls.Add(this.TC_main);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(266, 450);
            this.splitContainer2.SplitterDistance = 376;
            this.splitContainer2.TabIndex = 3;
            // 
            // TC_main
            // 
            this.TC_main.Controls.Add(this.Triangular_Series);
            this.TC_main.Controls.Add(this.Gaussian_Series);
            this.TC_main.Controls.Add(this.Bell_Series);
            this.TC_main.Controls.Add(this.Sigmoidal_Series);
            this.TC_main.Controls.Add(this.LeftRight_Series);
            this.TC_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_main.Location = new System.Drawing.Point(0, 27);
            this.TC_main.Name = "TC_main";
            this.TC_main.SelectedIndex = 0;
            this.TC_main.Size = new System.Drawing.Size(266, 349);
            this.TC_main.TabIndex = 3;
            this.TC_main.SelectedIndexChanged += new System.EventHandler(this.TC_main_SelectedIndexChanged);
            // 
            // Triangular_Series
            // 
            this.Triangular_Series.Controls.Add(this.pictureBox1);
            this.Triangular_Series.Controls.Add(this.TB_c);
            this.Triangular_Series.Controls.Add(this.TB_b);
            this.Triangular_Series.Controls.Add(this.TB_a);
            this.Triangular_Series.Controls.Add(this.label3);
            this.Triangular_Series.Controls.Add(this.label2);
            this.Triangular_Series.Controls.Add(this.label1);
            this.Triangular_Series.Location = new System.Drawing.Point(4, 22);
            this.Triangular_Series.Name = "Triangular_Series";
            this.Triangular_Series.Padding = new System.Windows.Forms.Padding(3);
            this.Triangular_Series.Size = new System.Drawing.Size(258, 350);
            this.Triangular_Series.TabIndex = 0;
            this.Triangular_Series.Text = "Triangular_Series";
            this.Triangular_Series.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TB_c
            // 
            this.TB_c.Location = new System.Drawing.Point(130, 110);
            this.TB_c.Name = "TB_c";
            this.TB_c.Size = new System.Drawing.Size(80, 22);
            this.TB_c.TabIndex = 5;
            this.TB_c.Text = "1";
            // 
            // TB_b
            // 
            this.TB_b.Location = new System.Drawing.Point(130, 70);
            this.TB_b.Name = "TB_b";
            this.TB_b.Size = new System.Drawing.Size(80, 22);
            this.TB_b.TabIndex = 4;
            this.TB_b.Text = "0";
            // 
            // TB_a
            // 
            this.TB_a.Location = new System.Drawing.Point(130, 30);
            this.TB_a.Name = "TB_a";
            this.TB_a.Size = new System.Drawing.Size(80, 22);
            this.TB_a.TabIndex = 3;
            this.TB_a.Text = "-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Right:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peak:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left:";
            // 
            // Gaussian_Series
            // 
            this.Gaussian_Series.Controls.Add(this.pictureBox2);
            this.Gaussian_Series.Controls.Add(this.TB_res);
            this.Gaussian_Series.Controls.Add(this.TB_sigma);
            this.Gaussian_Series.Controls.Add(this.TB_mean);
            this.Gaussian_Series.Controls.Add(this.label4);
            this.Gaussian_Series.Controls.Add(this.label5);
            this.Gaussian_Series.Controls.Add(this.label6);
            this.Gaussian_Series.Location = new System.Drawing.Point(4, 22);
            this.Gaussian_Series.Name = "Gaussian_Series";
            this.Gaussian_Series.Padding = new System.Windows.Forms.Padding(3);
            this.Gaussian_Series.Size = new System.Drawing.Size(258, 350);
            this.Gaussian_Series.TabIndex = 1;
            this.Gaussian_Series.Text = "Gaussian_Series";
            this.Gaussian_Series.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // TB_res
            // 
            this.TB_res.Location = new System.Drawing.Point(130, 110);
            this.TB_res.Name = "TB_res";
            this.TB_res.Size = new System.Drawing.Size(80, 22);
            this.TB_res.TabIndex = 11;
            this.TB_res.Text = "100";
            // 
            // TB_sigma
            // 
            this.TB_sigma.Location = new System.Drawing.Point(130, 70);
            this.TB_sigma.Name = "TB_sigma";
            this.TB_sigma.Size = new System.Drawing.Size(80, 22);
            this.TB_sigma.TabIndex = 10;
            this.TB_sigma.Text = "1";
            // 
            // TB_mean
            // 
            this.TB_mean.Location = new System.Drawing.Point(130, 30);
            this.TB_mean.Name = "TB_mean";
            this.TB_mean.Size = new System.Drawing.Size(80, 22);
            this.TB_mean.TabIndex = 9;
            this.TB_mean.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "resolution:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Siigma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mean:";
            // 
            // Bell_Series
            // 
            this.Bell_Series.Controls.Add(this.TB_res_01);
            this.Bell_Series.Controls.Add(this.label10);
            this.Bell_Series.Controls.Add(this.pictureBox3);
            this.Bell_Series.Controls.Add(this.TB_c_01);
            this.Bell_Series.Controls.Add(this.TB_b_01);
            this.Bell_Series.Controls.Add(this.TB_a_01);
            this.Bell_Series.Controls.Add(this.label7);
            this.Bell_Series.Controls.Add(this.label8);
            this.Bell_Series.Controls.Add(this.label9);
            this.Bell_Series.Location = new System.Drawing.Point(4, 22);
            this.Bell_Series.Name = "Bell_Series";
            this.Bell_Series.Size = new System.Drawing.Size(258, 323);
            this.Bell_Series.TabIndex = 2;
            this.Bell_Series.Text = "Bell-Series";
            this.Bell_Series.UseVisualStyleBackColor = true;
            // 
            // TB_res_01
            // 
            this.TB_res_01.Location = new System.Drawing.Point(130, 150);
            this.TB_res_01.Name = "TB_res_01";
            this.TB_res_01.Size = new System.Drawing.Size(80, 22);
            this.TB_res_01.TabIndex = 20;
            this.TB_res_01.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "resolution:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(258, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // TB_c_01
            // 
            this.TB_c_01.Location = new System.Drawing.Point(130, 110);
            this.TB_c_01.Name = "TB_c_01";
            this.TB_c_01.Size = new System.Drawing.Size(80, 22);
            this.TB_c_01.TabIndex = 17;
            this.TB_c_01.Text = "0";
            // 
            // TB_b_01
            // 
            this.TB_b_01.Location = new System.Drawing.Point(130, 70);
            this.TB_b_01.Name = "TB_b_01";
            this.TB_b_01.Size = new System.Drawing.Size(80, 22);
            this.TB_b_01.TabIndex = 16;
            this.TB_b_01.Text = "1";
            // 
            // TB_a_01
            // 
            this.TB_a_01.Location = new System.Drawing.Point(130, 30);
            this.TB_a_01.Name = "TB_a_01";
            this.TB_a_01.Size = new System.Drawing.Size(80, 22);
            this.TB_a_01.TabIndex = 15;
            this.TB_a_01.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Center:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Flatness:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Variation:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.BTN_plot);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.BTN_clear);
            this.splitContainer3.Size = new System.Drawing.Size(266, 70);
            this.splitContainer3.SplitterDistance = 163;
            this.splitContainer3.TabIndex = 2;
            // 
            // BTN_clear
            // 
            this.BTN_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_clear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_clear.Location = new System.Drawing.Point(0, 0);
            this.BTN_clear.Name = "BTN_clear";
            this.BTN_clear.Size = new System.Drawing.Size(99, 70);
            this.BTN_clear.TabIndex = 2;
            this.BTN_clear.Text = "Clear";
            this.BTN_clear.UseVisualStyleBackColor = true;
            this.BTN_clear.Click += new System.EventHandler(this.BTN_clear_Click);
            // 
            // Sigmoidal_Series
            // 
            this.Sigmoidal_Series.Controls.Add(this.TB_sig_res);
            this.Sigmoidal_Series.Controls.Add(this.TB_sig_c);
            this.Sigmoidal_Series.Controls.Add(this.TB_sig_a);
            this.Sigmoidal_Series.Controls.Add(this.label12);
            this.Sigmoidal_Series.Controls.Add(this.label13);
            this.Sigmoidal_Series.Controls.Add(this.label14);
            this.Sigmoidal_Series.Location = new System.Drawing.Point(4, 22);
            this.Sigmoidal_Series.Name = "Sigmoidal_Series";
            this.Sigmoidal_Series.Size = new System.Drawing.Size(258, 323);
            this.Sigmoidal_Series.TabIndex = 3;
            this.Sigmoidal_Series.Text = "Sigmoidal_Series";
            this.Sigmoidal_Series.UseVisualStyleBackColor = true;
            // 
            // TB_sig_res
            // 
            this.TB_sig_res.Location = new System.Drawing.Point(130, 110);
            this.TB_sig_res.Name = "TB_sig_res";
            this.TB_sig_res.Size = new System.Drawing.Size(80, 22);
            this.TB_sig_res.TabIndex = 26;
            this.TB_sig_res.Text = "100";
            // 
            // TB_sig_c
            // 
            this.TB_sig_c.Location = new System.Drawing.Point(130, 70);
            this.TB_sig_c.Name = "TB_sig_c";
            this.TB_sig_c.Size = new System.Drawing.Size(80, 22);
            this.TB_sig_c.TabIndex = 25;
            this.TB_sig_c.Text = "0";
            // 
            // TB_sig_a
            // 
            this.TB_sig_a.Location = new System.Drawing.Point(130, 30);
            this.TB_sig_a.Name = "TB_sig_a";
            this.TB_sig_a.Size = new System.Drawing.Size(80, 22);
            this.TB_sig_a.TabIndex = 24;
            this.TB_sig_a.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "resolution:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Center:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Sharpness:";
            // 
            // LeftRight_Series
            // 
            this.LeftRight_Series.Controls.Add(this.TB_lef_res);
            this.LeftRight_Series.Controls.Add(this.label11);
            this.LeftRight_Series.Controls.Add(this.TB_lef_beta);
            this.LeftRight_Series.Controls.Add(this.TB_lef_alpha);
            this.LeftRight_Series.Controls.Add(this.TB_lef_c);
            this.LeftRight_Series.Controls.Add(this.label15);
            this.LeftRight_Series.Controls.Add(this.label16);
            this.LeftRight_Series.Controls.Add(this.label17);
            this.LeftRight_Series.Location = new System.Drawing.Point(4, 22);
            this.LeftRight_Series.Name = "LeftRight_Series";
            this.LeftRight_Series.Size = new System.Drawing.Size(258, 323);
            this.LeftRight_Series.TabIndex = 4;
            this.LeftRight_Series.Text = "LeftRight_Series";
            this.LeftRight_Series.UseVisualStyleBackColor = true;
            // 
            // TB_lef_res
            // 
            this.TB_lef_res.Location = new System.Drawing.Point(130, 150);
            this.TB_lef_res.Name = "TB_lef_res";
            this.TB_lef_res.Size = new System.Drawing.Size(80, 22);
            this.TB_lef_res.TabIndex = 28;
            this.TB_lef_res.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "resolution:";
            // 
            // TB_lef_beta
            // 
            this.TB_lef_beta.Location = new System.Drawing.Point(130, 110);
            this.TB_lef_beta.Name = "TB_lef_beta";
            this.TB_lef_beta.Size = new System.Drawing.Size(80, 22);
            this.TB_lef_beta.TabIndex = 26;
            this.TB_lef_beta.Text = "1";
            // 
            // TB_lef_alpha
            // 
            this.TB_lef_alpha.Location = new System.Drawing.Point(130, 70);
            this.TB_lef_alpha.Name = "TB_lef_alpha";
            this.TB_lef_alpha.Size = new System.Drawing.Size(80, 22);
            this.TB_lef_alpha.TabIndex = 25;
            this.TB_lef_alpha.Text = "1";
            // 
            // TB_lef_c
            // 
            this.TB_lef_c.Location = new System.Drawing.Point(130, 30);
            this.TB_lef_c.Name = "TB_lef_c";
            this.TB_lef_c.Size = new System.Drawing.Size(80, 22);
            this.TB_lef_c.TabIndex = 24;
            this.TB_lef_c.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 21);
            this.label15.TabIndex = 23;
            this.label15.Text = "Beta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(30, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "Alpha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 21);
            this.label17.TabIndex = 21;
            this.label17.Text = "Center:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TCB_main});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(266, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            this.TCB_main.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Fuzzy Graph Plotting";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.TC_main.ResumeLayout(false);
            this.Triangular_Series.ResumeLayout(false);
            this.Triangular_Series.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Gaussian_Series.ResumeLayout(false);
            this.Gaussian_Series.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Bell_Series.ResumeLayout(false);
            this.Bell_Series.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.Sigmoidal_Series.ResumeLayout(false);
            this.Sigmoidal_Series.PerformLayout();
            this.LeftRight_Series.ResumeLayout(false);
            this.LeftRight_Series.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.Button BTN_plot;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl TC_main;
        private System.Windows.Forms.TabPage Triangular_Series;
        private System.Windows.Forms.TabPage Gaussian_Series;
        private System.Windows.Forms.TabPage Bell_Series;
        private System.Windows.Forms.TextBox TB_c;
        private System.Windows.Forms.TextBox TB_b;
        private System.Windows.Forms.TextBox TB_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_res;
        private System.Windows.Forms.TextBox TB_sigma;
        private System.Windows.Forms.TextBox TB_mean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TB_res_01;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TB_c_01;
        private System.Windows.Forms.TextBox TB_b_01;
        private System.Windows.Forms.TextBox TB_a_01;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button BTN_clear;
        private System.Windows.Forms.TabPage Sigmoidal_Series;
        private System.Windows.Forms.TextBox TB_sig_res;
        private System.Windows.Forms.TextBox TB_sig_c;
        private System.Windows.Forms.TextBox TB_sig_a;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage LeftRight_Series;
        private System.Windows.Forms.TextBox TB_lef_res;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_lef_beta;
        private System.Windows.Forms.TextBox TB_lef_alpha;
        private System.Windows.Forms.TextBox TB_lef_c;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox TCB_main;
    }
}

