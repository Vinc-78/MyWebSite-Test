﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebSite.Data;

#nullable disable

namespace MyWebSite.Migrations
{
    [DbContext(typeof(MyWebSiteContext))]
    [Migration("20220819095107_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyWebSite.Models.Azienda", b =>
                {
                    b.Property<int>("AziendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AziendaId"), 1L, 1);

                    b.Property<string>("Città")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indirizzo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAzienda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Settore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AziendaId");

                    b.ToTable("Azienda");
                });
#pragma warning restore 612, 618
        }
    }
}
