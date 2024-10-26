﻿// <auto-generated />
using System;
using AnimalsShelterBackend.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AnimalsShelterBackend.Migrations
{
    [DbContext(typeof(ShelterAppContext))]
    [Migration("20241022102921_health-condition field update")]
    partial class healthconditionfieldupdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Color")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HealthConditions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImagesNames")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LivingCondition")
                        .HasColumnType("integer");

                    b.Property<string>("MainImageName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReceiptDate")
                        .HasColumnType("integer");

                    b.Property<int>("Sex")
                        .HasColumnType("integer");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.Property<string>("TemperFeatures")
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
