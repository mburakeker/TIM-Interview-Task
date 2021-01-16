using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class BooksAndMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    IsbnId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.IsbnId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "4053208708088", "Mood Ruff", "Emo", 3 },
                    { "2905131821899", "Lioness", "Glam Screamo", 3 },
                    { "3268605012903", "Garth Brooks", "Brazillian Doo-Wop", 3 },
                    { "1156142140123", "Lee Harvey Osmond", "Fresh Jazz", 3 },
                    { "4317281624230", "Means", "Folk", 3 },
                    { "6987342151711", "Neil Diamond", "Jazz", 3 },
                    { "0245039199332", "Merryweather", "Folk", 3 },
                    { "7206617686439", "Moneyshot", "Hard Screamo", 3 },
                    { "8262269554058", "Mother Mother", "R&B", 3 },
                    { "4453957138429", "Mother Mother", "Classic Emo", 3 },
                    { "5662232743791", "Library Voices", "Glam Folk", 3 },
                    { "6995329499600", "Elvis Presley", "Easy Listening", 3 },
                    { "3473785751211", "Liferuiner", "Rock", 3 },
                    { "5566906398319", "Celine Dion", "Folk", 3 },
                    { "4478821174195", "Fleetwood Mac", "Acid Easy Listening", 3 },
                    { "6798461575143", "Loco Locass", "Funk", 3 },
                    { "2059257451949", "Gloria Estefan", "Brazillian Dance", 3 },
                    { "1188300172847", "Main Source", "Glam Rock", 3 },
                    { "3156909665398", "Love Inc.", "Jazz", 3 },
                    { "2791783455559", "Barry Manilow", "Pop", 3 },
                    { "9360965912686", "Mountain City Four", "Jazz", 3 },
                    { "8701417637820", "Bruce Springsteen", "Avant-Garde Doo-Wop", 3 },
                    { "7268105464975", "Maow", "Brazillian Jazz", 3 },
                    { "2627724414986", "Moev", "Jazz", 3 },
                    { "9497788372324", "Tina Turner", "Free Blues", 3 },
                    { "0535181738780", "Moev", "Easy Listening", 3 },
                    { "8571935353435", "Lost & Profound", "Emo", 3 },
                    { "5242279184675", "Leigh Ashford", "Caribbean Screamo", 3 },
                    { "0713518882175", "Rihanna", "Dance", 3 },
                    { "9157011586801", "Santana", "Jazz", 3 },
                    { "7053379384215", "Mahogany Rush", "Rock", 3 },
                    { "0793743730731", "Merlin", "R&B", 3 },
                    { "2142212388549", "Santana", "Rock", 3 },
                    { "9382428694773", "Rod Stewart", "Funk", 3 },
                    { "5636008679806", "Phil Collins", "Blues", 3 },
                    { "3812153918461", "Lost & Profound", "Fresh Easy Listening", 3 },
                    { "8456765204352", "Farm Fresh", "Classical", 3 },
                    { "3495567494718", "Lightning Dust", "Screamo", 3 },
                    { "0101392207868", "Memphis", "Folk", 3 },
                    { "8786047772468", "Maow", "Rock", 3 },
                    { "9928069490939", "Loco Locass", "Jazz", 3 },
                    { "5439710592785", "Love Inc.", "Electronic Jazz", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "2841741893003", "Bruce Springsteen", "Classical", 3 },
                    { "6615979245247", "Martyr", "Free R&B", 3 },
                    { "6188516215028", "Mercey Brothers", "Blues", 3 },
                    { "6107649438467", "ABBA", "Classic Emo", 3 },
                    { "5737020026910", "B'z", "Classical", 3 },
                    { "1960336021238", "Lightning Dust", "Jazz", 3 },
                    { "7327181122599", "Men Without Hats", "Free R&B", 3 },
                    { "2161578609712", "Van Halen", "Jazz", 3 },
                    { "3844415653829", "The Look People", "Jazz", 3 },
                    { "4640710246634", "AC/DC", "Brazillian Emo", 3 },
                    { "6430970738932", "Miriodor", "Jazz", 3 },
                    { "7399240632891", "Led Zeppelin", "Electronic Grunge", 3 },
                    { "5829116000407", "Me Mom & Morgentaler", "Kansas City House", 3 },
                    { "7539835580166", "MonkeyJunk", "Classic Emo", 3 },
                    { "3203842063557", "Kiss", "Screamo", 3 },
                    { "6256991703664", "Letters to Elora", "Grunge", 3 },
                    { "7735294143653", "The Beatles", "Rock", 3 },
                    { "8917198149122", "Local Rabbits", "African Blues", 3 },
                    { "8345635602969", "Lillix", "Jazzy Easy Listening", 3 },
                    { "7654944003012", "Barry Manilow", "Hard House", 3 },
                    { "2795488209561", "Moneyshot", "Rock", 3 },
                    { "1619041811904", "MacLean & MacLean", "Avant-Garde Rock", 3 },
                    { "0955145297895", "Madonna", "Fresh Screamo", 3 },
                    { "8242156638664", "Moneyshot", "Rock", 3 },
                    { "3814552536735", "Moneyshot", "Classical", 3 },
                    { "5781632479079", "Linda Ronstadt", "Jazzy Easy Listening", 3 },
                    { "6590219265363", "Magneta Lane", "Screamo", 3 },
                    { "7924854199497", "The Rolling Stones", "R&B", 3 },
                    { "0399796089783", "AC/DC", "Jazz", 3 },
                    { "6123153102304", "The Mark Inside", "Jazz", 3 },
                    { "1811158027315", "Bruce Springsteen", "Rock", 3 },
                    { "1310820159771", "AC/DC", "Avant-Garde Rock", 3 },
                    { "6652482813138", "Lillix", "Emo", 3 },
                    { "9399576244305", "Queen", "House", 3 },
                    { "5332562175842", "The McDades", "Easy Listening", 3 },
                    { "9161811769616", "Genesis", "Jazzy Folk", 3 },
                    { "6814101856680", "Eagles", "Classic Screamo", 3 },
                    { "2729219517750", "Loverboy", "House", 3 },
                    { "0097333499778", "Paul McCartney", "African Folk", 3 },
                    { "1969525619148", "Mecca Normal", "Emo", 3 },
                    { "6015601034189", "Metallica", "Electronic Doo-Wop", 3 },
                    { "6921651387729", "The Lincolns", "Fresh Funk", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "7047692092493", "Leahy", "Classic Jazz", 3 },
                    { "5151040082085", "Frank Sinatra", "Brazillian Screamo", 3 },
                    { "1574430782965", "MSTRKRFT", "Classic Children's", 3 },
                    { "6136035548898", "The Moffatts", "Screamo", 3 },
                    { "2327575243796", "Billy Joel", "Easy Listening", 3 },
                    { "5911084701349", "Max Webster", "Rock", 3 },
                    { "0829562892381", "Luther Wright and the Wrongs", "Pop", 3 },
                    { "8512565691165", "Metalwood", "Hard Pop", 3 },
                    { "2495726113912", "Loco Locass", "Modern Jazz", 3 },
                    { "2909863242692", "Chicago", "Caribbean Rock", 3 },
                    { "0386243201930", "MacLean & MacLean", "Children's", 3 },
                    { "0195178164592", "Library Voices", "Emo", 3 },
                    { "9228353014826", "Van Halen", "Folk", 3 },
                    { "4537263667936", "Billy Joel", "Electronic Funk", 3 },
                    { "8921889535419", "Metalwood", "Classic House", 3 },
                    { "5740199898455", "Mare", "Emo", 3 },
                    { "2815603502290", "Guns N' Roses", "Classic Rock", 3 },
                    { "0911885895591", "Masochistic Religion", "Screamo", 3 },
                    { "9162730330865", "Barbra Streisand", "Rock", 3 },
                    { "0674489792946", "LMDS", "Screamo", 3 },
                    { "2791217547910", "Magneta Lane", "Classic R&B", 3 },
                    { "2826594898000", "The Carpenters", "Jazzy Doo-Wop", 3 },
                    { "5388426214145", "Mahogany Rush", "Blues", 3 },
                    { "4152609393947", "Library Voices", "Acid Classical", 3 },
                    { "4624103831040", "Michael Jackson", "Rock", 3 },
                    { "7242444566973", "Mes Aïeux", "Emo", 3 },
                    { "3278432379304", "The Rolling Stones", "Asian Jazz", 3 },
                    { "0126780640414", "Mes Aïeux", "Glam House", 3 },
                    { "0171611213274", "Linda Ronstadt", "Electronic Dance", 3 },
                    { "6479510271270", "Matthew Good Band", "Fresh Easy Listening", 3 },
                    { "6806688629575", "The McDades", "Grunge", 3 },
                    { "8515362841611", "Lillix", "Emo", 3 },
                    { "0676843280357", "U2", "House", 3 },
                    { "8304921484399", "My Darkest Days", "Jazz", 3 },
                    { "4586629051371", "Farm Fresh", "Doo-Wop", 3 },
                    { "8616632472025", "Luke & The Apostles", "Electronic Screamo", 3 },
                    { "9082105557417", "Last Man Out", "Glam R&B", 3 },
                    { "0769646655913", "MacLean & MacLean", "Children's", 3 },
                    { "3092429728206", "Kiss", "Blues", 3 },
                    { "1593465873565", "Lioness", "Jazz", 3 },
                    { "6081480646432", "Mir", "Children's", 3 },
                    { "7504066795806", "Julio Iglesias", "Folk", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "2852178166462", "Mobile", "Caribbean Easy Listening", 3 },
                    { "9708952959520", "George Michael", "Screamo", 3 },
                    { "3637449606108", "Men Without Hats", "Emo", 3 },
                    { "7120375065295", "L'Étranger", "Caribbean Blues", 3 },
                    { "7626453958416", "Garth Brooks", "Screamo", 3 },
                    { "2933456053539", "DJ Jazzy Jeff and the Fresh Prince", "Easy Listening", 3 },
                    { "7066015512041", "MCJ & Cool G", "Jazz", 3 },
                    { "6524093145904", "Mir", "Kansas City Rock", 3 },
                    { "9074430958949", "Moneyshot", "Hard Easy Listening", 3 },
                    { "6501338053780", "Bruce Springsteen", "Rock", 3 },
                    { "5489695844560", "The Moffatts", "Classical", 3 },
                    { "2783084748903", "Linda Ronstadt", "Folk", 3 },
                    { "7494505052909", "Love Kills", "Rock", 3 },
                    { "1762948941743", "Mystery", "Jazzy Pop", 3 },
                    { "0819247943531", "Lola Dutronic", "Rock", 3 },
                    { "6903769515914", "The Lemon Bucket Orkestra", "Acid Folk", 3 },
                    { "5699856182877", "AC/DC", "Modern Pop", 3 },
                    { "4157326349025", "Main Source", "Rock", 3 },
                    { "0653652554570", "My Darkest Days", "Emo", 3 },
                    { "4348655291203", "Mother Mother", "Jazzy Children's", 3 },
                    { "2135349001373", "The Mynah Birds", "Avant-Garde Screamo", 3 },
                    { "0119074835483", "Love and Sas", "Glam Doo-Wop", 3 },
                    { "7960990752169", "Means", "Rock", 3 },
                    { "3819329703987", "Matthew Good Band", "Emo", 3 },
                    { "7490497757676", "MCJ & Cool G", "Emo", 3 },
                    { "6754085902991", "The Beatles", "Free Grunge", 3 },
                    { "4731175461971", "The Manvils", "Fresh R&B", 3 },
                    { "0636809874049", "Manic Drive", "Free Rock", 3 },
                    { "1497973867690", "Rihanna", "Blues", 3 },
                    { "5684399411642", "Cher", "Blues", 3 },
                    { "2574262163771", "Mes Aïeux", "Jazzy Rock", 3 },
                    { "5763464318612", "The Beatles", "Free Easy Listening", 3 },
                    { "3642083755214", "Mystery Machine", "Grunge", 3 },
                    { "0446410208523", "My Darkest Days", "Funk", 3 },
                    { "4685266556404", "Mare", "Hard Rock", 3 },
                    { "5357857609282", "The Mark Inside", "House", 3 },
                    { "8010146731672", "Paul McCartney", "Emo", 3 },
                    { "1678255790439", "Van Halen", "Fresh Blues", 3 },
                    { "7612422780986", "The Matadors", "Folk", 3 },
                    { "3308310694368", "Lola Dutronic", "Jazzy Doo-Wop", 3 },
                    { "1530480171953", "Pink Floyd", "Emo", 3 },
                    { "9341509200767", "The Doors", "Electronic Rock", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "0555312943785", "Major Maker", "Pop", 3 },
                    { "4934546959286", "Moist", "House", 3 },
                    { "5466688449601", "The Mountains and the Trees", "Blues", 3 },
                    { "8850800721815", "Mandala", "Brazillian Jazz", 3 },
                    { "4827219927399", "Last Man Out", "Caribbean Blues", 3 },
                    { "2021708073360", "DJ Jazzy Jeff and the Fresh Prince", "Emo", 3 },
                    { "9076551524338", "Leigh Ashford", "Modern Dance", 3 },
                    { "8720923894270", "Mudmen", "Electronic Emo", 3 },
                    { "5368379164759", "Elvis Presley", "Classic Classical", 3 },
                    { "1109392098248", "Maow", "Asian Children's", 3 },
                    { "4640707655725", "McKenna Mendelson Mainline", "Acid Easy Listening", 3 },
                    { "4856997561464", "Mother Mother", "R&B", 3 },
                    { "4274109223306", "The McDades", "Asian Emo", 3 },
                    { "1196572045858", "Love Inc.", "Jazz", 3 },
                    { "9010370380604", "Lost & Profound", "Children's", 3 },
                    { "8047699612898", "Moneen", "Electronic Jazz", 3 },
                    { "6878726442741", "Manic Drive", "Doo-Wop", 3 },
                    { "8807391485237", "Leahy", "Fresh Screamo", 3 },
                    { "8602428353227", "The Beatles", "Doo-Wop", 3 },
                    { "5165703354430", "U2", "Asian Rock", 3 },
                    { "9736771776761", "Moxy Früvous", "Pop", 3 },
                    { "3545651584291", "The Marble Index", "Emo", 3 },
                    { "3112051526210", "Eminem", "Modern Jazz", 3 },
                    { "4940224251008", "Len", "Screamo", 3 },
                    { "4039417048753", "Merlin", "Acid Emo", 3 },
                    { "4803233737480", "Motion Ensemble", "Dance", 3 },
                    { "1782912548024", "Red Hot Chili Peppers", "Screamo", 3 },
                    { "2790673142857", "Love and Sas", "Modern R&B", 3 },
                    { "0604343832214", "Machete Avenue", "Jazz", 3 },
                    { "7363697803667", "The Meligrove Band", "Jazz", 3 },
                    { "0937171329033", "Liferuiner", "Emo", 3 },
                    { "6457644046201", "The Manvils", "Electronic Rock", 3 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[,]
                {
                    { 18, new DateTime(1956, 9, 29, 2, 4, 23, 0, DateTimeKind.Unspecified), "rileywatson@libra.ry", "Riley", "1187 Morgan Avenue ", "Watson", "richardson", "(391) 364-4306", new DateTime(2020, 12, 8, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(7388), "rileywatson" },
                    { 11, new DateTime(1907, 5, 5, 10, 23, 37, 0, DateTimeKind.Unspecified), "lilliansmith@libra.ry", "Lillian", "5792 Elliott Place ", "Smith", "pickled", "(453) 676-3153", new DateTime(2018, 8, 30, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(4080), "lilliansmith" },
                    { 17, new DateTime(1918, 11, 13, 19, 15, 46, 0, DateTimeKind.Unspecified), "annaevans@libra.ry", "Anna", "8224 Pershing Loop ", "Evans", "you", "(457) 515-8617", new DateTime(2019, 9, 7, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(6911), "annaevans" },
                    { 16, new DateTime(1921, 4, 27, 8, 45, 58, 0, DateTimeKind.Unspecified), "oliviawilliams@libra.ry", "Olivia", "9724 Turnbull Avenue ", "Williams", "forage", "(355) 570-9072", new DateTime(2018, 9, 18, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(6433), "oliviawilliams" },
                    { 15, new DateTime(1940, 2, 27, 10, 46, 54, 0, DateTimeKind.Unspecified), "gabrielroberts@libra.ry", "Gabriel", "9557 Lancaster Avenue ", "Roberts", "hella", "(304) 357-1412", new DateTime(2019, 3, 4, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(5935), "gabrielroberts" },
                    { 14, new DateTime(1983, 7, 2, 21, 43, 44, 0, DateTimeKind.Unspecified), "josephcoleman@libra.ry", "Joseph", "7966 Cranberry Street ", "Coleman", "narwhal", "(378) 277-3884", new DateTime(2019, 2, 25, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(5499), "josephcoleman" },
                    { 13, new DateTime(1908, 1, 14, 14, 21, 25, 0, DateTimeKind.Unspecified), "brandonhall@libra.ry", "Brandon", "8869 Kansas Place ", "Hall", "truffaut", "(519) 367-0346", new DateTime(2019, 10, 5, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(5042), "brandonhall" },
                    { 12, new DateTime(1962, 12, 4, 1, 27, 36, 0, DateTimeKind.Unspecified), "christopherwood@libra.ry", "Christopher", "8155 Tudor Terrace ", "Wood", "pour-over", "(487) 368-4205", new DateTime(2019, 7, 3, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(4565), "christopherwood" },
                    { 10, new DateTime(2011, 12, 12, 18, 35, 17, 0, DateTimeKind.Unspecified), "samuelpearson@libra.ry", "Samuel", "9573 Neptune Avenue ", "Pearson", "pork", "(685) 673-8958", new DateTime(2018, 12, 31, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(3646), "samuelpearson" },
                    { 5, new DateTime(1902, 8, 10, 14, 11, 15, 0, DateTimeKind.Unspecified), "kaylamartinez@libra.ry", "Kayla", "5950 28th Street ", "Martinez", "Iphone", "(230) 670-1474", new DateTime(2019, 11, 12, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(1254), "kaylamartinez" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[,]
                {
                    { 8, new DateTime(1948, 10, 3, 11, 32, 3, 0, DateTimeKind.Unspecified), "laurenadams@libra.ry", "Lauren", "1649 Hull Street ", "Adams", "bicycle", "(608) 416-2123", new DateTime(2018, 10, 30, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(2698), "laurenadams" },
                    { 7, new DateTime(2016, 2, 8, 10, 15, 27, 0, DateTimeKind.Unspecified), "victorramirez@libra.ry", "Victor", "9105 Paerdegat 2nd Street ", "Ramirez", "on", "(373) 690-1248", new DateTime(2020, 6, 26, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(2178), "victorramirez" },
                    { 6, new DateTime(1971, 9, 17, 0, 5, 14, 0, DateTimeKind.Unspecified), "shelbymorris@libra.ry", "Shelby", "6935 Paerdegat 5th Street ", "Morris", "Lomo", "(446) 316-3679", new DateTime(2018, 7, 7, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(1721), "shelbymorris" },
                    { 4, new DateTime(1944, 7, 5, 23, 26, 28, 0, DateTimeKind.Unspecified), "evelyncarter@libra.ry", "Evelyn", "7998 Hart Street ", "Carter", "tofu", "(435) 220-7333", new DateTime(2019, 2, 12, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(778), "evelyncarter" },
                    { 3, new DateTime(1918, 5, 3, 2, 12, 59, 0, DateTimeKind.Unspecified), "coleıginla@libra.ry", "Cole", "4763 Vanderbilt Street ", "Iginla", "narwhal", "(469) 579-1947", new DateTime(2020, 1, 23, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(201), "coleıginla" },
                    { 2, new DateTime(1939, 2, 20, 7, 14, 23, 0, DateTimeKind.Unspecified), "josefoster@libra.ry", "Jose", "991 Atkins Avenue ", "Foster", "place", "(541) 471-2782", new DateTime(2018, 10, 25, 19, 50, 15, 423, DateTimeKind.Local).AddTicks(9674), "josefoster" },
                    { 1, new DateTime(1968, 4, 7, 12, 29, 12, 0, DateTimeKind.Unspecified), "saramackenzie@libra.ry", "Sara", "129 Norfolk Street ", "MacKenzie", "year", "(466) 555-5895", new DateTime(2018, 7, 7, 19, 50, 15, 423, DateTimeKind.Local).AddTicks(7177), "saramackenzie" },
                    { 19, new DateTime(1960, 3, 6, 17, 55, 49, 0, DateTimeKind.Unspecified), "brycecollins@libra.ry", "Bryce", "950 Erskine Loop ", "Collins", "womn", "(399) 628-7979", new DateTime(2018, 4, 30, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(7820), "brycecollins" },
                    { 9, new DateTime(1972, 10, 2, 2, 7, 39, 0, DateTimeKind.Unspecified), "bryanmartinez@libra.ry", "Bryan", "3470 Ocean Court ", "Martinez", "way", "(214) 563-1547", new DateTime(2019, 2, 8, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(3166), "bryanmartinez" },
                    { 20, new DateTime(1937, 8, 18, 21, 45, 28, 0, DateTimeKind.Unspecified), "alyssaedwards@libra.ry", "Alyssa", "7954 Withers Street ", "Edwards", "terry", "(575) 780-9267", new DateTime(2020, 6, 29, 19, 50, 15, 424, DateTimeKind.Local).AddTicks(8275), "alyssaedwards" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
