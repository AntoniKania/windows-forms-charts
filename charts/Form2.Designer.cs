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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażSerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.VerticalMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.Interval = 0D;
            chartArea2.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 27);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Odczyt Temperatur";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Różnica Temperatur";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(982, 530);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "title";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Wykres Pomiarów";
            title2.Text = "Wykresy Pomiarów";
            this.chart1.Titles.Add(title2);
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
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażSerieToolStripMenuItem,
            this.HorizontalMenuItem3});
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
            this.pokażSerieToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
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
            this.HorizontalMenuItem3.Size = new System.Drawing.Size(149, 22);
            this.HorizontalMenuItem3.Text = "Ukryj Legendę";
            this.HorizontalMenuItem3.Click += new System.EventHandler(this.HorizontalMenuItem3_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerticalMenuItem1,
            this.VerticalMenuItem2,
            this.VerticalMenuItem3,
            this.VerticalMenuItem4,
            this.VerticalMenuItem5,
            this.VerticalMenuItem6});
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
            // VerticalMenuItem4
            // 
            this.VerticalMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VerticalMenuItem4.AutoSize = false;
            this.VerticalMenuItem4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerticalMenuItem4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.VerticalMenuItem4.MergeIndex = 10;
            this.VerticalMenuItem4.Name = "VerticalMenuItem4";
            this.VerticalMenuItem4.Size = new System.Drawing.Size(183, 39);
            this.VerticalMenuItem4.Text = "Zmień podziałke";
            this.VerticalMenuItem4.Click += new System.EventHandler(this.VerticalMenuItem4_Click);
            // 
            // VerticalMenuItem5
            // 
            this.VerticalMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VerticalMenuItem5.AutoSize = false;
            this.VerticalMenuItem5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerticalMenuItem5.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.VerticalMenuItem5.MergeIndex = 10;
            this.VerticalMenuItem5.Name = "VerticalMenuItem5";
            this.VerticalMenuItem5.Size = new System.Drawing.Size(183, 39);
            this.VerticalMenuItem5.Text = "Zmień Typ Wykesu:";
            this.VerticalMenuItem5.Click += new System.EventHandler(this.VerticalMenuItem5_Click);
            // 
            // VerticalMenuItem6
            // 
            this.VerticalMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VerticalMenuItem6.AutoSize = false;
            this.VerticalMenuItem6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.VerticalMenuItem6.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.VerticalMenuItem6.MergeIndex = 10;
            this.VerticalMenuItem6.Name = "VerticalMenuItem6";
            this.VerticalMenuItem6.Size = new System.Drawing.Size(183, 39);
            this.VerticalMenuItem6.Text = "Zmien typ wykresu";
            this.VerticalMenuItem6.Click += new System.EventHandler(this.VerticalMenuItem6_Click);
            // 
            // Wykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 557);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Wykres";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.Wykres_Load);
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
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem VerticalMenuItem6;
    }
}