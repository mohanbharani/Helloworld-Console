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
            try
            {
                
                IHelloWorldApiService helloWorldApiService = ConsoleInstanceProvider.GetApiService();

                var textDataModel = helloWorldApiService.GetTextData();

                Console.WriteLine(textDataModel != null ? textDataModel.Data : "No data was found!", null);

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
