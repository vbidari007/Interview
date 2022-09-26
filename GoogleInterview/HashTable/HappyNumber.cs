using System;
using System.Collections.Generic;

namespace HashTable
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            var seen = new HashSet<int>();
            while(n!=1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = GetNext(n);
            }
            return n == 1;

        }

        public bool IsHappy2(int n)
        {
            int slowRunner = n;
            int fastRunner = GetNext(n);

            while(fastRunner!=1 && slowRunner!=fastRunner)
            {
                slowRunner = GetNext(slowRunner);
                fastRunner = GetNext(GetNext(fastRunner));
            }
            return fastRunner == 1;
        }

        private int GetNext(int n)
        {
            int totalSum = 0;
            while(n > 0)
            {
                int d = n % 10;
                n = n / 10;
                totalSum += d * d;
            }

            return totalSum;
        }
    }
}
