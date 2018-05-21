using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AtosParkCL;

namespace AtosPark
{
    public class UserService
    {
        const string Url = "https://atospark.azurewebsites.net/api/users";
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
        public async Task AddUser(User user)
        {
            HttpClient client = GetClient();
            await client.PostAsync(Url, new StringContent(JsonConvert.SerializeObject(user),Encoding.UTF8, "aplication/json"));

            
        }

    }
}
