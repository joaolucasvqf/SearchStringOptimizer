using SearchStringOptimizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SearchStringOptimizer.Models
{
    public class StringMutator : IStringMutator
    {
        public async Task<string> AplicaMutacao()
        {
            throw new NotImplementedException();
        }

        //private async Task<string> BuscaSinonimos(string palavra)
        //{
        //    HttpClient client = new HttpClient();
        //    HttpRequestMessage request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Get,
        //        RequestUri = new Uri("https://wordsapiv1.p.rapidapi.com/words/bloody/similarTo"),
        //        Headers =
        //        {
        //            { "x-rapidapi-key", "4d7520e99cmsha8fceb35925ce5ap1883ddjsncd9be4b442ae" },
        //            { "x-rapidapi-host", "wordsapiv1.p.rapidapi.com" },
        //        },
        //    };
        //    using (var response = await client.SendAsync(request))
        //    {
        //        response.EnsureSuccessStatusCode();
        //        var body = await response.Content.ReadAsStringAsync();
        //        Console.WriteLine(body);
        //    }
        //}
    }
}
