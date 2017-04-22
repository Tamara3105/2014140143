using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class LineaTelefonica
    {
        List<TipoLinea> _tipoLinea;


        public LineaTelefonica(string tipoLinea)
        {
            _tipoLinea.Add(new TipoLinea(tipoLinea));

        }
    }
}
