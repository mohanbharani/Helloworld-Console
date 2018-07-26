using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Content_API;
using Content_API.Controllers;
using HelloWorldRepo.Service.InterfaceService;
using HelloWorldRepo.Provider;

namespace Content_API.Controllers.Tests
{
    [TestClass()]
    public class HelloWorldAPIControllerTests
    {
        [TestMethod()]
        public void HelloWorldAPIControllerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {

            // Arrange
            HelloWorldAPIController controller = new HelloWorldAPIController();

            // Act
            IDataService dataService = InstanceProvider.GetDataService();

            var textData = dataService.GetTextData();

            // Assert
            Assert.IsNotNull(textData);
        }
    }
}