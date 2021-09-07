using Newtonsoft.Json;
using Seachcourses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Seachcourses.Helpers
{
    public class HttpcallsHandler
    {
       public async Task<List<UniversityCourses>> Get ( string url)
        {
            var client = new HttpClient();
            var result = new List<UniversityCourses>();
            HttpResponseMessage responseMessage = await client.GetAsync(url);


            if (responseMessage.IsSuccessStatusCode)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;

                 result = JsonConvert.DeserializeObject<List<UniversityCourses>>(content);

            }

            return result;
           
        }

        public async Task<List<UniversityCourses>> Post(string url, UniversityCourses data)
        {
            var client = new HttpClient();
            var result = new List<UniversityCourses>();
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url, data);


            if (responseMessage.IsSuccessStatusCode)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;

                result = JsonConvert.DeserializeObject<List<UniversityCourses>>(content);

            }

            return result;

        }
    }
}