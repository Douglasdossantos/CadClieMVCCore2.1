using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeClientes.Models.Contexto
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Cliente>().HasKey(t => t.Id);
            //modelBuilder.Entity<Cliente>().HasOne(t => t.Endereco);
            modelBuilder
                .Entity<Endereco>()
                .ToTable("Enderecos");
            modelBuilder
                .Entity<Endereco>()
                .Property<int>("ClienteId");
            modelBuilder
                .Entity<Endereco>()
                .HasKey("ClienteId");



        }
    }
}
