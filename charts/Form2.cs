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
        List<double> samples = new List<double>();
        public static string title;
        public Wykres(List<double> data, string text)
        {
            samples = data;
            InitializeComponent();
            Series s1; //s2;
            s1 = chart1.Series[0];
            s1.Points.AddXY(1, 12);
            title = text;
            //s2 = chart1.Series[1];
            //ArrayList listDataSource = new ArrayList();

            for (int x = 0; x < samples.Count; x++)
                s1.Points.AddXY(x + 1, samples[x]);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Series s1, s2;
            s1 = chart1.Series["Series1"];
            s1.LabelToolTip = title;
            s1.Points.AddXY(1, 12);
            //s2 = chart1.Series[1];
            //ArrayList listDataSource = new ArrayList();

            //for (int x = 0; x < samples.Capacity; x++)
                //s2.Points.AddXY(x, samples[x]);


            /*
            //ChartControl myChart = chartControl1;
            myChart.DataSource = samples;

            // Create a series, and add it to the chart.
            Series series1 = new Series("My Series", ViewType.Bar);
            myChart.Series.Add(series1);

            // Adjust the series data members.
            series1.ArgumentDataMember = "name";
            series1.ValueDataMembers.AddRange(new string[] { "age" });

            // Access the view-type-specific options of the series.
            ((BarSeriesView)series1.View).ColorEach = true;
            series1.LegendPointOptions.Pattern = "{A}";
            */
        }
    }
}
