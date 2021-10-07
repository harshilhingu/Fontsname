﻿// <auto-generated />
using System;
using Fontsname.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fontsname.Migrations
{
    [DbContext(typeof(FontsnameDifffontsContext))]
    [Migration("20211007075056_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Fontsname.Models.Difffonts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("cornerrounding")
                        .HasColumnType("TEXT");

                    b.Property<string>("weight")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Difffonts");
                });
#pragma warning restore 612, 618
        }
    }
}
