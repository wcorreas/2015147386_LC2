

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class ServicioConfiguration : EntityTypeConfiguration<ServicioConfiguration>
    {
        public ServicioConfiguration()
        {
            //Table Configurations

            ToTable("Servicios");
            HasKey(a => a.ServicioId);


            //Relation Configurations
        }
    }
}
