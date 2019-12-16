using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Web
{
    public class BuyBookModel
    {
        public string DeliveryService { get; set; } = string.Empty;
        public double DeliveryCost { get; set; } = 0;
    }
}
