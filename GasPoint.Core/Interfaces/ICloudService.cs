using GasPoint.Core.Entities;
using GasPoint.Core.Transaccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.Interfaces
{
    public interface ICloudService
    {
        Task<ApiResponse<T>> GetClientByTelephoneAsync<T>(string token, string url, string numero) where T : class;
        Task<ApiResponse<T>> CreateTransaccionAsync<T>(string token, string url, TransaccionDTO parametros) where T : class;
    }
}
