using HelloWorldRepo.Model;
using HelloWorldRepo.Provider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldRepo.Service.InterfaceService
{
    public class DataService : IDataService
    {

        private IAppSetting appSetting;
        private IFileIOService fileIOService;
        private IUri uri;
        private TextDataModel textModel;


        public IHelloWorldWrapper helloWorldWrapper;
        public DataService() {

            this.appSetting = InstanceProvider.GetAppSetting();
            this.fileIOService = InstanceProvider.GetTextFromFile();
            this.uri = InstanceProvider.GetLocalPath();
            this.helloWorldWrapper = InstanceProvider.GetHelloWorld();

        }

        public TextDataModel GetTextData()
        {
            
                
            try
            {
                // Get the file path
                var filePath = this.appSetting.GetAppSetting(Constants.Constants.TextData);

                if (string.IsNullOrEmpty(filePath))
                {

                    throw new Exception("File Doesn't Exsist");
                }

                var localPath = this.uri.GetLocalPath(filePath);

                var data = this.fileIOService.ReadFile(localPath);
                textModel = this.helloWorldWrapper.GetTextData(data);
                
            }
            catch(FileNotFoundException)
            {
                throw; // textModel.ErrorMsg = fx.Message.ToString();
            }
            catch (NullReferenceException)
            {
                throw;//textModel.ErrorMsg = nr.Message.ToString();
            }
            catch (Exception)
            {
                throw;// textModel.ErrorMsg = ex.Message.ToString();
            }
           
            return textModel;
        }


    }
}
