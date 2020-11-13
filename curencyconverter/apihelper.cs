using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace curencyconverter
{
    class apihelper
    {
        public static HttpClient apiclt { get; set; }
         public static void initclt()
        {
           apiclt = new HttpClient();
          
           
            apiclt.DefaultRequestHeaders.Accept.Clear();
            apiclt.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


        }
    }
}
