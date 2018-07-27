using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldRepo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepo.Service.Tests
{
    [TestClass()]
    public class AppSettingTests
    {
        [TestMethod()]
        public void GetAppSettingTest()
        {

            AppSetting appSeeting = new AppSetting();
            string sample = appSeeting.GetAppSetting("Sample");

            Assert.Equals(sample, "Sample");
        }

        [TestMethod()]
        public void GetAppSettingTest1()
        {

            AppSetting appSeeting = new AppSetting();
            string test = appSeeting.GetAppSetting("Test");

            Assert.Equals(test, "test");
            Assert.Fail();
        }
    }
}