
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Input Universe");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Output Universe");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_TFS = new System.Windows.Forms.RadioButton();
            this.RB_SFS = new System.Windows.Forms.RadioButton();
            this.RB_MFS = new System.Windows.Forms.RadioButton();
            this.PPGV_System = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_save = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.TV_Display = new System.Windows.Forms.TreeView();
            this.BTN_add_area = new System.Windows.Forms.Button();
            this.PPGV_parameters = new System.Windows.Forms.PropertyGrid();
            this.LB_indecator = new System.Windows.Forms.Label();
            this.TBC_main = new System.Windows.Forms.TabControl();
            this.TP_Fuzzy_set = new System.Windows.Forms.TabPage();
            this.GB_BO = new System.Windows.Forms.GroupBox();
            this.BTN_cancel_selection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_assign_fs_02 = new System.Windows.Forms.Button();
            this.BTN_assign_fs_01 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Binary_type = new System.Windows.Forms.ComboBox();
            this.BTN_add_Binary_function = new System.Windows.Forms.Button();
            this.GB_UO = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Unary_type = new System.Windows.Forms.ComboBox();
            this.BTN_add_Unary_function = new System.Windows.Forms.Button();
            this.GB_PFS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_fuzzy_type = new System.Windows.Forms.ComboBox();
            this.BTN_add_Pri_function = new System.Windows.Forms.Button();
            this.TP_If_Than_Rules = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.GB_Rules = new System.Windows.Forms.GroupBox();
            this.BTN_Delete_Rules = new System.Windows.Forms.Button();
            this.BTN_Add_Rules = new System.Windows.Forms.Button();
            this.DGV_Rules = new System.Windows.Forms.DataGridView();
            this.GB_Conditions = new System.Windows.Forms.GroupBox();
            this.RDB_Scale = new System.Windows.Forms.RadioButton();
            this.RDB_Cut = new System.Windows.Forms.RadioButton();
            this.BTN_Inference = new System.Windows.Forms.Button();
            this.DGV_Conditions = new System.Windows.Forms.DataGridView();
            this.TP_Sugeon_Conclusion = new System.Windows.Forms.TabPage();
            this.BTN_add_equation = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.TBC_Defuzzy = new System.Windows.Forms.TabControl();
            this.TB_2D = new System.Windows.Forms.TabPage();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.BTN_Two_D_Defuzzy = new System.Windows.Forms.Button();
            this.TChart = new Steema.TeeChart.TChart();
            this.surface1 = new Steema.TeeChart.Styles.Surface();
            this.chartController1 = new Steema.TeeChart.ChartController();
            this.TB_1D = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.BTN_One_D_Defuzzy = new System.Windows.Forms.Button();
            this.Chart_Defuzzy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
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
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.TBC_main.SuspendLayout();
            this.TP_Fuzzy_set.SuspendLayout();
            this.GB_BO.SuspendLayout();
            this.GB_UO.SuspendLayout();
            this.GB_PFS.SuspendLayout();
            this.TP_If_Than_Rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.GB_Rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rules)).BeginInit();
            this.GB_Conditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Conditions)).BeginInit();
            this.TP_Sugeon_Conclusion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.TBC_Defuzzy.SuspendLayout();
            this.TB_2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.TB_1D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Defuzzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Chart
            // 
            this.Main_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX2.MinorGrid.Interval = 1D;
            chartArea1.AxisY.Maximum = 1.2D;
            chartArea1.AxisY.Title = "Y";
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Main_Chart.ChartAreas.Add(chartArea1);
            this.Main_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.Main_Chart.Legends.Add(legend1);
            this.Main_Chart.Location = new System.Drawing.Point(0, 0);
            this.Main_Chart.Name = "Main_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Main_Chart.Series.Add(series1);
            this.Main_Chart.Size = new System.Drawing.Size(798, 418);
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Size = new System.Drawing.Size(1345, 758);
            this.splitContainer1.SplitterDistance = 543;
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
            this.splitContainer2.Panel2.Controls.Add(this.TBC_main);
            this.splitContainer2.Size = new System.Drawing.Size(543, 758);
            this.splitContainer2.SplitterDistance = 413;
            this.splitContainer2.SplitterWidth = 5;
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
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer4.Panel1.Controls.Add(this.PPGV_System);
            this.splitContainer4.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Size = new System.Drawing.Size(543, 413);
            this.splitContainer4.SplitterDistance = 145;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RB_TFS);
            this.groupBox1.Controls.Add(this.RB_SFS);
            this.groupBox1.Controls.Add(this.RB_MFS);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GB_fuzzy_system";
            // 
            // RB_TFS
            // 
            this.RB_TFS.AutoSize = true;
            this.RB_TFS.Location = new System.Drawing.Point(6, 69);
            this.RB_TFS.Name = "RB_TFS";
            this.RB_TFS.Size = new System.Drawing.Size(84, 18);
            this.RB_TFS.TabIndex = 2;
            this.RB_TFS.Text = "Tsukamoto";
            this.RB_TFS.UseVisualStyleBackColor = true;
            this.RB_TFS.CheckedChanged += new System.EventHandler(this.RB_TFS_CheckedChanged);
            // 
            // RB_SFS
            // 
            this.RB_SFS.AutoSize = true;
            this.RB_SFS.Location = new System.Drawing.Point(6, 45);
            this.RB_SFS.Name = "RB_SFS";
            this.RB_SFS.Size = new System.Drawing.Size(65, 18);
            this.RB_SFS.TabIndex = 1;
            this.RB_SFS.Text = "Sugeon";
            this.RB_SFS.UseVisualStyleBackColor = true;
            this.RB_SFS.CheckedChanged += new System.EventHandler(this.RB_SFS_CheckedChanged);
            // 
            // RB_MFS
            // 
            this.RB_MFS.AutoSize = true;
            this.RB_MFS.Checked = true;
            this.RB_MFS.Location = new System.Drawing.Point(6, 21);
            this.RB_MFS.Name = "RB_MFS";
            this.RB_MFS.Size = new System.Drawing.Size(74, 18);
            this.RB_MFS.TabIndex = 0;
            this.RB_MFS.TabStop = true;
            this.RB_MFS.Text = "Mandani";
            this.RB_MFS.UseVisualStyleBackColor = true;
            this.RB_MFS.CheckedChanged += new System.EventHandler(this.RB_MFS_CheckedChanged);
            // 
            // PPGV_System
            // 
            this.PPGV_System.Dock = System.Windows.Forms.DockStyle.Right;
            this.PPGV_System.Location = new System.Drawing.Point(271, 24);
            this.PPGV_System.Name = "PPGV_System";
            this.PPGV_System.Size = new System.Drawing.Size(272, 121);
            this.PPGV_System.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_save,
            this.BTN_Open});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // BTN_save
            // 
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(106, 22);
            this.BTN_save.Text = "Save";
            this.BTN_save.Click += new System.EventHandler(this.BTN_save_Click);
            // 
            // BTN_Open
            // 
            this.BTN_Open.Name = "BTN_Open";
            this.BTN_Open.Size = new System.Drawing.Size(106, 22);
            this.BTN_Open.Text = "Open";
            this.BTN_Open.Click += new System.EventHandler(this.BTN_Open_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.BTN_delete);
            this.splitContainer3.Panel1.Controls.Add(this.TV_Display);
            this.splitContainer3.Panel1.Controls.Add(this.BTN_add_area);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.PPGV_parameters);
            this.splitContainer3.Panel2.Controls.Add(this.LB_indecator);
            this.splitContainer3.Size = new System.Drawing.Size(543, 263);
            this.splitContainer3.SplitterDistance = 263;
            this.splitContainer3.TabIndex = 0;
            // 
            // BTN_delete
            // 
            this.BTN_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_delete.Enabled = false;
            this.BTN_delete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_delete.Location = new System.Drawing.Point(194, 0);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(66, 41);
            this.BTN_delete.TabIndex = 1;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // TV_Display
            // 
            this.TV_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TV_Display.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TV_Display.HideSelection = false;
            this.TV_Display.Location = new System.Drawing.Point(0, 45);
            this.TV_Display.Name = "TV_Display";
            treeNode1.Name = "TV_Node_Input";
            treeNode1.Text = "Input Universe";
            treeNode2.Name = "TV_Node_Output";
            treeNode2.Text = "Output Universe";
            this.TV_Display.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.TV_Display.Size = new System.Drawing.Size(263, 217);
            this.TV_Display.TabIndex = 0;
            this.TV_Display.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_Display_AfterSelect);
            this.TV_Display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TV_Display_KeyPress);
            // 
            // BTN_add_area
            // 
            this.BTN_add_area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add_area.Enabled = false;
            this.BTN_add_area.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_add_area.Location = new System.Drawing.Point(0, 0);
            this.BTN_add_area.Name = "BTN_add_area";
            this.BTN_add_area.Size = new System.Drawing.Size(188, 41);
            this.BTN_add_area.TabIndex = 0;
            this.BTN_add_area.Text = "Add area";
            this.BTN_add_area.UseVisualStyleBackColor = true;
            this.BTN_add_area.Click += new System.EventHandler(this.BTN_add_area_Click);
            // 
            // PPGV_parameters
            // 
            this.PPGV_parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PPGV_parameters.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPGV_parameters.Location = new System.Drawing.Point(0, 75);
            this.PPGV_parameters.Name = "PPGV_parameters";
            this.PPGV_parameters.Size = new System.Drawing.Size(276, 189);
            this.PPGV_parameters.TabIndex = 0;
            this.PPGV_parameters.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PPGV_parameters_PropertyValueChanged);
            // 
            // LB_indecator
            // 
            this.LB_indecator.BackColor = System.Drawing.Color.DimGray;
            this.LB_indecator.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_indecator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_indecator.ForeColor = System.Drawing.Color.White;
            this.LB_indecator.Location = new System.Drawing.Point(0, 0);
            this.LB_indecator.Name = "LB_indecator";
            this.LB_indecator.Size = new System.Drawing.Size(276, 71);
            this.LB_indecator.TabIndex = 0;
            this.LB_indecator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBC_main
            // 
            this.TBC_main.Controls.Add(this.TP_Fuzzy_set);
            this.TBC_main.Controls.Add(this.TP_If_Than_Rules);
            this.TBC_main.Controls.Add(this.TP_Sugeon_Conclusion);
            this.TBC_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBC_main.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBC_main.Location = new System.Drawing.Point(0, 0);
            this.TBC_main.Name = "TBC_main";
            this.TBC_main.SelectedIndex = 0;
            this.TBC_main.Size = new System.Drawing.Size(543, 340);
            this.TBC_main.TabIndex = 0;
            // 
            // TP_Fuzzy_set
            // 
            this.TP_Fuzzy_set.Controls.Add(this.GB_BO);
            this.TP_Fuzzy_set.Controls.Add(this.GB_UO);
            this.TP_Fuzzy_set.Controls.Add(this.GB_PFS);
            this.TP_Fuzzy_set.Location = new System.Drawing.Point(4, 23);
            this.TP_Fuzzy_set.Name = "TP_Fuzzy_set";
            this.TP_Fuzzy_set.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Fuzzy_set.Size = new System.Drawing.Size(535, 313);
            this.TP_Fuzzy_set.TabIndex = 0;
            this.TP_Fuzzy_set.Text = "Fuzzy set";
            this.TP_Fuzzy_set.UseVisualStyleBackColor = true;
            // 
            // GB_BO
            // 
            this.GB_BO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_BO.Controls.Add(this.BTN_cancel_selection);
            this.GB_BO.Controls.Add(this.label4);
            this.GB_BO.Controls.Add(this.BTN_assign_fs_02);
            this.GB_BO.Controls.Add(this.BTN_assign_fs_01);
            this.GB_BO.Controls.Add(this.label3);
            this.GB_BO.Controls.Add(this.CB_Binary_type);
            this.GB_BO.Controls.Add(this.BTN_add_Binary_function);
            this.GB_BO.Enabled = false;
            this.GB_BO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_BO.Location = new System.Drawing.Point(6, 177);
            this.GB_BO.Name = "GB_BO";
            this.GB_BO.Size = new System.Drawing.Size(523, 115);
            this.GB_BO.TabIndex = 4;
            this.GB_BO.TabStop = false;
            this.GB_BO.Text = "Add binary operated fuzzy set";
            // 
            // BTN_cancel_selection
            // 
            this.BTN_cancel_selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_cancel_selection.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_cancel_selection.Location = new System.Drawing.Point(468, 80);
            this.BTN_cancel_selection.Name = "BTN_cancel_selection";
            this.BTN_cancel_selection.Size = new System.Drawing.Size(49, 27);
            this.BTN_cancel_selection.TabIndex = 6;
            this.BTN_cancel_selection.Text = "X";
            this.BTN_cancel_selection.UseVisualStyleBackColor = true;
            this.BTN_cancel_selection.Click += new System.EventHandler(this.BTN_cancel_selection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fuzzy Sets:";
            // 
            // BTN_assign_fs_02
            // 
            this.BTN_assign_fs_02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_assign_fs_02.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_assign_fs_02.Location = new System.Drawing.Point(227, 83);
            this.BTN_assign_fs_02.Name = "BTN_assign_fs_02";
            this.BTN_assign_fs_02.Size = new System.Drawing.Size(130, 27);
            this.BTN_assign_fs_02.TabIndex = 4;
            this.BTN_assign_fs_02.Text = "Set_02";
            this.BTN_assign_fs_02.UseVisualStyleBackColor = true;
            this.BTN_assign_fs_02.Click += new System.EventHandler(this.BTN_assign_fs_02_Click);
            // 
            // BTN_assign_fs_01
            // 
            this.BTN_assign_fs_01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_assign_fs_01.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_assign_fs_01.Location = new System.Drawing.Point(91, 83);
            this.BTN_assign_fs_01.Name = "BTN_assign_fs_01";
            this.BTN_assign_fs_01.Size = new System.Drawing.Size(130, 27);
            this.BTN_assign_fs_01.TabIndex = 3;
            this.BTN_assign_fs_01.Text = "Set_01";
            this.BTN_assign_fs_01.UseVisualStyleBackColor = true;
            this.BTN_assign_fs_01.Click += new System.EventHandler(this.BTN_assign_fs_01_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of operator:";
            // 
            // CB_Binary_type
            // 
            this.CB_Binary_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Binary_type.DropDownHeight = 110;
            this.CB_Binary_type.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Binary_type.FormattingEnabled = true;
            this.CB_Binary_type.IntegralHeight = false;
            this.CB_Binary_type.Items.AddRange(new object[] {
            "Intersection",
            "Union",
            "Subtraction",
            "Algebraic Sum",
            "Algebraic Product",
            "Bounded Sum",
            "Bounded Product",
            "Logical Sum",
            "Logical Product",
            "Drastic Sum",
            "Drastic Product",
            "Einstein Sum",
            "Einstein Product",
            "Hamacher TNorm",
            "Hamacher SNorm",
            "Dombi TNorm"});
            this.CB_Binary_type.Location = new System.Drawing.Point(6, 42);
            this.CB_Binary_type.Name = "CB_Binary_type";
            this.CB_Binary_type.Size = new System.Drawing.Size(387, 22);
            this.CB_Binary_type.TabIndex = 0;
            this.CB_Binary_type.Text = "Intersection";
            // 
            // BTN_add_Binary_function
            // 
            this.BTN_add_Binary_function.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add_Binary_function.Enabled = false;
            this.BTN_add_Binary_function.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_add_Binary_function.Location = new System.Drawing.Point(399, 37);
            this.BTN_add_Binary_function.Name = "BTN_add_Binary_function";
            this.BTN_add_Binary_function.Size = new System.Drawing.Size(118, 34);
            this.BTN_add_Binary_function.TabIndex = 1;
            this.BTN_add_Binary_function.Text = "Binary operate";
            this.BTN_add_Binary_function.UseVisualStyleBackColor = true;
            this.BTN_add_Binary_function.Click += new System.EventHandler(this.BTN_add_Binary_function_Click);
            // 
            // GB_UO
            // 
            this.GB_UO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_UO.Controls.Add(this.label2);
            this.GB_UO.Controls.Add(this.CB_Unary_type);
            this.GB_UO.Controls.Add(this.BTN_add_Unary_function);
            this.GB_UO.Enabled = false;
            this.GB_UO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_UO.Location = new System.Drawing.Point(6, 92);
            this.GB_UO.Name = "GB_UO";
            this.GB_UO.Size = new System.Drawing.Size(523, 78);
            this.GB_UO.TabIndex = 3;
            this.GB_UO.TabStop = false;
            this.GB_UO.Text = "Add unary operated fuzzy set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of operator:";
            // 
            // CB_Unary_type
            // 
            this.CB_Unary_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Unary_type.DropDownHeight = 110;
            this.CB_Unary_type.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Unary_type.FormattingEnabled = true;
            this.CB_Unary_type.IntegralHeight = false;
            this.CB_Unary_type.Items.AddRange(new object[] {
            "Negate",
            "Very",
            "Extremely",
            "More_or_less",
            "Intensification",
            "Diminish",
            "Value Cut",
            "Value Scale"});
            this.CB_Unary_type.Location = new System.Drawing.Point(6, 42);
            this.CB_Unary_type.Name = "CB_Unary_type";
            this.CB_Unary_type.Size = new System.Drawing.Size(387, 22);
            this.CB_Unary_type.TabIndex = 0;
            this.CB_Unary_type.Text = "Negate";
            // 
            // BTN_add_Unary_function
            // 
            this.BTN_add_Unary_function.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add_Unary_function.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_add_Unary_function.Location = new System.Drawing.Point(399, 37);
            this.BTN_add_Unary_function.Name = "BTN_add_Unary_function";
            this.BTN_add_Unary_function.Size = new System.Drawing.Size(118, 34);
            this.BTN_add_Unary_function.TabIndex = 1;
            this.BTN_add_Unary_function.Text = "Unary operate";
            this.BTN_add_Unary_function.UseVisualStyleBackColor = true;
            this.BTN_add_Unary_function.Click += new System.EventHandler(this.BTN_add_Unary_function_Click);
            // 
            // GB_PFS
            // 
            this.GB_PFS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_PFS.Controls.Add(this.label1);
            this.GB_PFS.Controls.Add(this.CB_fuzzy_type);
            this.GB_PFS.Controls.Add(this.BTN_add_Pri_function);
            this.GB_PFS.Enabled = false;
            this.GB_PFS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_PFS.Location = new System.Drawing.Point(6, 7);
            this.GB_PFS.Name = "GB_PFS";
            this.GB_PFS.Size = new System.Drawing.Size(523, 78);
            this.GB_PFS.TabIndex = 2;
            this.GB_PFS.TabStop = false;
            this.GB_PFS.Text = "Add primary fuzzy set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of fuzzy set:";
            // 
            // CB_fuzzy_type
            // 
            this.CB_fuzzy_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_fuzzy_type.DropDownHeight = 110;
            this.CB_fuzzy_type.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_fuzzy_type.FormattingEnabled = true;
            this.CB_fuzzy_type.IntegralHeight = false;
            this.CB_fuzzy_type.Items.AddRange(new object[] {
            "Triangular",
            "Bell",
            "Gaussian",
            "Sigmoidal",
            "LeftRight",
            "S-shape",
            "Z-shape",
            "Trapzoidal"});
            this.CB_fuzzy_type.Location = new System.Drawing.Point(6, 42);
            this.CB_fuzzy_type.Name = "CB_fuzzy_type";
            this.CB_fuzzy_type.Size = new System.Drawing.Size(387, 22);
            this.CB_fuzzy_type.TabIndex = 0;
            this.CB_fuzzy_type.Text = "Triangular";
            // 
            // BTN_add_Pri_function
            // 
            this.BTN_add_Pri_function.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_add_Pri_function.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_add_Pri_function.Location = new System.Drawing.Point(399, 37);
            this.BTN_add_Pri_function.Name = "BTN_add_Pri_function";
            this.BTN_add_Pri_function.Size = new System.Drawing.Size(118, 34);
            this.BTN_add_Pri_function.TabIndex = 1;
            this.BTN_add_Pri_function.Text = "Add fuzzy set";
            this.BTN_add_Pri_function.UseVisualStyleBackColor = true;
            this.BTN_add_Pri_function.Click += new System.EventHandler(this.BTN_add_function_Click);
            // 
            // TP_If_Than_Rules
            // 
            this.TP_If_Than_Rules.Controls.Add(this.splitContainer6);
            this.TP_If_Than_Rules.Location = new System.Drawing.Point(4, 23);
            this.TP_If_Than_Rules.Name = "TP_If_Than_Rules";
            this.TP_If_Than_Rules.Size = new System.Drawing.Size(535, 313);
            this.TP_If_Than_Rules.TabIndex = 1;
            this.TP_If_Than_Rules.Text = "If then rules";
            this.TP_If_Than_Rules.UseVisualStyleBackColor = true;
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
            this.splitContainer6.Panel1.Controls.Add(this.GB_Rules);
            this.splitContainer6.Panel1.Controls.Add(this.DGV_Rules);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.GB_Conditions);
            this.splitContainer6.Panel2.Controls.Add(this.DGV_Conditions);
            this.splitContainer6.Size = new System.Drawing.Size(535, 313);
            this.splitContainer6.SplitterDistance = 162;
            this.splitContainer6.TabIndex = 0;
            // 
            // GB_Rules
            // 
            this.GB_Rules.Controls.Add(this.BTN_Delete_Rules);
            this.GB_Rules.Controls.Add(this.BTN_Add_Rules);
            this.GB_Rules.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_Rules.Enabled = false;
            this.GB_Rules.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Rules.Location = new System.Drawing.Point(0, 0);
            this.GB_Rules.Name = "GB_Rules";
            this.GB_Rules.Size = new System.Drawing.Size(535, 47);
            this.GB_Rules.TabIndex = 3;
            this.GB_Rules.TabStop = false;
            this.GB_Rules.Text = "Rules:";
            // 
            // BTN_Delete_Rules
            // 
            this.BTN_Delete_Rules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Delete_Rules.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete_Rules.Location = new System.Drawing.Point(440, 14);
            this.BTN_Delete_Rules.Name = "BTN_Delete_Rules";
            this.BTN_Delete_Rules.Size = new System.Drawing.Size(90, 29);
            this.BTN_Delete_Rules.TabIndex = 2;
            this.BTN_Delete_Rules.Text = "Delete Rule";
            this.BTN_Delete_Rules.UseVisualStyleBackColor = true;
            this.BTN_Delete_Rules.Click += new System.EventHandler(this.BTN_Delete_Rules_Click);
            // 
            // BTN_Add_Rules
            // 
            this.BTN_Add_Rules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Add_Rules.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add_Rules.Location = new System.Drawing.Point(344, 14);
            this.BTN_Add_Rules.Name = "BTN_Add_Rules";
            this.BTN_Add_Rules.Size = new System.Drawing.Size(90, 29);
            this.BTN_Add_Rules.TabIndex = 1;
            this.BTN_Add_Rules.Text = "Add Rule";
            this.BTN_Add_Rules.UseVisualStyleBackColor = true;
            this.BTN_Add_Rules.Click += new System.EventHandler(this.BTN_Add_Rules_Click);
            // 
            // DGV_Rules
            // 
            this.DGV_Rules.AllowUserToAddRows = false;
            this.DGV_Rules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Rules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rules.Location = new System.Drawing.Point(0, 46);
            this.DGV_Rules.Name = "DGV_Rules";
            this.DGV_Rules.RowTemplate.Height = 24;
            this.DGV_Rules.Size = new System.Drawing.Size(535, 116);
            this.DGV_Rules.TabIndex = 0;
            this.DGV_Rules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Rules_CellClick);
            // 
            // GB_Conditions
            // 
            this.GB_Conditions.Controls.Add(this.RDB_Scale);
            this.GB_Conditions.Controls.Add(this.RDB_Cut);
            this.GB_Conditions.Controls.Add(this.BTN_Inference);
            this.GB_Conditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_Conditions.Enabled = false;
            this.GB_Conditions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Conditions.Location = new System.Drawing.Point(0, 0);
            this.GB_Conditions.Name = "GB_Conditions";
            this.GB_Conditions.Size = new System.Drawing.Size(535, 44);
            this.GB_Conditions.TabIndex = 3;
            this.GB_Conditions.TabStop = false;
            this.GB_Conditions.Text = "Conditions:";
            // 
            // RDB_Scale
            // 
            this.RDB_Scale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RDB_Scale.AutoSize = true;
            this.RDB_Scale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Scale.Location = new System.Drawing.Point(331, 14);
            this.RDB_Scale.Name = "RDB_Scale";
            this.RDB_Scale.Size = new System.Drawing.Size(54, 19);
            this.RDB_Scale.TabIndex = 4;
            this.RDB_Scale.Text = "Scale";
            this.RDB_Scale.UseVisualStyleBackColor = true;
            // 
            // RDB_Cut
            // 
            this.RDB_Cut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RDB_Cut.AutoSize = true;
            this.RDB_Cut.Checked = true;
            this.RDB_Cut.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Cut.Location = new System.Drawing.Point(390, 14);
            this.RDB_Cut.Name = "RDB_Cut";
            this.RDB_Cut.Size = new System.Drawing.Size(43, 19);
            this.RDB_Cut.TabIndex = 3;
            this.RDB_Cut.TabStop = true;
            this.RDB_Cut.Text = "Cut";
            this.RDB_Cut.UseVisualStyleBackColor = true;
            // 
            // BTN_Inference
            // 
            this.BTN_Inference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Inference.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Inference.Location = new System.Drawing.Point(439, 11);
            this.BTN_Inference.Name = "BTN_Inference";
            this.BTN_Inference.Size = new System.Drawing.Size(90, 29);
            this.BTN_Inference.TabIndex = 2;
            this.BTN_Inference.Text = "Inference";
            this.BTN_Inference.UseVisualStyleBackColor = true;
            this.BTN_Inference.Click += new System.EventHandler(this.BTN_Inference_Click);
            // 
            // DGV_Conditions
            // 
            this.DGV_Conditions.AllowUserToAddRows = false;
            this.DGV_Conditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Conditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Conditions.Location = new System.Drawing.Point(0, 53);
            this.DGV_Conditions.Name = "DGV_Conditions";
            this.DGV_Conditions.RowTemplate.Height = 24;
            this.DGV_Conditions.Size = new System.Drawing.Size(535, 103);
            this.DGV_Conditions.TabIndex = 1;
            this.DGV_Conditions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Conditions_CellClick);
            // 
            // TP_Sugeon_Conclusion
            // 
            this.TP_Sugeon_Conclusion.Controls.Add(this.splitContainer9);
            this.TP_Sugeon_Conclusion.Location = new System.Drawing.Point(4, 23);
            this.TP_Sugeon_Conclusion.Name = "TP_Sugeon_Conclusion";
            this.TP_Sugeon_Conclusion.Size = new System.Drawing.Size(535, 313);
            this.TP_Sugeon_Conclusion.TabIndex = 2;
            this.TP_Sugeon_Conclusion.Text = "Sugeon Conclusion Equation";
            this.TP_Sugeon_Conclusion.UseVisualStyleBackColor = true;
            // 
            // BTN_add_equation
            // 
            this.BTN_add_equation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_add_equation.Enabled = false;
            this.BTN_add_equation.Location = new System.Drawing.Point(0, 0);
            this.BTN_add_equation.Name = "BTN_add_equation";
            this.BTN_add_equation.Size = new System.Drawing.Size(535, 72);
            this.BTN_add_equation.TabIndex = 1;
            this.BTN_add_equation.Text = "Add rule set";
            this.BTN_add_equation.UseVisualStyleBackColor = true;
            this.BTN_add_equation.Click += new System.EventHandler(this.BTN_add_equation_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "0: Y=0.1x+6.4",
            "1: Y=0.5x+4",
            "2: Y=x-2",
            "3: Z=-x+y+1",
            "4: Z=-y+3",
            "5: Z=-x+3",
            "6: Z=x+y+2"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(535, 237);
            this.listBox1.TabIndex = 0;
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
            this.splitContainer5.Panel1.Controls.Add(this.Main_Chart);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.TBC_Defuzzy);
            this.splitContainer5.Size = new System.Drawing.Size(798, 758);
            this.splitContainer5.SplitterDistance = 418;
            this.splitContainer5.TabIndex = 1;
            // 
            // TBC_Defuzzy
            // 
            this.TBC_Defuzzy.Controls.Add(this.TB_2D);
            this.TBC_Defuzzy.Controls.Add(this.TB_1D);
            this.TBC_Defuzzy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBC_Defuzzy.Location = new System.Drawing.Point(0, 0);
            this.TBC_Defuzzy.Name = "TBC_Defuzzy";
            this.TBC_Defuzzy.SelectedIndex = 0;
            this.TBC_Defuzzy.Size = new System.Drawing.Size(798, 336);
            this.TBC_Defuzzy.TabIndex = 2;
            // 
            // TB_2D
            // 
            this.TB_2D.Controls.Add(this.splitContainer8);
            this.TB_2D.Controls.Add(this.chartController1);
            this.TB_2D.Location = new System.Drawing.Point(4, 23);
            this.TB_2D.Name = "TB_2D";
            this.TB_2D.Padding = new System.Windows.Forms.Padding(3);
            this.TB_2D.Size = new System.Drawing.Size(790, 309);
            this.TB_2D.TabIndex = 0;
            this.TB_2D.Text = "2D output map";
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(3, 28);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.BTN_Two_D_Defuzzy);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.TChart);
            this.splitContainer8.Size = new System.Drawing.Size(784, 278);
            this.splitContainer8.SplitterDistance = 91;
            this.splitContainer8.TabIndex = 2;
            // 
            // BTN_Two_D_Defuzzy
            // 
            this.BTN_Two_D_Defuzzy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Two_D_Defuzzy.Location = new System.Drawing.Point(0, 0);
            this.BTN_Two_D_Defuzzy.Name = "BTN_Two_D_Defuzzy";
            this.BTN_Two_D_Defuzzy.Size = new System.Drawing.Size(91, 278);
            this.BTN_Two_D_Defuzzy.TabIndex = 1;
            this.BTN_Two_D_Defuzzy.Text = "Inference Crisp All Input";
            this.BTN_Two_D_Defuzzy.UseVisualStyleBackColor = true;
            this.BTN_Two_D_Defuzzy.Click += new System.EventHandler(this.BTN_Two_D_Defuzzy_Click);
            // 
            // TChart
            // 
            // 
            // 
            // 
            this.TChart.Aspect.Chart3DPercent = 85;
            this.TChart.Aspect.Orthogonal = false;
            this.TChart.Aspect.Zoom = 70;
            this.TChart.Aspect.ZoomFloat = 70D;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.TChart.Axes.Bottom.Title.Caption = "Input Universe";
            this.TChart.Axes.Bottom.Title.Lines = new string[] {
        "Input Universe"};
            // 
            // 
            // 
            this.TChart.Axes.Depth.LabelsAsSeriesTitles = true;
            // 
            // 
            // 
            this.TChart.Axes.DepthTop.LabelsAsSeriesTitles = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.TChart.Axes.Left.Title.Caption = "Output Universe";
            this.TChart.Axes.Left.Title.Lines = new string[] {
        "Output Universe"};
            this.TChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TChart.Location = new System.Drawing.Point(0, 0);
            this.TChart.Name = "TChart";
            this.TChart.Series.Add(this.surface1);
            this.TChart.Size = new System.Drawing.Size(689, 278);
            this.TChart.TabIndex = 0;
            // 
            // surface1
            // 
            // 
            // 
            // 
            this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.ColorEach = false;
            this.surface1.PaletteMin = 0D;
            this.surface1.PaletteStep = 0D;
            this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.surface1.Title = "surface1";
            // 
            // 
            // 
            this.surface1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.surface1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.surface1.ZValues.DataMember = "Z";
            // 
            // chartController1
            // 
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
            this.chartController1.Chart = this.TChart;
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(3, 3);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(784, 25);
            this.chartController1.TabIndex = 1;
            this.chartController1.Text = "chartController1";
            // 
            // TB_1D
            // 
            this.TB_1D.Controls.Add(this.splitContainer7);
            this.TB_1D.Location = new System.Drawing.Point(4, 23);
            this.TB_1D.Name = "TB_1D";
            this.TB_1D.Padding = new System.Windows.Forms.Padding(3);
            this.TB_1D.Size = new System.Drawing.Size(790, 309);
            this.TB_1D.TabIndex = 1;
            this.TB_1D.Text = "1D output map";
            this.TB_1D.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.BTN_One_D_Defuzzy);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.Chart_Defuzzy);
            this.splitContainer7.Size = new System.Drawing.Size(784, 303);
            this.splitContainer7.SplitterDistance = 89;
            this.splitContainer7.TabIndex = 2;
            // 
            // BTN_One_D_Defuzzy
            // 
            this.BTN_One_D_Defuzzy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_One_D_Defuzzy.Location = new System.Drawing.Point(0, 0);
            this.BTN_One_D_Defuzzy.Name = "BTN_One_D_Defuzzy";
            this.BTN_One_D_Defuzzy.Size = new System.Drawing.Size(89, 303);
            this.BTN_One_D_Defuzzy.TabIndex = 1;
            this.BTN_One_D_Defuzzy.Text = "Inference Crisp All Input";
            this.BTN_One_D_Defuzzy.UseVisualStyleBackColor = true;
            this.BTN_One_D_Defuzzy.Click += new System.EventHandler(this.BTN_Defuzzy_Click);
            // 
            // Chart_Defuzzy
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart_Defuzzy.ChartAreas.Add(chartArea2);
            this.Chart_Defuzzy.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.Chart_Defuzzy.Legends.Add(legend2);
            this.Chart_Defuzzy.Location = new System.Drawing.Point(0, 0);
            this.Chart_Defuzzy.Name = "Chart_Defuzzy";
            this.Chart_Defuzzy.Size = new System.Drawing.Size(691, 303);
            this.Chart_Defuzzy.TabIndex = 0;
            this.Chart_Defuzzy.Text = "chart1";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
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
            this.splitContainer9.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.BTN_add_equation);
            this.splitContainer9.Size = new System.Drawing.Size(535, 313);
            this.splitContainer9.SplitterDistance = 237;
            this.splitContainer9.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 758);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fuzzy Inferencing System";
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
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.TBC_main.ResumeLayout(false);
            this.TP_Fuzzy_set.ResumeLayout(false);
            this.GB_BO.ResumeLayout(false);
            this.GB_BO.PerformLayout();
            this.GB_UO.ResumeLayout(false);
            this.GB_UO.PerformLayout();
            this.GB_PFS.ResumeLayout(false);
            this.GB_PFS.PerformLayout();
            this.TP_If_Than_Rules.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.GB_Rules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rules)).EndInit();
            this.GB_Conditions.ResumeLayout(false);
            this.GB_Conditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Conditions)).EndInit();
            this.TP_Sugeon_Conclusion.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.TBC_Defuzzy.ResumeLayout(false);
            this.TB_2D.ResumeLayout(false);
            this.TB_2D.PerformLayout();
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.TB_1D.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Defuzzy)).EndInit();
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Main_Chart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TreeView TV_Display;
        private System.Windows.Forms.PropertyGrid PPGV_parameters;
        private System.Windows.Forms.Button BTN_add_area;
        private System.Windows.Forms.ComboBox CB_fuzzy_type;
        private System.Windows.Forms.Button BTN_add_Pri_function;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label LB_indecator;
        private System.Windows.Forms.TabControl TBC_main;
        private System.Windows.Forms.TabPage TP_Fuzzy_set;
        private System.Windows.Forms.GroupBox GB_UO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Unary_type;
        private System.Windows.Forms.Button BTN_add_Unary_function;
        private System.Windows.Forms.GroupBox GB_PFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_BO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Binary_type;
        private System.Windows.Forms.Button BTN_add_Binary_function;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BTN_assign_fs_02;
        private System.Windows.Forms.Button BTN_assign_fs_01;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_cancel_selection;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TabPage TP_If_Than_Rules;
        private System.Windows.Forms.DataGridView DGV_Rules;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button BTN_Delete_Rules;
        private System.Windows.Forms.Button BTN_Add_Rules;
        private System.Windows.Forms.DataGridView DGV_Conditions;
        private System.Windows.Forms.Button BTN_Inference;
        private System.Windows.Forms.GroupBox GB_Rules;
        private System.Windows.Forms.GroupBox GB_Conditions;
        private System.Windows.Forms.RadioButton RDB_Scale;
        private System.Windows.Forms.RadioButton RDB_Cut;
        private System.Windows.Forms.Button BTN_Two_D_Defuzzy;
        private Steema.TeeChart.ChartController chartController1;
        private Steema.TeeChart.TChart TChart;
        private Steema.TeeChart.Styles.Surface surface1;
        private System.Windows.Forms.TabPage TP_Sugeon_Conclusion;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BTN_add_equation;
        private System.Windows.Forms.PropertyGrid PPGV_System;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_TFS;
        private System.Windows.Forms.RadioButton RB_SFS;
        private System.Windows.Forms.RadioButton RB_MFS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BTN_save;
        private System.Windows.Forms.ToolStripMenuItem BTN_Open;
        private System.Windows.Forms.TabControl TBC_Defuzzy;
        private System.Windows.Forms.TabPage TB_2D;
        private System.Windows.Forms.TabPage TB_1D;
        private System.Windows.Forms.Button BTN_One_D_Defuzzy;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Defuzzy;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.SplitContainer splitContainer9;
    }
}

