using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Models
{
    public class Graph
    {
        int v;

        // Array of lists for Adjacency List Representation
        List<int> []adjacent;

        public Graph(int v)
        {
            this.v = v;
            adjacent = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adjacent[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjacent[v].Add(w); // Add w to v's list. 
        }

        internal void DFS()
        {
            //declare an array 
            bool[] visited = new bool[v];

            for (int i = 0; i < v; i++)
            {
                if (visited[i] == false)
                    DFSUtil(i, visited);
            }
        }

        internal void BFS()
        {
            Queue<int> bfsQueue = new Queue<int>();

            bool[] visited = new bool[v];
            //beginning from node 0

            bfsQueue.Enqueue(0);
            Console.WriteLine($"0 ");

            visited[0] = true;

            BFSUtil(visited, bfsQueue);
        }

        private void BFSUtil(bool[] visited, Queue<int> bfsQueue)
        {           
            while(bfsQueue.Count > 0) // while the queue is not empty
            {
                int v = bfsQueue.Dequeue();

                //find all adjacents of node v
                foreach (var adj in adjacent[v])
                {
                    if (visited[adj] == false)
                    {
                        bfsQueue.Enqueue(adj);
                        Console.WriteLine(adj + " ");
                        visited[adj] = true;
                    }                   
                }
                BFSUtil(visited, bfsQueue);
            }
        }

        private void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write($"{v} ");

            //find the adjacents of this node

            foreach (var i in adjacent[v])
            {
                if (visited[i] == false)
                    DFSUtil(i, visited);
            }
        }
    }
}
