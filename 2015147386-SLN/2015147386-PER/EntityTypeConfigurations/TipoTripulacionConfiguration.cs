using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class TipoTripulacionConfiguration : EntityTypeConfiguration<TipoTripulacionConfiguration>
    {
        public TipoTripulacionConfiguration()
        {
            //Table Configurations

            ToTable("TipoTripulaciones");
            HasKey(a => a.TipoTripulacionId);


            //Relation Configurations
        }
    }
}
