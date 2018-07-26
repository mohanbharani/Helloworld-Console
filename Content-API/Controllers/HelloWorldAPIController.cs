using HelloWorldRepo.Model;
using HelloWorldRepo.Provider;
using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Content_API.Controllers
{
    public class HelloWorldAPIController : ApiController
    {

        private IDataService dataService;


        public HelloWorldAPIController()
        {
            this.dataService = InstanceProvider.GetDataService();
        }

        public HttpResponseMessage Get()
        {

             var textData = this.dataService.GetTextData();

             return Request.CreateResponse<TextDataModel>(HttpStatusCode.OK, textData, "application/json");


            //return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
