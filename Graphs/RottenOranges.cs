using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Graphs
{
    class RottenOranges
    {
        int FindMinutes(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            int depth = 0;

            Queue<OrangeQueueType> visited = new Queue<OrangeQueueType>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(grid[i][j] == 2)
                    {
                        visited.Enqueue(new OrangeQueueType(i,j,depth));
                    }
                }
            }

            while(visited.Count > 0)
            {
                depth++;

                var currentRotten = visited.Dequeue();
                //for the 4 neighbours adjacent
                for (int i = currentRotten.Row - 1, j = currentRotten.Column - 1; i <= currentRotten.Row + 1 && j <= currentRotten.Column + 1;i++,j++)
                {
                    if (i < 0 && i < n && j > 0 && j < m)
                    {
                        if(grid[i][j] == 1)
                        {
                            grid[i][j] = 2;
                            visited.Enqueue(new OrangeQueueType(i, j, depth));
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            return -1;
                        }
                    }
                }
            }

            return depth;
        }
    }
}

class OrangeQueueType
{
    public OrangeQueueType(int row, int column, int depth)
    {
        this.Row = row;
        this.Column = column;
        this.Depth = depth;
    }

    public int Row { get; set; }
    public int Column { get; set; }
    public int Depth { get; set; }
}
