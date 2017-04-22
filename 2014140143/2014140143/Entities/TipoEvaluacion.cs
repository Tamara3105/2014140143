
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class TipoEvaluacion
    {
        string[] tipos = { "Renovación de Contrato", "Portabilidad", "Línea Nueva" };


        public string leerTipoEvaluacion(int tipo)
        {

            return tipos[tipo];
        }
    }
}
