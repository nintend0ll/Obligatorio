﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Papeleria.AccesoDatos.EF.Repositorios;

#nullable disable

namespace Papeleria.AccesoDatos.Migrations
{
    [DbContext(typeof(PapeleriaContext))]
    [Migration("20240415162629_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrecioVenta")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rut")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.ToTable("Pedidos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pedido");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.PedidoComun", b =>
                {
                    b.HasBaseType("Papeleria.LogicaNegocio.Entidades.Pedido");

                    b.HasDiscriminator().HasValue("PedidoComun");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.PedidoExpress", b =>
                {
                    b.HasBaseType("Papeleria.LogicaNegocio.Entidades.Pedido");

                    b.HasDiscriminator().HasValue("PedidoExpress");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.Cliente", b =>
                {
                    b.OwnsOne("Papeleria.LogicaNegocio.ValueObjects.Direccion", "Direccion", b1 =>
                        {
                            b1.Property<int>("ClienteId")
                                .HasColumnType("int");

                            b1.Property<string>("Calle")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Ciudad")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Distancia")
                                .HasColumnType("int");

                            b1.Property<int>("Numero")
                                .HasColumnType("int");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.Navigation("Direccion")
                        .IsRequired();
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.Pedido", b =>
                {
                    b.HasOne("Papeleria.LogicaNegocio.Entidades.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Papeleria.LogicaNegocio.Entidades.Usuario", b =>
                {
                    b.OwnsOne("Papeleria.LogicaNegocio.ValueObjects.NombreCompleto", "NombreCompleto", b1 =>
                        {
                            b1.Property<int>("UsuarioId")
                                .HasColumnType("int");

                            b1.Property<string>("Apellido")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Nombre")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("Usuarios");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.Navigation("NombreCompleto")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}