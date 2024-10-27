using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private CustomLinkedList<int> list;

        public Form1()
        {
            InitializeComponent();
            list = new CustomLinkedList<int>();
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int data))
            {
                list.AddFirst(data);
                UpdateDisplay();
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int data))
            {
                list.AddLast(data);
                UpdateDisplay();
            }
        }

        private void btnAddAt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int data) && listBoxDisplay.SelectedIndex != -1)
            {
                int index = listBoxDisplay.SelectedIndex;
                try
                {
                    list.AddAt(index, data);
                    UpdateDisplay();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Invalid index selected.");
                }
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
            UpdateDisplay();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            // Update the list of indexes for listBoxDisplay
            listBoxDisplay.Items.Clear();
            for (int i = 0; i <= list.Count; i++)
            {
                listBoxDisplay.Items.Add($"Index {i}");
            }

            // Display the list contents as a string in txtResults
            txtResults.Text = string.Join(" -> ", list.ToArray());
            txtInput.Clear();
        }
    }

}
