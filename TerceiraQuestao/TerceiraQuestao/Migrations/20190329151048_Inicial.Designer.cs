using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TerceiraQuestao;

namespace TerceiraQuestao.Migrations
{
    [DbContext(typeof(RadixContext))]
    [Migration("20190329151048_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TerceiraQuestao.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<double>("Credit_Limit");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TerceiraQuestao.Pessoa", b =>
                {
                    b.Property<int>("Id_customers");

                    b.Property<string>("Cpf");

                    b.HasKey("Id_customers");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("TerceiraQuestao.Pessoa", b =>
                {
                    b.HasOne("TerceiraQuestao.Cliente", "Cliente")
                        .WithOne("Cpf")
                        .HasForeignKey("TerceiraQuestao.Pessoa", "Id_customers")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
