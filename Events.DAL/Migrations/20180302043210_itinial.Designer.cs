﻿// <auto-generated />
using Events.DAL.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Events.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180302043210_itinial")]
    partial class itinial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Events.DAL.Model.AgeRange", b =>
                {
                    b.Property<int>("IdAgeRange")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("IdAgeRange");

                    b.ToTable("AgeRanges");
                });

            modelBuilder.Entity("Events.DAL.Model.Event", b =>
                {
                    b.Property<Guid>("IdEvent")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("EnvironmentsAmmount");

                    b.Property<int>("IdAgeRange");

                    b.Property<bool>("IsOpenBar");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Venue")
                        .IsRequired();

                    b.HasKey("IdEvent");

                    b.HasIndex("IdAgeRange");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Events.DAL.Model.Event", b =>
                {
                    b.HasOne("Events.DAL.Model.AgeRange", "AgeRange")
                        .WithMany()
                        .HasForeignKey("IdAgeRange")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
