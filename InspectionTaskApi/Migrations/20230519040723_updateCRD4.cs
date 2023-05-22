using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InspectionTaskApi.Migrations
{
    /// <inheritdoc />
    public partial class updateCRD4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CopyRequestDtoId",
                table: "Inspections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CopyRequestDtoId",
                table: "AssignedToPersons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_CopyRequestDtoId",
                table: "Inspections",
                column: "CopyRequestDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedToPersons_CopyRequestDtoId",
                table: "AssignedToPersons",
                column: "CopyRequestDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedToPersons_CopyRequests_CopyRequestDtoId",
                table: "AssignedToPersons",
                column: "CopyRequestDtoId",
                principalTable: "CopyRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_CopyRequests_CopyRequestDtoId",
                table: "Inspections",
                column: "CopyRequestDtoId",
                principalTable: "CopyRequests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedToPersons_CopyRequests_CopyRequestDtoId",
                table: "AssignedToPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_CopyRequests_CopyRequestDtoId",
                table: "Inspections");

            migrationBuilder.DropIndex(
                name: "IX_Inspections_CopyRequestDtoId",
                table: "Inspections");

            migrationBuilder.DropIndex(
                name: "IX_AssignedToPersons_CopyRequestDtoId",
                table: "AssignedToPersons");

            migrationBuilder.DropColumn(
                name: "CopyRequestDtoId",
                table: "Inspections");

            migrationBuilder.DropColumn(
                name: "CopyRequestDtoId",
                table: "AssignedToPersons");
        }
    }
}
