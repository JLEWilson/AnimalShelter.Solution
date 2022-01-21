﻿// <auto-generated />
using System;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20220121175831_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 2,
                            Age = 6,
                            ArrivalDate = new DateTime(2017, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Luna",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 1,
                            Age = 3,
                            ArrivalDate = new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Milo",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 3,
                            ArrivalDate = new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Nala",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 2,
                            ArrivalDate = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Leo",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 5,
                            ArrivalDate = new DateTime(2018, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Charlie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 2,
                            ArrivalDate = new DateTime(2020, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Daisy",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 1,
                            ArrivalDate = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Bailey",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 2,
                            ArrivalDate = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Name = "Lola",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 3,
                            ArrivalDate = new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Max",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 2,
                            ArrivalDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Name = "Dule",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}