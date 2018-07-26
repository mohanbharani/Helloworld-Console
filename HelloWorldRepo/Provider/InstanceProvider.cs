﻿using HelloWorldRepo.Service;
using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepo.Provider
{
    public static class InstanceProvider
    {
        public static IAppSetting GetAppSetting()
        {
            return new AppSetting();
        }

        public static IDataService GetDataService()
        {
            return new DataService();
        }

        public static IUri GetLocalPath()
        {
            return new UriLocalPath();
        }

        public static IFileIOService GetTextFromFile()
        {
            return new FileISService();
        }

        public static IHelloWorldWrapper GetHelloWorld()
        {
            return new HelloWorldWrapper();
        }
    }
}
