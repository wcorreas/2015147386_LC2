using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class VentaConfiguration : EntityTypeConfiguration<VentaConfiguration>
    {
        public VentaConfiguration()
        {
            //Table Configurations

            ToTable("Ventas");
            HasKey(a => a.VentaId);


            //Relation Configurations
        }
    }
}
