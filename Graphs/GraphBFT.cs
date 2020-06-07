using CSProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Graphs
{
    class GraphBFT
    {
        public static void Main()
        {
            Console.WriteLine($"Given N nodes and E edges of a connected undirected graph. " +
                $"The task is to do breadth first traversal of the graph.");

            Console.WriteLine($"");

            //Graph g = new Graph(4);

            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(1, 2);
            //g.AddEdge(2, 0);
            //g.AddEdge(2, 3);
            //g.AddEdge(3, 3);

            //Another input for validation of logic
            Graph g = new Graph(7);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(2, 4);
            g.AddEdge(2, 5);
            g.AddEdge(4, 6);
            g.AddEdge(5, 6);

            Console.WriteLine("Following is Breadth First Traversal");

            g.BFS();

            //Can also be done using stacks - lets check that out too.

            Console.ReadLine();
        }
    }
}
