using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.Entities
{

    public class ApiRequest
    {
        public string ApiType { get; set; }

        public string Url { get; set; }

        public Object Data { get; set; }

        public string AccessToken { get; set; }

        public ApiRequest(string token, string url, Object data, string apiType = "POST")
        {
            AccessToken = token;
            Url = url;
            Data = data;
            ApiType = apiType;
        }
    }
}
