using System;

namespace ConsoleTestAppNetCore5
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new();
            var rez = sol.TwoSum(new int[] { 3, 3 }, 6);

            for (int i = 0; i < rez.Length; i++)
            {
                Console.WriteLine(rez[i]);

            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int next = target - nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == next)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new ArgumentException("No solution");
        }
    }
}