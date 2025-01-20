using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal
{
    internal class OstTree
    {
        Graph graph;
        bool[] bools;

        public OstTree(Graph graph)
        {
            this.graph = graph;
            bools = new bool[graph.num];
            for (int i = 0; i < graph.num; i++)
            {
                bools[i] = true;
            }
        }
        void FindMin()
        {
            int min = 100;
            for (int i = 0; i < graph.num; i++)
            {
                if (bools[i] && graph.adj[i, j] < min) 
            }
        }
        void FindElem(int[,] array, int i, int j, int k, bool[] flag)
        {
            for (int v = j; v < k; v++)
            {
                if (array[i, v] == 1 && flag[v])
                {
                    Console.Write(v + " ");
                    flag[v] = false;
                    FindElem(array, v, ++j, k, flag);
                }
            }

        }
        public void DFS(Graph g)
        {
            bool[] flag = new bool[g.numEdges];
            for (int i = 0; i < g.numEdges; i++) { flag[i] = true; }
            Console.WriteLine("Вершины в порядке обхода в глубину");
            Console.Write(0 + " ");
            FindElem(g.adjacency, 0, 0, g.numEdges, flag);
        }
    }
}
