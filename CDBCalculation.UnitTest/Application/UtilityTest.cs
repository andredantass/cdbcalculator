using CDBCalculation.Application.Util;
using FluentAssertions;
using FakeItEasy;

namespace CDBCalculation.UnitTest.Application
{
    public class UtilityTest
    {
        public UtilityTest()
        {
            
        }
        [Theory]
        [InlineData(1, 22.5)]
        [InlineData(2, 22.5)]
        [InlineData(3, 22.5)]
        [InlineData(5, 22.5)]
        [InlineData(6, 22.5)]
        [InlineData(7, 20)]
        [InlineData(8, 20)]
        [InlineData(9, 20)]
        [InlineData(10, 20)]
        [InlineData(11, 20)]
        [InlineData(12, 20)]
        [InlineData(16, 17.5)]
        [InlineData(17, 17.5)]
        [InlineData(18, 17.5)]
        [InlineData(19, 17.5)]
        [InlineData(20, 17.5)]
        [InlineData(21, 17.5)]
        [InlineData(24, 17.5)]
        [InlineData(25, 15)]
        [InlineData(27, 15)]
        [InlineData(30, 15)]
        [InlineData(40, 15)]
        [InlineData(50, 15)]
        public void ShouldPassPerido_ReturnIRAliquot(int period, double expectedAliquot)
        {
            //Arrange

            //Act
            var result = Utility.GetIRAliquot(period);

            //Assert
            result.Should().Be(expectedAliquot);

        }
    }
}
