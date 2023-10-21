﻿// <auto-generated />
using B2C2_2023_Inleveropdracht_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace B2C2_2023_Inleveropdracht_MVC.Migrations
{
    [DbContext(typeof(WebsiteDBContext))]
    [Migration("20231021184922_KlassenNaarDatabase")]
    partial class KlassenNaarDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("B2C2_2023_Inleveropdracht_MVC.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naam = "Admin",
                            Wachtwoord = "Wachtwoord"
                        });
                });

            modelBuilder.Entity("B2C2_2023_Inleveropdracht_MVC.Models.Bestelling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KlantId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Punten")
                        .HasColumnType("int");

                    b.Property<int>("TotaalPrijs")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bestellings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KlantId = 0,
                            ProductId = 1,
                            Punten = 1,
                            TotaalPrijs = 5
                        });
                });

            modelBuilder.Entity("B2C2_2023_Inleveropdracht_MVC.Models.Klant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Klants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naam = "Klant1",
                            Wachtwoord = "Wachtwoord"
                        });
                });

            modelBuilder.Entity("B2C2_2023_Inleveropdracht_MVC.Models.Klantenkaart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Korting")
                        .HasColumnType("int");

                    b.Property<int>("Punten")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Klantenkaarts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Korting = 5,
                            Punten = 40
                        });
                });

            modelBuilder.Entity("B2C2_2023_Inleveropdracht_MVC.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("B2C2_2023_Inleveropdracht_MVC.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Prijs")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Beschrijving = "Product beschrijving 123",
                            Prijs = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}