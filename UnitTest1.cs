using System;
using Xunit;

namespace CalculatorTestProj.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 2, 2)]
        [InlineData(3, 4, 7)]
        [InlineData(2, 8, 10)]
        [InlineData(-4,-3,-7)]
        public void Adding(int num1, int num2, int expected)
        {
            CalcTest challenger = new CalcTest();
            int actual = challenger.Adding(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(1102, 2, 1100)]
        [InlineData(500, 200, 300)]
        [InlineData(20, 15, 5)]
        [InlineData(-20,-10,-10)]
        public void Subtract(int num1, int num2, int expected)
        {
            CalcTest challenger = new CalcTest();
            int actual = challenger.Subtract(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(5, 17, 85)]
        [InlineData(8, 9, 72)]
        [InlineData(6, 6, 36)]
        [InlineData(-8,-7,56)]
        public void Multiply(int num1, int num2, int expected)
        {
            CalcTest challenger = new CalcTest();
            int actual = challenger.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 5, 3)]
        [InlineData(20, 5, 4)]
        [InlineData(8, 4, 2)]
        [InlineData(7, 7, 1)]
        [InlineData(-60,-20,3)]

        public void Divide(int num1, int num2, int expected)
        {
            CalcTest challenger = new CalcTest();
            int actual = challenger.Divide(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 120)]
        [InlineData(1, 1)]
        [InlineData(10, 3628800)]
        [InlineData(0, 0)]
        
        public void Factorial(int num1, int expected)
        {
            CalcTest challenger = new CalcTest();
            int actual = challenger.Factorial(num1);
            Assert.Equal(expected, actual);
        }
    }
}
