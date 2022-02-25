using System;

namespace MathCalculator
{
    public class Calculator
    {
        public int Addition(int a, int b) => a + b;
        public int Subtraction(int a, int b) => a - b;
        public int Multiplication(int a, int b) => a * b;
        public double Deviation(int a, int b) => (b!=0) ? a / b : int.MinValue;
    }
}
