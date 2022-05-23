# windows-forms-charts
# 1. Opening file

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
# 2. Calculating and displaying values
```c#
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
```
Property **ReadOnly** is set to **true** for all of the textboxes. This means values can't be modified by user.
# 3. Chart
Declaring variables 
```c#
public static Legend legend;
public static Series s1, s2;
List<double> samples = new List<double>();
public static string title;
public static ChartArea chartArea;
```
Drawing series
```c#
for (int x = 0; x < samples.Count; x++)
        s1.Points.AddXY(x + 1, samples[x]);
for(int x2 = 1; x2 < samples.Count; x2++)
        s2.Points.AddXY(x2, samples[x2]-samples[x2-1]);
```
this part of code is executed in Wyres_Load method.

Changing type of chart in Series s1
```c#
private void ChangeChartTypeS1_Click(object sender, EventArgs e)
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
```
# 4. Saving results to file
```c#
private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    string dataToSave = $"Ilość pomiarów: {quantity}\nŚrednia arytmetyczna: {average}\nWariancja: {variance}\nWartość maksymalna: {maxValue}\nWartość minimalna: {minValue}";
                    File.WriteAllText(filename, dataToSave);
                }
            }
        }
```
Code is written in ToolStripMenuItem method due to shortcut **Ctrl + S** could be used. Saving is used by using **SaveFileDialog()** which open up window where user can determine the path where file should be saved.
