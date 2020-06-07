using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSProblems.Backtracking
{
    class NQueensProblem
    {
        public static void Main()
        {
            Console.WriteLine($"The n-queens puzzle is the problem of placing n queens on an n×n chessboard such that " +
                $"no two queens attack each other. Given an integer n, print all distinct solutions to the n-queens puzzle." +
                $" Each solution contains distinct board configurations of the n-queens’ placement, where the solutions " +
                $"are a permutation of [1,2,3..n] in increasing order, here the number in the ith place denotes that the " +
                $"ith-column queen is placed in the row with that number. For eg below figure represents a chessboard [3 1 4 2].");

            int N = 4;

            Console.WriteLine($"The matrix size is {N}, so the combinations are :");

            //declare an input matrix of of N * N

            var chessBoard = new int[N, N];

            //assuming all elements of the chess board are initialized with 0 on creating.

            if (SolveNQueens(chessBoard, 0) == false)
            {
                Console.WriteLine("Couldnt find a solution");
            }

            Console.ReadLine();
        }

        private static bool SolveNQueens(int[,] chessBoard, int col)
        {
            int N = 4;

            if(col >= N)
            {
                return true;
            }

            for (int i = 0; i < N; i++)
            {
                if(isSafe(chessBoard, i, col))
                {
                    chessBoard[i, col] = 1;

                    if(SolveNQueens(chessBoard,col+1) == true)
                    {
                        return true;
                    }

                    //this is backtracking ...
                    chessBoard[i, col] = 0;
                }
            }
            return false;
        }

        private static bool isSafe(int[,] chessBoard, int row, int col)
        {
            //check the same row
            int i, j;
            for(i = 0; i< col; i++)
            {
                if(chessBoard[row,i] == 1)
                {
                    return false;
                }
            }

            //check the left upper diagonal
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (chessBoard[i, j] == 1)
                {
                    return false;
                }
            }

            //check the left lower diagonal
            for (i = row, j = col; i < 4 && j >= 0; i++, j--)
            {
                if (chessBoard[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
