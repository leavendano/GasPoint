using GasPoint.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.Interfaces
{
    public interface IBaseService : IDisposable
    {
        Task<ApiResponse<T>> SendAsync<T>(ApiRequest request) where T : class;
    }
}
