﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepo.Service.InterfaceService
{
    public interface IAppSetting
    {
        string GetAppSetting(string key);
    }
}
