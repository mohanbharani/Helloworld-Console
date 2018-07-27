using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldRepo.Service.InterfaceService.Tests
{
    [TestClass()]
    public class DataServiceTests
    {
        [TestMethod()]
        public void GetTextDataTest()
        {
            DataService dataService = new DataService();

            dataService.GetTextData();


            Assert.Fail();
        }
    }
}