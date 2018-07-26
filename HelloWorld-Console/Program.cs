using HelloWorld_Console.Provider;
using HelloWorld_Console.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            IHelloWorldApiService helloWorldApiService = ConsoleInstanceProvider.GetApiService();

            var dataModel = helloWorldApiService.GetTodaysData();

            Console.WriteLine(dataModel != null ? dataModel.Data : "No data was found!", null);

            Console.ReadLine();

        }
    }
}
