using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] QuickSort(int[] arr, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = arr[(left + right)/2];
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(arr, left, j);
            }

            if (i < right)
            {
                QuickSort(arr, i, right);
            }

            return arr;
        }

        public void InsetSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
        }

        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min]) min = j;
                }

                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
        }

        public void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid+1, right);
            Merge(arr, left, mid, right);
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid+1, k = 0;
            while (i <= mid && j <= right)
            {
                temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
            }
            while(i<= mid) temp[k++] = arr[i++];
            while(j<= right) temp[k++] = arr[j++];
            for(int x = 0; x<temp.Length; x++) arr[left+x] = temp[x];
        }

        public void CountingSort(int[] arr)
        {
            int max = arr.Max();
            int[] count = new int[max+1];
            int[] output = new int[arr.Length];
            foreach (var num in arr)
            {
                count[num]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int[] arr = text.Split(',').Select(int.Parse).ToArray();
            QuickSort(arr, 0, arr.Length-1);
            //InsetSort(arr);
            //SelectionSort(arr);
            //MergeSort(arr, 0, arr.Length-1
            //CountingSort(arr);
            label1.Text = string.Join(", ", arr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
