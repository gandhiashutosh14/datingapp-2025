using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations;

/// <inheritdoc />
public partial class _20261123065706_MemberDisplayNameAdded : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "DisplayName",
            table: "Members",
            type: "TEXT",
            nullable: false,
            defaultValue: "");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "DisplayName",
            table: "Members");
    }
}
