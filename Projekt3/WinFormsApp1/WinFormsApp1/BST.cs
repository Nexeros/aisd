using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class BST
    {
        private NodeT root;

        public void Add(int liczba)
        {
            root = AddRecursive(root, liczba);
        }

        private NodeT AddRecursive(NodeT current, int liczba)
        {
            if (current == null)
                return new NodeT(liczba);

            if (liczba < current.Data)
            {
                current.lewe = AddRecursive(current.lewe, liczba);
                current.lewe.rodzic = current;
            }
            else
            {
                current.prawe = AddRecursive(current.prawe, liczba);
                current.prawe.rodzic = current;
            }

            return current;
        }

        public void DisplayTree(TreeView treeView)
        {
            treeView.Nodes.Clear();
            if (root != null)
            {
                TreeNode rootNode = new TreeNode(root.Data.ToString());
                treeView.Nodes.Add(rootNode);
                AddNodeToTreeView(rootNode, root);
                treeView.ExpandAll();
            }
        }

        private void AddNodeToTreeView(TreeNode treeNode, NodeT node)
        {
            if (node.lewe != null)
            {
                TreeNode leftNode = new TreeNode(node.lewe.Data.ToString());
                treeNode.Nodes.Add(leftNode);
                AddNodeToTreeView(leftNode, node.lewe);
            }
            if (node.prawe != null)
            {
                TreeNode rightNode = new TreeNode(node.prawe.Data.ToString());
                treeNode.Nodes.Add(rightNode);
                AddNodeToTreeView(rightNode, node.prawe);
            }
        }
    }
}