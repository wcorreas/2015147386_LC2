﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<ClienteConfiguration>
    {
        public ClienteConfiguration()
        {
            //Table Configurations

            ToTable("Clientes");
            HasKey(a => a.ClienteId);


            //Relation Configurations
        }

        private void HasKey(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        private void ToTable(string v)
        {
            throw new NotImplementedException();
        }
    }
}
