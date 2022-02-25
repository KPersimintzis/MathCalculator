using System;

namespace MathCalculator
{
    public static class Calculator
    {
        public static int Addition(int a, int b) => a + b;
        public static int Subtraction(int a, int b) => a - b;
        public static int Multiplication(int a, int b) => a * b;
        public static double Deviation(int a, int b) => (b!=0) ? a / b : int.MinValue;
    }
}
