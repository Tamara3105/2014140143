using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Cliente
    {
        string nombre;
        string apellidos;
        string dni;
        string sueldo;

        public Cliente() { }

        public Cliente(string nomb, string ape, string dni, string sue)
        {
            this.nombre = nomb;
            this.dni = dni;
            this.apellidos = ape;
            this.sueldo = sue;
        }

    }
}
