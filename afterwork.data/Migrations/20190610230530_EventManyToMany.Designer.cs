﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using afterwork.data;

namespace afterwork.data.Migrations
{
    [DbContext(typeof(AfterWorkDbContext))]
    [Migration("20190610230530_EventManyToMany")]
    partial class EventManyToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("afterwork.model.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("afterwork.model.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("afterwork.model.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId");

                    b.Property<int>("Complexity");

                    b.Property<int?>("CountryId");

                    b.Property<int?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndTime");

                    b.Property<int?>("EventImageId");

                    b.Property<int?>("EventPlaceLocationId");

                    b.Property<int>("EventType");

                    b.Property<int?>("GatheringSpotLocationId");

                    b.Property<bool>("IsPrivate");

                    b.Property<double>("MinimalBudget");

                    b.Property<string>("Name");

                    b.Property<int>("ParticipantLimit");

                    b.Property<string>("Rating");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("EventId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("EventImageId");

                    b.HasIndex("EventPlaceLocationId");

                    b.HasIndex("GatheringSpotLocationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("afterwork.model.EventAdministrator", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("EventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("EventAdministrator");
                });

            modelBuilder.Entity("afterwork.model.EventImage", b =>
                {
                    b.Property<int>("EventImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path");

                    b.HasKey("EventImageId");

                    b.ToTable("EventImages");
                });

            modelBuilder.Entity("afterwork.model.EventPartisipant", b =>
                {
                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("EventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("EventPartisipant");
                });

            modelBuilder.Entity("afterwork.model.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("afterwork.model.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("afterwork.model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Email");

                    b.Property<int?>("GroupId");

                    b.Property<string>("Name");

                    b.HasKey("UserId");

                    b.HasIndex("GroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("afterwork.model.Event", b =>
                {
                    b.HasOne("afterwork.model.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("afterwork.model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("afterwork.model.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("afterwork.model.EventImage", "EventImage")
                        .WithMany()
                        .HasForeignKey("EventImageId");

                    b.HasOne("afterwork.model.Location", "EventPlace")
                        .WithMany()
                        .HasForeignKey("EventPlaceLocationId");

                    b.HasOne("afterwork.model.Location", "GatheringSpot")
                        .WithMany()
                        .HasForeignKey("GatheringSpotLocationId");
                });

            modelBuilder.Entity("afterwork.model.EventAdministrator", b =>
                {
                    b.HasOne("afterwork.model.Event", "Event")
                        .WithMany("EventAdministrator")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("afterwork.model.User", "User")
                        .WithMany("EventAdministrator")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("afterwork.model.EventPartisipant", b =>
                {
                    b.HasOne("afterwork.model.Event", "Event")
                        .WithMany("EventPartisipant")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("afterwork.model.User", "User")
                        .WithMany("EventPartisipant")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("afterwork.model.User", b =>
                {
                    b.HasOne("afterwork.model.Group")
                        .WithMany("Participants")
                        .HasForeignKey("GroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
