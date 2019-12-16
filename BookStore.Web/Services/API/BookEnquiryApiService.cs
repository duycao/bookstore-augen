using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BookStore.Web.Services.API
{
    public class BookEnquiryApiService : IBookEnquiryService
    {
        public async Task<JObject> GetBooks(string searchText="")
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://www.googleapis.com/books/v1/volumes?q={searchText}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JObject.Parse(apiResponse);
                }
            }
        }
    }
}
