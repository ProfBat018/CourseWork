﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceDataLayer.Models;

#nullable disable

namespace ServiceDataLayer.Migrations
{
    [DbContext(typeof(ServiceDBContext))]
    partial class ServiceDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServiceDataLayer.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("RoleId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.CarStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarStatuses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("74321073-8a2e-4e58-b7fb-2a60908c2e09"),
                            StatusName = "Pending"
                        },
                        new
                        {
                            Id = new Guid("eb3b2f7b-1669-4188-80ca-0f1b8286f257"),
                            StatusName = "InProgress"
                        },
                        new
                        {
                            Id = new Guid("c1618794-64bf-4422-827a-f571daba4f08"),
                            StatusName = "Completed"
                        });
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "SuperAdmin"
                        });
                });

            modelBuilder.Entity("ServiceDataLayer.Models.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ServicePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ServiceName = "Oil Change",
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = 2,
                            ServiceName = "Tire Rotation",
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = 3,
                            ServiceName = "Brake Inspection",
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = 4,
                            ServiceName = "Engine Diagnostic",
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = 5,
                            ServiceName = "Battery Replacement",
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = 6,
                            ServiceName = "Transmission Repair",
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = 7,
                            ServiceName = "Wheel Alignment",
                            ServicePrice = 0m
                        },
                        new
                        {
                            Id = 8,
                            ServiceName = "Air Conditioning Service",
                            ServicePrice = 0m
                        });
                });

            modelBuilder.Entity("ServiceDataLayer.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoleId1")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId1");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Car", b =>
                {
                    b.HasOne("ServiceDataLayer.Models.Car", null)
                        .WithMany("Cars")
                        .HasForeignKey("CarId");

                    b.HasOne("ServiceDataLayer.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceDataLayer.Models.CarStatus", "Status")
                        .WithMany("Cars")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServiceDataLayer.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.User", b =>
                {
                    b.HasOne("ServiceDataLayer.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Car", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.CarStatus", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ServiceDataLayer.Models.User", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
