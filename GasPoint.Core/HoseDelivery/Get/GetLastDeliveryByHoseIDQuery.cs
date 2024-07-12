using MediatR;


namespace GasPoint.Core.HoseDelivery.Get
{
    public record GetLastDeliveryByHoseIDQuery(int hoseID) : IRequest<HoseDeliveryResponseDTO>;
   
}
