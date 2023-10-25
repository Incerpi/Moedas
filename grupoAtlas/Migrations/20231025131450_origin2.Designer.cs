﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using grupoAtlas.Persistence;

#nullable disable

namespace grupoAtlas.Migrations
{
    [DbContext(typeof(ContextoOracle))]
    [Migration("20231025131450_origin2")]
    partial class origin2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("grupoAtlas.Model.Moeda", b =>
                {
                    b.Property<int>("IdMoeda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMoeda"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<double>("PctVariacao")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<float>("Valor")
                        .HasColumnType("BINARY_FLOAT");

                    b.Property<float>("Variacao")
                        .HasColumnType("BINARY_FLOAT");

                    b.HasKey("IdMoeda");

                    b.ToTable("MOEDA");
                });
#pragma warning restore 612, 618
        }
    }
}