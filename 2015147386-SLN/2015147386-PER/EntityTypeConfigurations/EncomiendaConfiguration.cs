using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class EncomiendaConfiguration : EntityTypeConfiguration<EncomiendaConfiguration>
    {
        public EncomiendaConfiguration()
        {
            //Table Configurations

            ToTable("Encomiendas");
            HasKey(a => a.EncomiendaId);


            //Relation Configurations
        }
    }
}
