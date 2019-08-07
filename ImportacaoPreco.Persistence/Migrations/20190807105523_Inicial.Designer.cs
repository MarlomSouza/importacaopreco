﻿// <auto-generated />
using System;
using ImportacaoPreco.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImportacaoPreco.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190807105523_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Produto", b =>
                {
                    b.OwnsMany("ImportacaoPreco.Dominio.VO.PrecoPromocional", "PrecosPromocionais", b1 =>
                        {
                            b1.Property<decimal>("Valor");

                            b1.Property<DateTime>("DataInicioPromocao");

                            b1.Property<DateTime>("DataFimPromocao");

                            b1.Property<int>("ProdutoId");

                            b1.HasKey("Valor", "DataInicioPromocao", "DataFimPromocao");

                            b1.HasIndex("ProdutoId");

                            b1.ToTable("PrecoPromocional");

                            b1.HasOne("ImportacaoPreco.Dominio.Entities.Produto")
                                .WithMany("PrecosPromocionais")
                                .HasForeignKey("ProdutoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsMany("ImportacaoPreco.Dominio.ValueObjects.Cor", "Cores", b1 =>
                        {
                            b1.Property<int>("ProdutoId");

                            b1.Property<string>("Nome");

                            b1.HasKey("ProdutoId", "Nome");

                            b1.ToTable("Cor");

                            b1.HasOne("ImportacaoPreco.Dominio.Entities.Produto")
                                .WithMany("Cores")
                                .HasForeignKey("ProdutoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("ImportacaoPreco.Dominio.ValueObjects.Subgrupo", "Subgrupo", b1 =>
                        {
                            b1.Property<int>("ProdutoId");

                            b1.Property<string>("Nome");

                            b1.Property<int?>("GrupoId");

                            b1.HasKey("ProdutoId", "Nome");

                            b1.HasIndex("GrupoId");

                            b1.HasIndex("ProdutoId")
                                .IsUnique();

                            b1.ToTable("Subgrupos");

                            b1.HasOne("ImportacaoPreco.Dominio.Entities.Grupo", "Grupo")
                                .WithMany()
                                .HasForeignKey("GrupoId");

                            b1.HasOne("ImportacaoPreco.Dominio.Entities.Produto")
                                .WithOne("Subgrupo")
                                .HasForeignKey("ImportacaoPreco.Dominio.ValueObjects.Subgrupo", "ProdutoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsMany("ImportacaoPreco.Dominio.ValueObjects.Tamanho", "Tamanhos", b1 =>
                        {
                            b1.Property<int>("ProdutoId");

                            b1.Property<string>("Nome");

                            b1.HasKey("ProdutoId", "Nome");

                            b1.ToTable("Tamanho");

                            b1.HasOne("ImportacaoPreco.Dominio.Entities.Produto")
                                .WithMany("Tamanhos")
                                .HasForeignKey("ProdutoId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
