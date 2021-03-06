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
        public double average, maxValue, minValue, variance;
        public int quantity;
        public Form1()
        {
            InitializeComponent();
            zapiszJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((Keys.Control | Keys.S)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "/.";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Contains(".txt"))
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            button1.AccessibleRole = AccessibleRole.None;
                            button3.AccessibleRole = AccessibleRole.Default;
                            label1.Text = "Wczytano pliki " + openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf(@"\") + 1);
                            label1.ForeColor = Color.Green;
                            button2.Enabled = true;
                            button3.Enabled = true;
                            string file = File.ReadAllText(openFileDialog1.FileName);


                            string[] readData = file.Split(';').ToArray();
                            double number;



                            if (!double.TryParse(readData[0], out number))
                                title = readData[0];

                            for (int i = 0; i < readData.Length - 1; i++)
                            {
                                if (double.TryParse(readData[i], out number))
                                    samples.Add(number);
                            }
                            calculateValues();
                            myStream.Close();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Błąd: Nie można było wczytać pliku.\nOriginal error: " + ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Nie wybrano pliku!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                MessageBox.Show("Błąd: Wybrano zły typ pliku!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    //string quantity = "4.54";
                    string dataToSave = $"Ilość pomiarów: {quantity}\nŚrednia arytmetyczna: {average}\nWariancja: {variance}\nWartość maksymalna: {maxValue}\nWartość minimalna: {minValue}";
                    File.WriteAllText(filename, dataToSave);
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
            quantity = samples.Count;

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

        private void button3_Click(object sender, EventArgs e)
        {
            zapiszJakoToolStripMenuItem_Click(sender, e);
        }
    }
}
