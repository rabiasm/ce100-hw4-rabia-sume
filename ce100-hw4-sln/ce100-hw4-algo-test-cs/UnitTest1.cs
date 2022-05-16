using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw4_algo_lib_cs;

namespace ce100_hw4_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActivitySelection1Problem_TestMethod_1()
        {
            int[] s = { 0, 2, 4, 6, 8, 9 };
            int[] f = { 1, 3, 5, 7, 9, 9 };
            int n = s.Length;

            string act = Activity_Selection1.ActivitySelectionPrintMaxActivitie(s, f, n);
            string res = "5";
            Assert.AreEqual(act, res);
        }




        [TestMethod]
        public void ActivitySelection1Problem_TestMethod_2()
        {
            int[] s = { 1, 3, 0, 5, 8, 5 };

            int[] f = { 2, 5, 6, 9, 9, 9 };
            int n = s.Length;

            string act = Activity_Selection1.ActivitySelectionPrintMaxActivitie(s, f, n);
            string res = "3";
            Assert.AreEqual(act, res);
        }



        [TestMethod]
        public void ActivitySelection1Problem_TestMethod_3()
        {
            int[] s = { 1, 3, 0, 5, 8, 5 };

            int[] f = { 2, 4, 6, 7, 9, 9 };
            int n = s.Length;

            string act = Activity_Selection1.ActivitySelectionPrintMaxActivitie(s, f, n);
            string res = "4";
            Assert.AreEqual(act, res);
        }


        [TestMethod]
        public void KnapSack01_TestMethod_1()
        {
            int[] val = new int[] { 123, 856, 489 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            int actual = Knapsack1.KnapSack(W, wt, val, n);
            int res = 1345;
            Assert.AreEqual(actual, res);
        }


        [TestMethod]
        public void KnapSack01_TestMethod_2()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            int actual = Knapsack1.KnapSack(W, wt, val, n);
            int res = 220;
            Assert.AreEqual(actual, res);
        }


        [TestMethod]
        public void KnapSack01_TestMethod_3()
        {
            int[] val = new int[] { 538, 756, 452 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;
            int n = val.Length;
            int actual = Knapsack1.KnapSack(W, wt, val, n);
            int res = 1294;
            Assert.AreEqual(actual, res);
        }




        [TestMethod]
        public void Knapsack02_testmethod_1()
        {
            int[] val = new int[] { 25, 29, 30 };
            int[] wt = new int[] { 24, 29, 14 };
            int w = 50;
            int n = val.Length;
            string act = Knapsack2.printknapSack(w, wt, val, n);

            string res = "14, 29";
            Assert.AreEqual(act, res);
        }




        [TestMethod]
        public void Knapsack02_testmethod_2()
        {
            int[] val = new int[] { 21, 11, 13 };
            int[] wt = new int[] { 12, 22, 30 };
            int w = 50;
            int n = val.Length;
            string act = Knapsack2.printknapSack(w, wt, val, n);

            string res = "30, 12";
            Assert.AreEqual(act, res);
        }



        [TestMethod]
        public void Knapsack02_testmethod_3()
        {
            int[] val = new int[] { 10, 20, 30 };
            int[] wt = new int[] { 10, 20, 30 };
            int w = 50;
            int n = val.Length;
            string act = Knapsack2.printknapSack(w, wt, val, n);

            string res = "30, 20";
            Assert.AreEqual(act, res);
        }




        [TestMethod]
        public void BFS_TestMethod_1()
        {
            BFS.Graph(4);

            BFS.AddEdge(0, 1);
            BFS.AddEdge(0, 2);
            BFS.AddEdge(1, 2);
            BFS.AddEdge(2, 0);
            BFS.AddEdge(2, 3);
            BFS.AddEdge(3, 3);

            string act = BFS.BFS_Print(2);
            string res = "2, 0, 3, 1";
            Assert.AreEqual(act, res);


        }




        [TestMethod]
        public void BFS_TestMethod_2()
        {
            BFS.Graph(4);

            BFS.AddEdge(0, 1);
            BFS.AddEdge(0, 2);
            BFS.AddEdge(1, 2);
            BFS.AddEdge(2, 0);
            BFS.AddEdge(2, 3);
            BFS.AddEdge(3, 3);

            string act = BFS.BFS_Print(2);
            string res = "2, 0, 3, 1";
            Assert.AreEqual(act, res);


        }




        [TestMethod]
        public void BFS_TestMethod_3()
        {
            BFS.Graph(4);

            BFS.AddEdge(0, 1);
            BFS.AddEdge(0, 2);
            BFS.AddEdge(1, 2);
            BFS.AddEdge(2, 0);
            BFS.AddEdge(2, 3);
            BFS.AddEdge(3, 3);

            string act = BFS.BFS_Print(2);
            string res = "2, 0, 3, 1";
            Assert.AreEqual(act, res);


        }





        [TestMethod]
        public void Topological_Order_TestMethod_1()
        {
            Topological_Order.Graph(6);
            Topological_Order.AddEdge(5, 2);
            Topological_Order.AddEdge(5, 0);
            Topological_Order.AddEdge(4, 0);
            Topological_Order.AddEdge(4, 1);
            Topological_Order.AddEdge(2, 3);
            Topological_Order.AddEdge(3, 1);


            string act = Topological_Order.TopologicalSort();
            string res = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(act, res);
        }


        [TestMethod]
        public void Topological_Order_TestMethod_2()
        {
            Topological_Order.Graph(6);
            Topological_Order.AddEdge(5, 2);
            Topological_Order.AddEdge(5, 0);
            Topological_Order.AddEdge(4, 0);
            Topological_Order.AddEdge(4, 1);
            Topological_Order.AddEdge(2, 3);
            Topological_Order.AddEdge(3, 1);


            string act = Topological_Order.TopologicalSort();
            string res = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(act, res);
        }




        [TestMethod]
        public void Topological_Order_TestMethod_3()
        {
            Topological_Order.Graph(6);
            Topological_Order.AddEdge(5, 2);
            Topological_Order.AddEdge(5, 0);
            Topological_Order.AddEdge(4, 0);
            Topological_Order.AddEdge(4, 1);
            Topological_Order.AddEdge(2, 3);
            Topological_Order.AddEdge(3, 1);


            string act = Topological_Order.TopologicalSort();
            string res = "5, 4, 2, 3, 1, 0";
            Assert.AreEqual(act, res);
        }




        [TestMethod]
        public void DFS_TestMethod_1()
        {
            DFS.Graph(4);

            DFS.AddEdge(0, 1);
            DFS.AddEdge(0, 2);
            DFS.AddEdge(1, 2);
            DFS.AddEdge(2, 0);
            DFS.AddEdge(2, 3);
            DFS.AddEdge(3, 3);
            string act = DFS.DFS_Print(2);
            Assert.AreEqual(act, "2, 0, 1, 3");
        }



        [TestMethod]
        public void DFS_TestMethod_2()
        {
            DFS.Graph(4);

            DFS.AddEdge(0, 1);
            DFS.AddEdge(0, 2);
            DFS.AddEdge(1, 2);
            DFS.AddEdge(2, 0);
            DFS.AddEdge(2, 3);
            DFS.AddEdge(3, 3);
            string act = DFS.DFS_Print(2);
            Assert.AreEqual(act, "2, 0, 1, 3");
        }



        [TestMethod]
        public void DFS_TestMethod_3()
        {
            DFS.Graph(4);

            DFS.AddEdge(0, 1);
            DFS.AddEdge(0, 2);
            DFS.AddEdge(1, 2);
            DFS.AddEdge(2, 0);
            DFS.AddEdge(2, 3);
            DFS.AddEdge(3, 3);
            string act = DFS.DFS_Print(2);
            Assert.AreEqual(act, "2, 0, 1, 3");
        }


        [TestMethod]
        public void SCCProblem_test1()
        {
            SCCProblem g = new SCCProblem(4);
            g.addEdge(1, 3);
            g.addEdge(3, 2);
            g.addEdge(2, 1);
            int result = g.SCC();
            SCCProblem g1 = new SCCProblem(4);
            g1.addEdge(1, 3);
            g1.addEdge(3, 2);
            g1.addEdge(2, 1);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void SCCProblem_test2()
        {
            SCCProblem g = new SCCProblem(4);
            g.addEdge(1, 2);
            g.addEdge(0, 3);
            g.addEdge(2, 3);
            int result = g.SCC();
            SCCProblem g1 = new SCCProblem(4);
            g1.addEdge(1, 2);
            g1.addEdge(0, 3);
            g1.addEdge(2, 3);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
        }




        [TestMethod]
        public void SCCProblem_test3()
        {
            SCCProblem g = new SCCProblem(4);
            g.addEdge(0, 1);
            g.addEdge(2, 3);
            g.addEdge(2, 2);
            int result = g.SCC();
            SCCProblem g1 = new SCCProblem(4);
            g1.addEdge(0, 1);
            g1.addEdge(2, 3);
            g1.addEdge(2, 2);
            int expected = g1.SCC();
            Assert.AreEqual(expected, result);
        }

    }
}