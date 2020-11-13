using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace curencyconverter
{
    class curencyprossessor
    {
        public static async Task<pricemodel> loadprice(string base_currency_id, string quote_currency_id, int amount)
        {
            string url = $"https://api.coinpaprika.com/v1/price-converter?base_currency_id={ base_currency_id }&quote_currency_id={ quote_currency_id }&amount={ amount }";
          using (HttpResponseMessage response = await apihelper.apiclt.GetAsync(url))
            {
               
                if (response.IsSuccessStatusCode)
                {
                    pricemodel pricemodel1 = await response.Content.ReadAsAsync<pricemodel>();
                   
                    return pricemodel1;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                
            }
        }

    }
}
