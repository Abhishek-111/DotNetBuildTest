using BasicDotNetProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BasicDotNetProject.Tests
{
    public class DemoControllerTests
    {
        [Fact]
        public void Method1_ReturnsOk()
        {
            // Arrange
            var controller = new DemoController();

            // Act
            var result = controller.Method1() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Success", result.Value);
        }

        [Fact]
        public void Method2_ReturnsOkWithId()
        {
            // Arrange
            var controller = new DemoController();
            int id = 123;

            // Act
            var result = controller.Method2(id) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);

            var responseObject = result.Value as dynamic;
            Assert.NotNull(responseObject);
            Assert.Equal(id, responseObject.message);
        }
    }
}
