using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class _1_Matrix
    {
        public  List<List<int>> UpdateMatrix_1(int[][] mat)
        {
            int rows = mat.Length;
           // if (rows == 0)
               // return mat;

            int cols = mat[0].Length;

            List<List<int>> dist = new List<List<int>>(rows);
            for (int i = 0; i < rows; i++)
            {
                dist[i] = new List<int>(cols);
                dist[i].ForEach(x => x = int.MaxValue);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i][j] == 0)
                        dist[i][j] = 0;
                    else
                    {
                        for (int k = 0; k < rows; k++)
                        {
                            for (int l = 0; l < cols; l++)
                            {
                                if(mat[k][l]==0)
                                {
                                    int dist_01 = Math.Abs(k - i) + Math.Abs(l - j);
                                    dist[i][j] = Math.Min(dist[i][j], Math.Abs(k - i) + Math.Abs(l - j));
                                }
                            }
                        }
                    }
                }
            }
            return dist;
            
        }

        public int[][] UpdateMatrix_BFS(int[][] mat)
        {
            int rows = mat.Length;
            if (rows == 0)
                return mat;

            int cols = mat[0].Length;

            int[][] dist = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                dist[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    dist[i][j] = int.MaxValue;
                }
            }

            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(mat[i][j]==0)
                    {
                        dist[i][j] = 0;
                        q.Enqueue(new Tuple<int, int>(i, j));
                    }
                }
            }

            int[][] dir = new int[4][];

            

            dir[0] = new int[2] { -1, 0 };
            dir[1] = new int[2] { 1, 0 };
            dir[2] = new int[2] { 0, -1 };
            dir[3] = new int[2] { 0, 1 };

            while(q.Count > 0)

            {
                var curr = q.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int new_r = curr.Item1 + dir[i][0], new_c = curr.Item2 + dir[i][1];

                    if(new_r >=0  && new_c >=0 && new_r < rows && new_c < cols)
                    {
                        if(dist[new_r][new_c] > dist[curr.Item1][curr.Item2]+1)
                        {
                            dist[new_r][new_c] = dist[curr.Item1][curr.Item2] + 1;
                            q.Enqueue(new Tuple<int, int>(new_r, new_c));
                        }
                    }
                }
            }

            return dist;

        }

        public int[][] UpdateMatrix(int[][] mat)
        {

            int rows = mat.Length;
            if (rows == 0)
                return mat;

            int cols = mat[0].Length;

            int[][] dist = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                dist[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    dist[i][j] = int.MaxValue;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i][j] == 0)
                        dist[i][j] = 0;
                    else
                    {
                        if (i > 0)
                            dist[i][j] = Math.Min(dist[i][j], dist[i - 1][j] + 1);
                        if(j > 0)
                            dist[i][j] = Math.Min(dist[i][j], dist[i ][j-1] + 1);
                    }
                }
            }

            for (int i = rows-1; i >=0; i--)
            {
                for (int j = cols-1; j >=0; j--)
                {
                    if (i < rows - 1)
                        dist[i][j] = Math.Min(dist[i][j], dist[i + 1][j] + 1);
                    if (j < cols - 1)
                        dist[i][j] = Math.Min(dist[i][j], dist[i][j + 1] + 1);
                }
            }

            return dist;
        }




        }
}
