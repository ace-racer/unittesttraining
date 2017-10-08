using System;

namespace SimpleDotNetExample
{
    public static class Calculator
    {        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }

            return a / b;
        }
    }
}
