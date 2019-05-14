﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingLotApp.Data.Context;

namespace ParkingLotApp.Data.Migrations
{
    [DbContext(typeof(ParkingLotAppDbContext))]
    [Migration("20190513045939_add-parkinglot-to-parkinglot-type-relationship")]
    partial class addparkinglottoparkinglottyperelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParkingLotApp.Domain.Model.ParkingLotType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ParkingLotTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Parking Garage"
                        },
                        new
                        {
                            Id = 2,
                            Description = "On Street"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Business"
                        });
                });

            modelBuilder.Entity("ParkingLotApp.Domain.Models.ParkingLot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Floor")
                        .IsRequired();

                    b.Property<string>("Geomap");

                    b.Property<bool>("Handicap");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("ParkingLotTypeId");

                    b.Property<int>("Size");

                    b.Property<int>("Spaces");

                    b.HasKey("Id");

                    b.HasIndex("ParkingLotTypeId");

                    b.ToTable("parkingLots");
                });

            modelBuilder.Entity("ParkingLotApp.Domain.Models.ParkingLot", b =>
                {
                    b.HasOne("ParkingLotApp.Domain.Model.ParkingLotType", "ParkingLotType")
                        .WithMany()
                        .HasForeignKey("ParkingLotTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}