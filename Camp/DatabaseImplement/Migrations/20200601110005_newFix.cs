using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseImplement.Migrations
{
    public partial class newFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Counsellors_GroupId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_GroupId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Groups");

            migrationBuilder.CreateIndex(
                name: "IX_Counsellors_GroupId",
                table: "Counsellors",
                column: "GroupId",
                unique: true,
                filter: "[GroupId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Counsellors_Groups_GroupId",
                table: "Counsellors",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Counsellors_Groups_GroupId",
                table: "Counsellors");

            migrationBuilder.DropIndex(
                name: "IX_Counsellors_GroupId",
                table: "Counsellors");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupId",
                table: "Groups",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Counsellors_GroupId",
                table: "Groups",
                column: "GroupId",
                principalTable: "Counsellors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
