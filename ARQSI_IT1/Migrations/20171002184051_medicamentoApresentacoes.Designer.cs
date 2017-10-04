﻿// <auto-generated />
using ARQSI_IT1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ARQSI_IT1.Migrations
{
    [DbContext(typeof(ARQSI_IT1Context))]
    [Migration("20171002184051_medicamentoApresentacoes")]
    partial class medicamentoApresentacoes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ARQSI_IT1.Models.Apresentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Forma");

                    b.HasKey("Id");

                    b.ToTable("Apresentacao");
                });

            modelBuilder.Entity("ARQSI_IT1.Models.Farmaco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApresentacaoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("ApresentacaoId");

                    b.ToTable("Farmaco");
                });

            modelBuilder.Entity("ARQSI_IT1.Models.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Concentracao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Medicamento");
                });

            modelBuilder.Entity("ARQSI_IT1.Models.Posologia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Quantidade");

                    b.HasKey("Id");

                    b.ToTable("Posologia");
                });

            modelBuilder.Entity("ARQSI_IT1.Models.Farmaco", b =>
                {
                    b.HasOne("ARQSI_IT1.Models.Apresentacao", "Apresentacao")
                        .WithMany()
                        .HasForeignKey("ApresentacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
