﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutraChance.Models;

#nullable disable

namespace OutraChance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231124194923_m06-tamanhos-especificos")]
    partial class m06tamanhosespecificos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OutraChance.Models.Anuncio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Usuario");

                    b.ToTable("Anuncios");
                });

            modelBuilder.Entity("OutraChance.Models.Caracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Caracteristicas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Cor"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Tamanho"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Departamento"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Genero"
                        });
                });

            modelBuilder.Entity("OutraChance.Models.CaracteristicaAnuncio", b =>
                {
                    b.Property<int>("AnuncioId")
                        .HasColumnType("int");

                    b.Property<int>("CaracteristicaId")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnuncioId", "CaracteristicaId");

                    b.HasIndex("CaracteristicaId");

                    b.ToTable("CaracteristicaAnuncios");
                });

            modelBuilder.Entity("OutraChance.Models.CaracteristicaValores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CaracteristicaId")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaracteristicaId");

                    b.ToTable("CaracteristicaValores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CaracteristicaId = 1,
                            Valor = "Azul"
                        },
                        new
                        {
                            Id = 2,
                            CaracteristicaId = 1,
                            Valor = "Amarelo"
                        },
                        new
                        {
                            Id = 3,
                            CaracteristicaId = 1,
                            Valor = "Vermelho"
                        },
                        new
                        {
                            Id = 4,
                            CaracteristicaId = 1,
                            Valor = "Verde"
                        },
                        new
                        {
                            Id = 5,
                            CaracteristicaId = 1,
                            Valor = "Laranja"
                        },
                        new
                        {
                            Id = 6,
                            CaracteristicaId = 1,
                            Valor = "Lilás"
                        },
                        new
                        {
                            Id = 8,
                            CaracteristicaId = 1,
                            Valor = "Branco"
                        },
                        new
                        {
                            Id = 9,
                            CaracteristicaId = 1,
                            Valor = "Preto"
                        },
                        new
                        {
                            Id = 10,
                            CaracteristicaId = 2,
                            Valor = "PP"
                        },
                        new
                        {
                            Id = 11,
                            CaracteristicaId = 2,
                            Valor = "P"
                        },
                        new
                        {
                            Id = 12,
                            CaracteristicaId = 2,
                            Valor = "M"
                        },
                        new
                        {
                            Id = 13,
                            CaracteristicaId = 2,
                            Valor = "G"
                        },
                        new
                        {
                            Id = 14,
                            CaracteristicaId = 2,
                            Valor = "GG"
                        },
                        new
                        {
                            Id = 15,
                            CaracteristicaId = 3,
                            Valor = "Calças"
                        },
                        new
                        {
                            Id = 16,
                            CaracteristicaId = 3,
                            Valor = "Blusas"
                        },
                        new
                        {
                            Id = 17,
                            CaracteristicaId = 3,
                            Valor = "Calçados"
                        },
                        new
                        {
                            Id = 18,
                            CaracteristicaId = 3,
                            Valor = "Shorts"
                        },
                        new
                        {
                            Id = 19,
                            CaracteristicaId = 4,
                            Valor = "Masculino"
                        },
                        new
                        {
                            Id = 20,
                            CaracteristicaId = 4,
                            Valor = "Feminino"
                        });
                });

            modelBuilder.Entity("OutraChance.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("OutraChance.Models.Anuncio", b =>
                {
                    b.HasOne("OutraChance.Models.Usuario", "Usuario")
                        .WithMany("Anuncios")
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("OutraChance.Models.CaracteristicaAnuncio", b =>
                {
                    b.HasOne("OutraChance.Models.Anuncio", "Anuncio")
                        .WithMany("CaracteristicasAnuncios")
                        .HasForeignKey("AnuncioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutraChance.Models.Caracteristica", "Caracteristica")
                        .WithMany("CaracteristicasAnuncios")
                        .HasForeignKey("CaracteristicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anuncio");

                    b.Navigation("Caracteristica");
                });

            modelBuilder.Entity("OutraChance.Models.CaracteristicaValores", b =>
                {
                    b.HasOne("OutraChance.Models.Caracteristica", "Caracteristica")
                        .WithMany("caracteristicaValores")
                        .HasForeignKey("CaracteristicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caracteristica");
                });

            modelBuilder.Entity("OutraChance.Models.Anuncio", b =>
                {
                    b.Navigation("CaracteristicasAnuncios");
                });

            modelBuilder.Entity("OutraChance.Models.Caracteristica", b =>
                {
                    b.Navigation("CaracteristicasAnuncios");

                    b.Navigation("caracteristicaValores");
                });

            modelBuilder.Entity("OutraChance.Models.Usuario", b =>
                {
                    b.Navigation("Anuncios");
                });
#pragma warning restore 612, 618
        }
    }
}
