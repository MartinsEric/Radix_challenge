using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiraQuestao
{
    class RadixContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<Pessoa>()
                .HasKey("Id_customers");

            modelBuilder
                .Entity<Cliente>()
                .HasOne(p => p.Cpf)
                .WithOne(i => i.Cliente)
                .HasForeignKey<Pessoa>(b => b.Id_customers);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RadixDB;Trusted_Connection=true;");
        }
    }
}
