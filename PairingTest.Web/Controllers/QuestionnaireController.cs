using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using PairingTest.Web.Interface;
using PairingTest.Web.Models;
using PairingTest.Web.Service;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        /* ASYNC ACTION METHOD... IF REQUIRED... */
        //        public async Task<ViewResult> Index()
        //        {
        //        }
        private readonly IServiceApi _serviceApi;

        public QuestionnaireController(IServiceApi service)
        {
            _serviceApi = service;
        }

        public QuestionnaireController() : this(new GetDataFromApi())
        {

        }

        public async Task<ViewResult> Index()
        {
            var questionnaire =  await _serviceApi.Request();

            return View("Index", questionnaire);
        }
    }
}