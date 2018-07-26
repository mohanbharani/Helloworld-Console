using HelloWorldRepo.Model;
using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepo.Service
{
    public class HelloWorldWrapper : IHelloWorldWrapper
    {
        public TextDataModel GetTextData(string input)
        {
            return new TextDataModel {  Data = input };
        }
    }
}
