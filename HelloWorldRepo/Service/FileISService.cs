using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRepo.Service
{
    public class FileISService : IFileIOService

    {
       public string ReadFile(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath, Encoding.UTF8);
                return text;
            }
            catch(FieldAccessException fa)
            {
                throw fa;
            }
            //catch
            //{
            //    throw new Exception("Un-Handled Exception From FileIOService");
            //}
        }
    }
}
