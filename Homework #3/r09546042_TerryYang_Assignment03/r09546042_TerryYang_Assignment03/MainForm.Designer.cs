
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.TV_Display = new System.Windows.Forms.TreeView();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BTN_add_area = new System.Windows.Forms.Button();
            this.BTN_delete_area = new System.Windows.Forms.Button();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.CB_fuzzy_type = new System.Windows.Forms.ComboBox();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.BTN_add_function = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PB_function = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PPGV_parameters = new System.Windows.Forms.PropertyGrid();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_function)).BeginInit();
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
            this.Main_Chart.Location = new System.Drawing.Point(0, 0);
            this.Main_Chart.Name = "Main_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Size = new System.Drawing.Size(740, 734);
            this.Main_Chart.TabIndex = 0;
            this.Main_Chart.Text = "chart1";
            title1.Name = "Fuzzy membership function";
            this.Main_Chart.Titles.Add(title1);
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
            this.splitContainer1.Size = new System.Drawing.Size(1112, 734);
            this.splitContainer1.SplitterDistance = 368;
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
            this.splitContainer2.Panel2.Controls.Add(this.PPGV_parameters);
            this.splitContainer2.Size = new System.Drawing.Size(368, 734);
            this.splitContainer2.SplitterDistance = 453;
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
            this.splitContainer4.Size = new System.Drawing.Size(368, 453);
            this.splitContainer4.SplitterDistance = 112;
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
            this.splitContainer5.Panel2.Controls.Add(this.TV_Display);
            this.splitContainer5.Size = new System.Drawing.Size(368, 112);
            this.splitContainer5.SplitterDistance = 27;
            this.splitContainer5.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Areas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TV_Display
            // 
            this.TV_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV_Display.Location = new System.Drawing.Point(0, 0);
            this.TV_Display.Name = "TV_Display";
            this.TV_Display.Size = new System.Drawing.Size(368, 81);
            this.TV_Display.TabIndex = 0;
            this.TV_Display.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_Display_AfterSelect);
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
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer6.Size = new System.Drawing.Size(368, 337);
            this.splitContainer6.SplitterDistance = 35;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.BTN_add_area);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.BTN_delete_area);
            this.splitContainer3.Size = new System.Drawing.Size(368, 35);
            this.splitContainer3.SplitterDistance = 231;
            this.splitContainer3.TabIndex = 0;
            // 
            // BTN_add_area
            // 
            this.BTN_add_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_add_area.Location = new System.Drawing.Point(0, 0);
            this.BTN_add_area.Name = "BTN_add_area";
            this.BTN_add_area.Size = new System.Drawing.Size(231, 35);
            this.BTN_add_area.TabIndex = 0;
            this.BTN_add_area.Text = "Add area";
            this.BTN_add_area.UseVisualStyleBackColor = true;
            this.BTN_add_area.Click += new System.EventHandler(this.BTN_add_area_Click);
            // 
            // BTN_delete_area
            // 
            this.BTN_delete_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_delete_area.Location = new System.Drawing.Point(0, 0);
            this.BTN_delete_area.Name = "BTN_delete_area";
            this.BTN_delete_area.Size = new System.Drawing.Size(133, 35);
            this.BTN_delete_area.TabIndex = 0;
            this.BTN_delete_area.Text = "Delete";
            this.BTN_delete_area.UseVisualStyleBackColor = true;
            this.BTN_delete_area.Click += new System.EventHandler(this.BTN_delete_area_Click);
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
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.label2);
            this.splitContainer7.Size = new System.Drawing.Size(368, 298);
            this.splitContainer7.SplitterDistance = 247;
            this.splitContainer7.TabIndex = 38;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.splitContainer9);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.PB_function);
            this.splitContainer8.Size = new System.Drawing.Size(368, 247);
            this.splitContainer8.SplitterDistance = 135;
            this.splitContainer8.TabIndex = 0;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.splitContainer10);
            this.splitContainer9.Size = new System.Drawing.Size(368, 135);
            this.splitContainer9.SplitterDistance = 68;
            this.splitContainer9.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 68);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fuzzy function:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.CB_fuzzy_type);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer10.Size = new System.Drawing.Size(368, 63);
            this.splitContainer10.SplitterDistance = 154;
            this.splitContainer10.TabIndex = 0;
            // 
            // CB_fuzzy_type
            // 
            this.CB_fuzzy_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_fuzzy_type.FormattingEnabled = true;
            this.CB_fuzzy_type.Items.AddRange(new object[] {
            "Triangular",
            "Bell",
            "Gaussian",
            "Sigmoidal",
            "LeftRight"});
            this.CB_fuzzy_type.Location = new System.Drawing.Point(0, 0);
            this.CB_fuzzy_type.Name = "CB_fuzzy_type";
            this.CB_fuzzy_type.Size = new System.Drawing.Size(154, 20);
            this.CB_fuzzy_type.TabIndex = 0;
            this.CB_fuzzy_type.Text = "Triangular";
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.BTN_add_function);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.button4);
            this.splitContainer11.Size = new System.Drawing.Size(210, 63);
            this.splitContainer11.SplitterDistance = 127;
            this.splitContainer11.TabIndex = 0;
            // 
            // BTN_add_function
            // 
            this.BTN_add_function.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_add_function.Location = new System.Drawing.Point(0, 0);
            this.BTN_add_function.Name = "BTN_add_function";
            this.BTN_add_function.Size = new System.Drawing.Size(127, 63);
            this.BTN_add_function.TabIndex = 1;
            this.BTN_add_function.Text = "Add fucntion";
            this.BTN_add_function.UseVisualStyleBackColor = true;
            this.BTN_add_function.Click += new System.EventHandler(this.BTN_add_function_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 63);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PB_function
            // 
            this.PB_function.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_function.Image = global::r09546042_TerryYang_Assignment03.Properties.Resources.Triangular_function;
            this.PB_function.Location = new System.Drawing.Point(0, 0);
            this.PB_function.Name = "PB_function";
            this.PB_function.Size = new System.Drawing.Size(368, 108);
            this.PB_function.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_function.TabIndex = 37;
            this.PB_function.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parameters:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PPGV_parameters
            // 
            this.PPGV_parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPGV_parameters.Location = new System.Drawing.Point(0, 0);
            this.PPGV_parameters.Name = "PPGV_parameters";
            this.PPGV_parameters.Size = new System.Drawing.Size(368, 277);
            this.PPGV_parameters.TabIndex = 0;
            this.PPGV_parameters.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PPGV_parameters_PropertyValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 734);
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
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_function)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PB_function;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.TreeView TV_Display;
        private System.Windows.Forms.PropertyGrid PPGV_parameters;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button BTN_add_area;
        private System.Windows.Forms.Button BTN_delete_area;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.ComboBox CB_fuzzy_type;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.Button BTN_add_function;
        private System.Windows.Forms.Button button4;
    }
}

