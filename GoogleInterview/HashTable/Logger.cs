using System;
using System.Collections.Generic;

namespace HashTable
{
    public class Logger
    {
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            var dic = new Dictionary<string, int>();

            if(dic.ContainsKey(message))
            {
                if ((timestamp - dic[message]) >=10)
                    return true;
                else
                    return false;
            }
            else
            {
                dic.Add(message, timestamp);
            }
            return true;
        }



    }
}
