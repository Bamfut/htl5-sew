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
    [Migration("20240917093824_added list")]
    partial class addedlist
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("_02_Messstation.Models.Messstation", b =>
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

            modelBuilder.Entity("_02_Messstation.Models.Messwert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Einheit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MessstationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wert")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MessstationId");

                    b.ToTable("Messwert");
                });

            modelBuilder.Entity("_02_Messstation.Models.Messwert", b =>
                {
                    b.HasOne("_02_Messstation.Models.Messstation", "Messstation")
                        .WithMany("Messwerte")
                        .HasForeignKey("MessstationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Messstation");
                });

            modelBuilder.Entity("_02_Messstation.Models.Messstation", b =>
                {
                    b.Navigation("Messwerte");
                });
#pragma warning restore 612, 618
        }
    }
}
