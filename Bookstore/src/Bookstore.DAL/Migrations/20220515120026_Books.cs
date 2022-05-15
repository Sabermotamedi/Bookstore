using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.DAL.Migrations
{
    public partial class Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"insert into Books(BookName,Auther,Publisher,ReleaseDate) Values('Shahnameh','Ferdowsi','Ferdowsi','1645-01-01')");
            migrationBuilder.Sql($"insert into Books(BookName,Auther,Publisher,ReleaseDate) Values('Bustan','Saadi Shirazi','Saadi','1645-01-01')");

            migrationBuilder.Sql($"insert into Books(BookName,Auther,Publisher,ReleaseDate) Values('Les Misérables','Victor Hugo','A. Lacroix, Verboeckhoven & Cie.','1832-01-01')");
            migrationBuilder.Sql($"insert into Books(BookName,Auther,Publisher,ReleaseDate) Values('Ninety-Three','Victor Hugo','A. Lacroix, Verboeckhoven & Cie.','1874-01-01')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
