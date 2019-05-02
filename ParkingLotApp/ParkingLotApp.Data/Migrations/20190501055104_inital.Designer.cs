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
    [Migration("20190501055104_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int>("Size");

                    b.Property<int>("Spaces");

                    b.HasKey("Id");

                    b.ToTable("parkingLots");
                });
#pragma warning restore 612, 618
        }
    }
}
