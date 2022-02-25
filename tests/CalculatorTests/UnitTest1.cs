using FsCheck.Xunit;
using System;
using Xunit;
using MathCalculator;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Property(MaxTest = 10000)]
        public void Test1(int a,int b)
        {
            var addition = Calculator.Addition(a, b);
            Assert.Equal(a + b, addition);

        }
    }
}
