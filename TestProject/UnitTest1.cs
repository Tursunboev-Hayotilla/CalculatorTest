using Xceed.Wpf.Toolkit;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(3, 3, 6)]
        [InlineData(0, 3, 3)]
        public void TestAdd(int a, int b, double expected)
        {
            double result = CalculatorTest.CalculatorTest.Add(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(0, 1, -1)]
        [InlineData(3, 10, -7)]

        public void TestSubstract(int a, int b, double expected)
        {
            double result = CalculatorTest.CalculatorTest.Subtract(a,b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 1, 3)]
        [InlineData(0, 1, 0)]
        [InlineData(3, 10, 30)]

        public void TestMultiply(int a, int b, double expected)
        {
            double result = CalculatorTest.CalculatorTest.Multiply(a,b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 1, 3)]
        [InlineData(0, 1, 0)]
        [InlineData(1,0,typeof(DivideByZeroException))]

        public void TestDevide(int a, int b, object expected)
        {
            if (b != 0)
            {
                var result = CalculatorTest.CalculatorTest.Divide(a,b);
                Assert.Equal(expected, result);
            }
            else
            {
                Assert.Throws<DivideByZeroException>(() => a / b);
            }
        }
    }
}