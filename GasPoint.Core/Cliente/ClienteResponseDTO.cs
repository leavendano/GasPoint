using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPoint.Core.Cliente
{
    public record ClienteResponseDTO(int id, string nombre, decimal saldoPuntos);
}
