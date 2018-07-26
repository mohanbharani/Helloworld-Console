using HelloWorldRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console.Service
{
    public interface IHelloWorldApiService
    {

        TextDataModel GetTodaysData();
    }
}
