using HelloWorld_Console.Service;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console.Provider
{
    public sealed class ConsoleInstanceProvider
    {
        public static readonly ConsoleInstanceProvider instanceProvider = new ConsoleInstanceProvider();

        public ConsoleInstanceProvider GetInstance
        {
            get { return instanceProvider; }
        }
        private ConsoleInstanceProvider()
        {

        }

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
