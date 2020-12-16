using PruebaTecnicaLibrary.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLibrary.PruebaTecnicaService
{
    public class Json_Service
    {
        

        public List<MyJsonData> GetReleases(string url)
        {
            var Result = string.Empty;
            List<MyJsonData> dataObjects = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync("/users").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                
                // Parse the response body. Blocking!
                dataObjects = response.Content.ReadAsAsync<IEnumerable<MyJsonData>>().Result.ToList();
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            return dataObjects;
        }
    }
}
