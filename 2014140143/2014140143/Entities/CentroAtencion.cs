using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class CentroAtencion
    {
        string _sucursal;

        private Direccion _direccion;

        public CentroAtencion(string sucursal)
        {
            _sucursal = sucursal;
        }

        public Direccion direccion { get { return _direccion; } }

    }
}
