using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Ubigeo
    {
        List<Departamento> _depar;
        List<Provincia> _provi;
        List<Distrito> _dist;

        public Ubigeo(string depar, string provi, string dist)
        {
            _depar.Add(new Departamento(depar));
            _provi.Add(new Provincia(provi));
            _dist.Add(new Distrito(dist));
        }
    }
}
