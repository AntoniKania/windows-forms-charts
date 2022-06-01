# windows-forms-charts
Main window layout:

![Zrzut ekranu 2022-05-23 213903](https://user-images.githubusercontent.com/87483058/169895376-a68e4492-5b21-4f9d-9875-01e9cfaab351.png)

# 1. Opening file
Selecting file window:

![Zrzut ekranu 2022-05-23 213822](https://user-images.githubusercontent.com/87483058/169895532-d61f08ef-12d8-4faf-8d29-58c3529e5dfb.png)

If file was not selected or file is not .txt appropriate messagebox will be displayed. Window thats opens up automaticly shows only .txt files but user can manually change the filter to all files. This works like that because .Filter property is set to `"txt files (*.txt)|*.txt|All files (*.*)|*.*"`.
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
                                if (double.TryParse(readData[i], out number))
                                    samples.Add(number);
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
Part of code responsible for calculating each value and put it into right textbox.
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

![image](https://user-images.githubusercontent.com/87483058/171498624-78853d12-85a5-47f9-b439-2455a1ddf3a5.png)

# 3. Chart
![Zrzut ekranu 2022-05-23 213958](https://user-images.githubusercontent.com/87483058/169895679-6845b828-864a-4997-bbdd-09680ac74d07.png)
Creating new object called wykres (class **Wykres** inherits from class **Form**) this means that new window is created. Object **wykres** is new window in which chart is shown.
```c#
private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Wykres wykres = new Wykres(samples, title);
            wykres.Show(); //opening window
        }
```
Declaring variables 
```c#
public static Legend legend;
public static Series s1, s2;
List<double> samples = new List<double>();
public static string title;
public static ChartArea chartArea;
```
Drawing series. Simple for loop that iterates through each sample in array and creates series in result. That code is executed in Wyres_Load method.
```c#
for (int x = 0; x < samples.Count; x++)
        s1.Points.AddXY(x + 1, samples[x]);
for(int x2 = 1; x2 < samples.Count; x2++)
        s2.Points.AddXY(x2, samples[x2]-samples[x2-1]);
```


Changing type of chart in Series s1. The user can choose between Columne type and Line type.

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
Hiding side menu if the window get too small. Menu in right side automatically hides if height of the window is smaller than 553px. All of the options can still be access via `MenuStrip` located on top.
![image](https://user-images.githubusercontent.com/87483058/171502723-1b222ba1-de61-42ab-bbfb-b7162b10f07f.png)
```c#
private void Form2_Resize(object sender, System.EventArgs e)
        {
            if (this.Height < 553)
                menuStrip2.Visible = false;
            else
                menuStrip2.Visible = true;
        }
```
# 4. Saving results to the file
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
Code is written in ToolStripMenuItem method due to shortcut **Ctrl + S** could be used. Saving is manage by using **SaveFileDialog** class. **ShowDialog()** method opens up new window in which user can choose the path where file will be saved.
