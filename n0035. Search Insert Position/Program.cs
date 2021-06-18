using System;

namespace n0035._Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new();

            Console.WriteLine(sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int index = 0;
            int halfElem;

            while (start <= end)
            {
                index = (start + end) / 2;
                halfElem = nums[index];


                if (target > halfElem)
                {
                    start = index + 1;
                }
                else
                {
                    if (halfElem == target)
                    {
                        return index;
                    }
                    else
                    {
                        end = index - 1;
                    }
                }
            }

            if (target > nums[index])
            {
                index++;
            }

            return index;
        }
    }

}
