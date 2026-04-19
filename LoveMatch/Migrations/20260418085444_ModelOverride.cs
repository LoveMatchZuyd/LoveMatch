using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoveMatch.Migrations
{
    //Created by W. Smeets
    /// <inheritdoc />
    public partial class ModelOverride : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Members",
                newName: "AdminId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Members",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Games",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchMember",
                columns: table => new
                {
                    MatchesId = table.Column<int>(type: "INTEGER", nullable: false),
                    MembersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchMember", x => new { x.MatchesId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_MatchMember_Match_MatchesId",
                        column: x => x.MatchesId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchMember_Members_MembersId",
                        column: x => x.MembersId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_AdminId",
                table: "Members",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_MemberId",
                table: "Games",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchMember_MembersId",
                table: "MatchMember",
                column: "MembersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Members_MemberId",
                table: "Games",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Admins_AdminId",
                table: "Members",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Members_MemberId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Admins_AdminId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "MatchMember");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Members_AdminId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Games_MemberId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Members",
                newName: "Age");
        }
    }
}
