using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n003_Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new();

            Console.WriteLine(sol.LengthOfLongestSubstring(" "));
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> list = s.ToList();

            int maxLen = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count - i <= maxLen)
                {
                    break;
                }

                List<char> subList = new List<char>();

                for (int j = i; j < list.Count; j++)
                {
                    if (subList.Contains(list[j]))
                    {
                        break;
                    }
                    else
                    {
                        subList.Add(list[j]);
                    }
                }

                if (subList.Count > maxLen) maxLen = subList.Count;
            }

            return maxLen;
        }
    }

}
