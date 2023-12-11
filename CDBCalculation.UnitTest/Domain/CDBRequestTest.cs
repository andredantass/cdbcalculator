using CDBCalculation.Domain;
using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDBCalculation.UnitTest.Domain
{
    public class CDBRequestTest
    {
        [Fact]
        public async void ShouldCreate_CDBCalculatedRequestObject()
        {
            //Arrange
        
            double monetaryValue = 1000;
            int period = 6;

            //Act
            var request = new CDBRequest() { monetaryValue = monetaryValue, period = period};

            //Assert
            request.Should().NotBeNull();
        }
    }
}
