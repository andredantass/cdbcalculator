using CDBCalculation.Application.Abastraction;
using CDBCalculation.Application.Services;
using CDBCalculation.Domain;
using FakeItEasy;
using FluentAssertions;
using System.Xml.XPath;

namespace CDBCalculation.UnitTest.Application
{
    public class CDBCalculationServiceTest
    {
        private readonly ICDBCalculationService _service;
        public CDBCalculationServiceTest()
        {
            _service = A.Fake<ICDBCalculationService>(options => options.Implements<ICDBCalculationService>());
            _service = new CDBCalculationService();
        }

        [Theory]
        [InlineData(1000, 6, 1046.31, 1059.75)]
        [InlineData(1000, 12, 1098.46, 1123.07)]
        [InlineData(1000, 24, 1215.58, 1261.31)]
        [InlineData(1000, 25, 1232.53, 1273.57)]
        public async void CDBCalculation_RequestCalculation_ReturnCDBCalculatedObject(double monetary,
                                                                                      int period, 
                                                                                      double expectedNet, 
                                                                                      double expectedGross)
        {
            //Arrange
            var request = A.Fake<CDBRequest>();
            request.monetaryValue = monetary;
            request.period = period;

            //Act
            var result = await _service.CalculateCDBByPeriod(request);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<CDBResponse>();
            result.netValue.Should().Be(expectedNet);
            result.grossValue.Should().Be(expectedGross);
        }
    }
}
