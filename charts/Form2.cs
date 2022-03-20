using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;


namespace charts
{
    public partial class Wykres : Form
    {
        public static Legend legend;
        public static Series s1, s2;
        List<double> samples = new List<double>();
        public static string title;
        public static ChartArea chartArea;
        public Wykres(List<double> data, string text)
        {
            samples = data;
            InitializeComponent();
            title = text;
            //s2 = chart1.Series[1];
            //ArrayList listDataSource = new ArrayList();

            
        }

        private void Wykres_Load(object sender, EventArgs e)
        {
            legend = chart1.Legends["Legend1"];
            VerticalMenuItem3.Text = "Ukryj Legendę";
            VerticalMenuItem1.Text = "Ukryj Serię:\nOdczyt temperatur";
            VerticalMenuItem2.Text = "Ukryj Serię:\nRóżnica temperatur";
            VerticalMenuItem5.Text = "Zmień Typ Wykesu:\nOdczyt temeratur";
            VerticalMenuItem6.Text = "Zmień Typ Wykesu:\nRóżnica temperatur";
            s1 = chart1.Series["Odczyt Temperatur"];
            s2 = chart1.Series["Różnica Temperatur"];
            Title mainTitle = chart1.Titles["Wykres Pomiarów"];
            mainTitle.Text = title;
            chartArea = chart1.ChartAreas["ChartArea1"];

            for (int x = 0; x < samples.Count; x++)
                s1.Points.AddXY(x + 1, samples[x]);
            for(int x2 = 1; x2 < samples.Count; x2++)
                s2.Points.AddXY(x2, samples[x2]-samples[x2-1]);

        }


        private void VerticalMenuItem1_Click(object sender, EventArgs e)
        {
            if (s1.Enabled == true)
            {
                s1.Enabled = false;
                VerticalMenuItem1.Text = "Pokaż Serię: \nOdczyt temperatur";
                HorizontalMenuItem1.Checked = true;
            }

            else
            {
                s1.Enabled = true;
                VerticalMenuItem1.Text = "Ukryj Serię: \nOdczyt temperatur";
                HorizontalMenuItem1.Checked = false;
            }
        }
        private void VerticalMenuItem2_Click(object sender, EventArgs e)
        {
            if (s2.Enabled == true)
            {
                s2.Enabled = false;
                VerticalMenuItem2.Text = "Pokaż Serię: \nRóżnica temperatur";
                HorizontalMenuItem2.Checked = true;
            }

            else
            {
                s2.Enabled = true;
                VerticalMenuItem2.Text = "Ukryj Serię: \nRóżnica temperatur";
                HorizontalMenuItem2.Checked = false;
            }
        }

        private void HorizontalMenuItem1_Click(object sender, EventArgs e)
        {
            VerticalMenuItem1_Click(sender, e);
        }
        private void HorizontalMenuItem2_Click(object sender, EventArgs e)
        {
            VerticalMenuItem2_Click(sender, e);
        }
        private void HorizontalMenuItem3_Click(object sender, EventArgs e)
        {
            VerticalMenuItem3_Click(sender, e);
        }


        private void VerticalMenuItem3_Click(object sender, EventArgs e)
        {
            if (legend.Enabled == true)
            {
                legend.Enabled = false;
                VerticalMenuItem3.Text = "Pokaż Legendę";
                HorizontalMenuItem3.Checked = true;
            }

            else
            {
                legend.Enabled = true;
                VerticalMenuItem3.Text = "Ukryj Legendę";
                HorizontalMenuItem3.Checked = false;
            }
        }

        private void VerticalMenuItem5_Click(object sender, EventArgs e)
        {
            if (s1.ChartType == SeriesChartType.Column)
            {
                s1.ChartType = SeriesChartType.Line;
            }
            else if (s1.ChartType == SeriesChartType.Line)
            {
                s1.ChartType = SeriesChartType.Column;
            }
        }


        private void VerticalMenuItem6_Click(object sender, EventArgs e)
        {
            if (s2.ChartType == SeriesChartType.Column)
            {
                s2.ChartType = SeriesChartType.Line;
            }
            else if (s2.ChartType == SeriesChartType.Line)
            {
                s2.ChartType = SeriesChartType.Column;
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg";

            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                chart1.SaveImage(filename, ChartImageFormat.Jpeg);
            }

        }

        private void VerticalMenuItem4_Click(object sender, EventArgs e)
        {
            if(chartArea.AxisX.MinorGrid.Enabled == false)
            {
                chartArea.AxisX.MinorGrid.Enabled = true;
                chartArea.AxisY.MinorGrid.Enabled = true;
            }
            else
            {
                chartArea.AxisX.MinorGrid.Enabled = false;
                chartArea.AxisY.MinorGrid.Enabled = false;
            }
        }








    }
}
