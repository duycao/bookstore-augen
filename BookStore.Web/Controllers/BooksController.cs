using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Web.Providers;
using BookStore.Web.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BookStore.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private IServicesProvider<IBookEnquiryService> _bookServiceProvider;
        private IDeliveryInfoGenerator _deliveryInfoGenerator;

        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger, IServicesProvider<IBookEnquiryService> bookServiceProvider, IDeliveryInfoGenerator deliveryInfoGenerator)
        {
            _logger = logger;
            _bookServiceProvider = bookServiceProvider;
            _deliveryInfoGenerator = deliveryInfoGenerator;
        }

        [HttpGet]
        public async Task<object> Get( string text="" )
        {
            var result = await _bookServiceProvider.GetInstance("BookEnquiryApiService").GetBooks(text);
            
            return Ok(result);
        }

        public object Buy([FromBody] BuyBookModel buyBookModel)
        {
            return Ok(new
            {
                Driver = _deliveryInfoGenerator.Generate(1,10),
                Phone = _deliveryInfoGenerator.Generate(2,10),
                buyBookModel.DeliveryService,
                buyBookModel.DeliveryCost
            });
        }
    }
}
