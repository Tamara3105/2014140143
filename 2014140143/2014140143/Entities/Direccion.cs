using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Direccion
    {
        string _direccion;
        private Ubigeo _ubigeo;

        public Direccion(string direccion)
        {
            _direccion = direccion;
        }

        public Ubigeo ubigeo { get { return _ubigeo; } }
    }
}
