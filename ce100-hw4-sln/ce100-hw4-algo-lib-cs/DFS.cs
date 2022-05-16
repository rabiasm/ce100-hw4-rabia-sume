using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @file Algo_lib.cs
 * @author Rabia SÜME 
 * @date 16 MAY 2022
 *
 * @brief <b> HW-4 Functions </b>
 *
 * HW-4 Algo Lib Functions Header
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */
namespace ce100_hw4_algo_lib_cs
{
    public class DFS
    {
        // No. of vertices 
        public static int _V; // Number of Vertices
                              //Adjacency Lists
        public static LinkedList<int>[] adj; // adjacency lists


        /** 
        * @name  Graph
        * 
        * @brief Constructor of graph
        * 
        * @param [in] fiV [\b int]  function index of  in the serie
        * 
        *
        **/
        public static void Graph(int fiV)
        {

            adj = new LinkedList<int>[fiV];

            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new LinkedList<int>();
            }
            _V = fiV;
        }


        /** 
        * @name  AddEdge
        * 
        * @brief Function to add an edge into the graph
        * 
        * @param [in] fi_v [\b int]  function index of  in the serie
        * 
        * @param [in] fi_w [\b int]  function index of  in the serie
        * 
        **/
        public static void AddEdge(int fi_v, int fi_w)
        {
            adj[fi_v].AddFirst(fi_w); // Add w to v’s list.
        }


        /** 
        * @name  DFS_Print
        * 
        * @brief prints all not yet visited vertices reachable from s
        * 
        * @param [in] s [\b int]  function index of  in the serie
        * 
        * @retval [\b string] return Depth First Search as a string.
        * 
        **/
        public static string DFS_Print(int s)
        {
            // Initially mark all vertices as not visited
            Boolean[] visited = new Boolean[_V];

            // Create a stack for DFS
            Stack<int> stack = new Stack<int>();

            // Push the current source node
            stack.Push(s);
            string print = "";
            while (stack.Count > 0)
            {
                // Pop a vertex from stack and print it
                s = stack.Peek();
                stack.Pop();

                // Stack may contain same vertex twice. So
                // we need to print the popped item only
                // if it is not visited.
                if (visited[s] == false)
                {
                    print += s + ", ";
                    visited[s] = true;
                }

                // Get all adjacent vertices of the popped vertex s
                // If a adjacent has not been visited, then push it
                // to the stack.
                foreach (int v in adj[s])
                {
                    if (!visited[v])
                        stack.Push(v);
                }

            }

            return print.Remove(print.Length - 2);
        }
    }
}
