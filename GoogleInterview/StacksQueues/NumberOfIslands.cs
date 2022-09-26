using System;
namespace StacksQueues
{
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int nr = grid.Length;
            int nc = grid[0].Length;
            int number_islands = 0;
            for (int r = 0; r < nr; r++)
            {
                for (int c = 0; c < nc; c++)
                {
                    if(grid[r][c]==1)
                    {
                        ++number_islands;
                        DFS(grid, r, c);
                    }
                }
            }

            return number_islands;
        }

        private void DFS(char[][] grid, int r, int c)
        {
            int nr = grid.Length;
            int nc = grid[0].Length;

            if(r <0 || c < 0 || r >= nr || c >=nc || grid[r][c]==0)
            {
                return ;
            }


            grid[r][c] = '0';
            DFS(grid, r + 1, c);
            DFS(grid, r, c + 1);
            DFS(grid, r - 1, c);
            DFS(grid, r, c - 1);

        }
    }
}
