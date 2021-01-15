using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsbnId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentHolder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[,]
                {
                    { 1, "readymade", "american", "street", "mlkshk" },
                    { 2, "fixie", "whatever", "haven't", "fixie" },
                    { 3, "loko", "Lo-fi", "occupy", "they" },
                    { 4, "rights", "raw", "part", "art" },
                    { 5, "richardson", "apparel", "beer", "narwhal" },
                    { 6, "narwhal", "Iphone", "kogi", "freegan" },
                    { 7, "pickled", "company", "Polaroid", "DIY" },
                    { 8, "keffiyeh", "Ethnic", "shorts", "trust" },
                    { 9, "bicycle", "vice", "park", "ethnic" },
                    { 10, "Post-ironic", "post-ironic", "pickled", "Marfa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
