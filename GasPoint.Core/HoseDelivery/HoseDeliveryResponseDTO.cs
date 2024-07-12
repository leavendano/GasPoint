using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.HoseDelivery
{
    public class HoseDeliveryResponseDTO
    {
        public int Delivery_ID { get; set; }
        public int Hose_ID { get; set; }
        public int Grade_ID { get; set; }
        public string GradeName { get; set; } = string.Empty;
        public DateTime Completed_TS { get; set; }
        public decimal Delivery_Volume { get; set; }
        public decimal Delivery_Value { get; set; }
    }
}
