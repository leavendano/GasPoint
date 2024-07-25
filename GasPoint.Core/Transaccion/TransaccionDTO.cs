using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.Transaccion
{
    public class TransaccionDTO
    {
        public int HoseDeliveryId { get; set; }
        public int ClienteId { get; set; }
        public int EstacionId { get; set; }
        public string? Fecha { get; set; }
        public decimal Importe { get; set; }
        public decimal Volumen {  get; set; }
        public int ProductoId { get; set; }
        public int Puntos { get; set; }
    }
}
