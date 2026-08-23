using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());

        long[] c = Array.ConvertAll(
            Console.ReadLine().Split(),
            long.Parse
        );
        long left=0;
        long right=n-1;
        long left_sum=0;
        long right_sum=0;
        long result=0;
        while(left<=right)
        {
            if(left_sum<right_sum)
            {
                left_sum+=c[left];
                left++;
            }
            else
            {
                right_sum+=c[right];
                right--;
            }

            if (left_sum == right_sum)
            {
                result=left_sum;
            }
            
        }
        Console.WriteLine(result);


        
    }
}