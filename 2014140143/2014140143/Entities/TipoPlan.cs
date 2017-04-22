using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class TipoPlan
    {
       

        string[] tipos = { "Prepago", "Postpago"};


        public string leerTipoEvaluacion(int tipo)
        {

            return tipos[tipo];
        }
    }
}
