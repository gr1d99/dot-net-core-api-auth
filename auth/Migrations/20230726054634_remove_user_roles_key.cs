using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace auth.Migrations
{
    /// <inheritdoc />
    public partial class remove_user_roles_key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users_roles",
                table: "users_roles");

            migrationBuilder.DropIndex(
                name: "IX_users_roles_RoleId",
                table: "users_roles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "users_roles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_roles",
                table: "users_roles",
                columns: new[] { "RoleId", "UserId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users_roles",
                table: "users_roles");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "users_roles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_roles",
                table: "users_roles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_users_roles_RoleId",
                table: "users_roles",
                column: "RoleId");
        }
    }
}
