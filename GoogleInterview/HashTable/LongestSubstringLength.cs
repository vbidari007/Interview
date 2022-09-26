using System;
using System.Collections.Generic;

namespace HashTable
{
    public class LongestSubstringLength
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int res = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (check(s, i, j))
                        res = Math.Max(res, j - i + 1);


                }
            }

            return res;
        }

        private bool check(string s, int start, int end)
        {
            var hashSet = new HashSet<char>();

            for (int i = start; i <= end; i++)
            {
                if (hashSet.Contains(s[i]))
                    return false;

                hashSet.Add(s[i]);

            }
            return true;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            var chars = new Dictionary<char, int>();

            int left = 0, right = 0;

            int res = 0;
            while(right < s.Length)
            {
                char c = s[right];
                if (chars.ContainsKey(c))
                    chars[c]++;
                else
                    chars.Add(c, 1);

                while(chars[c] > 1)
                {
                    char l = s[left];
                    chars[l]--;
                    left++;
                }

                res = Math.Max(res, left - right + 1);
                right++;

            }

            return res;
        }

        public int LengthOfLongestSubstring3(string s)
        {
            int n = s.Length, ans = 0;
            var dic = new Dictionary<char, int>();

            for (int i = 0,j=0; j < n; j++)
            {
                if (dic.ContainsKey(s[j]))
                    i = Math.Max(dic[s[j]], i);

                ans = Math.Max(ans, j - i + 1);
                dic[s[j]] = j + 1;

            }

            return ans;
        }

        }
}
