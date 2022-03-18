﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace web5.Migrations
{
    [DbContext(typeof(SudContext))]
    [Migration("20220310163511_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Advokat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresaKancelarije")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("BrojKomore")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Zvanje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Advokat");
                });

            modelBuilder.Entity("Models.Slucaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JavniTuzitelj")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("KlasaVaznosti")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Organizacija")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PrvaSednica")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Slucaj");
                });

            modelBuilder.Entity("Models.Spoj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdvokatId")
                        .HasColumnType("int");

                    b.Property<string>("Klijent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SlucajId")
                        .HasColumnType("int");

                    b.Property<int?>("Sudijaid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvokatId");

                    b.HasIndex("SlucajId");

                    b.HasIndex("Sudijaid");

                    b.ToTable("Spoj");
                });

            modelBuilder.Entity("Models.Sudija", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Iskustvo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Sudija");
                });

            modelBuilder.Entity("Models.Spoj", b =>
                {
                    b.HasOne("Models.Advokat", "Advokat")
                        .WithMany("AdvokatSlucaj")
                        .HasForeignKey("AdvokatId");

                    b.HasOne("Models.Slucaj", "Slucaj")
                        .WithMany("SlucajAdvokat")
                        .HasForeignKey("SlucajId");

                    b.HasOne("Models.Sudija", "Sudija")
                        .WithMany("SudijaSlucaj")
                        .HasForeignKey("Sudijaid");

                    b.Navigation("Advokat");

                    b.Navigation("Slucaj");

                    b.Navigation("Sudija");
                });

            modelBuilder.Entity("Models.Advokat", b =>
                {
                    b.Navigation("AdvokatSlucaj");
                });

            modelBuilder.Entity("Models.Slucaj", b =>
                {
                    b.Navigation("SlucajAdvokat");
                });

            modelBuilder.Entity("Models.Sudija", b =>
                {
                    b.Navigation("SudijaSlucaj");
                });
#pragma warning restore 612, 618
        }
    }
}
