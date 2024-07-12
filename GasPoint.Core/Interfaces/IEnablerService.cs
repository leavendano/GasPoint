using GasPoint.Core.HoseDelivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.Interfaces
{
    public interface IEnablerService
    {
        
        HoseDeliveryResponseDTO? GetLastDeliveryByHostID(int hoseID);
    }
}
