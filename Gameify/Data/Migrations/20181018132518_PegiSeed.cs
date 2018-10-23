using Microsoft.EntityFrameworkCore.Migrations;

namespace Gameify.Data.Migrations
{
    public partial class PegiSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO PegiAge (Id, Age) VALUES (1, 3)");
            migrationBuilder.Sql("INSERT INTO PegiAge (Id, Age) VALUES (2, 7)");
            migrationBuilder.Sql("INSERT INTO PegiAge (Id, Age) VALUES (3, 12)");
            migrationBuilder.Sql("INSERT INTO PegiAge (Id, Age) VALUES (4, 16)");
            migrationBuilder.Sql("INSERT INTO PegiAge (Id, Age) VALUES (5, 18)");


            migrationBuilder.Sql("INSERT INTO PegiContent (Id, Name, Description) " +
                                 "VALUES (1, 'Violence', 'Game involves scenes of violence.')");
            migrationBuilder.Sql("INSERT INTO PegiContent (Id, Name, Description) " +
                                 "VALUES (2, 'Bad Language', 'Game involves curse words.')");
            migrationBuilder.Sql("INSERT INTO PegiContent (Id, Name, Description) " +
                                 "VALUES (3, 'Fear', 'Game involves video or audio which can be scary and terryfing.')");
            migrationBuilder.Sql("INSERT INTO PegiContent (Id, Name, Description) " +
                                 "VALUES (4, 'Gambling', 'Game involves elements which encourage gambling.')");
            migrationBuilder.Sql("INSERT INTO PegiContent (Id, Name, Description) " +
                                 "VALUES (5, 'Sex', 'Game involves elements which may relate to sex.')");
            migrationBuilder.Sql("INSERT INTO PegiContent (Id, Name, Description) " +
                                 "VALUES (6, 'Drugs', 'Game relates to doing drugs, drinking alcohol or smoking.')");
            migrationBuilder.Sql("INSERT INTO PegiContent (Id, Name, Description) " +
                                 "VALUES (7, 'Discrimination', 'Game involves stereotypes on religious, racial or nationalistic background.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
