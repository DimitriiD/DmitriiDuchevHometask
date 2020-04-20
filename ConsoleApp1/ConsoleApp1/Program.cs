using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string srt = Console.ReadLine();
                for (int i = 0; i < srt.Length; i+=2)
            {
                Console.WriteLine(srt[i]);
            }
        }
    }
}
