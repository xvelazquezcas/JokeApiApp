using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace JokeApiApp.Models
{
    public class JokeService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<Joke> GetRandomJokeAsync()
        {
            var response = await httpClient.GetAsync("https://v2.jokeapi.dev/joke/Programming,Spooky,Christmas");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Joke>(content);
        }
    }

    public class Joke
    {
        public string Setup { get; set; }
        public string Delivery { get; set; }
        public string JokeText{ get; set; }

        public bool IsSetup => Setup != null;
    }
}