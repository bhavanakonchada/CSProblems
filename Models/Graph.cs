using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace CSProblems.Models
{
    public class Graph
    {
        int vertices;
        List<int>[] adjacent;

        public Graph(int v)
        {
            vertices = v;
            adjacent = new List<int>[v];

            for (int i = 0; i < v; i++)
            {
                adjacent[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjacent[v].Add(w);
        }

        public void TopologicalSortUtil(int v, bool[] visited, Stack<int> stack)
        {
            visited[v] = true;

            //find all unvisited neighbours by checking the adjacent array
            // if one found - call this util recursively

            foreach (var item in adjacent[v])
            {
                if(visited[item] == false)
                {
                    TopologicalSortUtil(item, visited, stack);
                }
            }

            stack.Push(v);
        }

    }
}
