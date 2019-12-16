using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Web.Services.CSV
{
    public class BookEnquiryCSVService : IBookEnquiryService
    {
        public async Task<JObject> GetBooks(string searchText = "")
        {
            return await Task.FromResult(new JObject(false));
        }
    }
}
