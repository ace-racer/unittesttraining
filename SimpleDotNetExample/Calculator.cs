using System;

namespace SimpleDotNetExample
{
    public static class Calculator
    {
        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>The value of a + b if the result is in int range</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        public static int Add(int a, int b)
        {
            if (a > 0 && b > 0 && a + b <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (a < 0 && b < 0 && a + b > 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return a + b;
        }

        /// <summary>
        /// Divides the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>The value of a/b if b != 0</returns>
        /// <exception cref="System.DivideByZeroException">Cannot divide by 0</exception>
        public static double Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }

            return a / b;
        }

        /// <summary>
        /// Multiplies the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>The value of a * b</returns>
        public static int Multiply(int a, int b)
        {
            // TODO: Add conditions to handle boundary cases and add unit tests in a separate class in the unit tests project
            return a * b;
        }

        /// <summary>
        /// Subtracts the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>The value of a - b</returns>
        public static int Subtract (int a, int b)
        {
            // TODO: Add conditions to handle boundary cases and add unit tests in a separate class in the unit tests project
            return a - b;
        }

        /// <summary>
        /// Moduloes the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>The value of a % b</returns>
        public static int Modulo(int a, int b)
        {
            // TODO: Add conditions to handle boundary cases and add unit tests in a separate class in the unit tests project
            return a % b;
        }
    }
}
