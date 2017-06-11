using _2015147386_ENT.Entities;
using _2015147386_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.Repositories
{
    public class VentaRepository : Repository<Venta>, IVentaRepository
    {

        public VentaRepository(TransporteDbContext context) : base(context)
        {
        }

    }
}
