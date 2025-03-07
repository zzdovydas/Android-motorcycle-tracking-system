﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MotoDataLoggerAPI;

#nullable disable

namespace MotoDataLoggerAPI.Migrations
{
    [DbContext(typeof(MotoDataContext))]
    [Migration("20250307195542_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MotoDataLoggerAPI.Models.AngleData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Azimuth")
                        .HasColumnType("double");

                    b.Property<double?>("Pitch")
                        .HasColumnType("double");

                    b.Property<double?>("Roll")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("AngleData");
                });

            modelBuilder.Entity("MotoDataLoggerAPI.Models.LocationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Accuracy")
                        .HasColumnType("double");

                    b.Property<double?>("Altitude")
                        .HasColumnType("double");

                    b.Property<double?>("Angle")
                        .HasColumnType("double");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double?>("Speed")
                        .HasColumnType("double");

                    b.Property<double?>("Time")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("LocationData");
                });

            modelBuilder.Entity("MotoDataLoggerAPI.Models.MotoData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AngleDataId")
                        .HasColumnType("int");

                    b.Property<string>("BatteryChargingTimeLeft")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasAnnotation("Relational:JsonPropertyName", "Battery_Charging_Time_Left");

                    b.Property<int?>("BatteryLevel")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "Battery_Level");

                    b.Property<double?>("LightSensitivity")
                        .HasColumnType("double")
                        .HasAnnotation("Relational:JsonPropertyName", "Light_Sensitivity");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<double?>("MagneticField")
                        .HasColumnType("double")
                        .HasAnnotation("Relational:JsonPropertyName", "Magnetic_Field");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AngleDataId");

                    b.HasIndex("LocationId");

                    b.ToTable("MotoDatas");
                });

            modelBuilder.Entity("MotoDataLoggerAPI.Models.Motorcycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("EngineDisplacement")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Vin")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Motorcycles");
                });

            modelBuilder.Entity("MotoDataLoggerAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MotoDataLoggerAPI.Models.MotoData", b =>
                {
                    b.HasOne("MotoDataLoggerAPI.Models.AngleData", "AngleData")
                        .WithMany()
                        .HasForeignKey("AngleDataId");

                    b.HasOne("MotoDataLoggerAPI.Models.LocationData", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("AngleData");

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
