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
    [Migration("20180920093213_ProsirivanjeModelaSastanak")]
    partial class ProsirivanjeModelaSastanak
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

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Kazna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BodoviKazne");

                    b.Property<string>("Opis");

                    b.Property<int>("UcenikId");

                    b.HasKey("Id");

                    b.HasIndex("UcenikId");

                    b.ToTable("Kazne");
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

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Pohvala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BodoviPohvale");

                    b.Property<string>("Opis");

                    b.Property<int>("UcenikId");

                    b.HasKey("Id");

                    b.HasIndex("UcenikId");

                    b.ToTable("Pohvale");
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

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Razred", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojRazreda");

                    b.HasKey("Id");

                    b.ToTable("Razredi");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Roditelj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojTelefona");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("StepenObrazovanjaId");

                    b.Property<int>("UcenikId");

                    b.HasKey("Id");

                    b.HasIndex("StepenObrazovanjaId");

                    b.HasIndex("UcenikId");

                    b.ToTable("Roditelji");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Sastanak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojPrisutnihUcenika");

                    b.Property<DateTime>("DatumOdrzavanja");

                    b.Property<int>("UkupanBrojPrisutnihUcenika");

                    b.HasKey("Id");

                    b.ToTable("Sastanci");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Smer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivSmera");

                    b.HasKey("Id");

                    b.ToTable("Smerovi");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Staratelj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int>("UcenikId");

                    b.HasKey("Id");

                    b.HasIndex("UcenikId");

                    b.ToTable("Staratelji");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.StepenStrucneSpreme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.Property<string>("Stepen");

                    b.HasKey("Id");

                    b.ToTable("StepeniStrucneSpreme");
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

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.TipPorodice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NazivTipaPorodice");

                    b.HasKey("Id");

                    b.ToTable("TipoviPorodice");
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

                    b.Property<int>("MaterijalniPrihodi");

                    b.Property<int?>("MestoPrebivalistaId");

                    b.Property<int?>("MestoRodjenjaId");

                    b.Property<int?>("MestoZavrseneSkoleId");

                    b.Property<int?>("OpstinaId");

                    b.Property<int?>("OpstinaPrebivalistaId");

                    b.Property<int>("PolId");

                    b.Property<int>("PostanskiBrojId");

                    b.Property<int>("PrethodnaSkolaId");

                    b.Property<float>("PrethodniUspeh");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)")
                        .HasMaxLength(50);

                    b.Property<int>("RazredId");

                    b.Property<string>("Slika");

                    b.Property<int>("SmerId");

                    b.Property<int>("TelefonId");

                    b.Property<int>("TipPorodiceId");

                    b.Property<int>("UpisanaSkolaId");

                    b.Property<int>("VaspitnaGrupaId");

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

                    b.HasIndex("RazredId");

                    b.HasIndex("SmerId");

                    b.HasIndex("TelefonId");

                    b.HasIndex("TipPorodiceId");

                    b.HasIndex("UpisanaSkolaId");

                    b.HasIndex("VaspitnaGrupaId");

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

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Vaspitac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojTelefona");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("Slika");

                    b.HasKey("Id");

                    b.ToTable("Vaspitaci");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.VaspitnaGrupa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojUcenika");

                    b.Property<string>("Naziv");

                    b.Property<int>("VaspitacId");

                    b.HasKey("Id");

                    b.HasIndex("VaspitacId");

                    b.ToTable("VaspitneGrupe");
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Kazna", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Ucenik", "Ucenik")
                        .WithMany("Kazne")
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Pohvala", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Ucenik", "Ucenik")
                        .WithMany("Pohvale")
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                        .WithMany("OsnovneSkole")
                        .HasForeignKey("OpstinaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Roditelj", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.StepenStrucneSpreme", "StepenObrazovanja")
                        .WithMany()
                        .HasForeignKey("StepenObrazovanjaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Ucenik", "Ucenik")
                        .WithMany("Roditelji")
                        .HasForeignKey("UcenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.Staratelj", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Ucenik", "Ucenik")
                        .WithMany("Staratelji")
                        .HasForeignKey("UcenikId")
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

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Razred", "Razred")
                        .WithMany()
                        .HasForeignKey("RazredId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Smer", "Smer")
                        .WithMany()
                        .HasForeignKey("SmerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Telefon", "Telefon")
                        .WithMany()
                        .HasForeignKey("TelefonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.TipPorodice", "TipPorodice")
                        .WithMany()
                        .HasForeignKey("TipPorodiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.UpisanaSkola", "UpisanaSkola")
                        .WithMany()
                        .HasForeignKey("UpisanaSkolaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomUcenikaSvilajnac.Common.Models.VaspitnaGrupa", "VaspitnaGrupa")
                        .WithMany()
                        .HasForeignKey("VaspitnaGrupaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.UpisanaSkola", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Opstina", "Opstina")
                        .WithMany("SrednjeSkole")
                        .HasForeignKey("OpstinaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomUcenikaSvilajnac.Common.Models.VaspitnaGrupa", b =>
                {
                    b.HasOne("DomUcenikaSvilajnac.Common.Models.Vaspitac", "Vaspitac")
                        .WithMany()
                        .HasForeignKey("VaspitacId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
