﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIEmpresarial.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230901025039_MigrationInicial")]
    partial class MigrationInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIEmpresarial.Model.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("APIEmpresarial.Model.Estoque", b =>
                {
                    b.Property<int>("EstoqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float?>("Quantidade")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("float");

                    b.Property<double?>("TotalEstoque")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("double");

                    b.HasKey("EstoqueId");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("APIEmpresarial.Model.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EstoqueId")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("LivroId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("EstoqueId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("APIEmpresarial.Model.Livro", b =>
                {
                    b.HasOne("APIEmpresarial.Model.Categoria", "Categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIEmpresarial.Model.Estoque", "_Estoque")
                        .WithMany("_Livros")
                        .HasForeignKey("EstoqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("_Estoque");
                });

            modelBuilder.Entity("APIEmpresarial.Model.Categoria", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("APIEmpresarial.Model.Estoque", b =>
                {
                    b.Navigation("_Livros");
                });
#pragma warning restore 612, 618
        }
    }
}