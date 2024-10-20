﻿// <auto-generated />
using System;
using AnimalsShelterBackend.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AnimalsShelterBackend.Migrations
{
    [DbContext(typeof(ShelterAppContext))]
    partial class ShelterAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AnimalsShelterBackend.Domain.Animals.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("BehaviourFeatures")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HealthDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImagesNames")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MainImageName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OwnerWishes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RequiredConditions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Sex")
                        .HasColumnType("integer");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.Property<string>("SterilizationsInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Temper")
                        .HasColumnType("integer");

                    b.Property<string>("VaccinationsInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Wool")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
