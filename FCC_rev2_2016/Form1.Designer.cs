namespace FCC_rev2_2016
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.tb_Ip = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Connection = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.btn_Center = new System.Windows.Forms.Button();
            this.btn_StaticLoop = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_TestStatus = new System.Windows.Forms.DataGridView();
            this.tb_DisplayX = new System.Windows.Forms.TextBox();
            this.tb_DisplayY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gauge_X = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.gauge_Y = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Connection)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Test);
            this.groupBox1.Controls.Add(this.btn_Disconnect);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.tb_Port);
            this.groupBox1.Controls.Add(this.tb_Ip);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Connections";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address:";
            // 
            // btn_Test
            // 
            this.btn_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Test.Location = new System.Drawing.Point(428, 54);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(100, 33);
            this.btn_Test.TabIndex = 4;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disconnect.Location = new System.Drawing.Point(233, 54);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(100, 33);
            this.btn_Disconnect.TabIndex = 3;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(127, 54);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 33);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Port.Location = new System.Drawing.Point(428, 19);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(100, 29);
            this.tb_Port.TabIndex = 1;
            // 
            // tb_Ip
            // 
            this.tb_Ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ip.Location = new System.Drawing.Point(127, 19);
            this.tb_Ip.Name = "tb_Ip";
            this.tb_Ip.Size = new System.Drawing.Size(206, 29);
            this.tb_Ip.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Connection);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Status";
            // 
            // dgv_Connection
            // 
            this.dgv_Connection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Connection.Location = new System.Drawing.Point(6, 19);
            this.dgv_Connection.Name = "dgv_Connection";
            this.dgv_Connection.Size = new System.Drawing.Size(538, 151);
            this.dgv_Connection.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Abort);
            this.groupBox3.Controls.Add(this.btn_Center);
            this.groupBox3.Controls.Add(this.btn_StaticLoop);
            this.groupBox3.Controls.Add(this.btn_Circle);
            this.groupBox3.Controls.Add(this.btn_Plus);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 275);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Sequences";
            // 
            // btn_Abort
            // 
            this.btn_Abort.Location = new System.Drawing.Point(19, 187);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(236, 60);
            this.btn_Abort.TabIndex = 4;
            this.btn_Abort.Text = "ABORT";
            this.btn_Abort.UseVisualStyleBackColor = true;
            // 
            // btn_Center
            // 
            this.btn_Center.Location = new System.Drawing.Point(145, 112);
            this.btn_Center.Name = "btn_Center";
            this.btn_Center.Size = new System.Drawing.Size(110, 50);
            this.btn_Center.TabIndex = 3;
            this.btn_Center.Text = "Center";
            this.btn_Center.UseVisualStyleBackColor = true;
            // 
            // btn_StaticLoop
            // 
            this.btn_StaticLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StaticLoop.Location = new System.Drawing.Point(19, 112);
            this.btn_StaticLoop.Name = "btn_StaticLoop";
            this.btn_StaticLoop.Size = new System.Drawing.Size(110, 50);
            this.btn_StaticLoop.TabIndex = 2;
            this.btn_StaticLoop.Text = "Static Test Loop";
            this.btn_StaticLoop.UseVisualStyleBackColor = true;
            // 
            // btn_Circle
            // 
            this.btn_Circle.Location = new System.Drawing.Point(145, 39);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(110, 50);
            this.btn_Circle.TabIndex = 1;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = true;
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(19, 39);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(110, 50);
            this.btn_Plus.TabIndex = 0;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(292, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 275);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RCS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.moreToolStripMenuItem.Text = "More...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_TestStatus);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox5.Location = new System.Drawing.Point(12, 602);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 247);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Test Sequence Status";
            // 
            // dgv_TestStatus
            // 
            this.dgv_TestStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TestStatus.Location = new System.Drawing.Point(6, 28);
            this.dgv_TestStatus.Name = "dgv_TestStatus";
            this.dgv_TestStatus.Size = new System.Drawing.Size(538, 213);
            this.dgv_TestStatus.TabIndex = 0;
            // 
            // tb_DisplayX
            // 
            this.tb_DisplayX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tb_DisplayX.Location = new System.Drawing.Point(661, 360);
            this.tb_DisplayX.Name = "tb_DisplayX";
            this.tb_DisplayX.Size = new System.Drawing.Size(100, 29);
            this.tb_DisplayX.TabIndex = 9;
            // 
            // tb_DisplayY
            // 
            this.tb_DisplayY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tb_DisplayY.Location = new System.Drawing.Point(661, 395);
            this.tb_DisplayY.Name = "tb_DisplayY";
            this.tb_DisplayY.Size = new System.Drawing.Size(100, 29);
            this.tb_DisplayY.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(609, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(609, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(655, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 46);
            this.label5.TabIndex = 13;
            this.label5.Text = "LIVE";
            // 
            // gauge_X
            // 
            this.gauge_X.ForeColor = System.Drawing.Color.Gray;
            this.gauge_X.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_X.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.gauge_X.Location = new System.Drawing.Point(822, 749);
            this.gauge_X.MajorTicksHeight = 15;
            this.gauge_X.MinimumSize = new System.Drawing.Size(100, 50);
            this.gauge_X.MinorTickCount = 5;
            this.gauge_X.MinorTickHeight = 10;
            this.gauge_X.Name = "gauge_X";
            this.gauge_X.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            this.gauge_X.Size = new System.Drawing.Size(600, 100);
            this.gauge_X.TabIndex = 14;
            this.gauge_X.Text = "linearGaugeX";
            this.gauge_X.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // gauge_Y
            // 
            this.gauge_Y.ForeColor = System.Drawing.Color.Gray;
            this.gauge_Y.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_Y.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Vertical;
            this.gauge_Y.Location = new System.Drawing.Point(1452, 127);
            this.gauge_Y.MajorTicksHeight = 15;
            this.gauge_Y.MinimumSize = new System.Drawing.Size(75, 125);
            this.gauge_Y.MinorTickCount = 5;
            this.gauge_Y.MinorTickHeight = 10;
            this.gauge_Y.Name = "gauge_Y";
            this.gauge_Y.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            this.gauge_Y.Size = new System.Drawing.Size(120, 600);
            this.gauge_Y.TabIndex = 15;
            this.gauge_Y.Text = "linearGaugeY";
            this.gauge_Y.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(41))))));
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(144)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(190)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(222)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(66)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.chartControl1.DataSourceName = "[none]";
            this.chartControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(509, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(802, 81);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.DrawTextShape = false;
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries1.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Scatter;
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Default1";
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.DrawTextShape = false;
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Default1";
            chartSeries2.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Scatter;
            this.chartControl1.Series.Add(chartSeries1);
            this.chartControl1.Series.Add(chartSeries2);
            this.chartControl1.Size = new System.Drawing.Size(620, 662);
            this.chartControl1.TabIndex = 16;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gauge_Y);
            this.Controls.Add(this.gauge_X);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_DisplayY);
            this.Controls.Add(this.tb_DisplayX);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Connection)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.TextBox tb_Ip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Connection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.Button btn_Center;
        private System.Windows.Forms.Button btn_StaticLoop;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_TestStatus;
        private System.Windows.Forms.TextBox tb_DisplayX;
        private System.Windows.Forms.TextBox tb_DisplayY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge gauge_X;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge gauge_Y;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
    }
}

