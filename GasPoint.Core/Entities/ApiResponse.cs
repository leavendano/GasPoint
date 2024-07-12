using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GasPoint.Core.Entities
{
    public class ApiResponse<T> where T : class
    {
        private IEnumerable<T> _data = Array.Empty<T>();

        [JsonPropertyName("success")]
        public bool Success { get; set; } = true;


        [JsonPropertyName("error")]
        public string Error { get; set; } = "";


        [JsonPropertyName("data")]
        public IEnumerable<T>? Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value ?? Array.Empty<T>();
            }
        }
    }
}
