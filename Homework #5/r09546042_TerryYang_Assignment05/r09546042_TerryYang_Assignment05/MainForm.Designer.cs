
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.TV_Display = new System.Windows.Forms.TreeView();
            this.BTN_add_area = new System.Windows.Forms.Button();
            this.PPGV_parameters = new System.Windows.Forms.PropertyGrid();
            this.LB_indecator = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.TB_If_Than_Rules = new System.Windows.Forms.TabPage();
            this.DGV_Rules = new System.Windows.Forms.DataGridView();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BTN_Add_Rules = new System.Windows.Forms.Button();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.BTN_Delete_Rules = new System.Windows.Forms.Button();
            this.DGV_Conditions = new System.Windows.Forms.DataGridView();
            this.BTN_Inference = new System.Windows.Forms.Button();
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
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TP_Fuzzy_set.SuspendLayout();
            this.GB_BO.SuspendLayout();
            this.GB_UO.SuspendLayout();
            this.GB_PFS.SuspendLayout();
            this.TB_If_Than_Rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Conditions)).BeginInit();
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
            this.Main_Chart.Size = new System.Drawing.Size(798, 698);
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
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
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
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Size = new System.Drawing.Size(543, 413);
            this.splitContainer4.SplitterDistance = 35;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 30;
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
            this.splitContainer3.Size = new System.Drawing.Size(543, 373);
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
            this.TV_Display.Size = new System.Drawing.Size(263, 327);
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
            this.PPGV_parameters.Size = new System.Drawing.Size(276, 299);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TP_Fuzzy_set);
            this.tabControl1.Controls.Add(this.TB_If_Than_Rules);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 340);
            this.tabControl1.TabIndex = 0;
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
            this.GB_BO.Location = new System.Drawing.Point(6, 177);
            this.GB_BO.Name = "GB_BO";
            this.GB_BO.Size = new System.Drawing.Size(523, 115);
            this.GB_BO.TabIndex = 4;
            this.GB_BO.TabStop = false;
            this.GB_BO.Text = "Binary operator";
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
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fuzzy Sets:";
            // 
            // BTN_assign_fs_02
            // 
            this.BTN_assign_fs_02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_assign_fs_02.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_assign_fs_02.Location = new System.Drawing.Point(216, 80);
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
            this.BTN_assign_fs_01.Location = new System.Drawing.Point(80, 80);
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
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
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
            this.GB_UO.Location = new System.Drawing.Point(6, 92);
            this.GB_UO.Name = "GB_UO";
            this.GB_UO.Size = new System.Drawing.Size(523, 78);
            this.GB_UO.TabIndex = 3;
            this.GB_UO.TabStop = false;
            this.GB_UO.Text = "Unary operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
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
            this.GB_PFS.Location = new System.Drawing.Point(6, 7);
            this.GB_PFS.Name = "GB_PFS";
            this.GB_PFS.Size = new System.Drawing.Size(523, 78);
            this.GB_PFS.TabIndex = 2;
            this.GB_PFS.TabStop = false;
            this.GB_PFS.Text = "Primary fuzzy set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
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
            "Z-shape"});
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
            // TB_If_Than_Rules
            // 
            this.TB_If_Than_Rules.Controls.Add(this.splitContainer6);
            this.TB_If_Than_Rules.Location = new System.Drawing.Point(4, 23);
            this.TB_If_Than_Rules.Name = "TB_If_Than_Rules";
            this.TB_If_Than_Rules.Size = new System.Drawing.Size(535, 313);
            this.TB_If_Than_Rules.TabIndex = 1;
            this.TB_If_Than_Rules.Text = "If than rules";
            this.TB_If_Than_Rules.UseVisualStyleBackColor = true;
            // 
            // DGV_Rules
            // 
            this.DGV_Rules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Rules.Location = new System.Drawing.Point(0, 53);
            this.DGV_Rules.Name = "DGV_Rules";
            this.DGV_Rules.RowTemplate.Height = 24;
            this.DGV_Rules.Size = new System.Drawing.Size(535, 125);
            this.DGV_Rules.TabIndex = 0;
            this.DGV_Rules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Rules_CellClick);
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
            this.splitContainer5.Size = new System.Drawing.Size(798, 758);
            this.splitContainer5.SplitterDistance = 698;
            this.splitContainer5.TabIndex = 1;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // BTN_Add_Rules
            // 
            this.BTN_Add_Rules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Add_Rules.Location = new System.Drawing.Point(346, 3);
            this.BTN_Add_Rules.Name = "BTN_Add_Rules";
            this.BTN_Add_Rules.Size = new System.Drawing.Size(90, 41);
            this.BTN_Add_Rules.TabIndex = 1;
            this.BTN_Add_Rules.Text = "Add Rule";
            this.BTN_Add_Rules.UseVisualStyleBackColor = true;
            this.BTN_Add_Rules.Click += new System.EventHandler(this.BTN_Add_Rules_Click);
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
            this.splitContainer6.Panel1.Controls.Add(this.BTN_Delete_Rules);
            this.splitContainer6.Panel1.Controls.Add(this.DGV_Rules);
            this.splitContainer6.Panel1.Controls.Add(this.BTN_Add_Rules);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.BTN_Inference);
            this.splitContainer6.Panel2.Controls.Add(this.DGV_Conditions);
            this.splitContainer6.Size = new System.Drawing.Size(535, 313);
            this.splitContainer6.SplitterDistance = 178;
            this.splitContainer6.TabIndex = 0;
            // 
            // BTN_Delete_Rules
            // 
            this.BTN_Delete_Rules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Delete_Rules.Location = new System.Drawing.Point(442, 3);
            this.BTN_Delete_Rules.Name = "BTN_Delete_Rules";
            this.BTN_Delete_Rules.Size = new System.Drawing.Size(90, 41);
            this.BTN_Delete_Rules.TabIndex = 2;
            this.BTN_Delete_Rules.Text = "Delete Rule";
            this.BTN_Delete_Rules.UseVisualStyleBackColor = true;
            // 
            // DGV_Conditions
            // 
            this.DGV_Conditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Conditions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Conditions.Location = new System.Drawing.Point(0, 53);
            this.DGV_Conditions.Name = "DGV_Conditions";
            this.DGV_Conditions.RowTemplate.Height = 24;
            this.DGV_Conditions.Size = new System.Drawing.Size(535, 78);
            this.DGV_Conditions.TabIndex = 1;
            // 
            // BTN_Inference
            // 
            this.BTN_Inference.Location = new System.Drawing.Point(442, 3);
            this.BTN_Inference.Name = "BTN_Inference";
            this.BTN_Inference.Size = new System.Drawing.Size(90, 44);
            this.BTN_Inference.TabIndex = 2;
            this.BTN_Inference.Text = "Inference";
            this.BTN_Inference.UseVisualStyleBackColor = true;
            this.BTN_Inference.Click += new System.EventHandler(this.BTN_Inference_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 758);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Fuzzy Inference System Modeler and Execution system";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Chart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TP_Fuzzy_set.ResumeLayout(false);
            this.GB_BO.ResumeLayout(false);
            this.GB_BO.PerformLayout();
            this.GB_UO.ResumeLayout(false);
            this.GB_UO.PerformLayout();
            this.GB_PFS.ResumeLayout(false);
            this.GB_PFS.PerformLayout();
            this.TB_If_Than_Rules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rules)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Conditions)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.TabPage TB_If_Than_Rules;
        private System.Windows.Forms.DataGridView DGV_Rules;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button BTN_Delete_Rules;
        private System.Windows.Forms.Button BTN_Add_Rules;
        private System.Windows.Forms.DataGridView DGV_Conditions;
        private System.Windows.Forms.Button BTN_Inference;
    }
}

