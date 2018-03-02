using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using PairingTest.Web.Interface;
using PairingTest.Web.Models;

namespace PairingTest.Web.Service
{
    public class GetDataFromApi: IServiceApi
    {
        public async Task<QuestionnaireViewModel> Request()
        {
            var questionnaire = new QuestionnaireViewModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56244/api/");
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("questions");



                if (res.IsSuccessStatusCode)
                {

                    var quesResponse = res.Content.ReadAsStringAsync().Result;


                    questionnaire = JsonConvert.DeserializeObject<QuestionnaireViewModel>(quesResponse);

                }
            }

            return questionnaire;

        }


    }
}