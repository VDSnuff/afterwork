using Microsoft.EntityFrameworkCore.Migrations;

namespace afterwork.data.Migrations
{
    public partial class EventManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_CreatorId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Location_EventPlaceId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Location_GatheringSpotId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Events_EventId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Events_EventId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EventId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EventId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Location",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Groups",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "GatheringSpotId",
                table: "Events",
                newName: "GatheringSpotLocationId");

            migrationBuilder.RenameColumn(
                name: "EventPlaceId",
                table: "Events",
                newName: "EventPlaceLocationId");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Events",
                newName: "CreatorUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Events",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_GatheringSpotId",
                table: "Events",
                newName: "IX_Events_GatheringSpotLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_EventPlaceId",
                table: "Events",
                newName: "IX_Events_EventPlaceLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CreatorId",
                table: "Events",
                newName: "IX_Events_CreatorUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EventImages",
                newName: "EventImageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Countries",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "CityId");

            migrationBuilder.CreateTable(
                name: "EventAdministrator",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_EventAdministrator_UserId",
                table: "EventAdministrator",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPartisipant_UserId",
                table: "EventPartisipant",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_CreatorUserId",
                table: "Events",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Location_EventPlaceLocationId",
                table: "Events",
                column: "EventPlaceLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Location_GatheringSpotLocationId",
                table: "Events",
                column: "GatheringSpotLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_CreatorUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Location_EventPlaceLocationId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Location_GatheringSpotLocationId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EventAdministrator");

            migrationBuilder.DropTable(
                name: "EventPartisipant");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Location",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Groups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GatheringSpotLocationId",
                table: "Events",
                newName: "GatheringSpotId");

            migrationBuilder.RenameColumn(
                name: "EventPlaceLocationId",
                table: "Events",
                newName: "EventPlaceId");

            migrationBuilder.RenameColumn(
                name: "CreatorUserId",
                table: "Events",
                newName: "CreatorId");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Events",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Events_GatheringSpotLocationId",
                table: "Events",
                newName: "IX_Events_GatheringSpotId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_EventPlaceLocationId",
                table: "Events",
                newName: "IX_Events_EventPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CreatorUserId",
                table: "Events",
                newName: "IX_Events_CreatorId");

            migrationBuilder.RenameColumn(
                name: "EventImageId",
                table: "EventImages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Countries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Cities",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId1",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EventId",
                table: "Users",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EventId1",
                table: "Users",
                column: "EventId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_CreatorId",
                table: "Events",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Location_EventPlaceId",
                table: "Events",
                column: "EventPlaceId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Location_GatheringSpotId",
                table: "Events",
                column: "GatheringSpotId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Events_EventId",
                table: "Users",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Events_EventId1",
                table: "Users",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
