using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azki.Migrations
{
    /// <inheritdoc />
    public partial class InsuranceType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsuranceType",
                table: "Instruments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SvgUrl",
                table: "Instruments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InsuranceType",
                table: "Discounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsuranceType",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "SvgUrl",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "InsuranceType",
                table: "Discounts");
        }
    }
}
