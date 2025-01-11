using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private BST bst;

        public Form1()
        {
            InitializeComponent();
            bst = new BST();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int liczba;
            if (int.TryParse(textBoxInput.Text, out liczba))
            {
                bst.Add(liczba);
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Podaj poprawn¹ liczbê!");
            }
        }

        private void buttonDisplayTree_Click(object sender, EventArgs e)
        {
            bst.DisplayTree(treeView1);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            bst = new BST(); 
            treeView1.Nodes.Clear();
            MessageBox.Show("Drzewo zosta³o zresetowane. Mo¿esz teraz stworzyæ nowe.");
        }
    }
}
