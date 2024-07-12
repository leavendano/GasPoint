using GasPoint.Core.Entities;
using GasPoint.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Infrastructure.Services
{
    public class CloudService : BaseService, ICloudService
    {
        public CloudService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {  
        }

        public async Task<ApiResponse<T>> GetClientByTelephoneAsync<T>(string token, string url, string numero) where T : class
        {
            return await this.SendAsync<T>(new ApiRequest(token, url, numero));
        }
    }
}
