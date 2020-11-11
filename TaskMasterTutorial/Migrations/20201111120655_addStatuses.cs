using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskMasterTutorial.Migrations
{
    public partial class addStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Statuses(Name) values ('To Do');");
            migrationBuilder.Sql("insert into Statuses(Name) values ('In Progress');");
            migrationBuilder.Sql("insert into Statuses(Name) values ('Done');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete Statuses;");
        }
    }
}
