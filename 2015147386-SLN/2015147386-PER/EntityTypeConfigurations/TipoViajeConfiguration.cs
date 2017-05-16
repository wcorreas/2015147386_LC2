using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class TipoViajeConfiguration : EntityTypeConfiguration<TipoViajeConfiguration>
    {
        public TipoViajeConfiguration()
        {
            //Table Configurations

            ToTable("TipoViajes");
            HasKey(a => a.TipoViajeId);


            //Relation Configurations

        }
    }
}
