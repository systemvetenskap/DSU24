﻿// <auto-generated />
using System;
using DSU24.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DSU24.Migrations
{
    [DbContext(typeof(SportDbContext))]
    partial class SportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DSU24.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("DSU24.Models.Sport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int?>("SeasonId")
                        .HasColumnType("integer");

                    b.Property<decimal>("SecretCost")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("DSU24.Models.Sport", b =>
                {
                    b.HasOne("DSU24.Models.Season", "Season")
                        .WithMany("Sports")
                        .HasForeignKey("SeasonId");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("DSU24.Models.Season", b =>
                {
                    b.Navigation("Sports");
                });
#pragma warning restore 612, 618
        }
    }
}
