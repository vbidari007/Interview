using System;
using System.Collections.Generic;

namespace HashTable
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dic_s_t = new Dictionary<char, char>();
            var dic_t_s = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if(dic_s_t.ContainsKey(s[i]))
                {
                    if (dic_s_t[s[i]] == t[i])
                        continue;
                    else
                        return false;
                }
                else
                {
                    dic_s_t.Add(s[i], t[i]);
                }

                if (dic_t_s.ContainsKey(t[i]))
                {
                    if (dic_t_s[t[i]] == s[i])
                        continue;
                    else
                        return false;
                }
                else
                {
                    dic_t_s.Add(t[i], s[i]);
                }
            }
            return true;
        }
    }
}
