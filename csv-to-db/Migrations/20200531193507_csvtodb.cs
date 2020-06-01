using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace csv_to_db.Migrations
{
    public partial class csvtodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FName = table.Column<string>(maxLength: 50, nullable: true),
                    LName = table.Column<string>(maxLength: 75, nullable: true),
                    Title = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<int>(nullable: false),
                    Address1 = table.Column<string>(maxLength: 100, nullable: true),
                    Address2 = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Zip = table.Column<int>(maxLength: 10, nullable: false),
                    State = table.Column<string>(maxLength: 30, nullable: true),
                    CountryId = table.Column<string>(maxLength: 10, nullable: true),
                    Lang = table.Column<string>(maxLength: 5, nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");
        }
    }
}
