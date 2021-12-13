
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.LST_Problem = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_Create_ACS_Model = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBC_Show_result = new System.Windows.Forms.TabControl();
            this.TP_Route = new System.Windows.Forms.TabPage();
            this.CT_Route = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TB_Phrom_and_Sol = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TS_BTN_Openfile = new System.Windows.Forms.ToolStripButton();
            this.BTN_Run_One = new System.Windows.Forms.Button();
            this.LSB_Solution = new System.Windows.Forms.ListBox();
            this.LSB_Phromone = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.TBC_Show_result.SuspendLayout();
            this.TP_Route.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_Route)).BeginInit();
            this.TB_Phrom_and_Sol.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1242, 628);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer3.Panel1.Controls.Add(this.BTN_Run_One);
            this.splitContainer3.Panel1.Controls.Add(this.LST_Problem);
            this.splitContainer3.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer3.Panel1.Controls.Add(this.BTN_Reset);
            this.splitContainer3.Panel1.Controls.Add(this.BTN_Create_ACS_Model);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer3.Size = new System.Drawing.Size(411, 628);
            this.splitContainer3.SplitterDistance = 331;
            this.splitContainer3.TabIndex = 0;
            // 
            // LST_Problem
            // 
            this.LST_Problem.FormattingEnabled = true;
            this.LST_Problem.ItemHeight = 12;
            this.LST_Problem.Location = new System.Drawing.Point(13, 29);
            this.LST_Problem.Name = "LST_Problem";
            this.LST_Problem.Size = new System.Drawing.Size(387, 64);
            this.LST_Problem.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 191);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 136);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(389, 110);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(389, 110);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Location = new System.Drawing.Point(3, 153);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(120, 32);
            this.BTN_Reset.TabIndex = 1;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_Create_ACS_Model
            // 
            this.BTN_Create_ACS_Model.Location = new System.Drawing.Point(3, 115);
            this.BTN_Create_ACS_Model.Name = "BTN_Create_ACS_Model";
            this.BTN_Create_ACS_Model.Size = new System.Drawing.Size(120, 32);
            this.BTN_Create_ACS_Model.TabIndex = 0;
            this.BTN_Create_ACS_Model.Text = "Create ACS solver";
            this.BTN_Create_ACS_Model.UseVisualStyleBackColor = true;
            this.BTN_Create_ACS_Model.Click += new System.EventHandler(this.BTN_Create_ACS_Model_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(411, 293);
            this.propertyGrid1.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TBC_Show_result);
            this.splitContainer2.Size = new System.Drawing.Size(827, 628);
            this.splitContainer2.SplitterDistance = 411;
            this.splitContainer2.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Green;
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "Cites";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Shortest_Route";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "So_Far_The_Best_Route";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(827, 411);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // TBC_Show_result
            // 
            this.TBC_Show_result.Controls.Add(this.TP_Route);
            this.TBC_Show_result.Controls.Add(this.TB_Phrom_and_Sol);
            this.TBC_Show_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBC_Show_result.Location = new System.Drawing.Point(0, 0);
            this.TBC_Show_result.Name = "TBC_Show_result";
            this.TBC_Show_result.SelectedIndex = 0;
            this.TBC_Show_result.Size = new System.Drawing.Size(827, 213);
            this.TBC_Show_result.TabIndex = 1;
            // 
            // TP_Route
            // 
            this.TP_Route.Controls.Add(this.CT_Route);
            this.TP_Route.Location = new System.Drawing.Point(4, 22);
            this.TP_Route.Name = "TP_Route";
            this.TP_Route.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Route.Size = new System.Drawing.Size(819, 187);
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
            this.CT_Route.Location = new System.Drawing.Point(3, 3);
            this.CT_Route.Name = "CT_Route";
            this.CT_Route.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.CT_Route.Series.Add(series4);
            this.CT_Route.Size = new System.Drawing.Size(813, 181);
            this.CT_Route.TabIndex = 0;
            this.CT_Route.Text = "chart2";
            // 
            // TB_Phrom_and_Sol
            // 
            this.TB_Phrom_and_Sol.Controls.Add(this.LSB_Phromone);
            this.TB_Phrom_and_Sol.Controls.Add(this.LSB_Solution);
            this.TB_Phrom_and_Sol.Location = new System.Drawing.Point(4, 22);
            this.TB_Phrom_and_Sol.Name = "TB_Phrom_and_Sol";
            this.TB_Phrom_and_Sol.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Phrom_and_Sol.Size = new System.Drawing.Size(819, 187);
            this.TB_Phrom_and_Sol.TabIndex = 1;
            this.TB_Phrom_and_Sol.Text = "Pheromone & Solutions";
            this.TB_Phrom_and_Sol.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            // BTN_Run_One
            // 
            this.BTN_Run_One.Location = new System.Drawing.Point(129, 153);
            this.BTN_Run_One.Name = "BTN_Run_One";
            this.BTN_Run_One.Size = new System.Drawing.Size(120, 32);
            this.BTN_Run_One.TabIndex = 4;
            this.BTN_Run_One.Text = "Run one";
            this.BTN_Run_One.UseVisualStyleBackColor = true;
            this.BTN_Run_One.Click += new System.EventHandler(this.BTN_Run_One_Click);
            // 
            // LSB_Solution
            // 
            this.LSB_Solution.FormattingEnabled = true;
            this.LSB_Solution.ItemHeight = 12;
            this.LSB_Solution.Location = new System.Drawing.Point(408, 3);
            this.LSB_Solution.Name = "LSB_Solution";
            this.LSB_Solution.Size = new System.Drawing.Size(403, 184);
            this.LSB_Solution.TabIndex = 0;
            // 
            // LSB_Phromone
            // 
            this.LSB_Phromone.FormattingEnabled = true;
            this.LSB_Phromone.ItemHeight = 12;
            this.LSB_Phromone.Location = new System.Drawing.Point(3, 4);
            this.LSB_Phromone.Name = "LSB_Phromone";
            this.LSB_Phromone.Size = new System.Drawing.Size(403, 184);
            this.LSB_Phromone.TabIndex = 1;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 652);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.TBC_Show_result.ResumeLayout(false);
            this.TP_Route.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CT_Route)).EndInit();
            this.TB_Phrom_and_Sol.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CT_Route;
        private System.Windows.Forms.ToolStripButton TS_BTN_Openfile;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Create_ACS_Model;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TBC_Show_result;
        private System.Windows.Forms.TabPage TP_Route;
        private System.Windows.Forms.TabPage TB_Phrom_and_Sol;
        private System.Windows.Forms.ListBox LST_Problem;
        private System.Windows.Forms.Button BTN_Run_One;
        private System.Windows.Forms.ListBox LSB_Solution;
        private System.Windows.Forms.ListBox LSB_Phromone;
    }
}

