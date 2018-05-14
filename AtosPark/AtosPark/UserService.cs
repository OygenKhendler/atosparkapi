using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AtosPark
{
    public class UserService
    {
        const string Url = "http://localhost:62972/";
        //configure client
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "aplication/json");
            return client;
        }
        //Get all users
        public async Task<IEnumerable<User>> Get()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<User>>(result);
        }

        //Add user
        public async Task<User> AddUser(User user)
        {
            HttpClient client = GetClient();
            var response = await client.PostAsync(Url, new StringContent(JsonConvert.SerializeObject(user),Encoding.UTF8, "aplication/json"));

            if (response.StatusCode != HttpStatusCode.OK)
                return null;

            return JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
        }

    }
}
