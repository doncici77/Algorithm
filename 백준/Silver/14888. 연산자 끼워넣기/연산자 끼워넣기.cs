using System;
using System.Collections.Generic;
using System.Text;

class Num14888
{
    static int N;
    static int[] arr;
    static int[] _operator;
    static int max, min;
    
    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        
        string[] input_arr = Console.ReadLine().Split();
        arr = new int[N];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(input_arr[i]);
        }
        
        _operator = new int[4];
        string[] input_operator = Console.ReadLine().Split();
        for(int i = 0; i < 4; i++)
        {
            _operator[i] = int.Parse(input_operator[i]);
        }
        
        max = int.MinValue;
        min = int.MaxValue;
        
        BackTracking(1, arr[0]);
        
        Console.WriteLine(max.ToString());
        Console.WriteLine(min.ToString());
    }
    
    static void BackTracking(int index, int result)
    {
        if(index == N)
        {
            if(max < result)
            {
                max = result;
            }
            if(min > result)
            {
                min = result;
            }
            return;
        }
        
        for(int i = 0; i < 4; i++)
        {
            if(_operator[i] > 0)
            {
                _operator[i]--;
                
                if (i == 0)
                {
                    BackTracking(index + 1, result + arr[index]);
                }
                else if (i == 1)
                {
                    BackTracking(index + 1, result - arr[index]);
                }
                else if (i == 2)
                {
                    BackTracking(index + 1, result * arr[index]);
                }
                else if (i == 3)
                {
                    BackTracking(index + 1, result / arr[index]);
                }
            
                _operator[i]++;
            }
        }
    }
}