using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class TipoLugarConfiguration : EntityTypeConfiguration<TipoLugarConfiguration>
    {
        public TipoLugarConfiguration()
        {
            //Table Configurations

            ToTable("TipoLugares");
            HasKey(a => a.TipoLugarId);


            //Relation Configurations
        }
    }
}
