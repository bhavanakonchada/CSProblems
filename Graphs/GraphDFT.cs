using CSProblems.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Graphs
{
    class GraphDFT
    {
        public static void Main()
        {
            Console.WriteLine($"Given N nodes and E edges of a connected undirected graph. " +
                $"The task is to do depth first traversal of the graph. Suggested approach : use recursion");

            Console.WriteLine($"");

            Models.Graph g = new Models.Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal");

            g.DFS();

            //Can also be done using stacks - lets check that out too.

            Console.ReadLine();
        }
    }
}
