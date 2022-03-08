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
        List<double> samples = new List<double>();
        public static string title;
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
            Series s1, s2;
            s1 = chart1.Series["Odczyt Temperatur"];
            s2 = chart1.Series["Różnica Temperatur"];
            s1.LabelToolTip = title;
            for (int x = 0; x < samples.Count; x++)
                s1.Points.AddXY(x + 1, samples[x]);
            for(int x2 = 1; x2 < samples.Count; x2++)
                s2.Points.AddXY(x2, samples[x2]-samples[x2-1]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (legend.Enabled = true)
            {
                legend.Enabled = false;
                button1.Text = "Pokaż Legendę";
            }
                
            else
            {
                legend.Enabled = true;
                button1.Text = "Ukryj Legendę";
            }
                
            
        }
    }
}
