using System;
using System.Collections.Generic;
using System.Text;

class Num16953
{
    static int A;
    static int B;
    static int count;
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        
        A = int.Parse(input[0]);
        B = int.Parse(input[1]);
        count = 1;
        
        int num = B;
        while(true)
        {
            if(A > num)
            {
                count = -1;
                break;
            }
            
            if(A == num)
            {
                break;
            }
            
            if(num % 10 == 1)
            {
                num = num / 10;
                count++;
            }
            else if(num % 2 == 0)
            {
                num = num / 2;
                count++;
            }
            else
            {
                count = -1;
                break;
            }
              
        }
        
        Console.WriteLine(count);
    }
}