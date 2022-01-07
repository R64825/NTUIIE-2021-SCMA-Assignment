
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_Node = new System.Windows.Forms.NumericUpDown();
            this.LSB_Layers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Layer = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Reset_NN = new System.Windows.Forms.Button();
            this.BTN_Run_To_End = new System.Windows.Forms.Button();
            this.BTN_Train_One = new System.Windows.Forms.Button();
            this.PPTG = new System.Windows.Forms.PropertyGrid();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MLP_Print_DOC = new System.Drawing.Printing.PrintDocument();
            this.LB_RMSE = new System.Windows.Forms.Label();
            this.LB_Test = new System.Windows.Forms.Label();
            this.BTN_Classification = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.CB_Animation = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Node)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Layer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "Open...";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton2.Text = "Print MLP...";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(845, 549);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 2;
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
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.PPTG);
            this.splitContainer3.Size = new System.Drawing.Size(281, 549);
            this.splitContainer3.SplitterDistance = 325;
            this.splitContainer3.TabIndex = 9;
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
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer4.Size = new System.Drawing.Size(281, 325);
            this.splitContainer4.SplitterDistance = 143;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NUD_Node);
            this.groupBox1.Controls.Add(this.LSB_Layers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NUD_Layer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layer setting";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Node of layer";
            // 
            // NUD_Node
            // 
            this.NUD_Node.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Node.Location = new System.Drawing.Point(152, 111);
            this.NUD_Node.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Node.Name = "NUD_Node";
            this.NUD_Node.Size = new System.Drawing.Size(120, 22);
            this.NUD_Node.TabIndex = 6;
            this.NUD_Node.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Node.ValueChanged += new System.EventHandler(this.NUD_Node_ValueChanged);
            // 
            // LSB_Layers
            // 
            this.LSB_Layers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LSB_Layers.FormattingEnabled = true;
            this.LSB_Layers.ItemHeight = 12;
            this.LSB_Layers.Items.AddRange(new object[] {
            "2"});
            this.LSB_Layers.Location = new System.Drawing.Point(6, 21);
            this.LSB_Layers.Name = "LSB_Layers";
            this.LSB_Layers.Size = new System.Drawing.Size(137, 112);
            this.LSB_Layers.TabIndex = 0;
            this.LSB_Layers.SelectedIndexChanged += new System.EventHandler(this.LSB_Layers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of layer";
            // 
            // NUD_Layer
            // 
            this.NUD_Layer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Layer.Location = new System.Drawing.Point(152, 57);
            this.NUD_Layer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Layer.Name = "NUD_Layer";
            this.NUD_Layer.Size = new System.Drawing.Size(120, 22);
            this.NUD_Layer.TabIndex = 5;
            this.NUD_Layer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Layer.ValueChanged += new System.EventHandler(this.NUD_Layer_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_Animation);
            this.groupBox2.Controls.Add(this.BTN_Classification);
            this.groupBox2.Controls.Add(this.LB_Test);
            this.groupBox2.Controls.Add(this.LB_RMSE);
            this.groupBox2.Controls.Add(this.BTN_Reset_NN);
            this.groupBox2.Controls.Add(this.BTN_Run_To_End);
            this.groupBox2.Controls.Add(this.BTN_Train_One);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // BTN_Reset_NN
            // 
            this.BTN_Reset_NN.Location = new System.Drawing.Point(6, 21);
            this.BTN_Reset_NN.Name = "BTN_Reset_NN";
            this.BTN_Reset_NN.Size = new System.Drawing.Size(136, 29);
            this.BTN_Reset_NN.TabIndex = 1;
            this.BTN_Reset_NN.Text = "Reset NN";
            this.BTN_Reset_NN.UseVisualStyleBackColor = true;
            this.BTN_Reset_NN.Click += new System.EventHandler(this.BTN_Reset_NN_Click);
            // 
            // BTN_Run_To_End
            // 
            this.BTN_Run_To_End.Location = new System.Drawing.Point(6, 91);
            this.BTN_Run_To_End.Name = "BTN_Run_To_End";
            this.BTN_Run_To_End.Size = new System.Drawing.Size(136, 29);
            this.BTN_Run_To_End.TabIndex = 3;
            this.BTN_Run_To_End.Text = "Train to end";
            this.BTN_Run_To_End.UseVisualStyleBackColor = true;
            this.BTN_Run_To_End.Click += new System.EventHandler(this.BTN_Run_To_End_Click);
            // 
            // BTN_Train_One
            // 
            this.BTN_Train_One.Location = new System.Drawing.Point(5, 56);
            this.BTN_Train_One.Name = "BTN_Train_One";
            this.BTN_Train_One.Size = new System.Drawing.Size(136, 29);
            this.BTN_Train_One.TabIndex = 2;
            this.BTN_Train_One.Text = "Train an epoch";
            this.BTN_Train_One.UseVisualStyleBackColor = true;
            this.BTN_Train_One.Click += new System.EventHandler(this.BTN_Train_One_Click);
            // 
            // PPTG
            // 
            this.PPTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPTG.Location = new System.Drawing.Point(0, 0);
            this.PPTG.Name = "PPTG";
            this.PPTG.Size = new System.Drawing.Size(281, 220);
            this.PPTG.TabIndex = 4;
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
            this.splitContainer2.Panel1.Controls.Add(this.Main_Chart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(560, 549);
            this.splitContainer2.SplitterDistance = 197;
            this.splitContainer2.TabIndex = 0;
            // 
            // Main_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            this.Main_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(0, 0);
            this.Main_Chart.Name = "Main_Chart";
            this.Main_Chart.Size = new System.Drawing.Size(560, 197);
            this.Main_Chart.TabIndex = 0;
            this.Main_Chart.Text = "chart1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MLP_Print_DOC
            // 
            this.MLP_Print_DOC.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MLP_Print_DOC_PrintPage);
            // 
            // LB_RMSE
            // 
            this.LB_RMSE.AutoSize = true;
            this.LB_RMSE.Location = new System.Drawing.Point(153, 56);
            this.LB_RMSE.Name = "LB_RMSE";
            this.LB_RMSE.Size = new System.Drawing.Size(42, 12);
            this.LB_RMSE.TabIndex = 4;
            this.LB_RMSE.Text = "RMSE: ";
            // 
            // LB_Test
            // 
            this.LB_Test.AutoSize = true;
            this.LB_Test.Location = new System.Drawing.Point(153, 91);
            this.LB_Test.Name = "LB_Test";
            this.LB_Test.Size = new System.Drawing.Size(90, 36);
            this.LB_Test.TabIndex = 5;
            this.LB_Test.Text = "Correctness:\r\n\r\nConfusion matrix:";
            // 
            // BTN_Classification
            // 
            this.BTN_Classification.Location = new System.Drawing.Point(148, 21);
            this.BTN_Classification.Name = "BTN_Classification";
            this.BTN_Classification.Size = new System.Drawing.Size(124, 29);
            this.BTN_Classification.TabIndex = 6;
            this.BTN_Classification.Text = "Classification test";
            this.BTN_Classification.UseVisualStyleBackColor = true;
            this.BTN_Classification.Click += new System.EventHandler(this.BTN_Classification_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // CB_Animation
            // 
            this.CB_Animation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Animation.AutoSize = true;
            this.CB_Animation.Location = new System.Drawing.Point(9, 125);
            this.CB_Animation.Name = "CB_Animation";
            this.CB_Animation.Size = new System.Drawing.Size(73, 16);
            this.CB_Animation.TabIndex = 7;
            this.CB_Animation.Text = "Animation";
            this.CB_Animation.UseVisualStyleBackColor = true;
            this.CB_Animation.CheckedChanged += new System.EventHandler(this.CB_Animation_CheckedChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 598);
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
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Node)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Layer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.NumericUpDown NUD_Node;
        private System.Windows.Forms.NumericUpDown NUD_Layer;
        private System.Drawing.Printing.PrintDocument MLP_Print_DOC;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Classification;
        private System.Windows.Forms.Label LB_Test;
        private System.Windows.Forms.Label LB_RMSE;
        private System.Windows.Forms.CheckBox CB_Animation;
        private System.Windows.Forms.Timer Timer;
    }
}

