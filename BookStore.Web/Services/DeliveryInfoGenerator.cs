using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Web.Services
{
    public class DeliveryInfoGenerator : IDeliveryInfoGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">1: random string, 2: random number</param>
        /// <param name="length"></param>
        /// <returns>string</returns>
        public string Generate(int type, int length)
        {
            string characters = type==1 ? "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" : "0123456789";
            StringBuilder result = new StringBuilder(length);
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }
    }
}
