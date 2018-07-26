using HelloWorld_Console.Provider;
using HelloWorldRepo.Model;
using HelloWorldRepo.Provider;
using HelloWorldRepo.Service.InterfaceService;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console.Service
{
    public class HelloWorldApiService : IHelloWorldApiService
    {

        private IRestClient restClient;
        private IRestRequest restRequest;
        private IAppSetting appSettings;

        public HelloWorldApiService()
        {
            this.restClient = ConsoleInstanceProvider.GetRestClient();
            this.restRequest = ConsoleInstanceProvider.GetRestRequest();
            this.appSettings = InstanceProvider.GetAppSetting();
        }


        public TextDataModel GetTodaysData()
        {
            TextDataModel textData = null;

            this.restRequest.Resource = "HelloWorldAPI";
            this.restRequest.Method = Method.GET;
            this.restClient.BaseUrl = this.appSettings.GetAppSetting("HelloWorldAPIURL");
            
            this.restRequest.Parameters.Clear();

            
            var textDataModel = this.restClient.Execute<TextDataModel>(this.restRequest);

            
            if (textDataModel != null)
            {
                
                if (textDataModel.Data != null)
                {
                    textData = textDataModel.Data;
                }
                else
                {
                   
                    
                }
            }
            else
            {
                // Log the exception
                
            }

            return textData;
        }

    }
}
