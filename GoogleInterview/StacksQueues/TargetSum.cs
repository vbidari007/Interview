using System;
using System.Linq;

namespace StacksQueues
{
    public class TargetSum
    {
        int count = 0;
        int total = 0;
        public int FindTargetSumWays_1(int[] nums, int target)
        {
            Calculate(nums, 0, 0, target);
            return count;
        }

        private void Calculate(int[] nums, int i, int sum, int S)
        {
            if(i==nums.Length)
            {
                if (sum == S)
                    count++;


            }
            else
            {
                Calculate(nums, i + 1, sum + nums[i], S);
                Calculate(nums, i + 1, sum - nums[i], S);
            }



        }

        public int FindTargetSumWays_2(int[] nums, int target)
        {
            total = nums.Sum();
            int[][] memo = new int[nums.Length][];

            for (int i = 0; i < nums.Length; i++)
            {
                memo[i] = new int[2 * total + 1];
                Array.Fill<int>(memo[i], int.MinValue);
            }

            return Calculate(nums, 0, 0,target, memo);
        }

        private int Calculate(int[] nums, int i, int sum, int S, int[][] memo)
        {
            if(i==nums.Length)
            {
                if (sum == S)
                {
                    return 1;
                }
                else
                    return 0;
            }
            else
            {
                if(memo[i][sum+total]!=int.MinValue)
                {
                    return memo[i][sum + total];
                }

                int add = Calculate(nums, i + 1, sum + nums[i], S, memo);
                int subtract = Calculate(nums, i + 1, sum - nums[i], S, memo);

                memo[i][sum + total] = add + subtract;
                return memo[i][sum + total];
            }
        }
    }
}
