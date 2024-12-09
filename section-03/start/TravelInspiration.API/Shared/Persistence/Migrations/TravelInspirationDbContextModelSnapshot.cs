﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelInspiration.API.Shared.Persistence;

#nullable disable

namespace TravelInspiration.API.Migrations
{
    [DbContext(typeof(TravelInspirationDbContext))]
    partial class TravelInspirationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TravelInspiration.API.Shared.Domain.Entities.Itinerary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Itineraries", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2576),
                            Description = "Five great days in Paris",
                            Name = "A Trip to Paris",
                            UserId = "KevinsUserId"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2579),
                            Description = "A week in beautiful Antwerp",
                            Name = "Antwerp Extravaganza",
                            UserId = "KevinsUserId"
                        });
                });

            modelBuilder.Entity("TravelInspiration.API.Shared.Domain.Entities.Stop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItineraryId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool?>("Suggested")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("ItineraryId");

                    b.ToTable("Stops", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2838),
                            ImageUri = "https://localhost:7120/images/eiffeltower.jpg",
                            ItineraryId = 1,
                            Name = "The Eiffel Tower"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2844),
                            ImageUri = "https://localhost:7120/images/louvre.jpg",
                            ItineraryId = 1,
                            Name = "The Louvre"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2849),
                            ImageUri = "https://localhost:7120/images/perelachaise.jpg",
                            ItineraryId = 1,
                            Name = "Père Lachaise Cemetery"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2854),
                            ImageUri = "https://localhost:7120/images/royalmuseum.jpg",
                            ItineraryId = 2,
                            Name = "The Royal Museum of Beautiful Arts"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2858),
                            ImageUri = "https://localhost:7120/images/stpauls.jpg",
                            ItineraryId = 2,
                            Name = "Saint Paul's Church"
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "DATASEED",
                            CreatedOn = new DateTime(2024, 7, 4, 13, 51, 46, 455, DateTimeKind.Utc).AddTicks(2863),
                            ImageUri = "https://localhost:7120/images/michelin.jpg",
                            ItineraryId = 2,
                            Name = "Michelin Restaurant Visit"
                        });
                });

            modelBuilder.Entity("TravelInspiration.API.Shared.Domain.Entities.Stop", b =>
                {
                    b.HasOne("TravelInspiration.API.Shared.Domain.Entities.Itinerary", "Itinerary")
                        .WithMany("Stops")
                        .HasForeignKey("ItineraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Itinerary");
                });

            modelBuilder.Entity("TravelInspiration.API.Shared.Domain.Entities.Itinerary", b =>
                {
                    b.Navigation("Stops");
                });
#pragma warning restore 612, 618
        }
    }
}
