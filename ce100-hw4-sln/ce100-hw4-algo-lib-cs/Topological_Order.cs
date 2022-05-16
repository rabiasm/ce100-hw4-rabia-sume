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
    public class Topological_Order
    {
        // No. of vertices
        public static int V;

        // Adjacency List as ArrayList
        // of ArrayList's
        public static List<List<int>> adj;

        /** 
        * @name  Graph
        * 
        * @brief Constructor of graph
        * 
        * @param [in] fiV [\b int]  function index of  in the serie
        * 
        *
        **/
        // Constructor
        public static void Graph(int fiV)
        {
            V = fiV;
            adj = new List<List<int>>(fiV);
            for (int i = 0; i < fiV; i++)
                adj.Add(new List<int>());
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
            adj[fi_v].Add(fi_w);
        }

        /** 
        * @name  TopologicalSortUtil
        * 
        * @brief A recursive function used by topologicalSort
        * 
        * @param [in] fi_w [\b int]  function index of  in the serie
        * 
        * @param [in] fi_visited [\b bool[]]  function index of  in the serie
        * 
        * @param [in] fi_stack [\b Stack<int>]  function index of  in the serie
        *
        **/
        public static void TopologicalSortUtil(int fi_w, bool[] fi_visited,
                                 Stack<int> fi_stack)
        {

            // Mark the current node as visited.
            fi_visited[fi_w] = true;

            // Recur for all the vertices
            // adjacent to this vertex
            foreach (var vertex in adj[fi_w])
            {
                if (!fi_visited[vertex])
                    TopologicalSortUtil(vertex, fi_visited, fi_stack);
            }

            // Push current vertex to
            // stack which stores result
            fi_stack.Push(fi_w);
        }

        /** 
       * @name  TopologicalSort
       * 
       * @brief The function to do Topological Sort.
       *        It uses recursive topologicalSortUtil()
       * 
       * @retval [\b string] return Topological Order as a string.
       * 
       *
       **/
        public static string TopologicalSort()
        {
            Stack<int> stack = new Stack<int>();

            // Mark all the vertices as not visited
            var visited = new bool[V];
            string print = "";
            // Call the recursive helper function
            // to store Topological Sort starting
            // from all vertices one by one
            for (int i = 0; i < V; i++)
            {
                if (visited[i] == false)
                    TopologicalSortUtil(i, visited, stack);
            }

            // Print contents of stack
            foreach (var vertex in stack)
            {
                print += vertex + ", ";
            }
            return print.Remove(print.Length - 2);
        }
    }
}
