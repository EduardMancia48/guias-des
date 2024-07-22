﻿// <auto-generated />
using System;
using MVCPeliculas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCPeliculas.Migrations
{
    [DbContext(typeof(PeliculasDBContext))]
    partial class PeliculasDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCPeliculas.Models.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("MVCPeliculas.Models.Peliculas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaLanzmiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GeneroId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("GeneroId");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("MVCPeliculas.Models.Peliculas", b =>
                {
                    b.HasOne("MVCPeliculas.Models.Genero", null)
                        .WithMany("Peliculas")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVCPeliculas.Models.Genero", b =>
                {
                    b.Navigation("Peliculas");
                });
#pragma warning restore 612, 618
        }
    }
}