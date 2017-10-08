using System;

namespace SimpleDotNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 100;
            b = 20;
            c = Calculator.Add(a, b);
            Console.WriteLine("Add: " + c);

            c = Calculator.Multiply(a, b);
            Console.WriteLine("Multiply: " + c);

            c = Calculator.Subtract(a, b);
            Console.WriteLine("Subtract: " + c);

            var d = Calculator.Divide(a, b);
            Console.WriteLine("Divide: " + d);

            c = Calculator.Modulo(a, b);
            Console.WriteLine("Modulo: " + c);

            Console.ReadKey();
        }
    }
}
