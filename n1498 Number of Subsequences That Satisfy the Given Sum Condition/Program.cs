using System;
using System.Collections.Generic;
using System.Linq;

namespace n1498_Number_of_Subsequences_That_Satisfy_the_Given_Sum_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new();

            Console.WriteLine(sol.NumSubseq(new int[] { 3, 3, 6, 8 }, 10));
        }
    }


    public class Solution
    {
        public int NumSubseq(int[] nums, int target)
        {
            int count = 0;

            List<int> list = nums.ToList();
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                for (int x = 0; x < list.Count - i; x++)
                {
                    for (int j = i; j < list.Count; j++)
                    {
                        if (list[i] + list[j] <= target)
                        {
                            count++;
                            break;
                        }
                    }
                }
            }
            return count;
        }
    }

}
