﻿// <auto-generated />
using LittlePaktBookstore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LittlePaktBookstore.Migrations
{
    [DbContext(typeof(LittlePacktBookStoreDbContex))]
    [Migration("20190830174557_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LittlePaktBookstore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<double>("Price");

                    b.Property<string>("PublishDate");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("image");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LittlePaktBookstore.Models.Carousel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<string>("imageURL");

                    b.HasKey("Id");

                    b.ToTable("Carousels");
                });

            modelBuilder.Entity("LittlePaktBookstore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ClientName")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State");

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
