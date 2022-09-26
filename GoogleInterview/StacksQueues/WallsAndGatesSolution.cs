using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class WallsAndGatesSolution
    {
        private static int EMPTY = int.MaxValue-1;
        private static int GATE = 0;
        private static List<int[]> DIRECTIONS = new List<int[]>
        {
            new int[] {1,0},new int[]{0,1},new int[]{0,-1},new int[] {-1,0}
        };

        public void WallsAndGates(int[][] rooms)
        {
            int m = rooms.Length;
            if (m == 0) return;
            int n = rooms[0].Length;
            Queue<int[]> q = new Queue<int[]>();
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if(rooms[row][col]==GATE)
                    {
                        q.Enqueue(new int[] { row, col });
                    }
                }
            }

            while(q.Count > 0)
            {
                int[] point = q.Dequeue();
                int row = point[0];
                int col = point[1];
                foreach (var direction in DIRECTIONS)
                {
                    int r = row + direction[0];
                    int c = col + direction[1];
                    if(r<0 || c<0 ||r >=m || c >=n|| rooms[r][c]!=EMPTY)
                    {
                        continue;
                    }
                    rooms[r][c] = rooms[r][c] + 1;
                    q.Enqueue(new int[] { r, c });
                }
            }

        }
    }
}
