using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aisd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            var huff = new huffman();
            var freq = huff.CalculateFrequency(input);
            var root = huff.HuffTree(freq);
            var codes = new Dictionary<char, String>();
            String output = "";
            huff.CodeAsig(root, "", codes);
            foreach(var c in input)
            {
                output += $"{codes[c]}";
            }
            String labeltext = output;
            label1.Text = labeltext;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
