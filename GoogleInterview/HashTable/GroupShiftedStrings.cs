using System;
using System.Collections.Generic;

namespace HashTable
{
    public class GroupShiftedStrings
    {
        public char ShiftLetter(char letter,int shift)
        {
            return (char)((letter - shift + 26) % 26 + 'a');
        }

        public string GetHash(string s)
        {
            char[] chars = s.ToCharArray();
            int shift = chars[0];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = ShiftLetter(chars[i], shift);
            }

            string hashKey = new string(chars);
            return hashKey;
        }
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            var dic = new Dictionary<string, IList<string>>();

            foreach (var str in strings)
            {
                string hashKey = GetHash(str);
                if (dic.ContainsKey(hashKey))
                    {
                    dic[hashKey].Add(str);
                }
                else
                {
                    dic.Add(hashKey, new List<string>() { str });
                }
            }

            var result = new List<IList<string>>();


            foreach (var item in dic)
            {
                result.Add(item.Value);
            }

            return result;
        }
    }
}
