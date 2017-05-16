using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class TipoComprobanteConfiguration : EntityTypeConfiguration<TipoComprobanteConfiguration>
    {
        public TipoComprobanteConfiguration()
        {
            //Table Configurations

            ToTable("TipoComprobantes");
            HasKey(a => a.TipoComprobanteId);


            //Relation Configurations
        }
    }
}
