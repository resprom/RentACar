﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RentACar.Data;
using RentACar.Models.Helpers;
using System;

namespace RentACar.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180326190950_initialAzure2")]
    partial class initialAzure2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RentACar.Models.Car.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<int>("IsTheCarAvailable");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<int?>("PlaceId");

                    b.Property<DateTime>("RentFrom");

                    b.Property<DateTime>("RentTo");

                    b.HasKey("CarId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("RentACar.Models.Place.Place", b =>
                {
                    b.Property<int>("PlaceId");

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Region")
                        .IsRequired();

                    b.HasKey("PlaceId");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("RentACar.Models.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CarId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int?>("PlaceId");

                    b.Property<int>("TypeOfUser");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
