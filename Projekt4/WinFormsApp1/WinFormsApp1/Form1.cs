using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GrafApp1
{
    public partial class Form1 : Form
    {
        private Graf graf = new Graf();
        private Dictionary<int, NodeG> nodesDict = new Dictionary<int, NodeG>();
        private Panel graphPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tworzenie Panelu do rysowania grafu
            graphPanel = new Panel
            {
                Name = "GraphPanel",
                Location = new Point(400, 10),
                Size = new Size(380, 500),
                BackColor = Color.White
            };

            // Dodanie Panelu do formularza
            this.Controls.Add(graphPanel);

            // Obs�uga zdarzenia Paint do rysowania grafu
            graphPanel.Paint += GraphPanel_Paint;
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            int nodeValue = nodesDict.Count + 1;
            NodeG newNode = new NodeG(nodeValue);
            nodesDict[nodeValue] = newNode;
            graf.nodes.Add(newNode);

            graphPanel.Refresh();
            MessageBox.Show($"Dodano w�ze�: {nodeValue}");
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            if (nodesDict.Count < 2)
            {
                MessageBox.Show("Dodaj co najmniej dwa w�z�y, aby utworzy� kraw�d�.");
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj dwa w�z�y, kt�re chcesz po��czy� (np. 1,2):", "Dodaj Kraw�d�");
            var values = input.Split(',');

            if (values.Length != 2 || !int.TryParse(values[0], out int node1) || !int.TryParse(values[1], out int node2))
            {
                MessageBox.Show("Nieprawid�owe dane. Spr�buj ponownie.");
                return;
            }

            if (nodesDict.ContainsKey(node1) && nodesDict.ContainsKey(node2))
            {
                nodesDict[node1].sadziedzi.Add(nodesDict[node2]);
                nodesDict[node2].sadziedzi.Add(nodesDict[node1]);

                graphPanel.Refresh();
                MessageBox.Show($"Dodano kraw�d� mi�dzy w�z�ami {node1} i {node2}");
            }
            else
            {
                MessageBox.Show("Nie znaleziono jednego z podanych w�z��w.");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            graf = new Graf();
            nodesDict.Clear();
            graphPanel.Refresh();
            MessageBox.Show("Graf zosta� zresetowany.");
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen edgePen = new Pen(Color.Black, 2);
            Brush nodeBrush = Brushes.LightBlue;
            Brush textBrush = Brushes.Black;
            Font textFont = new Font("Arial", 10);

            Dictionary<NodeG, Point> nodePositions = GetNodePositions(graphPanel.Size);

            // Rysowanie kraw�dzi
            foreach (var node in graf.nodes)
            {
                foreach (var neighbor in node.sadziedzi)
                {
                    if (nodePositions.ContainsKey(node) && nodePositions.ContainsKey(neighbor))
                    {
                        Point start = nodePositions[node];
                        Point end = nodePositions[neighbor];
                        g.DrawLine(edgePen, start, end);
                    }
                }
            }

            // Rysowanie w�z��w
            foreach (var node in graf.nodes)
            {
                if (nodePositions.ContainsKey(node))
                {
                    Point position = nodePositions[node];
                    Rectangle nodeRect = new Rectangle(position.X - 15, position.Y - 15, 30, 30);
                    g.FillEllipse(nodeBrush, nodeRect);
                    g.DrawEllipse(Pens.Black, nodeRect);
                    g.DrawString(node.data.ToString(), textFont, textBrush, position.X - 10, position.Y - 10);
                }
            }
        }

        private Dictionary<NodeG, Point> GetNodePositions(Size panelSize)
        {
            Dictionary<NodeG, Point> positions = new Dictionary<NodeG, Point>();
            int centerX = panelSize.Width / 2;
            int centerY = panelSize.Height / 2;
            int radius = Math.Min(panelSize.Width, panelSize.Height) / 2 - 30;

            int nodeCount = graf.nodes.Count;
            if (nodeCount == 0) return positions;

            double angleStep = 2 * Math.PI / nodeCount;

            for (int i = 0; i < nodeCount; i++)
            {
                NodeG node = graf.nodes[i];
                int x = centerX + (int)(radius * Math.Cos(i * angleStep));
                int y = centerY + (int)(radius * Math.Sin(i * angleStep));
                positions[node] = new Point(x, y);
            }

            return positions;
        }
    }
}
