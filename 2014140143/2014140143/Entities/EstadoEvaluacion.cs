using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class EstadoEvaluacion
    {
        string[] tipos = { "Aprobado", "Desaprobado"};


        public string leerEstado(int tipo)
        {

            return tipos[tipo];
        }
    }
}
