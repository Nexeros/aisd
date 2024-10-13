namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Thread sortingThread;
        public Form1()
        {
            InitializeComponent();
            labelProgressStatus.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitCount_Click_1(object sender, EventArgs e)
        {
            int count;
            if (int.TryParse(txtBoxCount.Text, out count))
            {
                listBoxNumbers.Items.Clear();
                for (int i = 0; i < count; i++)
                {
                    listBoxNumbers.Items.Add("0"); 
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę.");
            }
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            foreach (var item in listBoxNumbers.Items)
            {
                int number;
                if (int.TryParse(item.ToString(), out number))
                {
                    numbers.Add(number);
                }
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = numbers.Count - 1;
            progressBar1.Value = 0;
            labelProgressStatus.Text = "Sorting...";

            sortingThread = new Thread(() => BubbleSort(numbers));
            sortingThread.Start();
        }

        private void BubbleSort(List<int> numbers)
        {
            int n = numbers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }

                Invoke(new Action(() => progressBar1.Value = i));
                Thread.Sleep(200);
            }
            Invoke(new Action(() =>
            {
                progressBar1.Value = progressBar1.Maximum;
                labelProgressStatus.Text = "Done";
            }));
            Invoke(new Action(() => UpdateListBox(numbers)));
        }

        private void listBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNumbers.SelectedIndex != -1)
            {
                txtBoxEditNumber.Text = listBoxNumbers.SelectedItem.ToString();
            }
        }

        private void UpdateListBox(List<int> sortedNumbers)
        {
            listBoxSortedNumbers.Items.Clear();
            foreach (var num in sortedNumbers)
            {
                listBoxSortedNumbers.Items.Add(num);
            }
        }

        private void listBoxSortedNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveNumber_Click(object sender, EventArgs e)
        {
            if (listBoxNumbers.SelectedIndex != -1)
            {
                int newValue;
                if (int.TryParse(txtBoxEditNumber.Text, out newValue))
                {
                    listBoxNumbers.Items[listBoxNumbers.SelectedIndex] = newValue.ToString();
                }
                else
                {
                    MessageBox.Show("Proszę wprowadzić poprawną liczbę.");
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać liczbę do edycji.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}