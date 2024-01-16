﻿// <auto-generated />
using System;
using CoureTestProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoureTestProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240115203847_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoureTestProject.Models.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryIso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CoureTestProject.Models.CountryDetail", b =>
                {
                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OperatorCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Operator", "OperatorCode");

                    b.HasIndex("CountryId");

                    b.ToTable("CountryDetails");
                });

            modelBuilder.Entity("CoureTestProject.Models.CountryDetail", b =>
                {
                    b.HasOne("CoureTestProject.Models.Country", "Country")
                        .WithMany("CountryDetails")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CoureTestProject.Models.Country", b =>
                {
                    b.Navigation("CountryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
