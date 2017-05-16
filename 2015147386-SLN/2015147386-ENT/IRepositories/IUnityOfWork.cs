﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_ENT.IRepositories
{
    //DEBE HEREDAR DE IDISPOSABLE PARA QUE EL GARGABE COLLECTOR PUEDA LIBERAR MEMORIA QUE NO SEA UTILIZADA
    public interface IUnityOfWork : IDisposable
    {
        //CADA UNA DE LAS PROPIEDADES DEBEN SER DE SOLO "LECTURA"

        IAdministrativoRepository Administrativos { get; }
        IBusRepository Buss { get; }
        IClienteRepository Clientes { get; }
        IEmpleadoRepository Empleados { get; }
        IEncomiendaRepository Encomiendas { get; }
        ILugarViajeRepository LugarViajes { get; }
        IServicioRepository Servicios { get; }
        ITipoComprobanteRepository TipoComprobantes { get; }
        ITipoLugarRepository TipoLugars { get; }
        ITipoPagoRepository TipoPagos { get; }
        ITipoTripulacionRepository TipoTripulacions { get; }
        ITipoViajeRepository TipoViajes { get; }
        ITransporteRepository Transportes { get; }
        ITripulacionRepository Tripulacions { get; }
        IVentaRepository Ventas { get; }



        //METODO QUE GUARDA CAMBIOS EN LA B.D

        int SaveChanges();
    }
}
