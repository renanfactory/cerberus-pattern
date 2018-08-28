﻿// <auto-generated />
using DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DAO.Migrations
{
    [DbContext(typeof(ApplicationDaoDbContext))]
    [Migration("20180824182535_startup")]
    partial class startup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("DAO.Entities.Domains.TipoEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Situacao");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.ToTable("TblTiposEnderecos");
                });

            modelBuilder.Entity("DAO.Entities.Domains.TipoTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Situacao");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.ToTable("TblTiposTelefones");
                });

            modelBuilder.Entity("DAO.Entities.SIG.EmailFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<bool>("Principal");

                    b.Property<Guid?>("ProprietarioId");

                    b.Property<string>("Situacao");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("EmailFuncionario");
                });

            modelBuilder.Entity("DAO.Entities.SIG.EnderecoFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cep");

                    b.Property<int>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Numero");

                    b.Property<bool>("Principal");

                    b.Property<Guid?>("ProprietarioId");

                    b.Property<string>("Situacao");

                    b.Property<int?>("TipoEnderecoId");

                    b.Property<string>("UF");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.HasIndex("TipoEnderecoId");

                    b.ToTable("TblEnderecoFuncionario");
                });

            modelBuilder.Entity("DAO.Entities.SIG.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CNPJ");

                    b.Property<string>("CPF");

                    b.Property<string>("Cargo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("HorarioEntrada");

                    b.Property<string>("HorarioSaida");

                    b.Property<string>("Nome");

                    b.Property<string>("Situacao");

                    b.Property<string>("Sobrenome");

                    b.HasKey("Id");

                    b.ToTable("TblFuncionarios");
                });

            modelBuilder.Entity("DAO.Entities.SIG.TelefoneFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoPais");

                    b.Property<string>("CodigoRegiao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Numero");

                    b.Property<bool>("Principal");

                    b.Property<Guid?>("ProprietarioId");

                    b.Property<string>("Ramal");

                    b.Property<string>("Situacao");

                    b.Property<int?>("TipoTelefoneId");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.HasIndex("TipoTelefoneId");

                    b.ToTable("TblTelefoneFuncionarios");
                });

            modelBuilder.Entity("DAO.Entities.SIG.EmailFuncionario", b =>
                {
                    b.HasOne("DAO.Entities.SIG.Funcionario", "Proprietario")
                        .WithMany("Emails")
                        .HasForeignKey("ProprietarioId");
                });

            modelBuilder.Entity("DAO.Entities.SIG.EnderecoFuncionario", b =>
                {
                    b.HasOne("DAO.Entities.SIG.Funcionario", "Proprietario")
                        .WithMany("Enderecos")
                        .HasForeignKey("ProprietarioId");

                    b.HasOne("DAO.Entities.Domains.TipoEndereco", "TipoEndereco")
                        .WithMany()
                        .HasForeignKey("TipoEnderecoId");
                });

            modelBuilder.Entity("DAO.Entities.SIG.TelefoneFuncionario", b =>
                {
                    b.HasOne("DAO.Entities.SIG.Funcionario", "Proprietario")
                        .WithMany("Telefones")
                        .HasForeignKey("ProprietarioId");

                    b.HasOne("DAO.Entities.Domains.TipoTelefone", "TipoTelefone")
                        .WithMany()
                        .HasForeignKey("TipoTelefoneId");
                });
#pragma warning restore 612, 618
        }
    }
}
