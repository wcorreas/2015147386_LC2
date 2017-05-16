using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_ENT.Entities
{
    class Transporte : Servicio
    {
        public Bus Bus { get; set; }
        public Cliente Cliente { get; set; }
        public TipoViaje TipoViaje { get; set; }
        public LugarViaje LugarViaje { get; set; }


        private Transporte()
        {
            Cliente = new Cliente();
            TipoViaje = new TipoViaje();
            LugarViaje = new LugarViaje();
        }

        public Transporte(Bus bus)
        {
            Bus = bus;
            Cliente = new Cliente();
            TipoViaje = new TipoViaje();
            LugarViaje = new LugarViaje();
        }
    }
}
