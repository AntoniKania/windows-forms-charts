# windows-forms-charts
# 1. Opening file
<!---
```c#
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
        ```
--->


