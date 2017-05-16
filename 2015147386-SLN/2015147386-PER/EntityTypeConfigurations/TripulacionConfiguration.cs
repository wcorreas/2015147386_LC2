using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class TripulacionConfiguration : EntityTypeConfiguration<TipoTripulacionConfiguration>
    {
        public TripulacionConfiguration()
        {
            //Table Configurations

            ToTable("Tripulaciones");
            HasKey(a => a.TripulacionId);


            //Relation Configurations
        }
    }
}
