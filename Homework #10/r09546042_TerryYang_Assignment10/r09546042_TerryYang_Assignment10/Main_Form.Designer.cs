
namespace r09546042_TerryYang_Assignment10
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TS_BTN_Open_file = new System.Windows.Forms.ToolStripButton();
            this.BTN_Create_PSO_Solver = new System.Windows.Forms.Button();
            this.PPTG_Solver = new System.Windows.Forms.PropertyGrid();
            this.BTN_Reset_Solver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.BTN_Reset_Solver);
            this.splitContainer2.Panel1.Controls.Add(this.PPTG_Solver);
            this.splitContainer2.Panel1.Controls.Add(this.BTN_Create_PSO_Solver);
            this.splitContainer2.Size = new System.Drawing.Size(530, 426);
            this.splitContainer2.SplitterDistance = 166;
            this.splitContainer2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_BTN_Open_file});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TS_BTN_Open_file
            // 
            this.TS_BTN_Open_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TS_BTN_Open_file.Image = ((System.Drawing.Image)(resources.GetObject("TS_BTN_Open_file.Image")));
            this.TS_BTN_Open_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BTN_Open_file.Name = "TS_BTN_Open_file";
            this.TS_BTN_Open_file.Size = new System.Drawing.Size(52, 22);
            this.TS_BTN_Open_file.Text = "Open...";
            this.TS_BTN_Open_file.Click += new System.EventHandler(this.TS_BTN_Open_file_Click);
            // 
            // BTN_Create_PSO_Solver
            // 
            this.BTN_Create_PSO_Solver.Location = new System.Drawing.Point(3, 42);
            this.BTN_Create_PSO_Solver.Name = "BTN_Create_PSO_Solver";
            this.BTN_Create_PSO_Solver.Size = new System.Drawing.Size(118, 23);
            this.BTN_Create_PSO_Solver.TabIndex = 0;
            this.BTN_Create_PSO_Solver.Text = "Create PSO solver";
            this.BTN_Create_PSO_Solver.UseVisualStyleBackColor = true;
            this.BTN_Create_PSO_Solver.Click += new System.EventHandler(this.BTN_Create_PSO_Solver_Click);
            // 
            // PPTG_Solver
            // 
            this.PPTG_Solver.Location = new System.Drawing.Point(368, 28);
            this.PPTG_Solver.Name = "PPTG_Solver";
            this.PPTG_Solver.Size = new System.Drawing.Size(130, 130);
            this.PPTG_Solver.TabIndex = 1;
            // 
            // BTN_Reset_Solver
            // 
            this.BTN_Reset_Solver.Location = new System.Drawing.Point(3, 71);
            this.BTN_Reset_Solver.Name = "BTN_Reset_Solver";
            this.BTN_Reset_Solver.Size = new System.Drawing.Size(118, 23);
            this.BTN_Reset_Solver.TabIndex = 2;
            this.BTN_Reset_Solver.Text = "Reset";
            this.BTN_Reset_Solver.UseVisualStyleBackColor = true;
            this.BTN_Reset_Solver.Click += new System.EventHandler(this.BTN_Reset_Solver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TS_BTN_Open_file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Reset_Solver;
        private System.Windows.Forms.PropertyGrid PPTG_Solver;
        private System.Windows.Forms.Button BTN_Create_PSO_Solver;
    }
}

