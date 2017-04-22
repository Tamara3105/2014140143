using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Plan
    {
        List<TipoPlan> _tipoPlan;


        public Plan(string tipoPlan)
        {
            _tipoPlan.Add(new TipoPlan(tipoPlan));

        }
    }
}
}
