using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    class Vvod
    {
        public static double Ninput()
        {

            for (; ; )
            {
                try
                {
                    double a = double.Parse(Console.ReadLine());
                    return a;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. You can only input numbers");
                }
            }
        }
        public static char Oinput()
        {
            for (; ; )
            {
                try
                {
                    char opr = char.Parse(Console.ReadLine());
                    if (opr == '+' || opr == '-' || opr == '/' || opr == '*')
                    {
                        return opr;
                    }
                    Console.WriteLine("Invalid input. You can only input operation + - * /");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. You can only input operation + - * /");
                }
            }
        }
      }
}
