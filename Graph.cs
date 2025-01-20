using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal
{
    internal class Graph
    {
        public int[,] adj;
        public int num;
        public List<int>[] adj_list;
        public Graph(int num)
        {
            this.num = num;
            adj = new int[num, num];
            adj_list = new List<int>[num];
            for (int i = 0; i < num; i++) { adj_list[i] = new List<int>(); }
        }
        public void Add(int start, int end, int weight)
        {
            adj[start, end] = weight;
            adj[end, start] = weight;
            adj_list[start] = new List<int>(end);
        }
    }
}
