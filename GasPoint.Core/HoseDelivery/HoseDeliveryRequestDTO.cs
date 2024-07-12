using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.HoseDelivery
{
    public class HoseDeliveryRequestDTO
    {
        public int Hose_ID { get; set; }
        public short Delivery_State { get; set; } = 15;
    }
}
