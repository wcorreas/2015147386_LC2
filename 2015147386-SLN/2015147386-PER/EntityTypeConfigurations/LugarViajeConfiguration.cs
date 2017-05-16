using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class LugarViajeConfiguration : EntityTypeConfiguration<LugarViajeConfiguration>
    {
        public LugarViajeConfiguration()
        {
            //Table Configurations

            ToTable("LugarViajes");
            HasKey(a => a.LugarViajeId);


            //Relation Configurations
        }

    }
}
