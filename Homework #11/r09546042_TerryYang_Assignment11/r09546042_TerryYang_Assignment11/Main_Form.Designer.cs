﻿
namespace r09546042_TerryYang_Assignment11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LSB_Layers = new System.Windows.Forms.ListBox();
            this.BTN_Reset_NN = new System.Windows.Forms.Button();
            this.BTN_Train_One = new System.Windows.Forms.Button();
            this.BTN_Run_To_End = new System.Windows.Forms.Button();
            this.PPTG = new System.Windows.Forms.PropertyGrid();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PPTG);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Run_To_End);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Train_One);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Reset_NN);
            this.splitContainer1.Panel1.Controls.Add(this.LSB_Layers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(885, 543);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 2;
            // 
            // LSB_Layers
            // 
            this.LSB_Layers.FormattingEnabled = true;
            this.LSB_Layers.ItemHeight = 12;
            this.LSB_Layers.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.LSB_Layers.Location = new System.Drawing.Point(12, 16);
            this.LSB_Layers.Name = "LSB_Layers";
            this.LSB_Layers.Size = new System.Drawing.Size(239, 136);
            this.LSB_Layers.TabIndex = 0;
            // 
            // BTN_Reset_NN
            // 
            this.BTN_Reset_NN.Location = new System.Drawing.Point(13, 159);
            this.BTN_Reset_NN.Name = "BTN_Reset_NN";
            this.BTN_Reset_NN.Size = new System.Drawing.Size(136, 29);
            this.BTN_Reset_NN.TabIndex = 1;
            this.BTN_Reset_NN.Text = "Reset NN";
            this.BTN_Reset_NN.UseVisualStyleBackColor = true;
            this.BTN_Reset_NN.Click += new System.EventHandler(this.BTN_Reset_NN_Click);
            // 
            // BTN_Train_One
            // 
            this.BTN_Train_One.Location = new System.Drawing.Point(12, 194);
            this.BTN_Train_One.Name = "BTN_Train_One";
            this.BTN_Train_One.Size = new System.Drawing.Size(136, 29);
            this.BTN_Train_One.TabIndex = 2;
            this.BTN_Train_One.Text = "Train an epoch";
            this.BTN_Train_One.UseVisualStyleBackColor = true;
            this.BTN_Train_One.Click += new System.EventHandler(this.BTN_Train_One_Click);
            // 
            // BTN_Run_To_End
            // 
            this.BTN_Run_To_End.Location = new System.Drawing.Point(13, 229);
            this.BTN_Run_To_End.Name = "BTN_Run_To_End";
            this.BTN_Run_To_End.Size = new System.Drawing.Size(136, 29);
            this.BTN_Run_To_End.TabIndex = 3;
            this.BTN_Run_To_End.Text = "Train to end";
            this.BTN_Run_To_End.UseVisualStyleBackColor = true;
            this.BTN_Run_To_End.Click += new System.EventHandler(this.BTN_Run_To_End_Click);
            // 
            // PPTG
            // 
            this.PPTG.Location = new System.Drawing.Point(13, 265);
            this.PPTG.Name = "PPTG";
            this.PPTG.Size = new System.Drawing.Size(279, 266);
            this.PPTG.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.splitContainer2.Size = new System.Drawing.Size(586, 543);
            this.splitContainer2.SplitterDistance = 195;
            this.splitContainer2.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(34, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(540, 145);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 592);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main Form";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid PPTG;
        private System.Windows.Forms.Button BTN_Run_To_End;
        private System.Windows.Forms.Button BTN_Train_One;
        private System.Windows.Forms.Button BTN_Reset_NN;
        private System.Windows.Forms.ListBox LSB_Layers;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
