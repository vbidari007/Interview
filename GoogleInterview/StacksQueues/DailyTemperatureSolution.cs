using System;
namespace StacksQueues
{
    public class DailyTemperatureSolution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int len = temperatures.Length;
            int[] res = new int[len];

            for (int i = 0; i < len; i++)
            {
                var count = 0;
                for (int j = i+1; j < len; j++)
                {
                  if(temperatures[i] < temperatures[j])
                    {
                        res[i] = count;
                        break;
                    }
                  else
                    {
                        count++;
                    }
                }
            }
           // res[len - 1] = 0;
            return res;

        }
    }
}
