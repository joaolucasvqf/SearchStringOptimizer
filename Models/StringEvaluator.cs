using SearchStringOptimizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace SearchStringOptimizer.Models
{
    public class StringEvaluator : IStringEvaluator
    {
        public async Task AvaliarString(string SearchString)
        {
            await ConsultaBaseI3E(SearchString);
        }
        private async Task ConsultaBaseI3E(string SearchString)
        {
            string url = "http://ieeexploreapi.ieee.org/api/v1/search/articles?apikey=ba9768qsdbn4ec6wmdgpkvxv&format=json&querytext=" + HttpUtility.UrlEncode(SearchString);
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
