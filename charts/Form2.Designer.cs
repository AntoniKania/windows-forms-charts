namespace charts
{
    partial class Wykres
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wykres));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażSerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScaleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńTypWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeChartTypeS1Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeChartTypeS2Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńKolorWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytTemperaturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.różnicaTemperatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.S2RedVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.S2BlueVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.S2OrangeVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.VerticalMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScaleButtonVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeChartTypeS1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeChartTypeS2 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.S1RedButton = new System.Windows.Forms.ToolStripMenuItem();
            this.S1BlueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.S1OrangeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.S2RedButton = new System.Windows.Forms.ToolStripMenuItem();
            this.S2BlueButton = new System.Windows.Forms.ToolStripMenuItem();
            this.S2OrangeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.S1RedVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.S1BlueVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.S1OrangeVertical = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.AxisX.MajorGrid.Interval = 0D;
            chartArea4.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Alignment = System.Drawing.StringAlignment.Far;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 27);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Odczyt Temperatur";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Różnica Temperatur";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(982, 530);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "title";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title4.Name = "Wykres Pomiarów";
            title4.Text = "Wykresy Pomiarów";
            this.chart1.Titles.Add(title4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.widokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszJakoToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 23);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażSerieToolStripMenuItem,
            this.HorizontalMenuItem3,
            this.ScaleButton,
            this.zmieńTypWykresuToolStripMenuItem,
            this.zmieńKolorWykresuToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // pokażSerieToolStripMenuItem
            // 
            this.pokażSerieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizontalMenuItem1,
            this.HorizontalMenuItem2});
            this.pokażSerieToolStripMenuItem.Name = "pokażSerieToolStripMenuItem";
            this.pokażSerieToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pokażSerieToolStripMenuItem.Text = "Ukryj Serie";
            // 
            // HorizontalMenuItem1
            // 
            this.HorizontalMenuItem1.Name = "HorizontalMenuItem1";
            this.HorizontalMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.HorizontalMenuItem1.Text = "Odczyt temperatur";
            this.HorizontalMenuItem1.Click += new System.EventHandler(this.HorizontalMenuItem1_Click);
            // 
            // HorizontalMenuItem2
            // 
            this.HorizontalMenuItem2.Name = "HorizontalMenuItem2";
            this.HorizontalMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.HorizontalMenuItem2.Text = "Różnica temeratur";
            this.HorizontalMenuItem2.Click += new System.EventHandler(this.HorizontalMenuItem2_Click);
            // 
            // HorizontalMenuItem3
            // 
            this.HorizontalMenuItem3.Name = "HorizontalMenuItem3";
            this.HorizontalMenuItem3.Size = new System.Drawing.Size(185, 22);
            this.HorizontalMenuItem3.Text = "Ukryj Legendę";
            this.HorizontalMenuItem3.Click += new System.EventHandler(this.HorizontalMenuItem3_Click);
            // 
            // ScaleButton
            // 
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(185, 22);
            this.ScaleButton.Text = "Zmień Siatkę";
            this.ScaleButton.Click += new System.EventHandler(this.ScaleButton_Click);
            // 
            // zmieńTypWykresuToolStripMenuItem
            // 
            this.zmieńTypWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeChartTypeS1Horizontal,
            this.ChangeChartTypeS2Horizontal});
            this.zmieńTypWykresuToolStripMenuItem.Name = "zmieńTypWykresuToolStripMenuItem";
            this.zmieńTypWykresuToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.zmieńTypWykresuToolStripMenuItem.Text = "Zmień Typ Wykresu";
            // 
            // ChangeChartTypeS1Horizontal
            // 
            this.ChangeChartTypeS1Horizontal.Name = "ChangeChartTypeS1Horizontal";
            this.ChangeChartTypeS1Horizontal.Size = new System.Drawing.Size(178, 22);
            this.ChangeChartTypeS1Horizontal.Text = "Odczyt Temperatur";
            this.ChangeChartTypeS1Horizontal.Click += new System.EventHandler(this.ChangeChartTypeS1Horizontal_Click);
            // 
            // ChangeChartTypeS2Horizontal
            // 
            this.ChangeChartTypeS2Horizontal.Name = "ChangeChartTypeS2Horizontal";
            this.ChangeChartTypeS2Horizontal.Size = new System.Drawing.Size(178, 22);
            this.ChangeChartTypeS2Horizontal.Text = "Różnica Temperatur";
            this.ChangeChartTypeS2Horizontal.Click += new System.EventHandler(this.ChangeChartTypeS2Horizontal_Click);
            // 
            // zmieńKolorWykresuToolStripMenuItem
            // 
            this.zmieńKolorWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odczytTemperaturToolStripMenuItem,
            this.różnicaTemperatuToolStripMenuItem});
            this.zmieńKolorWykresuToolStripMenuItem.Name = "zmieńKolorWykresuToolStripMenuItem";
            this.zmieńKolorWykresuToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.zmieńKolorWykresuToolStripMenuItem.Text = "Zmień Kolor wykresu";
            // 
            // odczytTemperaturToolStripMenuItem
            // 
            this.odczytTemperaturToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S1RedVertical,
            this.S1BlueVertical,
            this.S1OrangeVertical});
            this.odczytTemperaturToolStripMenuItem.Name = "odczytTemperaturToolStripMenuItem";
            this.odczytTemperaturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odczytTemperaturToolStripMenuItem.Text = "Odczyt Temperatur";
            // 
            // różnicaTemperatuToolStripMenuItem
            // 
            this.różnicaTemperatuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S2RedVertical,
            this.S2BlueVertical,
            this.S2OrangeVertical});
            this.różnicaTemperatuToolStripMenuItem.Name = "różnicaTemperatuToolStripMenuItem";
            this.różnicaTemperatuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.różnicaTemperatuToolStripMenuItem.Text = "Różnica Temperatur";
            // 
            // S2RedVertical
            // 
            this.S2RedVertical.Image = global::charts.Properties.Resources.red;
            this.S2RedVertical.Name = "S2RedVertical";
            this.S2RedVertical.Size = new System.Drawing.Size(180, 22);
            this.S2RedVertical.Text = "Czerwony";
            this.S2RedVertical.Click += new System.EventHandler(this.S2RedVertical_Click);
            // 
            // S2BlueVertical
            // 
            this.S2BlueVertical.Image = global::charts.Properties.Resources.blue;
            this.S2BlueVertical.Name = "S2BlueVertical";
            this.S2BlueVertical.Size = new System.Drawing.Size(180, 22);
            this.S2BlueVertical.Text = "Niebieski";
            this.S2BlueVertical.Click += new System.EventHandler(this.S2BlueVertical_Click);
            // 
            // S2OrangeVertical
            // 
            this.S2OrangeVertical.Image = global::charts.Properties.Resources.orange;
            this.S2OrangeVertical.Name = "S2OrangeVertical";
            this.S2OrangeVertical.Size = new System.Drawing.Size(180, 22);
            this.S2OrangeVertical.Text = "Pomarańczowy";
            this.S2OrangeVertical.Click += new System.EventHandler(this.S2OrangeVertical_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerticalMenuItem1,
            this.VerticalMenuItem2,
            this.VerticalMenuItem3,
            this.ScaleButtonVertical,
            this.ChangeChartTypeS1,
            this.ChangeChartTypeS2,
            this.VerticalMenuItem7,
            this.toolStripMenuItem2});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(982, 0);
            this.menuStrip2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(203, 557);
            this.menuStrip2.Stretch = false;
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // VerticalMenuItem1
            // 
            this.VerticalMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VerticalMenuItem1.AutoSize = false;
            this.VerticalMenuItem1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerticalMenuItem1.Margin = new System.Windows.Forms.Padding(0, 60, 0, 20);
            this.VerticalMenuItem1.MergeIndex = 10;
            this.VerticalMenuItem1.Name = "VerticalMenuItem1";
            this.VerticalMenuItem1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.VerticalMenuItem1.Size = new System.Drawing.Size(183, 39);
            this.VerticalMenuItem1.Text = "Ukryj Serię: Odczyt temperatur";
            this.VerticalMenuItem1.Click += new System.EventHandler(this.VerticalMenuItem1_Click);
            // 
            // VerticalMenuItem2
            // 
            this.VerticalMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VerticalMenuItem2.AutoSize = false;
            this.VerticalMenuItem2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerticalMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.VerticalMenuItem2.MergeIndex = 10;
            this.VerticalMenuItem2.Name = "VerticalMenuItem2";
            this.VerticalMenuItem2.Size = new System.Drawing.Size(183, 39);
            this.VerticalMenuItem2.Text = "Ukryj Serię: Różnica temperatur";
            this.VerticalMenuItem2.Click += new System.EventHandler(this.VerticalMenuItem2_Click);
            // 
            // VerticalMenuItem3
            // 
            this.VerticalMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VerticalMenuItem3.AutoSize = false;
            this.VerticalMenuItem3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerticalMenuItem3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.VerticalMenuItem3.MergeIndex = 10;
            this.VerticalMenuItem3.Name = "VerticalMenuItem3";
            this.VerticalMenuItem3.Size = new System.Drawing.Size(183, 39);
            this.VerticalMenuItem3.Text = "Ukryj Legendę";
            this.VerticalMenuItem3.Click += new System.EventHandler(this.VerticalMenuItem3_Click);
            // 
            // ScaleButtonVertical
            // 
            this.ScaleButtonVertical.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ScaleButtonVertical.AutoSize = false;
            this.ScaleButtonVertical.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ScaleButtonVertical.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.ScaleButtonVertical.MergeIndex = 10;
            this.ScaleButtonVertical.Name = "ScaleButtonVertical";
            this.ScaleButtonVertical.Size = new System.Drawing.Size(183, 39);
            this.ScaleButtonVertical.Text = "Zmień Siatkę";
            this.ScaleButtonVertical.Click += new System.EventHandler(this.ScaleButtonVertical_Click);
            // 
            // ChangeChartTypeS1
            // 
            this.ChangeChartTypeS1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ChangeChartTypeS1.AutoSize = false;
            this.ChangeChartTypeS1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ChangeChartTypeS1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.ChangeChartTypeS1.MergeIndex = 10;
            this.ChangeChartTypeS1.Name = "ChangeChartTypeS1";
            this.ChangeChartTypeS1.Size = new System.Drawing.Size(183, 39);
            this.ChangeChartTypeS1.Text = "Zmień Typ Wykesu:";
            this.ChangeChartTypeS1.Click += new System.EventHandler(this.ChangeChartTypeS1_Click);
            // 
            // ChangeChartTypeS2
            // 
            this.ChangeChartTypeS2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ChangeChartTypeS2.AutoSize = false;
            this.ChangeChartTypeS2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ChangeChartTypeS2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.ChangeChartTypeS2.MergeIndex = 10;
            this.ChangeChartTypeS2.Name = "ChangeChartTypeS2";
            this.ChangeChartTypeS2.Size = new System.Drawing.Size(183, 39);
            this.ChangeChartTypeS2.Text = "Zmien typ wykresu";
            this.ChangeChartTypeS2.Click += new System.EventHandler(this.ChangeChartTypeS1_Click);
            // 
            // VerticalMenuItem7
            // 
            this.VerticalMenuItem7.AutoSize = false;
            this.VerticalMenuItem7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerticalMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S1RedButton,
            this.S1BlueButton,
            this.S1OrangeButton});
            this.VerticalMenuItem7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VerticalMenuItem7.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.VerticalMenuItem7.MergeIndex = 10;
            this.VerticalMenuItem7.Name = "VerticalMenuItem7";
            this.VerticalMenuItem7.Size = new System.Drawing.Size(183, 39);
            this.VerticalMenuItem7.Text = "Zmień Kolor Serii Odczyt temperatu";
            // 
            // S1RedButton
            // 
            this.S1RedButton.Image = global::charts.Properties.Resources.red;
            this.S1RedButton.Name = "S1RedButton";
            this.S1RedButton.Size = new System.Drawing.Size(180, 22);
            this.S1RedButton.Text = "Czerwony";
            this.S1RedButton.Click += new System.EventHandler(this.S1RedButton_Click);
            // 
            // S1BlueButton
            // 
            this.S1BlueButton.Image = global::charts.Properties.Resources.blue;
            this.S1BlueButton.Name = "S1BlueButton";
            this.S1BlueButton.Size = new System.Drawing.Size(180, 22);
            this.S1BlueButton.Text = "Niebieski";
            this.S1BlueButton.Click += new System.EventHandler(this.S1BlueButton_Click);
            // 
            // S1OrangeButton
            // 
            this.S1OrangeButton.Image = global::charts.Properties.Resources.orange;
            this.S1OrangeButton.Name = "S1OrangeButton";
            this.S1OrangeButton.Size = new System.Drawing.Size(180, 22);
            this.S1OrangeButton.Text = "Pomarańczowy";
            this.S1OrangeButton.Click += new System.EventHandler(this.S1OrangeButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.S2RedButton,
            this.S2BlueButton,
            this.S2OrangeButton});
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 39);
            this.toolStripMenuItem2.Text = "Zmień Kolor Serii Różnica Temperatur";
            // 
            // S2RedButton
            // 
            this.S2RedButton.Image = global::charts.Properties.Resources.red;
            this.S2RedButton.Name = "S2RedButton";
            this.S2RedButton.Size = new System.Drawing.Size(180, 22);
            this.S2RedButton.Text = "Czerwony";
            this.S2RedButton.Click += new System.EventHandler(this.S2RedButton_Click);
            // 
            // S2BlueButton
            // 
            this.S2BlueButton.Image = global::charts.Properties.Resources.blue;
            this.S2BlueButton.Name = "S2BlueButton";
            this.S2BlueButton.Size = new System.Drawing.Size(180, 22);
            this.S2BlueButton.Text = "Niebieski";
            this.S2BlueButton.Click += new System.EventHandler(this.S2BlueButton_Click);
            // 
            // S2OrangeButton
            // 
            this.S2OrangeButton.Image = global::charts.Properties.Resources.orange;
            this.S2OrangeButton.Name = "S2OrangeButton";
            this.S2OrangeButton.Size = new System.Drawing.Size(180, 22);
            this.S2OrangeButton.Text = "Pomarańczowy";
            this.S2OrangeButton.Click += new System.EventHandler(this.S2OrangeButton_Click);
            // 
            // S1RedVertical
            // 
            this.S1RedVertical.Image = global::charts.Properties.Resources.red;
            this.S1RedVertical.Name = "S1RedVertical";
            this.S1RedVertical.Size = new System.Drawing.Size(180, 22);
            this.S1RedVertical.Text = "Czerwony";
            this.S1RedVertical.Click += new System.EventHandler(this.S1RedVertical_Click);
            // 
            // S1BlueVertical
            // 
            this.S1BlueVertical.Image = global::charts.Properties.Resources.blue;
            this.S1BlueVertical.Name = "S1BlueVertical";
            this.S1BlueVertical.Size = new System.Drawing.Size(180, 22);
            this.S1BlueVertical.Text = "Niebieski";
            this.S1BlueVertical.Click += new System.EventHandler(this.S1BlueVertical_Click);
            // 
            // S1OrangeVertical
            // 
            this.S1OrangeVertical.Image = global::charts.Properties.Resources.orange;
            this.S1OrangeVertical.Name = "S1OrangeVertical";
            this.S1OrangeVertical.Size = new System.Drawing.Size(180, 22);
            this.S1OrangeVertical.Text = "Pomarańczowy";
            this.S1OrangeVertical.Click += new System.EventHandler(this.S1OrangeVertical_Click);
            // 
            // Wykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 557);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Wykres";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.Wykres_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażSerieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizontalMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HorizontalMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem HorizontalMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ScaleButtonVertical;
        private System.Windows.Forms.ToolStripMenuItem ChangeChartTypeS1;
        private System.Windows.Forms.ToolStripMenuItem ChangeChartTypeS2;
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem S1RedButton;
        private System.Windows.Forms.ToolStripMenuItem S1BlueButton;
        private System.Windows.Forms.ToolStripMenuItem S1OrangeButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem S2RedButton;
        private System.Windows.Forms.ToolStripMenuItem S2BlueButton;
        private System.Windows.Forms.ToolStripMenuItem S2OrangeButton;
        private System.Windows.Forms.ToolStripMenuItem zmieńKolorWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytTemperaturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem S1RedVertical;
        private System.Windows.Forms.ToolStripMenuItem S1BlueVertical;
        private System.Windows.Forms.ToolStripMenuItem S1OrangeVertical;
        private System.Windows.Forms.ToolStripMenuItem różnicaTemperatuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem S2RedVertical;
        private System.Windows.Forms.ToolStripMenuItem S2BlueVertical;
        private System.Windows.Forms.ToolStripMenuItem S2OrangeVertical;
        private System.Windows.Forms.ToolStripMenuItem ScaleButton;
        private System.Windows.Forms.ToolStripMenuItem zmieńTypWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeChartTypeS1Horizontal;
        private System.Windows.Forms.ToolStripMenuItem ChangeChartTypeS2Horizontal;
    }
}