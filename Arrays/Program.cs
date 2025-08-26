using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        
        static void Main(string[] args)
        { 

            int[] nums = new int[11] { 12, 7, 4, 27, 1, 13, 19, 6, 30, 9, 8 };
            int[] sortNums = new int[11];
            int low = nums[0];
            for (int i = 0; i<nums.Length;i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < low)
                    {
                        low = nums[j];
                    }
                }

                sortNums[i] = low;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == low)
                    {
                        nums[j] = 999999;
                    }
                }


            }

            foreach (int i in sortNums)
            {
                Console.WriteLine(i);


            }
        }
    }
}
