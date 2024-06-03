using System;

namespace Program
{
    class Program 
    {
        static void Main(string[] args)
        {
                    
            int[] nums = new int[10];
            

            for(int i = 0; i< nums.Length; i++)
            {
                nums[i] = i + 1;
            }

            // for(int j = 0; j < nums.Length; j++)
            // {
            //     System.Console.WriteLine("Element at position {0} = {1}",j, nums[j] );
            // }

            int counter = 0;
            foreach(int k in nums)
            {
                counter ++;
                System.Console.WriteLine("Element at position {0} = {1}", counter, k );
            }

        }
    }
}
