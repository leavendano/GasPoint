using GasPoint.Core.Entities;
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
    }
}
