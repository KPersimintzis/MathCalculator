using System;

namespace MathCalculator
{
    public static class Calculator
    {
        public static int Addition(int a, int b) => a + b;
        public static int Subtraction(int a, int b) => a - b;
        public static int Multiplication(int a, int b) => a * b;
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
