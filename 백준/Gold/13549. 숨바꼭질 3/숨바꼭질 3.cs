using System;
using System.Collections.Generic;
using System.Text;

class Num13549
{
    static int N;
    static int K;
    static int[] minTimes = new int[100001];
    
    struct State
    {
        public int pos;
        public int time;
        
        public State(int p, int t)
        {
            pos = p;
            time = t;
        }
    }
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        K = int.Parse(input[1]);
        Queue<State> queue = new Queue<State>();
        
        for(int i = 0; i < minTimes.Length; i++)
        {
            minTimes[i] = int.MaxValue;
        }
        
        queue.Enqueue(new State(N, 0));
        minTimes[N] = 0;
        
        while(queue.Count > 0)
        {
            State current = queue.Dequeue();
            
            if(current.time > minTimes[current.pos])
            {
                continue;
            }
            
            if (current.pos * 2 <= 100000)
            {
                if (minTimes[current.pos * 2] > current.time)
                {
                    minTimes[current.pos * 2] = current.time;
                    queue.Enqueue(new State(current.pos * 2, current.time));
                }
            }

            if (current.pos + 1 <= 100000)
            {
                if (minTimes[current.pos + 1] > current.time + 1)
                {
                    minTimes[current.pos + 1] = current.time + 1;
                    queue.Enqueue(new State(current.pos + 1, current.time + 1));
                }
            }

            if (current.pos - 1 >= 0)
            {
                if (minTimes[current.pos - 1] > current.time + 1)
                {
                    minTimes[current.pos - 1] = current.time + 1;
                    queue.Enqueue(new State(current.pos - 1, current.time + 1));
                }
            }
        }
        
        Console.WriteLine(minTimes[K]);
    }
}