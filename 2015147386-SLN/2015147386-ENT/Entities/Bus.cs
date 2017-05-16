using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_ENT.Entities
{
    class Bus
    {
        public Tripulacion Tripulacion { get; set; }

        public Bus()
        {

        }

        public Bus(Tripulacion tripulacion)
        {
            Tripulacion = tripulacion;
        }

        public string Placa { get; set; }
    }
}

