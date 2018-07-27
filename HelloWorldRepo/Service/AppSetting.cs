using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepo.Service
{
    public class AppSetting : IAppSetting
    {
        public string GetAppSetting(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings.Get(key);
            }
            catch(NullReferenceException nr)
            {
                throw nr;
            }
            catch
            {
                throw new Exception("Un-handled Exception From AppSetting");
            }
        }
    }
}
