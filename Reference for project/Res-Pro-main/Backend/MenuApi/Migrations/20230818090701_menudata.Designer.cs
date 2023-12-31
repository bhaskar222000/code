﻿// <auto-generated />
using Menu_MS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Menu_MS.Migrations
{
    [DbContext(typeof(ProductDBContextClass))]
    [Migration("20230818090701_menudata")]
    partial class menudata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Menu_MS.Models.FoodList01", b =>
                {
                    b.Property<int>("Product_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_ID"));

                    b.Property<int>("Empty1")
                        .HasColumnType("int");

                    b.Property<string>("Product_Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Product_Price")
                        .HasColumnType("real");

                    b.Property<int>("Product_Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Product_Rating")
                        .HasColumnType("real");

                    b.HasKey("Product_ID");

                    b.ToTable("foodLists");
                });
#pragma warning restore 612, 618
        }
    }
}
