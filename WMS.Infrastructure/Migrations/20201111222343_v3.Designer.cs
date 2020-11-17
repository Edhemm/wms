﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMS.Infrastructure;

namespace WMS.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20201111222343_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WMS.Domain.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GlobalTradeItemNumber")
                        .HasColumnType("int");

                    b.Property<double>("MinimalQuantity")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WMS.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<Guid?>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WMS.Domain.Entities.OrderDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WMS.Domain.Entities.StorageBin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WarehouseLocationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseLocationId");

                    b.ToTable("StorageBins");
                });

            modelBuilder.Entity("WMS.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WMS.Domain.Entities.Warehouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GlobalLocationNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("WMS.Domain.Entities.WarehouseLocation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehouseLocations");
                });

            modelBuilder.Entity("WMS.Domain.Entities.Order", b =>
                {
                    b.HasOne("WMS.Domain.Entities.Warehouse", null)
                        .WithMany("Orders")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("WMS.Domain.Entities.OrderDetails", b =>
                {
                    b.HasOne("WMS.Domain.Entities.Item", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("ItemId");

                    b.HasOne("WMS.Domain.Entities.Order", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("WMS.Domain.Entities.StorageBin", b =>
                {
                    b.HasOne("WMS.Domain.Entities.WarehouseLocation", null)
                        .WithMany("StorageBins")
                        .HasForeignKey("WarehouseLocationId");
                });

            modelBuilder.Entity("WMS.Domain.Entities.User", b =>
                {
                    b.HasOne("WMS.Domain.Entities.Warehouse", null)
                        .WithMany("Users")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("WMS.Domain.Entities.WarehouseLocation", b =>
                {
                    b.HasOne("WMS.Domain.Entities.Warehouse", null)
                        .WithMany("WarehouseLocations")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("WMS.Domain.Entities.Item", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("WMS.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("WMS.Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Users");

                    b.Navigation("WarehouseLocations");
                });

            modelBuilder.Entity("WMS.Domain.Entities.WarehouseLocation", b =>
                {
                    b.Navigation("StorageBins");
                });
#pragma warning restore 612, 618
        }
    }
}
