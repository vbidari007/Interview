using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            Stack<char> data = new Stack<char>();

            foreach (var c in s)
            {
                if(c==')')
                {

                    if (data.Count==0 || data.Pop() != '(')
                        return false;
                }
                 else if(data.Count == 0 || c =='}')
                {
                  
                    if(data.Count == 0 || data.Pop() != '}')
                        return false;
                   
                }
                else  if (data.Count == 0 || c == ']')
                {
                    if( data.Pop() != '[')
                        return false;
                }
                else
                data.Push(c);
                 
            }

            return data.Count == 0;
        }
    }
}
