﻿// <auto-generated />
using System;
using HealthTracker.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthTracker.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20241222141417_DatabaseInit")]
    partial class DatabaseInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HealthTracker.Entities.Models.Device.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeviceId"));

                    b.Property<Guid>("DeviceGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeviceId");

                    b.HasIndex("DeviceGuid")
                        .IsUnique();

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("HealthTracker.Entities.Models.Device.DeviceData", b =>
                {
                    b.Property<int>("DeviceDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeviceDataId"));

                    b.Property<float>("Bpm")
                        .HasColumnType("real");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<float>("Humidity")
                        .HasColumnType("real");

                    b.Property<float>("Spo2")
                        .HasColumnType("real");

                    b.Property<float>("Temp")
                        .HasColumnType("real");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("DeviceDataId");

                    b.HasIndex("DeviceId");

                    b.ToTable("DeviceDatas");
                });

            modelBuilder.Entity("HealthTracker.Entities.Models.PushNotification.PushNotificationKey", b =>
                {
                    b.Property<int>("PushNotificationKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PushNotificationKeyId"));

                    b.Property<string>("AuthKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endpoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P256DH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PushNotificationKeyId");

                    b.ToTable("PushNotificationKeys");
                });

            modelBuilder.Entity("HealthTracker.Entities.Models.Device.DeviceData", b =>
                {
                    b.HasOne("HealthTracker.Entities.Models.Device.Device", "Device")
                        .WithMany("DeviceData")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("HealthTracker.Entities.Models.Device.Device", b =>
                {
                    b.Navigation("DeviceData");
                });
#pragma warning restore 612, 618
        }
    }
}
