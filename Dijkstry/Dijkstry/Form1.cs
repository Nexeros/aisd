using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstry
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, int>> graph;
        public Form1()
        {
            InitializeComponent();
            graph = new Dictionary<string, Dictionary<string, int>>();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStartNode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGraph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }

        private Dictionary<string, int> Dijkstra(Dictionary<string, Dictionary<string, int>> graph, string startNode)
        {
            var distances = graph.Keys.ToDictionary(node => node, node => int.MaxValue);
            distances[startNode] = 0;

            var priorityQueue = new SortedSet<(int, string)>(Comparer<(int, string)>.Create((a, b) =>
            {
                int comparison = a.Item1.CompareTo(b.Item1);
                return comparison == 0 ? a.Item2.CompareTo(b.Item2) : comparison;
            }));

            priorityQueue.Add((0, startNode));

            while (priorityQueue.Any())
            {
                var (currentDistance, currentNode) = priorityQueue.First();
                priorityQueue.Remove(priorityQueue.First());

                foreach (var neighbor in graph[currentNode])
                {
                    int newDist = currentDistance + neighbor.Value;
                    if (newDist < distances[neighbor.Key])
                    {
                        priorityQueue.Remove((distances[neighbor.Key], neighbor.Key));
                        distances[neighbor.Key] = newDist;
                        priorityQueue.Add((newDist, neighbor.Key));
                    }
                }
            }

            return distances;
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string from = txtFrom.Text;
            string to = txtTo.Text;
            if (int.TryParse(txtWeight.Text, out int weight))
            {
                if (!graph.ContainsKey(from))
                    graph[from] = new Dictionary<string, int>();
                if (!graph.ContainsKey(to))
                    graph[to] = new Dictionary<string, int>();

                graph[from][to] = weight;
                graph[to][from] = weight; 

                txtGraph.AppendText($"{from} -> {to} (Weight: {weight}); ");
            }
            else
            {
                MessageBox.Show("Weight must be integer.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRunDijkstra_Click(object sender, EventArgs e)
        {
            string startNode = txtStartNode.Text;
            if (!graph.ContainsKey(startNode))
            {
                MessageBox.Show("Start node doesn't exist.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var distances = Dijkstra(graph, startNode);
            txtResults.Clear();
            txtResults.AppendText("Resoults: ");
            foreach (var node in distances)
            {
                txtResults.AppendText($"From {startNode} to {node.Key}: {node.Value}; ");
            }
        }
    }
}
