﻿// <auto-generated />
using AspNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNet.Migrations
{
    [DbContext(typeof(BusContext))]
    partial class BusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AspNet.Models.BusTable", b =>
                {
                    b.Property<int>("BusIdx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BusCnt")
                        .HasColumnType("int");

                    b.Property<int>("BusGap")
                        .HasColumnType("int");

                    b.Property<int>("BusNowIn")
                        .HasColumnType("int");

                    b.Property<string>("BusNum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BusIdx");

                    b.ToTable("BusTable");
                });
#pragma warning restore 612, 618
        }
    }
}