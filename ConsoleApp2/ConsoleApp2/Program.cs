using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Random mrnd = new Random();
            int[] arr = new int[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = mrnd.Next(0, 1000);
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                if (arr[i] % 2 == 0)
                {
                    x += arr[i];
                }
            }
            Console.WriteLine("x = {0}", x);
        }
    }
}
