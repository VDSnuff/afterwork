using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace afterwork.data.Migrations
{
    public partial class PropositionForEventDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PropositionForEventDateTime",
                columns: table => new
                {
                    PropositionForEventDateTimeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropositionCreatorUserId = table.Column<int>(nullable: true),
                    ProposedDateTime = table.Column<DateTime>(nullable: false),
                    VoicesCount = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: true)
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
                    UserId = table.Column<int>(nullable: false),
                    PropositionForEventDateTimeId = table.Column<int>(nullable: false)
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
                name: "IX_EventDateTimeVoter_PropositionForEventDateTimeId",
                table: "EventDateTimeVoter",
                column: "PropositionForEventDateTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDateTimeVoter_UserId",
                table: "EventDateTimeVoter",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PropositionForEventDateTime_EventId",
                table: "PropositionForEventDateTime",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_PropositionForEventDateTime_PropositionCreatorUserId",
                table: "PropositionForEventDateTime",
                column: "PropositionCreatorUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventDateTimeVoter");

            migrationBuilder.DropTable(
                name: "PropositionForEventDateTime");

            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Events");
        }
    }
}
