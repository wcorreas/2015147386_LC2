using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class EmpleadoConfiguration : EntityTypeConfiguration<EmpleadoConfiguration>
    {
        public EmpleadoConfiguration()
        {
            //Table Configurations

            ToTable("Empleados");
            HasKey(a => IdDEmpleado);


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
