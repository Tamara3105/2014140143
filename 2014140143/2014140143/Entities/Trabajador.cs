using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Trabajador
    {
        public string nombre;

        public string tipoTraba;

        public Trabajador(string nom, string tipo)
        {

            nombre = nom;
            tipoTraba = tipo;
        }
    }
}
