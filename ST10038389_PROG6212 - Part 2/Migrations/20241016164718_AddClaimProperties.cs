using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10038389_PROG6212___Part_2.Migrations
{
    /// <inheritdoc />
    public partial class AddClaimProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SupportingDocument",
                table: "Claims",
                newName: "SupportingDocumentPath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SupportingDocumentPath",
                table: "Claims",
                newName: "SupportingDocument");
        }
    }
}
