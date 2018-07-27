using HelloWorldRepo.Model;
using HelloWorldRepo.Provider;
using HelloWorldRepo.Service.InterfaceService;
using System;
using System.Collections.Generic;
using System.IO;
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
            HttpResponseMessage response;
            try
            {
                // throw new Exception();
                var txtModel = this.dataService.GetTextData();
                response = Request.CreateResponse<TextDataModel>(HttpStatusCode.OK, txtModel);
            }
            catch (FileNotFoundException fx)
            {
                response= Request.CreateResponse(HttpStatusCode.NotFound, fx.Message);
            }
            catch (NullReferenceException nr)
            {
                response = Request.CreateResponse(HttpStatusCode.MethodNotAllowed, nr.Message);
            }
            catch (Exception ex)
            {
                response= Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            return response;
            //return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
