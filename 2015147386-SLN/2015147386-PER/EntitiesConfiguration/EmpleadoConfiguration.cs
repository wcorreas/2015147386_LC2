using _2015147386_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguration()
        {
            ToTable("Empleados");
            HasKey(a => a.EmpleadoId);

            Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativos"));
            Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulaciones"));
        }

    }
}
