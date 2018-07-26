using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace HelloWorldRepo.Service
{
    public class UriLocalPath : IUri
    {
        public string GetLocalPath(string fileName)
        {

            string path;
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + fileName;
            string localPath = new Uri(path).LocalPath;

            return localPath;
        }
    }
}
