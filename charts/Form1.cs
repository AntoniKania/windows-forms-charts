using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Collections;


namespace charts
{
    public partial class Form1 : Form
    {
        //public static double[] samples = new double[100];
        
        //public static ArrayList samples = new ArrayList();
        List<double> samples = new List<double>();
        public static string title = "title form1";
        public static double sum;
        public static double pom;
        public static int accuracy = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "/.";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            label1.Text = "Wczytano pliki!";
                            button2.Enabled = true;
                            string file = File.ReadAllText(openFileDialog1.FileName);


                            string[] readData = file.Split(';').ToArray();
                            double number;

                            

                            if (!double.TryParse(readData[0], out number))
                                title = readData[0];
                            
                            for(int i = 0; i < readData.Length - 1; i++)
                            {
                                if(double.TryParse(readData[i], out number))
                                    samples.Add(number);
                            }

                            calculateValues();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Wykres wykres = new Wykres(samples, title);
            wykres.Show();
        }
        public void calculateValues()
        {
            double average, maxValue, minValue, variance;
            int quantity = samples.Count;

            for (int i = 0; i < samples.Count; i++)
            {
                sum += samples[i];
            }
            average = Math.Round(sum / samples.Count, accuracy);
            samples.Sort();
            maxValue = Math.Round(samples[samples.Count - 1], accuracy);
            minValue = Math.Round(samples[0], accuracy);

            for(int j = 0; j < samples.Count; j++)
            {
                pom += Math.Pow(samples[j] - average, 2);
            }
            variance = Math.Round(pom / samples.Count, accuracy);

            textBoxQuantity.Text = quantity.ToString();
            textBoxAverage.Text = average.ToString();
            textBoxvVariance.Text = variance.ToString();
            textBoxMaxValue.Text = maxValue.ToString();
            textBoxMinValues.Text = minValue.ToString();
            
        }

        
    }
}
