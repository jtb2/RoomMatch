﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoomMatch.Models;

namespace RoomMatch.Migrations
{
    [DbContext(typeof(RoomMatchContext))]
    partial class RoomMatchContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("RoomMatch.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cleanliness")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOrganized")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LikesLight")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LikesWorkingAlone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sharing")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sleep")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Social")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sound")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Temperature")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
