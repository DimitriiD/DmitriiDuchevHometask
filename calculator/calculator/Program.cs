using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A");
            double a = Vvod.Ninput();
            Console.WriteLine("Input operation + - * /");
            char opr = Vvod.Oinput();
            Console.WriteLine("Input B");
            double b = Vvod.Ninput();
            Console.WriteLine("{0} {1} {2} = {3}", a, opr, b, Calc.Calculator(a, b, opr));
        }
    }
}
