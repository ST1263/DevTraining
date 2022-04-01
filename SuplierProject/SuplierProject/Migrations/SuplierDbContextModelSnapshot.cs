﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuplierProject.Data;

namespace SuplierProject.Migrations
{
    [DbContext(typeof(SuplierDbContext))]
    partial class SuplierDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("addressOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("suplierid")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("suplierid")
                        .IsUnique();

                    b.ToTable("BillingAddress");
                });

            modelBuilder.Entity("SuplierProject.Model.Product", b =>
                {
                    b.Property<int>("productid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("productname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("produtunit")
                        .HasColumnType("float");

                    b.Property<int?>("suplierid")
                        .HasColumnType("int");

                    b.HasKey("productid");

                    b.HasIndex("suplierid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SuplierProject.Model.Suplier", b =>
                {
                    b.Property<int>("suplierid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("supliername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("suplierid");

                    b.ToTable("Suplier");
                });

            modelBuilder.Entity("SuplierProject.Model.BillingAddress", b =>
                {
                    b.HasOne("SuplierProject.Model.Suplier", "Suplier")
                        .WithOne("BillingAddress")
                        .HasForeignKey("SuplierProject.Model.BillingAddress", "suplierid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suplier");
                });

            modelBuilder.Entity("SuplierProject.Model.Product", b =>
                {
                    b.HasOne("SuplierProject.Model.Suplier", "Suplier")
                        .WithMany("Products")
                        .HasForeignKey("suplierid");

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
