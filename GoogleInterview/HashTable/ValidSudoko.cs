using System;
using System.Collections.Generic;

namespace HashTable
{
    public class ValidSudoko
    {
        public bool IsValidSudoku1(char[][] board)
        {
            int N = 9;

            var rows = new HashSet<char>[N];
            var cols = new HashSet<char>[N];
            var boxes = new HashSet<char>[N];

            for (int r = 0; r < N; r++)
            {
                rows[r] = new HashSet<char>();
                cols[r] = new HashSet<char>();
                boxes[r] = new HashSet<char>();
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    char val = board[r][c];

                    if (val == '.')
                        continue;

                    if (rows[r].Contains(val))
                        return false;

                    rows[r].Add(val);

                    if (cols[c].Contains(val))
                        return false;

                    cols[c].Add(val);

                    int idx = (r / 3) * 3 + c / 3;
                    if (boxes[idx].Contains(val))
                        return false;

                    boxes[idx].Add(val);

                }
            }

            return true;
        }

        public bool IsValidSudoku2(char[][] board)
        {
            int N = 9;

            var rows = new int[N,N];
            var cols = new int[N, N];
            var boxes = new int[N, N];


            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {

                    if (board[r][c] == '.')
                        continue;

                    int pos = board[r][c] - '1';

                    if (rows[r, pos] == 1)
                        return false;

                    rows[r, pos] = 1;

                    if (cols[c, pos] == 1)
                        return false;

                    cols[c, pos] = 1;

                    int idx = (r / 3 * 3) + c / 3;

                    if (boxes[idx, pos] == 1)
                        return false;

                    boxes[idx, pos] = 1;
                }
            }

            return true;
        }

        public bool IsValidSudoku3(char[][] board)
        {
            int N = 9;

            var rows = new int[N];
            var cols = new int[N];
            var boxes = new int[N];



            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {

                    if (board[r][c] == '.')
                        continue;
                    int val = board[r][c] - '0';
                    int pos = (1 << (val - 1));

                    if ((rows[r]  & pos )> 0)
                        return false;

                    rows[pos] |= pos;

                    if ((cols[c] & pos) > 0)
                        return false;

                    cols[c] |= pos;

                    var idx = (r / 3 * 3) + c / 3;


                    if ((boxes[idx] & pos) > 0)
                        return false;

                    boxes[idx] |= pos;


                }
            }

            return true;
        }
    }
}
