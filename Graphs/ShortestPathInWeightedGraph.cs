using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Graphs
{
    //From a source node to a destination node
    class ShortestPathInWeightedGraph
    {
        public static void Main()
        {
            Console.WriteLine("Given a graph and a source vertex in graph," +
                " find shortest distances from source to all vertices in the given graph.");
            List<List<WeightedEdge>> graph = new List<List<WeightedEdge>>();
            graph.Add(new List<WeightedEdge>() { new WeightedEdge(1, 2), new WeightedEdge(2, 6) });
            graph.Add(new List<WeightedEdge>() { new WeightedEdge(2, 1) });
            graph.Add(new List<WeightedEdge>() {new WeightedEdge(0,1), new WeightedEdge(1,3)});
            graph.Add(new List<WeightedEdge>() { });
            graph.Add(new List<WeightedEdge>() { new WeightedEdge(1,1) });

            ShortestPath(graph, 0);

            Console.ReadLine();
        }

        static void ShortestPath(List<List<WeightedEdge>> graph, int sourceNode)
        {
            int nodeCount = graph.Count;
            int[] distance = new int[nodeCount];
            int[] prev = new int[nodeCount];

            //PriorityQueue<>
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < graph.Count; i++)
            {
                distance[i] = Int32.MaxValue;
                prev[i] = -1;
                queue.Enqueue(i);
            }

            distance[sourceNode] = 0;

            while(queue.Count > 0)
            {
                //pick a node from the queue that has minimum distance
            }
        }
    }
    class WeightedEdge
    {
        public WeightedEdge(int node, int weight)
        {
            this.DestinationNode = node;
            this.Weight = weight;
        }

        public int DestinationNode { get; set; }
        public int Weight { get; set; }
    }
}
