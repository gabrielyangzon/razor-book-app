using Book_App.Model;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Book_App.Services
{
    public class DataModelServices
    {
        public IWebHostEnvironment WebHostEnvironment { get; set; }
        public DataModelServices(IWebHostEnvironment webHostEnvironment)
        {
            this.WebHostEnvironment = webHostEnvironment;
        }


        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Data.json"); }
        }


        public IEnumerable<ProductModel> GetData()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<ProductModel[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }


        public async Task<List<UsersModel>> GetUsers()
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");

            List<UsersModel> users = new List<UsersModel>();

            if (response.IsSuccessStatusCode)
            {
                users = response.Content.ReadFromJsonAsync<List<UsersModel>>().Result;
            }

            return users;
        }
    }
}
