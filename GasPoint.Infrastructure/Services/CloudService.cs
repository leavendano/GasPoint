using GasPoint.Core.Entities;
using GasPoint.Core.Interfaces;
using GasPoint.Core.Transaccion;
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
            url = url + $"/{numero}";
            var resultado = await this.SendAsync<T>(new ApiRequest(token, url, null,"GET"));

            return resultado;
        }


        public async Task<ApiResponse<T>> CreateTransaccionAsync<T>(string token, string url, TransaccionDTO parametros) where T : class
        {
            var resultado = await this.SendAsync<T>(new ApiRequest(token, url, parametros));

            return resultado;
        }
    }
}
