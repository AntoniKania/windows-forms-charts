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
        
        public static ArrayList samples = new ArrayList();
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
                            string title = "Wykres Pomiarów";
                            /*
                            for (int i = 0; i < file.Length; i++)
                            {
                                if (file[i] != ";")
                                    title[i] = file[i];
                                else
                                    break;
                            }
                            double[] samples = file.Split(',').Select(double.Parse).ToArray();
                            */
                            string[] readData = file.Split(';').ToArray();
                            int n = 0;
                            
                            double number;
                            //label2.Text += s;
                            if(!double.TryParse(readData[0], out number))
                            {
                                title = readData[0];
                                n++;
                            }
                            
                            
                            for(int i = 0; i < readData.Length - n; i++)
                            {
                                double.TryParse(readData[i], out number);
                                samples.Add(number);
                            }

                            label2.Text = title + "\n";
                            for(int z = 0; z < samples.Count; z++)
                                label2.Text += samples[z] + "\n";

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
            Wykres wykres = new Wykres(samples);
            wykres.Show();
        }
    }
}
