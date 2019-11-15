using System;

namespace Exam3
{
    class Program
    {
        static int M = 3;
        static int N = 4;

      
        static bool isBinaryMatrix(int[,] mat)
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                     
                    if (!(mat[i, j] == 0 || mat[i, j] == 1))
                        return false;
                }
            }

          
            return true;
        }

    
        public static void Main()
        {
            int[,] mat = { { 1, 0, 1, 1 },
                        { 0, 1, 0, 1 },
                        { 1, 1, 1, 0 } };

            if (isBinaryMatrix(mat))
                Console.WriteLine("Matrix is Binary");
            else
                Console.WriteLine("Matrix is not Binary");
        }
    }
}
















