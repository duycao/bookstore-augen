using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Web.Services
{
    public interface IDeliveryInfoGenerator
    {
        string Generate(int type,int length);
    }
}
