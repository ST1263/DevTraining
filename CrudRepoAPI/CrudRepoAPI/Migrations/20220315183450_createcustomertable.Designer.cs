﻿// <auto-generated />
using CrudRepoAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudRepoAPI.Migrations
{
    [DbContext(typeof(databaseContext))]
    [Migration("20220315183450_createcustomertable")]
    partial class createcustomertable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudRepoAPI.Model.Customer", b =>
                {
                    b.Property<int>("CustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustLName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustId");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
