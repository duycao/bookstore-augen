using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Web.Services
{
    public interface IBookEnquiryService
    {
        Task<JObject> GetBooks(string searchText = "");
    }
}
