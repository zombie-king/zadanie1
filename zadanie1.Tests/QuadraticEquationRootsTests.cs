using Xunit;

namespace zadanie1.Tests
{
    public class ConsulOptionsTests
    {
        [Theory]
        [InlineData(1.0, 1.0, -2.0, -2.0, 1.0)]
        [InlineData(-2.0, 4.0, -2.0, 1.0, null)]
        [InlineData(1.0, 1.0, 1.0, null, null)]
        public void TestCalculate(double a, double b, double c, double? x1, double? x2)
        {
            var quadraticEquationRoots = new QuadraticEquationRoots(a, b, c);
            var result = quadraticEquationRoots.Calculate();

            Assert.Equal(x1, result.Item1);
            Assert.Equal(x2, result.Item2);
        }
        
    }
}