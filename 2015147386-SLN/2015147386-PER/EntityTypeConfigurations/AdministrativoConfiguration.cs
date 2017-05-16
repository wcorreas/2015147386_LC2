using System;

namespace _2015147386_PER.EntityTypeConfigurations
{
    public class AdministrativoConfiguration : EntityTypeConfiguration<AdministrativoConfiguration>
    {
        public AdministrativoConfiguration()
        {
            //Table Configurations

            ToTable("Administrativos");
            HasKey(a => a.AdministrativoId);


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

    public class EntityTypeConfiguration<T>
    {
    }
}
