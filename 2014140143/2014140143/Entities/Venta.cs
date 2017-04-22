using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Venta
    {
        List<Contrato> _contrato;
        List<TipoPago> _tipoPago;


        public Venta(string contrato, string tipoPago)
        {
            _contrato.Add(new Contrato(contrato));
            _tipoPago.Add(new TipoPago(tipoPago));
        }

    }
}
