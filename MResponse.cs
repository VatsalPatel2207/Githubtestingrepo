using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWEB2
{
    public class MResponse
    {
        [JsonProperty("@xmlns:xs")]
        public string xmlnsxs { get; set; }

        [JsonProperty("@xmlns")]
        public string xmlns { get; set; }
        public Response Response { get; set; }
    }

    public class Response
    {
        public string EntityID { get; set; }
        public string EntityNumber { get; set; }
        public string Status { get; set; }
        public string StatusType { get; set; }
    }

}