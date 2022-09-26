using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueues
{
    public class DecodeStringSolution
    {
        private Stack<string> stack = new Stack<string>();

        private string RepeatString(string str,int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }
        public string DecodeString(string s)
        {
            string result = string.Empty;
            foreach (var ch in s.ToCharArray())
            {
                if(ch!=']')
                {
                    stack.Push(ch.ToString());
                }
                else
                {
                    string temp = stack.Pop();
                    string str = null;
                   while(temp !="[")
                    {
                        str = temp + str;
                        temp = stack.Pop();
                    }
                    int x = 0;
                    string num = string.Empty;
                   while(stack.Count > 0 && int.TryParse(stack.Peek(),out x))
                        {
                        x =int.Parse( stack.Peek());
                        num = x + num;
                    }
                    int n =int.Parse( num);
                   var res=RepeatString(str, n);
                    if (stack.Count > 0)
                        stack.Push(res);
                    else
                        result += res;
                }
            }

            string tem = string.Empty;
            while(stack.Count > 0)
            {
                tem = stack.Pop() + tem;
            }
            return result+tem;
        }
    }
}
