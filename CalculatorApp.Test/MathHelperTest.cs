using Xunit;

namespace CalculatorApp.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void IsEvenTest()
        {
            var calculator = new MathHelper();
            int x = 1;
            int y = 2;

            var xResult = calculator.IEven(x);
            var yResult = calculator.IEven(y);

            Assert.False(xResult);
            Assert.True(yResult);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(1, 3, 2)]
        public void DiffTest(int x, int y, int expectedValue)
        {
            var calculator = new MathHelper();
            var result = calculator.Diff(x, y);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        public void AddTest(int x, int y, int expectedValue)
        {
            var calculator = new MathHelper();
            var result = calculator.Add(x, y);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, 6)]
        [InlineData(new int[3] { -4, -6, -10 }, -20)]
        public void SumTest(int[] values, int expectedValue)
        {
            var calculator = new MathHelper();
            var result = calculator.Sum(values);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, 2)]
        [InlineData(new int[3] { -4, -6, -10 }, -6)]
        public void AverageTest(int[] values, int expectedValue)
        {
            var calculator = new MathHelper();
            var result = calculator.Average(values);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(MathHelper.Data), MemberType = typeof(MathHelper))]
        public void Add_MemberData_Test(int x, int y, int expectedValue)
        {
            var calculator = new MathHelper();
            var result = calculator.Add(x, y);

            Assert.Equal(expectedValue, result);
        }

        [Theory(Skip ="This is just a reason...")]
        [ClassData(typeof(MathHelper))]
        public void Add_ClassData_Test(int x, int y, int expectedValue)
        {
            var calculator = new MathHelper();
            var result = calculator.Add(x, y);

            Assert.Equal(expectedValue, result);
        }
    }
}