using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class EquipoCelular
    {
        public string modelo;
        public string color;

        public EquipoCelular(string mode, string color)
        {

            this.modelo = mode;
            this.color = color;
        }
    }
}
