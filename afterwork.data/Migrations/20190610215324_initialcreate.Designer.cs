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
    [Migration("20190610215324_initialcreate")]
    partial class initialcreate
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("afterwork.model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("afterwork.model.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId");

                    b.Property<int>("Complexity");

                    b.Property<int?>("CountryId");

                    b.Property<int?>("CreatorId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndTime");

                    b.Property<int?>("EventImageId");

                    b.Property<int?>("EventPlaceId");

                    b.Property<int>("EventType");

                    b.Property<int?>("GatheringSpotId");

                    b.Property<bool>("IsPrivate");

                    b.Property<double>("MinimalBudget");

                    b.Property<string>("Name");

                    b.Property<int>("ParticipantLimit");

                    b.Property<string>("Rating");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("EventImageId");

                    b.HasIndex("EventPlaceId");

                    b.HasIndex("GatheringSpotId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("afterwork.model.EventImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.ToTable("EventImages");
                });

            modelBuilder.Entity("afterwork.model.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("afterwork.model.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("afterwork.model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Email");

                    b.Property<int?>("EventId");

                    b.Property<int?>("EventId1");

                    b.Property<int?>("GroupId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("EventId1");

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
                        .HasForeignKey("CreatorId");

                    b.HasOne("afterwork.model.EventImage", "EventImage")
                        .WithMany()
                        .HasForeignKey("EventImageId");

                    b.HasOne("afterwork.model.Location", "EventPlace")
                        .WithMany()
                        .HasForeignKey("EventPlaceId");

                    b.HasOne("afterwork.model.Location", "GatheringSpot")
                        .WithMany()
                        .HasForeignKey("GatheringSpotId");
                });

            modelBuilder.Entity("afterwork.model.User", b =>
                {
                    b.HasOne("afterwork.model.Event")
                        .WithMany("Administrators")
                        .HasForeignKey("EventId");

                    b.HasOne("afterwork.model.Event")
                        .WithMany("Partisipants")
                        .HasForeignKey("EventId1");

                    b.HasOne("afterwork.model.Group")
                        .WithMany("Participants")
                        .HasForeignKey("GroupId");
                });
#pragma warning restore 612, 618
        }
    }
}