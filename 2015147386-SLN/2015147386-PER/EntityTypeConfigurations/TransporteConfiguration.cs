using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class TransportConfiguration : EntityTypeConfiguration<TransportConfiguration>
    {
        public TransportConfiguration()
        {
            //Table Configurations

            ToTable("Transports");
            HasKey(a => a.TransporteId);


            //Relation Configurations
        }
    }
}
