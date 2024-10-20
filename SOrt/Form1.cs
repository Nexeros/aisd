using SortingApp;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SOrt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbAlgorithms.Items.Add("Bubble Sort");
            cmbAlgorithms.Items.Add("Quick Sort");
            cmbAlgorithms.Items.Add("Merge Sort");
            cmbAlgorithms.Items.Add("Count Sort");
            cmbAlgorithms.Items.Add("Shell Sort");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Pobierz liczby od użytkownika
            int[] numbers = ParseNumbers(txtInput.Text);

            try
            {
                string selectedAlgorithm = cmbAlgorithms.SelectedItem.ToString();

                // Sortuj ciąg liczb i zmierz czas sortowania
                var (sortedNumbers, elapsedTime) = SortNumbers(numbers, selectedAlgorithm);

                // Wyświetl wynik i czas
                txtSortedNumbers.Text = string.Join(", ", sortedNumbers);
                lblTime.Text = $"Czas: {elapsedTime} ms";
            }
            catch
            {
                MessageBox.Show("Proszę wybrać sposób sortowania!");
            }

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // Pobierz liczby od użytkownika
            int[] numbers = ParseNumbers(txtInput.Text);

            // Porównaj wszystkie algorytmy i zmierz ich czasy
            var results = CompareAlgorithms(numbers);

            // Wyświetl wyniki w DataGridView
            dgvResults.Rows.Clear();
            foreach (var result in results)
            {
                dgvResults.Rows.Add(result.Algorithm, result.Time);
            }
        }

        private void txtSortedNumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        private int[] ParseNumbers(string input)
        {
            // Parsowanie ciągu liczbowego wprowadzonego przez użytkownika
            return input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        private (int[] sortedNumbers, long elapsedTime) SortNumbers(int[] numbers, string algorithm)
        {
            // Algorytmy sortowania
            ISortAlgorithm sorter = algorithm switch
            {
                "Bubble Sort" => new BubbleSort(),
                "Quick Sort" => new QuickSort(),
                "Merge Sort" => new MergeSort(),
                "Count Sort" => new CountSort(),
                "Heap Sort" => new HeapSort(),      // Nowy algorytm
                "Shell Sort" => new ShellSort(),    // Nowy algorytm
                _ => throw new ArgumentException("Nieznany algorytm sortowania"),
            };

            // Zmierz czas sortowania
            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] sortedNumbers = sorter.Sort(numbers);
            stopwatch.Stop();

            return (sortedNumbers, stopwatch.ElapsedMilliseconds);
        }
        private (string Algorithm, long Time)[] CompareAlgorithms(int[] numbers)
        {
            var algorithms = new ISortAlgorithm[]
            {
                new BubbleSort(),
                new QuickSort(),
                new MergeSort(),
                new CountSort(),
            };

            // Zmierz czas działania każdego algorytmu
            return algorithms.Select(algorithm =>
            {
                var stopwatch = Stopwatch.StartNew();
                algorithm.Sort((int[])numbers.Clone());
                stopwatch.Stop();
                return (algorithm.Name, stopwatch.ElapsedMilliseconds);
            }).ToArray();
        }

        private void cmbAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}