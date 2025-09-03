using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void SortArray()
        {
            int[] nums = new int[11] { 12, 7, 4, 27, 1, 13, 19, 6, 30, 9, 8 };
            int[] sortNums = new int[11];

            for (int i = 0; i < nums.Length; i++)
            {
                int low = 999;
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

       

        static void SortMultiArry()
        {
            int[,] nums = { {54,3,21,50,57,7,73,24,85,79}, {33,11,19,33,51,72,80,6,78,25}, {1,65,4,86,71,52,16,77,29,13}, {23,44,90,70,28,17,53,64,62,83}, {55,98,22,89,34,75,56,58,27,35}, {87,88,8,61,74,14,66,20,59,81}, {18,76,2,5,26,84,15,82,9,60} };
            int[,] sortNums = { { 0,0,0,0,0,0,0,0,0,0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

            for (int i = 0; i < nums.GetLength(0); i++)
            {
               
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    int low=999;

                    
                    for (int k = 0; k < nums.GetLength(0); k++)
                    {
                        for (int l = 0; l < nums.GetLength(1); l++)
                        {
                            if (nums[k, l] <= low)
                            {
                                low = nums[k, l];
                            }
                        }

                    }
                    

                    sortNums[i,j] = low;
                    
                    for (int k = 0; k < nums.GetLength(0); k++)
                    {
                        for (int l = 0; l < nums.GetLength(1); l++)
                        {
                            if (nums[k, l] == low)
                            {
                                nums[k, l] = 999999;
                                break;
                            }
                        }
                        
                    }
                }

                
            }

            foreach (int i in sortNums)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Normal array sorted:");
            SortArray();
            Console.WriteLine("\n");
            Console.WriteLine("Multi dimensional array sorted:");
            SortMultiArry();

        }
    }
}
