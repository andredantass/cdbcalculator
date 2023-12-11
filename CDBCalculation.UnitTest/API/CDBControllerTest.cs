using CDBCalculation.API.Controllers;
using CDBCalculation.Application.Abastraction;
using CDBCalculation.Application.Services;
using CDBCalculation.Domain;
using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CDBCalculation.UnitTest.API
{
    public class CDBControllerTest
    {
        private readonly ICDBCalculationService _service;
        private readonly CDBController _controller;
        public CDBControllerTest()
        {
            _service = A.Fake<ICDBCalculationService>(options => options.Implements<ICDBCalculationService>());
            _controller = new CDBController();
        }

        [Fact]
        public async void CDBCalculation_RequestCalculationController_ReturnCDBCalculatedObject()
        {
            //Arrange
            var response = A.Fake<CDBResponse>();
            response.netValue = 1000;
            response.grossValue = 1200;

            var request = A.Fake<CDBRequest>();
            request.monetaryValue = 1000;
            request.period = 6;

            A.CallTo(() => _service.CalculateCDBByPeriod(request)).Returns(response);
            //Act
            var controllerResult = await _controller.RequestCDBCalculcation(_service,request);

            //Assert
            controllerResult.Should().NotBeNull();
            controllerResult.Should().BeOfType<OkObjectResult>();
        }
    }
}
