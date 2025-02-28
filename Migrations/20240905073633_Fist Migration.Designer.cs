﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using carserver.models;

#nullable disable

namespace carserver.Migrations
{
    [DbContext(typeof(PaimentDetailsContext))]
    [Migration("20240905073633_Fist Migration")]
    partial class FistMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("carserver.models.PaimentDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Association_Cost")
                        .HasColumnType("float");

                    b.Property<double>("Base_Coast")
                        .HasColumnType("float");

                    b.Property<double>("Base_price")
                        .HasColumnType("float");

                    b.Property<string>("Buy_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Custom_cost")
                        .HasColumnType("float");

                    b.Property<double>("Fixed_cost")
                        .HasColumnType("float");

                    b.Property<double>("Special_Coast")
                        .HasColumnType("float");

                    b.Property<double>("Total_price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("PaimentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
