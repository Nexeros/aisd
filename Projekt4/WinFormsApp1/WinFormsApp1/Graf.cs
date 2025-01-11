using System.Collections.Generic;

namespace GrafApp1
{
    public class Graf
    {
        public List<NodeG> nodes = new List<NodeG>();

        public List<NodeG> Wszerz(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>() { start };

            for (int i = 0; i < odwiedzone.Count; i++)
            {
                var tmp = odwiedzone[i];
                for (int j = 0; j < tmp.sadziedzi.Count; j++)
                {
                    if (!odwiedzone.Contains(tmp.sadziedzi[j]))
                    {
                        odwiedzone.Add(tmp.sadziedzi[j]);
                    }
                }
            }
            return odwiedzone;
        }
    }
}

