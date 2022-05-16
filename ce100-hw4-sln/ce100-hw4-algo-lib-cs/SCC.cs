using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw4_algo_lib_cs
{
    public class SCCProblem
    {
        private int V;
        private LinkedList<int>[] adj;
        private int Time;
        public void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }
        public SCCProblem(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }
        public void SCCUtil(int u, int[] low, int[] disc, bool[] stackMember, Stack<int> stack)
        {
            low[u] = disc[u] = Time++;
            stack.Push(u);
            stackMember[u] = true;
            foreach (int v in adj[u])
            {
                if (disc[v] == -1)
                {
                    SCCUtil(v, low, disc, stackMember, stack);
                    low[u] = Math.Min(low[u], low[v]);
                }
                else if (stackMember[v])
                {
                    low[u] = Math.Min(low[u], disc[v]);
                }
            }
            if (low[u] == disc[u])
            {
                int v;
                do
                {
                    v = stack.Pop();
                    Console.WriteLine(v + " ");
                    stackMember[v] = false;
                } while (v != u);
            }
        }
        public int SCC()
        {
            int[] low = new int[V];
            int[] disc = new int[V];
            bool[] stackMember = new bool[V];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < V; i++)
            {
                disc[i] = -1;
                low[i] = -1;
            }
            for (int i = 0; i < V; i++)
            {
                if (disc[i] == -1)
                {
                    SCCUtil(i, low, disc, stackMember, stack);
                }
            }
            return 0;
        }
    }
}
