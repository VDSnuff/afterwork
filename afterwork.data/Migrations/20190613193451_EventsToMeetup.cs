using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace afterwork.data.Migrations
{
    public partial class EventsToMeetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAdministrator");

            migrationBuilder.DropTable(
                name: "EventDateTimeVoter");

            migrationBuilder.DropTable(
                name: "EventPartisipant");

            migrationBuilder.DropTable(
                name: "PropositionForEventDateTime");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventImages");

            migrationBuilder.CreateTable(
                name: "MeetUpImages",
                columns: table => new
                {
                    MeetUpImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetUpImages", x => x.MeetUpImageId);
                });

            migrationBuilder.CreateTable(
                name: "MeetUps",
                columns: table => new
                {
                    MeetUpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorUserId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MeetUpImageId = table.Column<int>(nullable: true),
                    MeetUpType = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    GatheringSpotLocationId = table.Column<int>(nullable: true),
                    MeetUpPlaceLocationId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    ParticipantLimit = table.Column<int>(nullable: false),
                    MinimalBudget = table.Column<double>(nullable: false),
                    Complexity = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetUps", x => x.MeetUpId);
                    table.ForeignKey(
                        name: "FK_MeetUps_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetUps_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetUps_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetUps_Location_GatheringSpotLocationId",
                        column: x => x.GatheringSpotLocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetUps_MeetUpImages_MeetUpImageId",
                        column: x => x.MeetUpImageId,
                        principalTable: "MeetUpImages",
                        principalColumn: "MeetUpImageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetUps_Location_MeetUpPlaceLocationId",
                        column: x => x.MeetUpPlaceLocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetUpAdministrator",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    MeetUpId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetUpAdministrator", x => new { x.MeetUpId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MeetUpAdministrator_MeetUps_MeetUpId",
                        column: x => x.MeetUpId,
                        principalTable: "MeetUps",
                        principalColumn: "MeetUpId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetUpAdministrator_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetUpPartisipant",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    MeetUpId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetUpPartisipant", x => new { x.MeetUpId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MeetUpPartisipant_MeetUps_MeetUpId",
                        column: x => x.MeetUpId,
                        principalTable: "MeetUps",
                        principalColumn: "MeetUpId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetUpPartisipant_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropositionForMeetUpDateTime",
                columns: table => new
                {
                    PropositionForMeetUpDateTimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropositionCreatorUserId = table.Column<int>(nullable: true),
                    ProposedDateTime = table.Column<DateTime>(nullable: false),
                    VoicesCount = table.Column<int>(nullable: false),
                    MeetUpId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropositionForMeetUpDateTime", x => x.PropositionForMeetUpDateTimeId);
                    table.ForeignKey(
                        name: "FK_PropositionForMeetUpDateTime_MeetUps_MeetUpId",
                        column: x => x.MeetUpId,
                        principalTable: "MeetUps",
                        principalColumn: "MeetUpId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropositionForMeetUpDateTime_Users_PropositionCreatorUserId",
                        column: x => x.PropositionCreatorUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetUpDateTimeVoter",
                columns: table => new
                {
                    MeetUpDateTimeVoterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    PropositionForMeetUptDateTimeId = table.Column<int>(nullable: false),
                    PropositionForMeetUpDateTimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetUpDateTimeVoter", x => x.MeetUpDateTimeVoterId);
                    table.ForeignKey(
                        name: "FK_MeetUpDateTimeVoter_PropositionForMeetUpDateTime_PropositionForMeetUpDateTimeId",
                        column: x => x.PropositionForMeetUpDateTimeId,
                        principalTable: "PropositionForMeetUpDateTime",
                        principalColumn: "PropositionForMeetUpDateTimeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetUpDateTimeVoter_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeetUpAdministrator_UserId",
                table: "MeetUpAdministrator",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUpDateTimeVoter_PropositionForMeetUpDateTimeId",
                table: "MeetUpDateTimeVoter",
                column: "PropositionForMeetUpDateTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUpDateTimeVoter_UserId",
                table: "MeetUpDateTimeVoter",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUpPartisipant_UserId",
                table: "MeetUpPartisipant",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_CityId",
                table: "MeetUps",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_CountryId",
                table: "MeetUps",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_CreatorUserId",
                table: "MeetUps",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_GatheringSpotLocationId",
                table: "MeetUps",
                column: "GatheringSpotLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_MeetUpImageId",
                table: "MeetUps",
                column: "MeetUpImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_MeetUpPlaceLocationId",
                table: "MeetUps",
                column: "MeetUpPlaceLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropositionForMeetUpDateTime_MeetUpId",
                table: "PropositionForMeetUpDateTime",
                column: "MeetUpId");

            migrationBuilder.CreateIndex(
                name: "IX_PropositionForMeetUpDateTime_PropositionCreatorUserId",
                table: "PropositionForMeetUpDateTime",
                column: "PropositionCreatorUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetUpAdministrator");

            migrationBuilder.DropTable(
                name: "MeetUpDateTimeVoter");

            migrationBuilder.DropTable(
                name: "MeetUpPartisipant");

            migrationBuilder.DropTable(
                name: "PropositionForMeetUpDateTime");

            migrationBuilder.DropTable(
                name: "MeetUps");

            migrationBuilder.DropTable(
                name: "MeetUpImages");

            migrationBuilder.CreateTable(
                name: "EventImages",
                columns: table => new
                {
                    EventImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventImages", x => x.EventImageId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<int>(nullable: true),
                    Complexity = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: true),
                    CreatorUserId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    EventImageId = table.Column<int>(nullable: true),
                    EventPlaceLocationId = table.Column<int>(nullable: true),
                    EventType = table.Column<int>(nullable: false),
                    GatheringSpotLocationId = table.Column<int>(nullable: true),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    IsPrivate = table.Column<bool>(nullable: false),
                    MinimalBudget = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParticipantLimit = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Users_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_EventImages_EventImageId",
                        column: x => x.EventImageId,
                        principalTable: "EventImages",
                        principalColumn: "EventImageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Location_EventPlaceLocationId",
                        column: x => x.EventPlaceLocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Location_GatheringSpotLocationId",
                        column: x => x.GatheringSpotLocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventAdministrator",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAdministrator", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EventAdministrator_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAdministrator_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventPartisipant",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPartisipant", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EventPartisipant_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventPartisipant_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropositionForEventDateTime",
                columns: table => new
                {
                    PropositionForEventDateTimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: true),
                    ProposedDateTime = table.Column<DateTime>(nullable: false),
                    PropositionCreatorUserId = table.Column<int>(nullable: true),
                    VoicesCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropositionForEventDateTime", x => x.PropositionForEventDateTimeId);
                    table.ForeignKey(
                        name: "FK_PropositionForEventDateTime_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropositionForEventDateTime_Users_PropositionCreatorUserId",
                        column: x => x.PropositionCreatorUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventDateTimeVoter",
                columns: table => new
                {
                    EventDateTimeVoterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropositionForEventDateTimeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDateTimeVoter", x => x.EventDateTimeVoterId);
                    table.ForeignKey(
                        name: "FK_EventDateTimeVoter_PropositionForEventDateTime_PropositionForEventDateTimeId",
                        column: x => x.PropositionForEventDateTimeId,
                        principalTable: "PropositionForEventDateTime",
                        principalColumn: "PropositionForEventDateTimeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDateTimeVoter_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventAdministrator_UserId",
                table: "EventAdministrator",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDateTimeVoter_PropositionForEventDateTimeId",
                table: "EventDateTimeVoter",
                column: "PropositionForEventDateTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDateTimeVoter_UserId",
                table: "EventDateTimeVoter",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPartisipant_UserId",
                table: "EventPartisipant",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CityId",
                table: "Events",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CountryId",
                table: "Events",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatorUserId",
                table: "Events",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventImageId",
                table: "Events",
                column: "EventImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventPlaceLocationId",
                table: "Events",
                column: "EventPlaceLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_GatheringSpotLocationId",
                table: "Events",
                column: "GatheringSpotLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropositionForEventDateTime_EventId",
                table: "PropositionForEventDateTime",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_PropositionForEventDateTime_PropositionCreatorUserId",
                table: "PropositionForEventDateTime",
                column: "PropositionCreatorUserId");
        }
    }
}
