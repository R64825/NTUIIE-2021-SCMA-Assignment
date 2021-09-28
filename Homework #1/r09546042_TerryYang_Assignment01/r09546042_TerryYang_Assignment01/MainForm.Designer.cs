
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BTN_plot = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.T_graph = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_c = new System.Windows.Forms.TextBox();
            this.TB_b = new System.Windows.Forms.TextBox();
            this.TB_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.G_graph = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TB_res = new System.Windows.Forms.TextBox();
            this.TB_sigma = new System.Windows.Forms.TextBox();
            this.TB_mean = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.B_graph = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.T_graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.G_graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.B_graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Chart
            // 
            chartArea1.AxisX2.MinorGrid.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            this.Main_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(0, 0);
            this.Main_Chart.Name = "Main_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Size = new System.Drawing.Size(530, 450);
            this.Main_Chart.TabIndex = 0;
            this.Main_Chart.Text = "chart1";
            // 
            // BTN_plot
            // 
            this.BTN_plot.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(266, 450);
            this.splitContainer2.SplitterDistance = 376;
            this.splitContainer2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.T_graph);
            this.tabControl1.Controls.Add(this.G_graph);
            this.tabControl1.Controls.Add(this.B_graph);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 376);
            this.tabControl1.TabIndex = 3;
            // 
            // T_graph
            // 
            this.T_graph.Controls.Add(this.pictureBox1);
            this.T_graph.Controls.Add(this.TB_c);
            this.T_graph.Controls.Add(this.TB_b);
            this.T_graph.Controls.Add(this.TB_a);
            this.T_graph.Controls.Add(this.label3);
            this.T_graph.Controls.Add(this.label2);
            this.T_graph.Controls.Add(this.label1);
            this.T_graph.Location = new System.Drawing.Point(4, 22);
            this.T_graph.Name = "T_graph";
            this.T_graph.Padding = new System.Windows.Forms.Padding(3);
            this.T_graph.Size = new System.Drawing.Size(258, 350);
            this.T_graph.TabIndex = 0;
            this.T_graph.Text = "T_graph";
            this.T_graph.UseVisualStyleBackColor = true;
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
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "c:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // G_graph
            // 
            this.G_graph.Controls.Add(this.pictureBox2);
            this.G_graph.Controls.Add(this.TB_res);
            this.G_graph.Controls.Add(this.TB_sigma);
            this.G_graph.Controls.Add(this.TB_mean);
            this.G_graph.Controls.Add(this.label4);
            this.G_graph.Controls.Add(this.label5);
            this.G_graph.Controls.Add(this.label6);
            this.G_graph.Location = new System.Drawing.Point(4, 22);
            this.G_graph.Name = "G_graph";
            this.G_graph.Padding = new System.Windows.Forms.Padding(3);
            this.G_graph.Size = new System.Drawing.Size(258, 350);
            this.G_graph.TabIndex = 1;
            this.G_graph.Text = "G_graph";
            this.G_graph.UseVisualStyleBackColor = true;
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
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "resolution:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(30, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "sigma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "mean:";
            // 
            // B_graph
            // 
            this.B_graph.Controls.Add(this.TB_res_01);
            this.B_graph.Controls.Add(this.label10);
            this.B_graph.Controls.Add(this.pictureBox3);
            this.B_graph.Controls.Add(this.TB_c_01);
            this.B_graph.Controls.Add(this.TB_b_01);
            this.B_graph.Controls.Add(this.TB_a_01);
            this.B_graph.Controls.Add(this.label7);
            this.B_graph.Controls.Add(this.label8);
            this.B_graph.Controls.Add(this.label9);
            this.B_graph.Location = new System.Drawing.Point(4, 22);
            this.B_graph.Name = "B_graph";
            this.B_graph.Size = new System.Drawing.Size(258, 350);
            this.B_graph.TabIndex = 2;
            this.B_graph.Text = "B_graph";
            this.B_graph.UseVisualStyleBackColor = true;
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
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(30, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "resolution:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 201);
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
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(30, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "c:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(30, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "b:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(30, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "a:";
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
            this.BTN_clear.Location = new System.Drawing.Point(0, 0);
            this.BTN_clear.Name = "BTN_clear";
            this.BTN_clear.Size = new System.Drawing.Size(99, 70);
            this.BTN_clear.TabIndex = 2;
            this.BTN_clear.Text = "Clear";
            this.BTN_clear.UseVisualStyleBackColor = true;
            this.BTN_clear.Click += new System.EventHandler(this.BTN_clear_Click);
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
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.T_graph.ResumeLayout(false);
            this.T_graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.G_graph.ResumeLayout(false);
            this.G_graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.B_graph.ResumeLayout(false);
            this.B_graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.Button BTN_plot;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage T_graph;
        private System.Windows.Forms.TabPage G_graph;
        private System.Windows.Forms.TabPage B_graph;
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
    }
}

