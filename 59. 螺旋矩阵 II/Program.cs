using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _59.螺旋矩阵_II
{
    internal class Program
    {

        /*
         给你一个正整数 n ，生成一个包含 1 到 n2 所有元素，且元素按顺时针顺序螺旋排列的 n x n 正方形矩阵 matrix 。
         
         输入：n = 3
            输出：[[1,2,3],[8,9,4],[7,6,5]]
         */

        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] ints = solution.GenerateMatrix(5);
            foreach (int[] nums in ints)
            {
                foreach (int i in nums)
                {
                    Console.Write("\t" + i);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            int start = 0;
            int end = n - 1;
            int x, y;
            int count = 1;
            while (count < n * n)
            {
                x = start;
                y = start;
                for (; x < end; x++)
                    result[y][x] = count++;
                for (; y < end; y++)
                    result[y][x] = count++;
                for (; x > start; x--)
                    result[y][x] = count++;
                for (; y > start; y--)
                    result[y][x] = count++;
                start++;
                end--;
            }
            if (n % 2 == 1)
            {
                result[start][start] = count;
            }
            return result;
        }
    }
}
