﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_Messstation.Data;

#nullable disable

namespace _02_Messstation.Migrations
{
    [DbContext(typeof(MessstationContext))]
    [Migration("20240917091702_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("_02_Messstation.Models.Messstationen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Betriebsdauer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Messstation");
                });

            modelBuilder.Entity("_02_Messstation.Models.Messwerte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Einheit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MessstationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MessstationenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Messwert")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MessstationenId");

                    b.ToTable("Messwert");
                });

            modelBuilder.Entity("_02_Messstation.Models.Messwerte", b =>
                {
                    b.HasOne("_02_Messstation.Models.Messstationen", "Messstationen")
                        .WithMany()
                        .HasForeignKey("MessstationenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Messstationen");
                });
#pragma warning restore 612, 618
        }
    }
}
