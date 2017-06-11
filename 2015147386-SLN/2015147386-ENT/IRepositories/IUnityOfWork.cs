using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {

        IAdministrativoRepository Administrativos { get; }
        IBusRepository Buses { get; }
        IClienteRepository Clientes { get; }
        IEncomiendaRepository Encomiendas { get; }
        ILugarViajeRepository LugarViajes { get; }
        ITransporteRepository Transportes { get; }
        ITripulacionRepository Tripulaciones { get; }
        IVentaRepository Ventas { get; }


        int SaveChanges();

        void StateModified(object Entity);
    }
}
