﻿using _2015147386_ENT.Entities;
using _2015147386_PER.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147386_PER
{
    public class TransporteDbContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<LugarViaje> LugarViajes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public TransporteDbContext() : base("Transporte")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());



            base.OnModelCreating(modelBuilder);
        }

        

    }
}
