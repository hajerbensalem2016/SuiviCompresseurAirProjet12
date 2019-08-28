﻿// <auto-generated />
using System;
using MicroRabbit.GestionCompresseur.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroRabbit.GestionCompresseur.Data.Migrations
{
    [DbContext(typeof(CompresseurDbContext))]
    [Migration("20190827160607_ijo")]
    partial class ijo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.CompresseurFiliale", b =>
                {
                    b.Property<int>("CompFilialeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompresseurID");

                    b.Property<DateTime>("DateDebut");

                    b.Property<int>("Duree");

                    b.Property<int>("FilialeID");

                    b.Property<float>("MontantMensuel");

                    b.Property<float>("MontantTotal");

                    b.Property<string>("Name");

                    b.HasKey("CompFilialeID");

                    b.HasIndex("CompresseurID");

                    b.ToTable("CompresseurFiliales");
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.Consommable", b =>
                {
                    b.Property<int>("ConsommableID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompFilialeID");

                    b.Property<int>("ConsommationComp");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("PrixUnitaire");

                    b.HasKey("ConsommableID");

                    b.HasIndex("CompFilialeID");

                    b.ToTable("Consommables");
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.FicheCompresseur", b =>
                {
                    b.Property<int>("CompresseurID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodeCompresseur");

                    b.Property<int>("CompFilialeID");

                    b.Property<string>("Constructeur");

                    b.Property<float>("Debit");

                    b.Property<int>("FournisseurID");

                    b.Property<int>("Puissance");

                    b.Property<string>("TypeCompresseur");

                    b.HasKey("CompresseurID");

                    b.HasIndex("FournisseurID");

                    b.ToTable("FicheCompresseurs");
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.Fiche_Suivi", b =>
                {
                    b.Property<int>("FicheSuiviID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompFilialeID");

                    b.Property<double>("CourantAbsorbePhase");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Etat");

                    b.Property<string>("FréquenceEentretienDeshuileur");

                    b.Property<int>("Index_Electrique");

                    b.Property<int>("Nbre_Heurs_Charge");

                    b.Property<int>("Nbre_Heurs_Total");

                    b.Property<double>("PriseCompteur");

                    b.Property<string>("Remarques");

                    b.Property<double>("THuileC");

                    b.Property<string>("TSécheurC");

                    b.Property<double>("TempsArret");

                    b.Property<string>("TypeDernierEntretien");

                    b.HasKey("FicheSuiviID");

                    b.HasIndex("CompFilialeID");

                    b.ToTable("Fiche_Suivis");
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.FilialeDup", b =>
                {
                    b.Property<int>("FilialeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Nom");

                    b.HasKey("FilialeID");

                    b.ToTable("filialeDup");
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.FournisseurDup", b =>
                {
                    b.Property<int>("FournisseurID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse");

                    b.Property<string>("Email");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.HasKey("FournisseurID");

                    b.ToTable("FournisseursDup");
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.GRH", b =>
                {
                    b.Property<int>("GRhID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Charge_Compresseur");

                    b.Property<float>("Charge_Secteur");

                    b.Property<float>("Charge_Total");

                    b.Property<int>("CompFilialeID");

                    b.Property<float>("Compresseur_Pourcentage");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<decimal>("Salaire");

                    b.Property<float>("Secheur_Pourcentage");

                    b.HasKey("GRhID");

                    b.HasIndex("CompFilialeID");

                    b.ToTable("GRHs");
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.CompresseurFiliale", b =>
                {
                    b.HasOne("MicroRabbit.GestionCompresseur.Domain.Models.FicheCompresseur", "FicheCompresseur")
                        .WithMany("CompresseurFiliales")
                        .HasForeignKey("CompresseurID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.Consommable", b =>
                {
                    b.HasOne("MicroRabbit.GestionCompresseur.Domain.Models.CompresseurFiliale", "CompresseurFiliale")
                        .WithMany("Consommables")
                        .HasForeignKey("CompFilialeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.FicheCompresseur", b =>
                {
                    b.HasOne("MicroRabbit.GestionCompresseur.Domain.Models.FournisseurDup")
                        .WithMany("FicheCompresseurs")
                        .HasForeignKey("FournisseurID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.Fiche_Suivi", b =>
                {
                    b.HasOne("MicroRabbit.GestionCompresseur.Domain.Models.CompresseurFiliale", "CompresseurFiliale")
                        .WithMany("Fiche_Suivis")
                        .HasForeignKey("CompFilialeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MicroRabbit.GestionCompresseur.Domain.Models.GRH", b =>
                {
                    b.HasOne("MicroRabbit.GestionCompresseur.Domain.Models.CompresseurFiliale", "CompresseurFiliale")
                        .WithMany("GRHs")
                        .HasForeignKey("CompFilialeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
