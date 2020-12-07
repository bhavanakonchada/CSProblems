using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace CSProblems.Graphs
{
    class ShortestPathInUnWeightedGraph
    {
        public static void Main()
        {
            Console.WriteLine("Find the shortest path in an unweighted graph");

            List<List<int>> graph = new List<List<int>>();
            graph.Add(new List<int>() { 1, 2 });
            graph.Add(new List<int>() { 0,2,4 });
            graph.Add(new List<int>(){ 0,1,3});
            graph.Add(new List<int>() {2 }); 
            graph.Add(new List<int>() {1 });
            ShortestPath(graph, 0, 4);

            Console.ReadLine();
        }
        static bool ShortestPath(List<List<int>> graph, int s, int d)
        {
            int[] pred = new int[graph.Count];
            foreach (var item in pred)
            {
                pred[item] = -1;
            }

            int[] visited = new int[graph.Count];
            foreach (var item in visited)
            {
                visited[item] = 0;
            }

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(s);
            visited[s] = 1;

            while (queue.Count > 0)
            {
                var currentVertex = queue.Dequeue();
                foreach (var vertex in graph[currentVertex])
                {
                    if (visited[vertex] == 0)
                    {
                        visited[vertex] = 1;
                        pred[vertex] = currentVertex;
                        queue.Enqueue(vertex);

                        if(vertex == d)
                        {
                            break;
                        }
                    }
                }                
            }
            
            //trace the path using pred array
            if(pred[d] == -1)
            {
                return false;
            }

            string path = $"{d}";
            int current = d;
            while(pred[current] != -1)
            {
                current = pred[current];
                path += $" {current}";
            }
            Console.WriteLine($"Path is {path}");
            return true;
        }
    }
}
