using System;
using System.Collections.Generic;


namespace SymmetricPairs
{
    class Program
    {
        public void Symmetric(int[,] arr)
        {
            Dictionary<int, int> pair = new Dictionary<int, int>();
            int val = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                int first = arr[i, 0];
                int sec = arr[i, 1];
                if (pair.ContainsKey(sec))
                {
                    val = pair[sec];
                }
                if (val != 0 && val == first)
                    Console.WriteLine("(" + sec + ", " + first + ")");
                else
                    pair.Add(first, sec);
            }

        }
        static void Main(string[] args)
        {            
            int[,] arr = new int[5, 2];
            arr[0, 0] = 11;
            arr[0, 1] = 20;
            arr[1, 0] = 30;
            arr[1, 1] = 40;
            arr[2, 0] = 5;
            arr[2, 1] = 10;
            arr[3, 0] = 40;
            arr[3, 1] = 30;
            arr[4, 0] = 10;
            arr[4, 1] = 5;
            new Program().Symmetric(arr);
            Console.ReadLine();
        }
    }
}
