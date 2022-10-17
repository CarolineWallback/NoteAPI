﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteAPI.Data;

#nullable disable

namespace NoteAPI.Migrations
{
    [DbContext(typeof(NoteDbContext))]
    [Migration("20221017161811_set up database at home")]
    partial class setupdatabaseathome
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NoteAPI.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Ät upp din choklad",
                            Tag = "Viktigt",
                            Title = "Viktigt"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Kalas på lekland lördag vecka 32",
                            Tag = "Barnen",
                            Title = "Kalas"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Sök semester från jobb vecka 28-32, boka resa!",
                            Tag = "Jobb, Semester",
                            Title = "Semester"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Hos farmor kl 12.30",
                            Tag = "Jul",
                            Title = "Julafton"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
