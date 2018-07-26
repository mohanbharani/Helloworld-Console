using HelloWorldRepo.Model;
using HelloWorldRepo.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldRepo.Service.InterfaceService
{
    public class DataService : IDataService
    {

        public IAppSetting appSetting;
        public IFileIOService fileIOService;
        public IUri uri;

        public IHelloWorldWrapper helloWorldWrapper;
        public DataService() {

            this.appSetting = InstanceProvider.GetAppSetting();
            this.fileIOService = InstanceProvider.GetTextFromFile();
            this.uri = InstanceProvider.GetLocalPath();
            this.helloWorldWrapper = InstanceProvider.GetHelloWorld();

        }

        public TextDataModel GetTextData()
        {
            // Get the file path
            var filePath = this.appSetting.GetAppSetting(Constants.Constants.TextData);

            if (string.IsNullOrEmpty(filePath))
            {

                throw new Exception("File Doesn't Exsist");
            }

            var localPath = this.uri.GetLocalPath(filePath);
            
            var data = this.fileIOService.ReadFile(localPath);
            var dataModel = this.helloWorldWrapper.GetTextData(data);

            return dataModel;
        }


    }
}
