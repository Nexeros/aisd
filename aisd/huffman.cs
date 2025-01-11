using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aisd
{
    public class nodeG
    {
        public nodeG left;
        public nodeG right;
        public nodeG parent;
        public int data;
    }
    public class nodeGS : nodeG
    {
        public char symbol;
    }
    internal class huffman
    {
        public Dictionary<char, int> CalculateFrequency(string input)
        {
            var freq = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (!freq.ContainsKey(c))
                {
                    freq[c] = 0;
                }
                freq[c]++;
            }
            return freq;
        }

        public nodeG HuffTree(Dictionary<char, int> freq)
        {
            var nodes = new List<nodeG>();
            foreach (var item in freq)
            {
                nodes.Add(new nodeGS { symbol = item.Key, data = item.Value });
            }
            while (nodes.Count > 1)
            {
                nodes = nodes.OrderBy(n=>n.data).ThenBy(n=>n.GetType()==typeof(nodeGS)?0:1).ToList();
                var left = nodes[0];
                var right = nodes[1];
                var parent = new nodeG
                {
                    left = left,
                    right = right,
                    data = left.data + right.data,
                };
                left.parent = parent;
                right.parent = parent;
                nodes.Remove(left);
                nodes.Remove(right);
                nodes.Add(parent);
            }
            return nodes[0];
        }

        public void CodeAsig(nodeG node, string code, Dictionary<char, string> codes) 
        { 
            if(node == null) return;
            if(node is nodeGS leaf)
            {
                codes[leaf.symbol] = code;
                Console.WriteLine($"Symbol: {leaf.symbol}, Code: {code}");
                return;
            }
            CodeAsig(node.left, code + "0", codes);
            CodeAsig(node.right, code + "1", codes);
        }
    }
}
