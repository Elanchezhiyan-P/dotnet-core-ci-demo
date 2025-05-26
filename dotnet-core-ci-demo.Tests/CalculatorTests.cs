namespace dotnet_core_ci_demo.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        public void Add_MultipleCases(int a, int b, int expected)
        {
            var calc = new Calculator();
            Assert.Equal(expected, calc.Add(a, b));
        }
    }
}