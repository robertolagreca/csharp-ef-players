using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class Milestone3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "score",
                table: "player",
                newName: "Score");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colors = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.TeamId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_player_TeamId",
                table: "player",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_player_team_TeamId",
                table: "player",
                column: "TeamId",
                principalTable: "team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_TeamId",
                table: "player");

            migrationBuilder.DropTable(
                name: "team");

            migrationBuilder.DropIndex(
                name: "IX_player_TeamId",
                table: "player");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "player");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "player",
                newName: "score");
        }
    }
}
