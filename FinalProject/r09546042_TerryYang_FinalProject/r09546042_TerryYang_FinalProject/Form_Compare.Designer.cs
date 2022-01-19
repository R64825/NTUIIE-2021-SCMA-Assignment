
namespace r09546042_TerryYang_FinalProject
{
    partial class Form_Compare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Compare));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.GB_Validation = new System.Windows.Forms.GroupBox();
            this.BTN_Validate = new System.Windows.Forms.Button();
            this.NUD_Test = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_Agents = new System.Windows.Forms.NumericUpDown();
            this.NUD_Iter_Limit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Argo = new System.Windows.Forms.GroupBox();
            this.PPTG = new System.Windows.Forms.PropertyGrid();
            this.CB_Argo = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CT_Comparsion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_Val_Open = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Pro_Bar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.GB_Validation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Agents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Iter_Limit)).BeginInit();
            this.GB_Argo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_Comparsion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 618);
            this.splitContainer1.SplitterDistance = 319;
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
            this.splitContainer3.Panel1.Controls.Add(this.GB_Validation);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.GB_Argo);
            this.splitContainer3.Panel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer3.Size = new System.Drawing.Size(319, 618);
            this.splitContainer3.SplitterDistance = 221;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 2;
            // 
            // GB_Validation
            // 
            this.GB_Validation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Validation.Controls.Add(this.BTN_Validate);
            this.GB_Validation.Controls.Add(this.NUD_Test);
            this.GB_Validation.Controls.Add(this.label4);
            this.GB_Validation.Controls.Add(this.NUD_Agents);
            this.GB_Validation.Controls.Add(this.NUD_Iter_Limit);
            this.GB_Validation.Controls.Add(this.label2);
            this.GB_Validation.Controls.Add(this.label1);
            this.GB_Validation.Enabled = false;
            this.GB_Validation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Validation.Location = new System.Drawing.Point(12, 13);
            this.GB_Validation.Name = "GB_Validation";
            this.GB_Validation.Size = new System.Drawing.Size(294, 196);
            this.GB_Validation.TabIndex = 0;
            this.GB_Validation.TabStop = false;
            this.GB_Validation.Text = "Validation";
            // 
            // BTN_Validate
            // 
            this.BTN_Validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Validate.Location = new System.Drawing.Point(6, 128);
            this.BTN_Validate.Name = "BTN_Validate";
            this.BTN_Validate.Size = new System.Drawing.Size(279, 49);
            this.BTN_Validate.TabIndex = 10;
            this.BTN_Validate.Text = "Run Valdiation";
            this.BTN_Validate.UseVisualStyleBackColor = true;
            this.BTN_Validate.Click += new System.EventHandler(this.BTN_Validate_Click);
            // 
            // NUD_Test
            // 
            this.NUD_Test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Test.Location = new System.Drawing.Point(150, 93);
            this.NUD_Test.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_Test.Name = "NUD_Test";
            this.NUD_Test.Size = new System.Drawing.Size(137, 22);
            this.NUD_Test.TabIndex = 9;
            this.NUD_Test.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number Of Test";
            // 
            // NUD_Agents
            // 
            this.NUD_Agents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Agents.Location = new System.Drawing.Point(150, 58);
            this.NUD_Agents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_Agents.Name = "NUD_Agents";
            this.NUD_Agents.Size = new System.Drawing.Size(137, 22);
            this.NUD_Agents.TabIndex = 7;
            this.NUD_Agents.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // NUD_Iter_Limit
            // 
            this.NUD_Iter_Limit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Iter_Limit.Location = new System.Drawing.Point(150, 23);
            this.NUD_Iter_Limit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_Iter_Limit.Name = "NUD_Iter_Limit";
            this.NUD_Iter_Limit.Size = new System.Drawing.Size(137, 22);
            this.NUD_Iter_Limit.TabIndex = 6;
            this.NUD_Iter_Limit.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Agents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iteration Limit";
            // 
            // GB_Argo
            // 
            this.GB_Argo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Argo.Controls.Add(this.PPTG);
            this.GB_Argo.Controls.Add(this.CB_Argo);
            this.GB_Argo.Enabled = false;
            this.GB_Argo.Location = new System.Drawing.Point(12, 13);
            this.GB_Argo.Name = "GB_Argo";
            this.GB_Argo.Size = new System.Drawing.Size(294, 366);
            this.GB_Argo.TabIndex = 6;
            this.GB_Argo.TabStop = false;
            this.GB_Argo.Text = "Algorithms:";
            // 
            // PPTG
            // 
            this.PPTG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PPTG.Location = new System.Drawing.Point(6, 61);
            this.PPTG.Name = "PPTG";
            this.PPTG.Size = new System.Drawing.Size(281, 281);
            this.PPTG.TabIndex = 1;
            this.PPTG.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PPTG_PropertyValueChanged);
            // 
            // CB_Argo
            // 
            this.CB_Argo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Argo.FormattingEnabled = true;
            this.CB_Argo.Items.AddRange(new object[] {
            "GA",
            "PSO",
            "ABC",
            "dABC"});
            this.CB_Argo.Location = new System.Drawing.Point(9, 28);
            this.CB_Argo.Name = "CB_Argo";
            this.CB_Argo.Size = new System.Drawing.Size(278, 22);
            this.CB_Argo.TabIndex = 4;
            this.CB_Argo.Text = "GA";
            this.CB_Argo.SelectedIndexChanged += new System.EventHandler(this.CB_Argo_SelectedIndexChanged);
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
            this.splitContainer2.Panel1.Controls.Add(this.CT_Comparsion);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DGV);
            this.splitContainer2.Size = new System.Drawing.Size(830, 618);
            this.splitContainer2.SplitterDistance = 469;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // CT_Comparsion
            // 
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisX.Title = "Test No. ";
            chartArea2.AxisY.Title = "Best Objective";
            chartArea2.Name = "ChartArea1";
            this.CT_Comparsion.ChartAreas.Add(chartArea2);
            this.CT_Comparsion.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.CT_Comparsion.Legends.Add(legend2);
            this.CT_Comparsion.Location = new System.Drawing.Point(0, 0);
            this.CT_Comparsion.Name = "CT_Comparsion";
            this.CT_Comparsion.Size = new System.Drawing.Size(830, 469);
            this.CT_Comparsion.TabIndex = 0;
            this.CT_Comparsion.Text = "chart1";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(3, 3);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(824, 138);
            this.DGV.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Val_Open});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1153, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_Val_Open
            // 
            this.BTN_Val_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Val_Open.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Val_Open.Image")));
            this.BTN_Val_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Val_Open.Name = "BTN_Val_Open";
            this.BTN_Val_Open.Size = new System.Drawing.Size(123, 22);
            this.BTN_Val_Open.Text = "Choose Benchmark...";
            this.BTN_Val_Open.Click += new System.EventHandler(this.BTN_Val_Open_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pro_Bar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 673);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1153, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Pro_Bar
            // 
            this.Pro_Bar.AutoSize = false;
            this.Pro_Bar.Name = "Pro_Bar";
            this.Pro_Bar.Size = new System.Drawing.Size(1100, 20);
            // 
            // Form_Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 699);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Compare";
            this.Text = "Algorithm Comparsion";
            this.SizeChanged += new System.EventHandler(this.Form_Compare_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.GB_Validation.ResumeLayout(false);
            this.GB_Validation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Agents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Iter_Limit)).EndInit();
            this.GB_Argo.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CT_Comparsion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart CT_Comparsion;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox GB_Validation;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.NumericUpDown NUD_Agents;
        private System.Windows.Forms.NumericUpDown NUD_Iter_Limit;
        private System.Windows.Forms.ComboBox CB_Argo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid PPTG;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_Val_Open;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BTN_Validate;
        private System.Windows.Forms.NumericUpDown NUD_Test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GB_Argo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar Pro_Bar;
    }
}