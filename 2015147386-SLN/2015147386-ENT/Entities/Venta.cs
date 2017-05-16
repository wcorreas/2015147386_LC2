using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_ENT.Entities
{
    class Venta
    {
        public Administrativo Administrativo { get; set; }
        public Cliente Cliente { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        public TipoPago TipoPago { get; set; }
        public Servicio Servicio { get; set; }

        public Venta()
        {
            Administrativo = new Administrativo();
            Cliente = new Cliente();
            TipoComprobante = new TipoComprobante();
            TipoPago = new TipoPago();
            Servicio = new Servicio();
        }
    }
}
