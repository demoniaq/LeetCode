using System;

namespace n0027_Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new();

            Console.WriteLine(sol.RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i++] = nums[j];
                }
            }

            return i;
        }
    }
}
