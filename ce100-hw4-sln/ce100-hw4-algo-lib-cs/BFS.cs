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
    public class BFS
    {
        // No. of vertices    
        public static int _V;

        //Adjacency Lists
        public static LinkedList<int>[] _adj;

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
            _adj = new LinkedList<int>[fiV];
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
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
            _adj[fi_v].AddLast(fi_w);

        }

        /** 
        * @name  BFS_Print
        * 
        * @brief Prints BFS traversal from a given source s
        * 
        * @param [in] s [\b int]  function index of  in the serie
        * 
        * @retval [\b string] return Breadth First Search as a string.
        * 
        **/

        public static string BFS_Print(int fiS)
        {
            string print = "";
            // Mark all the vertices as not
            // visited(By default set as false)
            bool[] visited = new bool[_V];
            for (int i = 0; i < _V; i++)
                visited[i] = false;

            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as
            // visited and enqueue it
            visited[fiS] = true;
            queue.AddLast(fiS);

            while (queue.Any())
            {

                // Dequeue a vertex from queue
                // and print it
                fiS = queue.First();
                print += fiS + ", ";
                queue.RemoveFirst();

                // Get all adjacent vertices of the
                // dequeued vertex s. If a adjacent
                // has not been visited, then mark it
                // visited and enqueue it
                LinkedList<int> list = _adj[fiS];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
            return print.Remove(print.Length - 2);
        }
    }
}
