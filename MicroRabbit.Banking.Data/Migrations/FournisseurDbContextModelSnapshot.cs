﻿// <auto-generated />
using MicroRabbit.GestionFournisseur.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroRabbit.GestionFournisseur.Data.Migrations
{
    [DbContext(typeof(FournisseurDbContext))]
    partial class FournisseurDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicroRabbit.GestionFournisseur.Domain.Models.Fournisseur", b =>
                {
                    b.Property<int>("FournisseurID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse");

                    b.Property<string>("Email");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.HasKey("FournisseurID");

                    b.ToTable("Fournisseurs");
                });
#pragma warning restore 612, 618
        }
    }
}
