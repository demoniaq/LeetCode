using System;

namespace n007_Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new();

            Console.WriteLine(sol.Reverse(2147483647));
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            int maxValDel10 = int.MaxValue / 10;
            int minValDel10 = int.MinValue / 10;

            int result = 0;
            while (x != 0)
            {
                int rest = x % 10;
                x /= 10;
                if (result > maxValDel10 || (result == maxValDel10 && rest > 7)) return 0;
                if (result < minValDel10 || (result == minValDel10 && rest < -8)) return 0;
                result = result * 10 + rest;
            }

            return result;
        }
    }
}
