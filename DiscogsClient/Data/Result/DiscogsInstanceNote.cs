using System;
using Newtonsoft.Json;
using RestSharpHelper;

namespace DiscogsClient.Data.Result 
{
    public class DiscogsInstanceNote : DiscogsEntity
    {
        public string name { get; set; }
        public string value { get; set; }
       
    }
}
