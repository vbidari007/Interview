using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class TrieNode
    {
        public TrieNode[] Children;
        public String Word;
        public TrieNode()
        {
            Children = new TrieNode[26];
        }
    }
    public class ReplaceWordsSolution
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            TrieNode trie = new TrieNode();
            foreach (var root in dictionary)
            {
                TrieNode cur = trie;
                foreach (var letter in root.ToCharArray())
                {
                    if(cur.Children[letter-'a']==null)
                    {
                        cur.Children[letter - 'a'] = new TrieNode();
                    }

                    cur = cur.Children[letter - 'a'];
                }
                cur.Word = root;
            }

            StringBuilder ans = new StringBuilder();

            foreach (var word in sentence.Split(' '))
            {
                if (ans.Length > 0)
                    ans.Append(" ");
                TrieNode cur = trie;

                foreach (var letter in word.ToCharArray())
                {
                    if(cur.Children[letter-'a']==null || cur.Word!=null)
                    {
                        break;
                    }

                    cur = cur.Children[letter - 'a'];
                }
                ans.Append(cur.Word != null ? cur.Word : word);
            }

            return ans.ToString();
        }
    }
}
