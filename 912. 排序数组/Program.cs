using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _912.排序数组
{
    internal class Program
    {
        /*

         给你一个整数数组 nums，请你将该数组升序排列。
        你必须在 不使用任何内置函数 的情况下解决问题，时间复杂度为 O(nlog(n))，并且空间复杂度尽可能小。
        输入：nums = [5,2,3,1]
        输出：[1,2,3,5]
         */
        static void Main(string[] args)
        {
            int[] array = { 19, 20, 22, 32, 34, 50, 99, 49, 1, 11, 11, 55, 35, 93, 96, 71, 70, 38, 78, 48 };
            Solution s = new Solution();
            int[] arr = s.XiEr(array);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }

    public class Solution
    {

        public int[] SortArray(int[] nums)
        {

            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }


        public void QuickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivotpas = Partition(nums, low, high);
                QuickSort(nums, low, pivotpas - 1);
                QuickSort(nums, pivotpas + 1, high);

            }
        }


        private int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[low];
            while (low < high)
            {
                while (low < high && nums[high] >= pivot)
                    high--;
                nums[low] = nums[high];
                while (low < high && nums[low] <= pivot)
                    low++;
                nums[high] = nums[low];
            }
            nums[low] = pivot;
            return low;

        }
        public int[] XuanZe(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i; j < nums.Length; j++)
                    if (nums[i] > nums[j])
                        (nums[i], nums[j]) = (nums[j], nums[i]);
            return nums;
        }

        public int[] MaoPao(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length - 1 - i; j++)
                    if (nums[j] > nums[j + 1])
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
            return nums;
        }

        public int[] ChaRu(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = nums[i], j;
                for (j = i - 1; j > 0; j--)
                    if (nums[j] > temp)
                        nums[j + 1] = nums[j];
                    else
                        break;
                nums[j] = temp;
            }
            return nums;
        }




        public int[] XiEr(int[] arr)
        {
            int j, temp;
            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    temp = arr[i];
                    for (j = i; j >= gap && temp < arr[j - gap]; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }
            return arr;
        }
    }
}
