using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Graph
{
    class TopologicalSort
    {
        public static void Main()
        {
            Console.WriteLine($"Given a Directed Graph. Find any Topological Sorting of that Graph");
            int V = 6;
            //creating a graph
            Models.Graph g = new Models.Graph(V);
            g.AddEdge(5, 2);
            g.AddEdge(5, 0);
            g.AddEdge(4, 0);
            g.AddEdge(4, 1);
            g.AddEdge(2, 3);
            g.AddEdge(3, 1);

            Stack<int> stack = new Stack<int>();

            bool[] visited = new bool[V];

            for (int i = 0; i < V; i++)
            {
                if(visited[i] == false)
                {
                    g.TopologicalSortUtil(i, visited, stack);
                }
            }
            Console.ReadLine();
        }
    }
}
