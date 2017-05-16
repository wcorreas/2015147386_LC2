using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class TipoPagoConfiguration : EntityTypeConfiguration<TipoPagoConfiguration>
    {
        public TipoPagoConfiguration()
        {
            //Table Configurations

            ToTable("TipoPagos");
            HasKey(a => a.TipoPagoId);


            //Relation Configurations
        }
    }
}
