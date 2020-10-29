using System;
using Newtonsoft.Json;
using RestSharpHelper;

namespace DiscogsClient.Data.Result 
{
    public class DiscogsCollectionFolder : DiscogsEntity
    {
        public string name { get; set; }       
    }
}
