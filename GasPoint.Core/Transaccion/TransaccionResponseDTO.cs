using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GasPoint.Core.Transaccion
{
    public class TransaccionResponseDTO
    {
        [JsonPropertyName("hoseDeliveryId")]
        public int HoseDeliveryId { get; set; }
        [JsonPropertyName("clienteId")]
        public int ClienteId { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }
        [JsonPropertyName("productoId")]
        public int ProductoId { get; set; }
        [JsonPropertyName("importe")]
        public decimal Importe { get; set; }
        [JsonPropertyName("volumen")]
        public decimal Volumen {  get; set; }
        [JsonPropertyName("puntos")]
        public int Puntos { get; set; }
    }
}
