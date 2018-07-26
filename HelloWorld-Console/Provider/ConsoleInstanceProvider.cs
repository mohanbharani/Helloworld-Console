using HelloWorld_Console.Service;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console.Provider
{
    public static class ConsoleInstanceProvider
    {

        public static IRestClient GetRestClient()
        {
            return new RestClient();
        }

        public static IRestRequest GetRestRequest()
        {
            return new RestRequest();
        }

        public static IHelloWorldApiService GetApiService()
        {
            return new HelloWorldApiService();
        }
    }
}
