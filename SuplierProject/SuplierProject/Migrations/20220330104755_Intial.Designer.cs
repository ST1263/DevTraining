﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuplierProject.Data;

namespace SuplierProject.Migrations
{
    [DbContext(typeof(SuplierDbContext))]
    [Migration("20220330104755_Intial")]
    partial class Intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuplierProject.Model.BillingAddress", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuplierId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("SuplierId")
                        .IsUnique();

                    b.ToTable("BillingAddress");
                });

            modelBuilder.Entity("SuplierProject.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuplierId")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("SuplierId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SuplierProject.Model.Suplier", b =>
                {
                    b.Property<int>("SuplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuplierId");

                    b.ToTable("Suplier");
                });

            modelBuilder.Entity("SuplierProject.Model.BillingAddress", b =>
                {
                    b.HasOne("SuplierProject.Model.Suplier", "Suplier")
                        .WithOne("BillingAddress")
                        .HasForeignKey("SuplierProject.Model.BillingAddress", "SuplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suplier");
                });

            modelBuilder.Entity("SuplierProject.Model.Product", b =>
                {
                    b.HasOne("SuplierProject.Model.Suplier", "Suplier")
                        .WithMany("Products")
                        .HasForeignKey("SuplierId");

                    b.Navigation("Suplier");
                });

            modelBuilder.Entity("SuplierProject.Model.Suplier", b =>
                {
                    b.Navigation("BillingAddress");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
