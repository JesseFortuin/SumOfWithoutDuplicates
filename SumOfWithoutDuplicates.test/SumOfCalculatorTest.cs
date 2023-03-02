using SumOfWithoutDuplicates.BL;

namespace SumOfWithoutDuplicates.test
{
    public class SumOfCalculatorTest
    {
        [Theory]
        [InlineData(new int[] { 3, 4, 3, 6 }, 10)]
        [InlineData(new int[] { 1, 1, 2, 3 }, 5)]
        [InlineData(new int[] {1, 1, 2, 2, 3}, 3)]

        public void SumNoDuplicates(int[] input, int expected)
        {
            //arrange
            SumOfCalculator calculator = new SumOfCalculator();

            //act
            int actual = calculator.SumNoDuplicates(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}