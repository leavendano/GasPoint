using GasPoint.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.HoseDelivery.Get
{
    public class GetLastDeliveryByHoseIDHandler : IRequestHandler<GetLastDeliveryByHoseIDQuery, HoseDeliveryResponseDTO?>
    {
        public Task<HoseDeliveryResponseDTO?> Handle(GetLastDeliveryByHoseIDQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
