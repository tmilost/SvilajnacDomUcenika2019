﻿// <auto-generated />
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DomUcenikaSvilajnac.DAL.Context.Migrations
{
    [DbContext(typeof(UcenikContext))]
    [Migration("20180712101214_SpajanjeUcenikaISmera")]
    partial class SpajanjeUcenikaISmera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Drzava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivDrzave")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Mesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivMesta");

                    b.HasKey("Id");

                    b.ToTable("Mesta");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Opstina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivOpstine")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Opstine");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Pol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivPola")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Polovi");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.PostanskiBroj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Broj");

                    b.Property<int>("OpstinaId");

                    b.HasKey("Id");

                    b.HasIndex("OpstinaId");

                    b.ToTable("PostanskiBrojevi");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.PrethodnaSkola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivPrethodneSkole")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<int>("OpstinaId");

                    b.HasKey("Id");

                    b.HasIndex("OpstinaId");

                    b.ToTable("OsnovneSkole");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Smer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivSmera");

                    b.HasKey("Id");

                    b.ToTable("Smerovi");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Telefon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Kucni")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("Mobilni")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.HasKey("Id");

                    b.ToTable("BrojeviTelefona");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Ucenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<int>("DrzavaRodjenjaId");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(50);

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<int?>("MestoPrebivalistaId");

                    b.Property<int?>("MestoRodjenjaId");

                    b.Property<int?>("MestoZavrseneSkoleId");

                    b.Property<int?>("OpstinaId");

                    b.Property<int?>("OpstinaPrebivalistaId");

                    b.Property<int>("PolId");

                    b.Property<int>("PostanskiBrojId");

                    b.Property<int>("PrethodnaSkolaId");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(50);

                    b.Property<int>("SmerId");

                    b.Property<int>("TelefonId");

                    b.Property<int>("UpisanaSkolaId");

                    b.Property<DateTime>("VremeUpisa");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaRodjenjaId");

                    b.HasIndex("MestoPrebivalistaId");

                    b.HasIndex("MestoRodjenjaId");

                    b.HasIndex("MestoZavrseneSkoleId");

                    b.HasIndex("OpstinaId");

                    b.HasIndex("OpstinaPrebivalistaId");

                    b.HasIndex("PolId");

                    b.HasIndex("PostanskiBrojId");

                    b.HasIndex("PrethodnaSkolaId");

                    b.HasIndex("SmerId");

                    b.HasIndex("TelefonId");

                    b.HasIndex("UpisanaSkolaId");

                    b.ToTable("Ucenici");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.UpisanaSkola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivSrednjeSkole")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<int>("OpstinaId");

                    b.HasKey("Id");

                    b.HasIndex("OpstinaId");

                    b.ToTable("SrednjeSkole");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.PostanskiBroj", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Opstina")
                        .WithMany("PostanskiBrojevi")
                        .HasForeignKey("OpstinaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.PrethodnaSkola", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Opstina", "Opstina")
                        .WithMany()
                        .HasForeignKey("OpstinaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Ucenik", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Drzava", "DrzavaRodjenja")
                        .WithMany()
                        .HasForeignKey("DrzavaRodjenjaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Mesto", "MestoPrebivalista")
                        .WithMany()
                        .HasForeignKey("MestoPrebivalistaId");

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Mesto", "MestoRodjenja")
                        .WithMany()
                        .HasForeignKey("MestoRodjenjaId");

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Mesto", "MestoZavrseneSkole")
                        .WithMany()
                        .HasForeignKey("MestoZavrseneSkoleId");

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Opstina", "Opstina")
                        .WithMany()
                        .HasForeignKey("OpstinaId");

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Opstina", "OpstinaPrebivalista")
                        .WithMany()
                        .HasForeignKey("OpstinaPrebivalistaId");

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Pol", "Pol")
                        .WithMany()
                        .HasForeignKey("PolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.PostanskiBroj", "PostanskiBroj")
                        .WithMany()
                        .HasForeignKey("PostanskiBrojId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.PrethodnaSkola", "PrethodnaSkola")
                        .WithMany()
                        .HasForeignKey("PrethodnaSkolaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Smer", "Smer")
                        .WithMany()
                        .HasForeignKey("SmerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Telefon", "Telefon")
                        .WithMany()
                        .HasForeignKey("TelefonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.UpisanaSkola", "UpisanaSkola")
                        .WithMany()
                        .HasForeignKey("UpisanaSkolaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.UpisanaSkola", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Opstina", "Opstina")
                        .WithMany()
                        .HasForeignKey("OpstinaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
