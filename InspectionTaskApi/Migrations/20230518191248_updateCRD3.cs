using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InspectionTaskApi.Migrations
{
    /// <inheritdoc />
    public partial class updateCRD3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_AssignedToPersons_AssignedToPersonId",
                table: "Inspections");

            migrationBuilder.DropColumn(
                name: "AsignedToPersonId",
                table: "Inspections");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedToPersonId",
                table: "Inspections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_AssignedToPersons_AssignedToPersonId",
                table: "Inspections",
                column: "AssignedToPersonId",
                principalTable: "AssignedToPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_AssignedToPersons_AssignedToPersonId",
                table: "Inspections");

            migrationBuilder.AlterColumn<int>(
                name: "AssignedToPersonId",
                table: "Inspections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AsignedToPersonId",
                table: "Inspections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_AssignedToPersons_AssignedToPersonId",
                table: "Inspections",
                column: "AssignedToPersonId",
                principalTable: "AssignedToPersons",
                principalColumn: "Id");
        }
    }
}
