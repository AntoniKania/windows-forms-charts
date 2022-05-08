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
            VerticalMenuItem7.Text = "Zmień Kolor Serii\nOdczyt temperatu";
            toolStripMenuItem2.Text = "Zmień Kolor Serii\nRóżnica Temperatur";
            VerticalMenuItem7.Size = new System.Drawing.Size(183, 39);
            Title mainTitle = chart1.Titles["Wykres Pomiarów"];
            mainTitle.Text = title;
            chartArea = chart1.ChartAreas["ChartArea1"];
            S2BlueButton_Click(sender, e);
            S1RedButton_Click(sender, e);

            /*
            PictureBox display = new PictureBox();
            display.Width = ClientRectangle.Width;
            display.Height = ClientRectangle.Height;
            this.Controls.Add(display);
            //display.Image = bmp;
            */

            for (int x = 0; x < samples.Count; x++)
                s1.Points.AddXY(x + 1, samples[x]);
            for(int x2 = 1; x2 < samples.Count; x2++)
                s2.Points.AddXY(x2, samples[x2]-samples[x2-1]);

        }
 
        private void Form2_Resize(object sender, System.EventArgs e)
        {
            //Control control = (Control)sender;
            if (this.Height < 553)
                menuStrip2.Visible = false;
            else
                menuStrip2.Visible = true;
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

        private void S1RedButton_Click(object sender, EventArgs e)
        {
            s1.Color = Color.Red;
            S1RedButton.Checked = true;
            S1OrangeButton.Checked = false;
            S1BlueButton.Checked = false;
            S1RedVertical.Checked = true;
            S1BlueVertical.Checked = false;
            S1OrangeVertical.Checked = false;
        }

        private void S1BlueButton_Click(object sender, EventArgs e)
        {
            s1.Color = Color.Blue;
            S1RedButton.Checked = false;
            S1OrangeButton.Checked = false;
            S1BlueButton.Checked = true;
            S1RedVertical.Checked = false;
            S1BlueVertical.Checked = true;
            S1OrangeVertical.Checked = false;
        }

        private void S1OrangeButton_Click(object sender, EventArgs e)
        {
            s1.Color = Color.Orange;
            S1RedButton.Checked = false;
            S1OrangeButton.Checked = true;
            S1BlueButton.Checked = false;
            S1RedVertical.Checked = false;
            S1BlueVertical.Checked = false;
            S1OrangeVertical.Checked = true;
        }
        private void S2RedButton_Click(object sender, EventArgs e)
        {
            s2.Color = Color.Red;
            S2RedButton.Checked = true;
            S2OrangeButton.Checked = false;
            S2BlueButton.Checked = false;
        }

        private void S2BlueButton_Click(object sender, EventArgs e)
        {
            s2.Color = Color.Blue;
            S2RedButton.Checked = false;
            S2OrangeButton.Checked = false;
            S2BlueButton.Checked = true;
        }

        private void S2OrangeButton_Click(object sender, EventArgs e)
        {
            s2.Color = Color.Orange;
            S2RedButton.Checked = false;
            S2OrangeButton.Checked = true;
            S2BlueButton.Checked = false;
        }

        private void S1RedVertical_Click(object sender, EventArgs e)
        {
            S1RedButton_Click(sender, e);
        }

        private void S1BlueVertical_Click(object sender, EventArgs e)
        {
            S1BlueButton_Click(sender, e);
        }

        private void S1OrangeVertical_Click(object sender, EventArgs e)
        {
            S1OrangeButton_Click(sender, e);
        }

        private void S2RedVertical_Click(object sender, EventArgs e)
        {
            S2RedButton_Click(sender, e);
        }

        private void S2BlueVertical_Click(object sender, EventArgs e)
        {
            S2BlueButton_Click(sender, e);
        }

        private void S2OrangeVertical_Click(object sender, EventArgs e)
        {
            S2OrangeButton_Click(sender, e);
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
