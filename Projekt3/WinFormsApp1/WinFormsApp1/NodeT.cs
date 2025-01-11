using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class NodeT
    {
        public NodeT rodzic;
        public NodeT lewe;
        public NodeT prawe;
        public int Data { get; }

        public NodeT(int liczba)
        {
            this.Data = liczba;
            this.rodzic = null;
            this.lewe = null;
            this.prawe = null;
        }
    }
}