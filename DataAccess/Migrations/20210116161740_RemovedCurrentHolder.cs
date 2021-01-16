using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class RemovedCurrentHolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentHolder",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Martha and the Muffins", "Brazillian Screamo", "4128949025348" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Magneta Lane", "Jazz", "4002224963569" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Eminem", "Dance", "8160505815117" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Michael Jackson", "Brazillian Rock", "6880424205871" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Chicago", "Funk", "2312576159803" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Meligrove Band", "Funk", "6367268893374" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Phil Collins", "Classical", "0256211992933" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Major Maker", "Folk", "3641005625313" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Most Serene Republic", "Caribbean Funk", "3654663428356" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Garth Brooks", "Brazillian Dance", "1754930697183" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Pink Floyd", "Dance", "6375838163490" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Celine Dion", "Jazzy Dance", "2087864514474" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mythos", "Rock", "3658973662158" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The McRackins", "R&B", "7492183066299" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Metric", "Easy Listening", "2629821374342" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Leahy", "Grunge", "8718622398719" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Linda Ronstadt", "African Jazz", "9810850546874" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Love Inc.", "Electronic Blues", "6717972014113" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mr. Pine", "Classical", "3776667080877" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mother Mother", "Blues", "2065231986428" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Gloria Estefan", "Blues", "2058264049490" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lost & Profound", "R&B", "3270640233459" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mercy, the Sexton", "Modern Pop", "2997548913396" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Memphis", "Electronic Screamo", "2626212096190" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The McDades", "Emo", "4843796519578" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mobile", "Folk", "4303430720087" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Beatles", "Blues", "2262216367759" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lioness", "Emo", "3027445112458" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Madonna", "Classic Rock", "4883492883044" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Loverboy", "Classic Jazz", "5581495296087" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mecca Normal", "Hard Jazz", "3700068450438" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lioness", "Fresh Folk", "4962227409652" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Farm Fresh", "House", "5638932864333" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Meligrove Band", "Classical", "7308693857132" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Love Kills", "Jazz", "3524614572267" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Meligrove Band", "Blues", "7445600701417" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Elton John", "House", "0523467904567" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "R.E.M.", "Electronic Easy Listening", "6502247505221" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Machete Avenue", "Jazz", "7245481375503" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Barbra Streisand", "Doo-Wop", "8815958898493" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Martyr", "Jazz", "9095516003235" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mir", "Free Jazz", "7913484897280" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Most Serene Republic", "Acid Classical", "0741617761712" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Marianas Trench", "Emo", "2770690186274" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Red Hot Chili Peppers", "Funk", "5908199975904" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Lowest of the Low", "Jazz", "3052715100255" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Queen", "Classical", "5403821149664" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Metalwood", "Children's", "9093823377053" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Moxy Früvous", "Hard Screamo", "2439724144856" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50,
                columns: new[] { "Author", "IsbnId" },
                values: new object[] { "MacLean & MacLean", "8687059308071" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Marilyn's Vitamins", "Modern Blues", "1724888543380" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Dire Straits", "Rock", "8950677194283" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Mountains and the Trees", "Fresh Rock", "6969988851643" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Rihanna", "Brazillian Blues", "8602737696927" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mariah Carey", "Emo", "1155162116464" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "MCJ & Cool G", "Rock", "8120726965142" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mercey Brothers", "Blues", "8267104223425" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Love Kills", "Jazzy Jazz", "2796721892181" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Led Zeppelin", "Blues", "9299065859546" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Lincolns", "Emo", "5271553612970" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Midway State", "Rock", "1367480698869" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "B'z", "Caribbean Rock", "4491205053727" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Low Level Flight", "Dance", "6019930915522" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lightning Dust", "R&B", "5335596305521" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lili Fatale", "Children's", "5317300419997" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 66,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Masochistic Religion", "African House", "8676028927090" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 67,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Mark Inside", "Dance", "3711369823393" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 68,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The MRQ", "African Easy Listening", "3612707978278" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 69,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Elton John", "Dance", "1230006667284" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 70,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mashmakhan", "Avant-Garde Blues", "2446648846177" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 71,
                columns: new[] { "Author", "IsbnId" },
                values: new object[] { "Left Spine Down", "5457592667404" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 72,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Rod Stewart", "Fresh Emo", "0571041214906" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 73,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "ABBA", "Caribbean Rock", "6734918811863" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 74,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "My Darkest Days", "Fresh Screamo", "2223136355637" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 75,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mobile", "Acid Folk", "0232144156445" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 76,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Queen", "Free Rock", "1407217325462" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 77,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Linda Ronstadt", "Glam Children's", "9791450644999" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 78,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Men Without Hats", "Funk", "7489276900376" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 79,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Land of Talk", "Kansas City Classical", "3980440293538" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 80,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mystery Machine", "Free Rock", "9053509592574" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 81,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Luciano Pavarotti", "Doo-Wop", "6162047743675" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 82,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Carpenters", "Free House", "0430811163959" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 83,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lola Dutronic", "Caribbean Grunge", "7850149140855" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 84,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Moist", "Avant-Garde Jazz", "3458861748225" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 85,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Eminem", "Fresh Grunge", "1119044925960" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 86,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lola Dutronic", "Kansas City Rock", "2011809429407" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 87,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "MCJ & Cool G", "R&B", "5254676731262" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 88,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Farm Fresh", "Emo", "4298613340659" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 89,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Genesis", "Modern R&B", "3415969913920" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 90,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lillix", "Blues", "2666325780376" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 91,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mare", "Jazz", "6440934651244" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 92,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Janet Jackson", "Asian Classical", "4989164185639" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 93,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Elton John", "Easy Listening", "4465609818927" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 94,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Manic Drive", "Folk", "9236345935785" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 95,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Queen", "Jazz", "4710906372877" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 96,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Led Zeppelin", "Kansas City Folk", "1866749122760" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 97,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Farm Fresh", "Glam Screamo", "9155972155012" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 98,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Matadors", "African Rock", "2668449629444" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 99,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Matt Mays & El Torpedo", "Avant-Garde Blues", "4715817939528" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 100,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Barbra Streisand", "Asian Emo", "4494599222067" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 101,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Manvils", "Fresh Children's", "6603773450115" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 102,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Main Source", "Jazzy Emo", "9053541344639" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 103,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Local Rabbits", "Fresh R&B", "5126254883021" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 104,
                columns: new[] { "Author", "IsbnId" },
                values: new object[] { "Left Spine Down", "7255503471931" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 105,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mes Aïeux", "House", "0491884813920" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 106,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Merryweather", "Emo", "8416255501727" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 107,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mes Aïeux", "Pop", "9478186555673" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 108,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Me Mom & Morgentaler", "House", "2009280669259" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 109,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Manteca", "Children's", "5633021713735" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 110,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Luther Wright and the Wrongs", "Modern Screamo", "7010372964254" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 111,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Mohawk Lodge", "Rock", "5591694493397" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 112,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Eminem", "Fresh Emo", "8040255496301" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 113,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Bee Gees", "Classical", "6078719771895" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 114,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Motion Ensemble", "Rock", "7507974440224" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 115,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Love and Sas", "Children's", "6371944042547" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 116,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Lincolns", "Folk", "8199097708163" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 117,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "My Darkest Days", "Emo", "3903484086125" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 118,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Farm Fresh", "Folk", "9823497340549" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 119,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Rod Stewart", "Rock", "1478989552814" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 120,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Merlin", "Hard Jazz", "0567929163842" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 121,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Loverboy", "Folk", "0683790369081" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 122,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Kiss", "Brazillian Jazz", "6675164655987" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 123,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Low Level Flight", "Glam Classical", "7459166237609" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 124,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Live on Arrival", "Emo", "5826109060160" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 125,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lee Harvey Osmond", "Asian Pop", "3268132368186" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 126,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "McKenna Mendelson Mainline", "Dance", "7730866655017" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 127,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Loverboy", "Glam Dance", "3367869569230" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 128,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Backstreet Boys", "Grunge", "4760991049331" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 129,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Paul McCartney", "Screamo", "4774668156013" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 130,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Moxy", "Emo", "5627823206938" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 131,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Dire Straits", "Pop", "9513653343704" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 132,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Chicago", "Pop", "4385449188806" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 133,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Ladyhawk", "Asian Dance", "0035897134100" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 134,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Bryan Adams", "Dance", "6748279244722" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 135,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Whitney Houston", "Brazillian Funk", "9712154315713" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 136,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lime", "Classic Rock", "4370924572290" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 137,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Moxy", "Pop", "2566984454190" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 138,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Midway State", "Blues", "7857053842177" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 139,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Stevie Wonder", "Free Jazz", "0229415107557" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 140,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "DJ Jazzy Jeff and the Fresh Prince", "Brazillian Blues", "9965207597485" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 141,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Miriodor", "Doo-Wop", "9796031046987" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 142,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Moxy Früvous", "R&B", "0507824235256" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 143,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Gloria Estefan", "R&B", "5928019800177" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 144,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Gloria Estefan", "Classical", "3668015122919" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 145,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Limblifter", "Brazillian R&B", "4337049460232" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 146,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Leigh Ashford", "Asian Children's", "5663107328195" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 147,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Marianas Trench", "Emo", "6172872586996" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 148,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Meligrove Band", "Kansas City Jazz", "4220053551956" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 149,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lola Dutronic", "Acid House", "0126840066492" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 150,
                columns: new[] { "BookName", "IsbnId" },
                values: new object[] { "African Emo", "3774226837966" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 151,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Rolling Stones", "Electronic Jazz", "5225693209888" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 152,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Madonna", "Electronic R&B", "6594902987715" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 153,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "AC/DC", "Kansas City Doo-Wop", "8451888249883" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 154,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Matadors", "Asian Rock", "1410326948939" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 155,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Britney Spears", "Acid R&B", "1073237026239" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 156,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Moneen", "Classic Classical", "7191036967380" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 157,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Elvis Presley", "R&B", "8856803280282" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 158,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mystery", "Rock", "6562563996113" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 159,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Who", "Grunge", "1249809276997" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 160,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Luciano Pavarotti", "Modern Doo-Wop", "0023446332155" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 161,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Barry Manilow", "Jazzy Classical", "2310824105749" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 162,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Britney Spears", "African Blues", "1979623679596" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 163,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Moist", "Glam Jazz", "4497040686498" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 164,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "The Midway State", "Glam Emo", "7267626680049" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 165,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "My Darkest Days", "Classic Children's", "4759147793803" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 166,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lionel Richie", "Classical", "8468683477843" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 167,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Major Maker", "Asian Easy Listening", "5266786535454" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 168,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Letters to Elora", "Classic Classical", "6592868700425" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 169,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Machete Avenue", "Classic Rock", "5058248297764" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 170,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Red Hot Chili Peppers", "African Doo-Wop", "9263447643510" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 171,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Santana", "Fresh Dance", "2894541427226" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 172,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Maow", "Rock", "3308848417200" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 173,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "LiveonRelease", "Avant-Garde Blues", "6856510406245" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 174,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Janet Jackson", "Acid Blues", "8776190128582" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 175,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Maharahj", "Acid Classical", "8034306290108" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 176,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mecca Normal", "R&B", "7438394307077" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 177,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mother Mother", "Acid Doo-Wop", "8009573029063" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 178,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lili Fatale", "Fresh Easy Listening", "1053579287942" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 179,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Van Halen", "Emo", "8751487773180" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 180,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Guns N' Roses", "House", "4867453213244" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 181,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Linda Ronstadt", "Jazz", "8820412241274" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 182,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lighthouse", "Rock", "6410234190527" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 183,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Bruce Springsteen", "Rock", "1896589156091" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 184,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Lightning Dust", "Brazillian Children's", "8262869491299" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 185,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "B'z", "African Rock", "7664558170302" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 186,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "MonkeyJunk", "Glam Jazz", "0181188529241" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 187,
                columns: new[] { "Author", "IsbnId" },
                values: new object[] { "The Mark Inside", "3195989112176" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 188,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Van Halen", "Classic Rock", "5887998358413" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 189,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Mariah Carey", "Classic Jazz", "2937470391737" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 190,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Janet Jackson", "Modern Dance", "9783555521585" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 191,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Leahy", "Easy Listening", "2776539465260" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 192,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Whitney Houston", "Emo", "3266848631329" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 193,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Local Rabbits", "House", "3869682738433" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 194,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Tina Turner", "Fresh Blues", "7468396948654" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 195,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Little Caesar and the Consuls", "Kansas City Blues", "4916811664989" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 196,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Chicago", "Asian R&B", "5078845540644" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 197,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Malajube", "Jazz", "3273201722011" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 198,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Liferuiner", "Acid Doo-Wop", "5922811293381" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 199,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Luther Wright and the Wrongs", "Classical", "6171295502369" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 200,
                columns: new[] { "Author", "BookName", "IsbnId" },
                values: new object[] { "Britney Spears", "Asian Doo-Wop", "3130794155642" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 201,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1961, 3, 11, 20, 19, 27, 0, DateTimeKind.Unspecified), "adrianramirez@libra.ry", "Adrian", "3143 Woodside Avenue ", "Ramirez", "Dreamcatcher", "(735) 453-6757", new DateTime(2019, 2, 26, 19, 17, 40, 279, DateTimeKind.Local).AddTicks(7611), "adrianramirez" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 202,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1985, 8, 29, 0, 27, 45, 0, DateTimeKind.Unspecified), "kayleerussell@libra.ry", "Kaylee", "9703 Durland Place ", "Russell", "butcher", "(293) 599-6134", new DateTime(2019, 4, 8, 19, 17, 40, 279, DateTimeKind.Local).AddTicks(9523), "kayleerussell" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 203,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1979, 6, 26, 23, 44, 16, 0, DateTimeKind.Unspecified), "kaitlyntellies@libra.ry", "Kaitlyn", "7474 Paerdegat 15th Street ", "Tellies", "williamsburg", "(609) 785-0306", new DateTime(2018, 10, 23, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(57), "kaitlyntellies" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 204,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1913, 10, 23, 18, 37, 28, 0, DateTimeKind.Unspecified), "connorstewart@libra.ry", "Connor", "6321 Powell Street ", "Stewart", "apparel", "(423) 236-1193", new DateTime(2018, 10, 22, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(563), "connorstewart" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 205,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1944, 7, 17, 14, 10, 32, 0, DateTimeKind.Unspecified), "angelinacook@libra.ry", "Angelina", "697 82nd Street ", "Cook", "keffiyeh", "(301) 449-8792", new DateTime(2018, 7, 12, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(1059), "angelinacook" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 206,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1994, 4, 21, 3, 0, 5, 0, DateTimeKind.Unspecified), "jackrivera@libra.ry", "Jack", "2219 Bristol Street ", "Rivera", "butcher", "(716) 769-9270", new DateTime(2019, 2, 10, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(1558), "jackrivera" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 207,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1989, 3, 7, 9, 35, 29, 0, DateTimeKind.Unspecified), "ryanbell@libra.ry", "Ryan", "3546 Sands Street ", "Bell", "sold", "(298) 300-8676", new DateTime(2019, 2, 17, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(2034), "ryanbell" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 208,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2019, 7, 15, 10, 29, 44, 0, DateTimeKind.Unspecified), "lucasreed@libra.ry", "Lucas", "137 Bulwer Place ", "Reed", "Polaroid", "(651) 599-0282", new DateTime(2020, 10, 26, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(2496), "lucasreed" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 209,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2003, 12, 25, 19, 39, 5, 0, DateTimeKind.Unspecified), "ashleysimmons@libra.ry", "Ashley", "6112 Taaffe Place ", "Simmons", "terry", "(645) 669-9252", new DateTime(2020, 10, 1, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(2935), "ashleysimmons" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 210,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1972, 7, 21, 8, 59, 34, 0, DateTimeKind.Unspecified), "adamross@libra.ry", "Adam", "8732 Wolcott Street ", "Ross", "hella", "(270) 627-8389", new DateTime(2019, 4, 6, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(3447), "adamross" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 211,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1983, 5, 11, 9, 38, 22, 0, DateTimeKind.Unspecified), "baileymitchell@libra.ry", "Bailey", "9517 O'Brien Place ", "Mitchell", "pour-over", "(284) 687-4637", new DateTime(2019, 8, 19, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(3914), "baileymitchell" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 212,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1967, 10, 26, 18, 31, 11, 0, DateTimeKind.Unspecified), "evelynmurphy@libra.ry", "Evelyn", "6048 Ryerson Street ", "Murphy", "narwhal", "(675) 743-6074", new DateTime(2019, 8, 18, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(4370), "evelynmurphy" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 213,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2018, 6, 12, 7, 44, 57, 0, DateTimeKind.Unspecified), "vanessabarnes@libra.ry", "Vanessa", "5544 Brighton Beach Avenue ", "Barnes", "narwhal", "(400) 703-1175", new DateTime(2020, 1, 5, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(4822), "vanessabarnes" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 214,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1916, 11, 27, 2, 38, 33, 0, DateTimeKind.Unspecified), "sethperez@libra.ry", "Seth", "2165 Classon Avenue ", "Perez", "mixtape", "(400) 614-2609", new DateTime(2018, 9, 20, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(5276), "sethperez" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 215,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1969, 4, 26, 22, 15, 18, 0, DateTimeKind.Unspecified), "brandonbrown@libra.ry", "Brandon", "6616 102nd Street ", "Brown", "terry", "(367) 584-9789", new DateTime(2020, 2, 22, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(5753), "brandonbrown" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 216,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1947, 2, 27, 10, 34, 22, 0, DateTimeKind.Unspecified), "chloebailey@libra.ry", "Chloe", "2425 Ovington Court ", "Bailey", "artisan", "(495) 618-4557", new DateTime(2019, 1, 8, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(6224), "chloebailey" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 217,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1929, 3, 3, 18, 16, 42, 0, DateTimeKind.Unspecified), "jacobanderson@libra.ry", "Jacob", "5691 Shore Parkway ", "Anderson", "Brooklyn", "(472) 280-6159", new DateTime(2020, 1, 20, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(6655), "jacobanderson" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 218,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1957, 2, 14, 1, 47, 25, 0, DateTimeKind.Unspecified), "dylanmacdonald@libra.ry", "Dylan", "4281 Wyckoff Street ", "MacDonald", "echo", "(312) 713-5561", new DateTime(2019, 2, 24, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(7112), "dylanmacdonald" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 219,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2019, 7, 29, 9, 1, 56, 0, DateTimeKind.Unspecified), "jenniferbrooks@libra.ry", "Jennifer", "4895 Regent Place ", "Brooks", "Four", "(649) 693-6768", new DateTime(2020, 6, 30, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(7634), "jenniferbrooks" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 220,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1940, 11, 10, 10, 17, 11, 0, DateTimeKind.Unspecified), "melisagarcia@libra.ry", "Melisa", "1888 Guider Avenue ", "Garcia", "trade", "(370) 310-0638", new DateTime(2020, 4, 23, 19, 17, 40, 280, DateTimeKind.Local).AddTicks(8099), "melisagarcia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentHolder",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moev", "Funk", "pack", "9557715328204" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The MRQ", "Pop", "post-ironic", "3973063283587" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Martha and the Muffins", "Kansas City Pop", "life", "7393544068277" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moist", "Avant-Garde Easy Listening", "skateboard", "1159625929388" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mes Aïeux", "R&B", "world", "2377057360660" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Cher", "Dance", "richardson", "2338035768986" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lotus Child", "Fresh Funk", "carles", "5644342971800" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Chicago", "African Funk", "company", "1657999787320" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lightning Dust", "Funk", "seitan", "4298578255948" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Memories Attack", "Hard Emo", "batch", "801044819318" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mystery", "Glam Jazz", "womn", "2016758109450" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "LMDS", "Funk", "direct", "7156382378729" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Eagles", "Fresh Pop", "government", "7447160104032" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moev", "Jazz", "haven't", "8226705653698" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Luyas", "Funk", "park", "5233703379162" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Kate and Anna McGarrigle", "Jazz", "occupy", "5551036016806" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Barry Manilow", "Brazillian Children's", "booth", "5504994055025" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Look People", "Free Rock", "Polaroid", "8991747819349" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Madonna", "Jazzy Jazz", "organic", "5385806427982" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "AC/DC", "Acid Rock", "it", "9941410184810" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Madonna", "Emo", "semiotics", "1172396131405" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Led Zeppelin", "Emo", "portland", "4087944335345" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Manteca", "Classic Funk", "pork", "3887648635491" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "DJ Jazzy Jeff and the Fresh Prince", "Jazz", "raw", "2915862688289" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Luke & The Apostles", "African Folk", "way", "2984041326206" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moxy", "R&B", "of", "9676182493416" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "R.E.M.", "Rock", "gastropub", "814946606203" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Matthew Good Band", "Funk", "richardson", "3108339218007" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Letters to Elora", "Pop", "haven't", "8705413680852" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Magneta Lane", "Jazz", "pour-over", "7053080344131" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Lovely Feathers", "Folk", "company", "9948221598727" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Paul McCartney", "Screamo", "work", "6708801349955" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Elton John", "Rock", "mustache", "7920929988809" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moxy", "Rock", "loko", "6988596505014" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Major Maker", "Easy Listening", "cray", "7242541446929" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mahogany Rush", "Kansas City Dance", "company", "9629478915421" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Cher", "Kansas City Grunge", "artisan", "7672861510735" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mean Red Spiders", "Brazillian Grunge", "keffiyeh", "9559438405353" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lillix", "Acid Screamo", "man", "5677833448014" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moxy", "Funk", "pickled", "45284852406" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Olivia Newton-John", "Screamo", "apparel", "6578884993949" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Low Level Flight", "Glam Classical", "bicycle", "2093272270678" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Maow", "Emo", "etsy", "6962296118476" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Prince", "Brazillian Doo-Wop", "shorts", "4758487862888" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Martyr", "Acid Jazz", "way", "3219813221702" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Luke & The Apostles", "Doo-Wop", "rights", "1432375144880" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lotus Child", "Rock", "narwhal", "6730937169273" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Letters to Elora", "Caribbean Jazz", "echo", "8235857439337" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Genesis", "Jazz", "Marfa", "5756193444019" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50,
                columns: new[] { "Author", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lace", "post-ironic", "5555173687429" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "B'z", "Screamo", "life", "4737532145687" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Metric", "Screamo", "cosby", "8481092019230" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Santana", "House", "occupy", "2420131034413" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mr. Pine", "Kansas City Jazz", "williamsburg", "8654125541753" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Men Without Hats", "Hard Screamo", "pork", "2043584697900" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Most Serene Republic", "Modern Jazz", "semiotics", "2732203692538" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Miriodor", "Jazz", "craft", "7347847347775" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Metric", "African Easy Listening", "denim", "1740114079667" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Rihanna", "Doo-Wop", "Ethnic", "5438017302862" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Loverboy", "Asian Screamo", "park", "9963307566923" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moneyshot", "Kansas City Folk", "eye", "8785521862462" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Eminem", "Classic Rock", "chips", "9798436453472" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Phil Collins", "Jazz", "stumptown", "215018806147" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Liferuiner", "Emo", "mlkshk", "4507930611496" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lioness", "Blues", "Marfa", "8115255920270" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 66,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lime", "Jazzy R&B", "narwhal", "2570389459175" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 67,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Luyas", "African Grunge", "Messenger", "6497885089599" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 68,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mes Aïeux", "Grunge", "gentrify", "7720996298697" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 69,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Means", "Modern Jazz", "post-ironic", "8246596906448" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 70,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Last Man Out", "Hard Funk", "sweater", "2866657163420" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 71,
                columns: new[] { "Author", "CurrentHolder", "IsbnId" },
                values: new object[] { "Love and Sas", "photo", "5140607205750" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 72,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mecca Normal", "Jazz", "terry", "3207988349352" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 73,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Library Voices", "Blues", "out", "576347071014" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 74,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "ABBA", "Rock", "of", "2602954275255" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 75,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mecca Normal", "House", "raw", "624957890540" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 76,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Liferuiner", "Classical", "post-ironic", "6341556560407" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 77,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Marilyn's Vitamins", "Fresh Funk", "haven't", "4388080916548" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 78,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lionel Richie", "Rock", "park", "6391593472283" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 79,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Madonna", "Brazillian Blues", "cleanse", "6958482166267" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 80,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mudmen", "Blues", "life", "8814098881005" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 81,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mir", "Blues", "freegan", "207678023822" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 82,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Bruce Springsteen", "House", "fap", "9841521866545" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 83,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Martyr", "Jazz", "godard", "4614578473667" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 84,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Luther Wright and the Wrongs", "Asian Pop", "messenger", "412672693102" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 85,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Barry Manilow", "Pop", "8-bit", "9577980898124" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 86,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Britney Spears", "Glam Jazz", "life", "8729562279176" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 87,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lava Hay", "Brazillian Emo", "fund", "1551103015221" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 88,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Motion Ensemble", "Folk", "hella", "6529237146735" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 89,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "MacLean & MacLean", "Fresh Classical", "brooklyn", "2207444506793" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 90,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Marilyn's Vitamins", "Grunge", "shorts", "1772770454069" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 91,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Local Rabbits", "Blues", "kale", "9544064267326" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 92,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Latency", "Classical", "etsy", "3195180130747" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 93,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mudmen", "Jazz", "artisan", "1383853802170" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 94,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Loverboy", "Glam Blues", "small", "2976958580770" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 95,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mir", "African Rock", "dreamcatcher", "8522195689623" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 96,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Doors", "Screamo", "retro", "4042881240156" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 97,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Manvils", "Grunge", "narwhal", "9140686164209" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 98,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moneen", "Acid Easy Listening", "part", "9716798206659" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 99,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Means", "Hard Rock", "irony", "3905664642297" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 100,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Major Maker", "Doo-Wop", "tofu", "7911856462206" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 101,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Cher", "Screamo", "mumblecore", "2196922754960" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 102,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Martha and the Muffins", "Rock", "Vinyl", "6272373570256" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 103,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Queen", "Jazz", "art", "7251693232567" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 104,
                columns: new[] { "Author", "CurrentHolder", "IsbnId" },
                values: new object[] { "Live on Arrival", "bag", "151968980278" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 105,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mahogany Rush", "Kansas City Rock", "ennui", "7676999181358" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 106,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lee Harvey Osmond", "Grunge", "thing", "8791976496014" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 107,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Led Zeppelin", "Classic Jazz", "vegan", "5167177647895" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 108,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Machete Avenue", "Emo", "master", "7079609458837" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 109,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Prince", "Jazz", "semiotics", "5291600350891" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 110,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lost Dakotas", "Doo-Wop", "life", "2964460837172" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 111,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Red Hot Chili Peppers", "Classical", "on", "5606555475670" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 112,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Leahy", "Caribbean Easy Listening", "park", "8218686575171" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 113,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Bryan Adams", "African Easy Listening", "you", "2044064613079" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 114,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Neil Diamond", "Blues", "thing", "3886351121536" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 115,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Bon Jovi", "Rock", "cred", "7018062242780" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 116,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Who", "Grunge", "wayfarers", "6206432695596" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 117,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Elvis Presley", "Electronic Folk", "truffaut", "2446290679483" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 118,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Lovely Feathers", "Asian House", "Messenger", "7064778812725" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 119,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Rihanna", "Electronic Rock", "richardson", "2192382413052" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 120,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Memphis", "Brazillian Classical", "Four", "6648126340773" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 121,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lili Fatale", "Jazz", "vegan", "8281719143633" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 122,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mir", "Jazz", "farm-to-table", "7231080642543" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 123,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Billy Joel", "Rock", "marfa", "2775984491582" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 124,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Loverboy", "Classic Children's", "you", "3736259152058" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 125,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Lowest of the Low", "Emo", "ennui", "585025595773" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 126,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "LiveonRelease", "Caribbean Emo", "cleanse", "9207859774682" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 127,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Leigh Ashford", "Children's", "8-bit", "9086567246861" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 128,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Library Voices", "Avant-Garde Jazz", "vegan", "4861821189924" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 129,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Mahones", "House", "haven't", "1343191285311" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 130,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mythos", "Rock", "company", "3844509350063" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 131,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Matadors", "Blues", "eye", "4463303095876" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 132,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Memories Attack", "Screamo", "PBR", "1933715409568" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 133,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Mountains and the Trees", "Easy Listening", "dreamcatcher", "9748361529665" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 134,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Metalwood", "Rock", "jean", "6309058403740" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 135,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Leahy", "Jazzy Blues", "post-ironic", "3879608825724" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 136,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Tina Turner", "Classical", "out", "1197737153245" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 137,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Led Zeppelin", "Dance", "pickled", "9852261333657" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 138,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "L'Étranger", "Jazz", "park", "1725042193068" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 139,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Chicago", "Brazillian Blues", "Umami", "9998106211422" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 140,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mr. Pine", "Caribbean Jazz", "probably", "8048437101789" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 141,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Monster Voodoo Machine", "Folk", "high", "824817330960" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 142,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Olivia Newton-John", "Acid Emo", "cosby", "1733926256063" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 143,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Leslie Spit Treeo", "African Funk", "DIY", "8500069495523" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 144,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Julio Iglesias", "Dance", "thundercats", "6505416369300" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 145,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lava Hay", "Electronic Screamo", "narwhal", "3428647678079" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 146,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Marble Index", "Kansas City Folk", "post-ironic", "8587810391833" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 147,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Donna Summer", "Brazillian Grunge", "on", "8413548217347" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 148,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Leigh Ashford", "Rock", "eye", "4759935380313" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 149,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Moxy", "Pop", "farm-to-table", "3221329037668" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 150,
                columns: new[] { "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Kansas City Emo", "of", "9578195693706" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 151,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Garth Brooks", "Dance", "probably", "8859023260352" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 152,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Masochistic Religion", "Emo", "master", "9338340051164" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 153,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Latency", "African Jazz", "richardson", "4786848493286" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 154,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Barry Manilow", "Rock", "mlkshk", "4519971001204" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 155,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Neil Diamond", "Children's", "truffaut", "6892570018252" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 156,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Marilyn's Vitamins", "Kansas City Classical", "work", "2228274812096" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 157,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "L'Étranger", "Children's", "cray", "758821778352" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 158,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lioness", "Jazzy Emo", "american", "777866780188" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 159,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mir", "Caribbean R&B", "authentic", "6829376084184" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 160,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mes Aïeux", "African House", "park", "5731572106355" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 161,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Matadors", "Classical", "readymade", "6967841948833" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 162,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lee Harvey Osmond", "Jazz", "terry", "7567789157651" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 163,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Miriodor", "Jazz", "dreamcatcher", "2998850873205" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 164,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "New Kids on the Block", "Jazz", "heard", "8709523700508" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 165,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Limblifter", "Emo", "fanny", "5763590440975" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 166,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lime", "Emo", "shorts", "935272765781" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 167,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Little Girls", "Jazz", "stumptown", "5732757745186" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 168,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Matthew Good Band", "Glam Jazz", "etsy", "2997438909019" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 169,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Lace", "Emo", "day", "7269174995491" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 170,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mythos", "Easy Listening", "stumptown", "3082757789214" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 171,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Matadors", "Classic Emo", "brunch", "3616604061618" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 172,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Matt Mays & El Torpedo", "Jazz", "DIY", "7983681186094" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 173,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Martyr", "Children's", "Gluten-free", "4329105300982" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 174,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Merryweather", "Electronic Screamo", "echo", "1406378010942" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 175,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Memphis", "Asian Pop", "kale", "3085741709492" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 176,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Matthew Good Band", "Jazzy Doo-Wop", "tofu", "3810225587249" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 177,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Lovely Feathers", "House", "beer", "5993443846699" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 178,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Mark Inside", "House", "Iphone", "3533000821961" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 179,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Magneta Lane", "Brazillian Emo", "heard", "7570044173658" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 180,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Mariah Carey", "Jazz", "tofu", "9259647903619" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 181,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Pink Floyd", "Glam Emo", "organic", "8056744257014" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 182,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Bon Jovi", "Avant-Garde R&B", "before", "1589064566227" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 183,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Martha and the Muffins", "Jazz", "on", "8902924851934" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 184,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Paul McCartney", "Hard Emo", "pour-over", "9027428291285" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 185,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Olivia Newton-John", "Jazz", "raw", "2247918789390" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 186,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Chicago", "Emo", "trade", "2387395744392" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 187,
                columns: new[] { "Author", "CurrentHolder", "IsbnId" },
                values: new object[] { "Len", "etsy", "4409299615961" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 188,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Martyr", "Free Grunge", "future", "2490823228140" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 189,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Eminem", "Glam Easy Listening", "terry", "6678921085167" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 190,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Farm Fresh", "Brazillian R&B", "chips", "8913766713307" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 191,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Mark Inside", "Grunge", "etsy", "7701348074572" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 192,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Bee Gees", "Doo-Wop", "semiotics", "6336827253148" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 193,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Rolling Stones", "Acid Rock", "organic", "2158098808563" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 194,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Manvils", "Jazz", "VHS", "1528966804746" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 195,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "The Mohawk Lodge", "Kansas City Jazz", "bag", "8343027852635" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 196,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Garth Brooks", "Hard Pop", "part", "519460872988" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 197,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Chicago", "Rock", "fund", "5997508082537" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 198,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Barry Manilow", "Electronic Rock", "DIY", "7052978494694" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 199,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "Elvis Presley", "Acid Blues", "rights", "8004258628005" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 200,
                columns: new[] { "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[] { "McKenna Mendelson Mainline", "Funk", "mixtape", "9755807611977" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 201,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1983, 5, 6, 6, 9, 38, 0, DateTimeKind.Unspecified), "charlessimmons@libra.ry", "Charles", "5356 Anthony Street ", "Simmons", "they", "(719) 795-9333", new DateTime(2020, 4, 9, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(4576), "charlessimmons" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 202,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1976, 8, 10, 15, 33, 51, 0, DateTimeKind.Unspecified), "paigecox@libra.ry", "Paige", "9389 Berkeley Place ", "Cox", "vice", "(762) 212-5873", new DateTime(2019, 9, 19, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(6361), "paigecox" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 203,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1911, 6, 29, 9, 54, 10, 0, DateTimeKind.Unspecified), "petronilaadams@libra.ry", "Petronila", "1500 Gerritsen Avenue ", "Adams", "organic", "(237) 483-4614", new DateTime(2019, 1, 2, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(7011), "petronilaadams" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 204,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1941, 12, 16, 8, 30, 42, 0, DateTimeKind.Unspecified), "christopherhoward@libra.ry", "Christopher", "2660 Radde Place ", "Howard", "eye", "(548) 698-0818", new DateTime(2020, 2, 16, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(7692), "christopherhoward" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 205,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1997, 11, 25, 13, 48, 30, 0, DateTimeKind.Unspecified), "lesliebailey@libra.ry", "Leslie", "2136 Brighton Avenue ", "Bailey", "them", "(361) 276-4227", new DateTime(2018, 10, 22, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(8230), "lesliebailey" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 206,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1999, 1, 4, 8, 53, 48, 0, DateTimeKind.Unspecified), "jesusperez@libra.ry", "Jesus", "9015 Mc Kenny Street ", "Perez", "richardson", "(532) 271-3352", new DateTime(2020, 5, 19, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(8687), "jesusperez" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 207,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2015, 10, 5, 20, 34, 14, 0, DateTimeKind.Unspecified), "jordanallen@libra.ry", "Jordan", "9658 Bay 43rd Street ", "Allen", "post-ironic", "(215) 203-6990", new DateTime(2020, 10, 25, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(9283), "jordanallen" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 208,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1941, 1, 30, 8, 42, 51, 0, DateTimeKind.Unspecified), "leroybennett@libra.ry", "Leroy", "2879 Veterans Avenue ", "Bennett", "fixie", "(759) 468-9781", new DateTime(2018, 8, 28, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(43), "leroybennett" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 209,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1986, 12, 18, 18, 30, 45, 0, DateTimeKind.Unspecified), "michaeljames@libra.ry", "Michael", "8047 Suydam Street ", "James", "batch", "(408) 247-2316", new DateTime(2020, 11, 24, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(581), "michaeljames" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 210,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1958, 11, 8, 5, 56, 59, 0, DateTimeKind.Unspecified), "angiethomas@libra.ry", "Angie", "5080 Locust Street ", "Thomas", "richardson", "(459) 240-7306", new DateTime(2020, 1, 20, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(1165), "angiethomas" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 211,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2010, 2, 18, 7, 13, 27, 0, DateTimeKind.Unspecified), "rosshughes@libra.ry", "Ross", "5334 Argyle Road ", "Hughes", "of", "(543) 718-7302", new DateTime(2019, 10, 15, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(1688), "rosshughes" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 212,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2012, 7, 2, 6, 25, 59, 0, DateTimeKind.Unspecified), "katherinerivera@libra.ry", "Katherine", "688 Brighton 4th Street ", "Rivera", "VHS", "(703) 519-9958", new DateTime(2020, 11, 11, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(2224), "katherinerivera" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 213,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1928, 9, 23, 2, 40, 37, 0, DateTimeKind.Unspecified), "haileydiaz@libra.ry", "Hailey", "8523 College Place ", "Diaz", "world", "(266) 773-4338", new DateTime(2019, 9, 11, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(2759), "haileydiaz" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 214,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1966, 4, 28, 10, 46, 35, 0, DateTimeKind.Unspecified), "haileyrodriguez@libra.ry", "Hailey", "7562 Division Place ", "Rodriguez", "cleanse", "(240) 495-6278", new DateTime(2019, 9, 1, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(3251), "haileyrodriguez" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 215,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1985, 7, 12, 0, 24, 31, 0, DateTimeKind.Unspecified), "gabrielleward@libra.ry", "Gabrielle", "1037 Avenue T  ", "Ward", "sweater", "(509) 229-4408", new DateTime(2020, 4, 13, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(3723), "gabrielleward" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 216,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1933, 5, 11, 7, 18, 32, 0, DateTimeKind.Unspecified), "sophiaadams@libra.ry", "Sophia", "919 Hamilton Avenue ", "Adams", "beer", "(549) 322-9031", new DateTime(2019, 5, 27, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(4234), "sophiaadams" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 217,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1945, 12, 12, 7, 4, 49, 0, DateTimeKind.Unspecified), "allisontimms@libra.ry", "Allison", "9977 Engert Avenue ", "Timms", "Swag", "(514) 619-9813", new DateTime(2020, 8, 29, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(4715), "allisontimms" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 218,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1943, 4, 12, 1, 49, 49, 0, DateTimeKind.Unspecified), "pilarwalker@libra.ry", "Pilar", "828 Ludlam Place ", "Walker", "art", "(665) 482-5806", new DateTime(2019, 12, 29, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(5153), "pilarwalker" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 219,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1974, 6, 29, 1, 22, 33, 0, DateTimeKind.Unspecified), "victoriawhite@libra.ry", "Victoria", "776 Harbor View Terrace ", "White", "narwhal", "(419) 635-2293", new DateTime(2020, 10, 26, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(5616), "victoriawhite" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 220,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1963, 2, 13, 20, 52, 48, 0, DateTimeKind.Unspecified), "nicolereed@libra.ry", "Nicole", "7196 Avenue U  ", "Reed", "art", "(233) 440-6497", new DateTime(2019, 12, 22, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(6108), "nicolereed" });
        }
    }
}
