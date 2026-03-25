using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_second_approch.Migrations
{
    /// <inheritdoc />
    public partial class inserting_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "registers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "registers",
                columns: new[] { "ID", "ConfirmPassword", "Email", "Name", "Password", "phone" },
                values: new object[] { 1, "Admin@123", "somya36@gmail.com", "Admin", "Admin@123", 1234567890L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registers");
        }
    }
}
