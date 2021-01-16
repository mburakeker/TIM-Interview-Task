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
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsbnId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentHolder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
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
                columns: new[] { "BookId", "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[,]
                {
                    { 1, "Moev", "Funk", "pack", "9557715328204" },
                    { 129, "The Mahones", "House", "haven't", "1343191285311" },
                    { 130, "Mythos", "Rock", "company", "3844509350063" },
                    { 131, "The Matadors", "Blues", "eye", "4463303095876" },
                    { 132, "The Memories Attack", "Screamo", "PBR", "1933715409568" },
                    { 133, "The Mountains and the Trees", "Easy Listening", "dreamcatcher", "9748361529665" },
                    { 134, "Metalwood", "Rock", "jean", "6309058403740" },
                    { 135, "Leahy", "Jazzy Blues", "post-ironic", "3879608825724" },
                    { 136, "Tina Turner", "Classical", "out", "1197737153245" },
                    { 137, "Led Zeppelin", "Dance", "pickled", "9852261333657" },
                    { 138, "L'Étranger", "Jazz", "park", "1725042193068" },
                    { 139, "Chicago", "Brazillian Blues", "Umami", "9998106211422" },
                    { 140, "Mr. Pine", "Caribbean Jazz", "probably", "8048437101789" },
                    { 141, "Monster Voodoo Machine", "Folk", "high", "824817330960" },
                    { 142, "Olivia Newton-John", "Acid Emo", "cosby", "1733926256063" },
                    { 143, "Leslie Spit Treeo", "African Funk", "DIY", "8500069495523" },
                    { 144, "Julio Iglesias", "Dance", "thundercats", "6505416369300" },
                    { 145, "Lava Hay", "Electronic Screamo", "narwhal", "3428647678079" },
                    { 146, "The Marble Index", "Kansas City Folk", "post-ironic", "8587810391833" },
                    { 147, "Donna Summer", "Brazillian Grunge", "on", "8413548217347" },
                    { 148, "Leigh Ashford", "Rock", "eye", "4759935380313" },
                    { 149, "Moxy", "Pop", "farm-to-table", "3221329037668" },
                    { 128, "Library Voices", "Avant-Garde Jazz", "vegan", "4861821189924" },
                    { 150, "The McDades", "Kansas City Emo", "of", "9578195693706" },
                    { 127, "Leigh Ashford", "Children's", "8-bit", "9086567246861" },
                    { 125, "The Lowest of the Low", "Emo", "ennui", "585025595773" },
                    { 103, "Queen", "Jazz", "art", "7251693232567" },
                    { 104, "Live on Arrival", "R&B", "bag", "151968980278" },
                    { 105, "Mahogany Rush", "Kansas City Rock", "ennui", "7676999181358" },
                    { 106, "Lee Harvey Osmond", "Grunge", "thing", "8791976496014" },
                    { 107, "Led Zeppelin", "Classic Jazz", "vegan", "5167177647895" },
                    { 108, "Machete Avenue", "Emo", "master", "7079609458837" },
                    { 109, "Prince", "Jazz", "semiotics", "5291600350891" },
                    { 111, "Red Hot Chili Peppers", "Classical", "on", "5606555475670" },
                    { 112, "Leahy", "Caribbean Easy Listening", "park", "8218686575171" },
                    { 113, "Bryan Adams", "African Easy Listening", "you", "2044064613079" },
                    { 114, "Neil Diamond", "Blues", "thing", "3886351121536" },
                    { 115, "Bon Jovi", "Rock", "cred", "7018062242780" },
                    { 116, "The Who", "Grunge", "wayfarers", "6206432695596" },
                    { 117, "Elvis Presley", "Electronic Folk", "truffaut", "2446290679483" },
                    { 118, "The Lovely Feathers", "Asian House", "Messenger", "7064778812725" },
                    { 119, "Rihanna", "Electronic Rock", "richardson", "2192382413052" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[,]
                {
                    { 120, "Memphis", "Brazillian Classical", "Four", "6648126340773" },
                    { 121, "Lili Fatale", "Jazz", "vegan", "8281719143633" },
                    { 122, "Mir", "Jazz", "farm-to-table", "7231080642543" },
                    { 123, "Billy Joel", "Rock", "marfa", "2775984491582" },
                    { 124, "Loverboy", "Classic Children's", "you", "3736259152058" },
                    { 126, "LiveonRelease", "Caribbean Emo", "cleanse", "9207859774682" },
                    { 151, "Garth Brooks", "Dance", "probably", "8859023260352" },
                    { 152, "Masochistic Religion", "Emo", "master", "9338340051164" },
                    { 153, "The Latency", "African Jazz", "richardson", "4786848493286" },
                    { 180, "Mariah Carey", "Jazz", "tofu", "9259647903619" },
                    { 181, "Pink Floyd", "Glam Emo", "organic", "8056744257014" },
                    { 182, "Bon Jovi", "Avant-Garde R&B", "before", "1589064566227" },
                    { 183, "Martha and the Muffins", "Jazz", "on", "8902924851934" },
                    { 184, "Paul McCartney", "Hard Emo", "pour-over", "9027428291285" },
                    { 185, "Olivia Newton-John", "Jazz", "raw", "2247918789390" },
                    { 186, "Chicago", "Emo", "trade", "2387395744392" },
                    { 187, "Len", "Emo", "etsy", "4409299615961" },
                    { 188, "Martyr", "Free Grunge", "future", "2490823228140" },
                    { 189, "Eminem", "Glam Easy Listening", "terry", "6678921085167" },
                    { 190, "Farm Fresh", "Brazillian R&B", "chips", "8913766713307" },
                    { 191, "The Mark Inside", "Grunge", "etsy", "7701348074572" },
                    { 192, "Bee Gees", "Doo-Wop", "semiotics", "6336827253148" },
                    { 193, "The Rolling Stones", "Acid Rock", "organic", "2158098808563" },
                    { 194, "The Manvils", "Jazz", "VHS", "1528966804746" },
                    { 195, "The Mohawk Lodge", "Kansas City Jazz", "bag", "8343027852635" },
                    { 196, "Garth Brooks", "Hard Pop", "part", "519460872988" },
                    { 197, "Chicago", "Rock", "fund", "5997508082537" },
                    { 198, "Barry Manilow", "Electronic Rock", "DIY", "7052978494694" },
                    { 199, "Elvis Presley", "Acid Blues", "rights", "8004258628005" },
                    { 200, "McKenna Mendelson Mainline", "Funk", "mixtape", "9755807611977" },
                    { 179, "Magneta Lane", "Brazillian Emo", "heard", "7570044173658" },
                    { 178, "The Mark Inside", "House", "Iphone", "3533000821961" },
                    { 177, "The Lovely Feathers", "House", "beer", "5993443846699" },
                    { 176, "Matthew Good Band", "Jazzy Doo-Wop", "tofu", "3810225587249" },
                    { 154, "Barry Manilow", "Rock", "mlkshk", "4519971001204" },
                    { 155, "Neil Diamond", "Children's", "truffaut", "6892570018252" },
                    { 156, "Marilyn's Vitamins", "Kansas City Classical", "work", "2228274812096" },
                    { 157, "L'Étranger", "Children's", "cray", "758821778352" },
                    { 158, "Lioness", "Jazzy Emo", "american", "777866780188" },
                    { 159, "Mir", "Caribbean R&B", "authentic", "6829376084184" },
                    { 160, "Mes Aïeux", "African House", "park", "5731572106355" },
                    { 161, "The Matadors", "Classical", "readymade", "6967841948833" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[,]
                {
                    { 162, "Lee Harvey Osmond", "Jazz", "terry", "7567789157651" },
                    { 163, "Miriodor", "Jazz", "dreamcatcher", "2998850873205" },
                    { 102, "Martha and the Muffins", "Rock", "Vinyl", "6272373570256" },
                    { 164, "New Kids on the Block", "Jazz", "heard", "8709523700508" },
                    { 166, "Lime", "Emo", "shorts", "935272765781" },
                    { 167, "Little Girls", "Jazz", "stumptown", "5732757745186" },
                    { 168, "Matthew Good Band", "Glam Jazz", "etsy", "2997438909019" },
                    { 169, "Lace", "Emo", "day", "7269174995491" },
                    { 170, "Mythos", "Easy Listening", "stumptown", "3082757789214" },
                    { 171, "The Matadors", "Classic Emo", "brunch", "3616604061618" },
                    { 172, "Matt Mays & El Torpedo", "Jazz", "DIY", "7983681186094" },
                    { 173, "Martyr", "Children's", "Gluten-free", "4329105300982" },
                    { 174, "Merryweather", "Electronic Screamo", "echo", "1406378010942" },
                    { 175, "Memphis", "Asian Pop", "kale", "3085741709492" },
                    { 165, "Limblifter", "Emo", "fanny", "5763590440975" },
                    { 101, "Cher", "Screamo", "mumblecore", "2196922754960" },
                    { 110, "Lost Dakotas", "Doo-Wop", "life", "2964460837172" },
                    { 99, "Means", "Hard Rock", "irony", "3905664642297" },
                    { 28, "Matthew Good Band", "Funk", "richardson", "3108339218007" },
                    { 29, "Letters to Elora", "Pop", "haven't", "8705413680852" },
                    { 30, "Magneta Lane", "Jazz", "pour-over", "7053080344131" },
                    { 31, "The Lovely Feathers", "Folk", "company", "9948221598727" },
                    { 32, "Paul McCartney", "Screamo", "work", "6708801349955" },
                    { 33, "Elton John", "Rock", "mustache", "7920929988809" },
                    { 34, "Moxy", "Rock", "loko", "6988596505014" },
                    { 35, "Major Maker", "Easy Listening", "cray", "7242541446929" },
                    { 36, "Mahogany Rush", "Kansas City Dance", "company", "9629478915421" },
                    { 37, "Cher", "Kansas City Grunge", "artisan", "7672861510735" },
                    { 38, "Mean Red Spiders", "Brazillian Grunge", "keffiyeh", "9559438405353" },
                    { 39, "Lillix", "Acid Screamo", "man", "5677833448014" },
                    { 40, "Moxy", "Funk", "pickled", "45284852406" },
                    { 100, "Major Maker", "Doo-Wop", "tofu", "7911856462206" },
                    { 42, "Low Level Flight", "Glam Classical", "bicycle", "2093272270678" },
                    { 43, "Maow", "Emo", "etsy", "6962296118476" },
                    { 44, "Prince", "Brazillian Doo-Wop", "shorts", "4758487862888" },
                    { 45, "Martyr", "Acid Jazz", "way", "3219813221702" },
                    { 46, "Luke & The Apostles", "Doo-Wop", "rights", "1432375144880" },
                    { 47, "Lotus Child", "Rock", "narwhal", "6730937169273" },
                    { 48, "Letters to Elora", "Caribbean Jazz", "echo", "8235857439337" },
                    { 27, "R.E.M.", "Rock", "gastropub", "814946606203" },
                    { 26, "Moxy", "R&B", "of", "9676182493416" },
                    { 25, "Luke & The Apostles", "African Folk", "way", "2984041326206" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[,]
                {
                    { 24, "DJ Jazzy Jeff and the Fresh Prince", "Jazz", "raw", "2915862688289" },
                    { 2, "The MRQ", "Pop", "post-ironic", "3973063283587" },
                    { 3, "Martha and the Muffins", "Kansas City Pop", "life", "7393544068277" },
                    { 4, "Moist", "Avant-Garde Easy Listening", "skateboard", "1159625929388" },
                    { 5, "Mes Aïeux", "R&B", "world", "2377057360660" },
                    { 6, "Cher", "Dance", "richardson", "2338035768986" },
                    { 7, "Lotus Child", "Fresh Funk", "carles", "5644342971800" },
                    { 8, "Chicago", "African Funk", "company", "1657999787320" },
                    { 9, "Lightning Dust", "Funk", "seitan", "4298578255948" },
                    { 10, "The Memories Attack", "Hard Emo", "batch", "801044819318" },
                    { 11, "Mystery", "Glam Jazz", "womn", "2016758109450" },
                    { 49, "Genesis", "Jazz", "Marfa", "5756193444019" },
                    { 12, "LMDS", "Funk", "direct", "7156382378729" },
                    { 14, "Moev", "Jazz", "haven't", "8226705653698" },
                    { 15, "The Luyas", "Funk", "park", "5233703379162" },
                    { 16, "Kate and Anna McGarrigle", "Jazz", "occupy", "5551036016806" },
                    { 17, "Barry Manilow", "Brazillian Children's", "booth", "5504994055025" },
                    { 18, "The Look People", "Free Rock", "Polaroid", "8991747819349" },
                    { 19, "Madonna", "Jazzy Jazz", "organic", "5385806427982" },
                    { 20, "AC/DC", "Acid Rock", "it", "9941410184810" },
                    { 21, "Madonna", "Emo", "semiotics", "1172396131405" },
                    { 22, "Led Zeppelin", "Emo", "portland", "4087944335345" },
                    { 23, "Manteca", "Classic Funk", "pork", "3887648635491" },
                    { 13, "Eagles", "Fresh Pop", "government", "7447160104032" },
                    { 50, "Lace", "Grunge", "post-ironic", "5555173687429" },
                    { 41, "Olivia Newton-John", "Screamo", "apparel", "6578884993949" },
                    { 52, "Metric", "Screamo", "cosby", "8481092019230" },
                    { 78, "Lionel Richie", "Rock", "park", "6391593472283" },
                    { 79, "Madonna", "Brazillian Blues", "cleanse", "6958482166267" },
                    { 80, "Mudmen", "Blues", "life", "8814098881005" },
                    { 81, "Mir", "Blues", "freegan", "207678023822" },
                    { 82, "Bruce Springsteen", "House", "fap", "9841521866545" },
                    { 83, "Martyr", "Jazz", "godard", "4614578473667" },
                    { 84, "Luther Wright and the Wrongs", "Asian Pop", "messenger", "412672693102" },
                    { 51, "B'z", "Screamo", "life", "4737532145687" },
                    { 86, "Britney Spears", "Glam Jazz", "life", "8729562279176" },
                    { 87, "Lava Hay", "Brazillian Emo", "fund", "1551103015221" },
                    { 88, "Motion Ensemble", "Folk", "hella", "6529237146735" },
                    { 89, "MacLean & MacLean", "Fresh Classical", "brooklyn", "2207444506793" },
                    { 90, "Marilyn's Vitamins", "Grunge", "shorts", "1772770454069" },
                    { 91, "Local Rabbits", "Blues", "kale", "9544064267326" },
                    { 92, "The Latency", "Classical", "etsy", "3195180130747" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookName", "CurrentHolder", "IsbnId" },
                values: new object[,]
                {
                    { 93, "Mudmen", "Jazz", "artisan", "1383853802170" },
                    { 94, "Loverboy", "Glam Blues", "small", "2976958580770" },
                    { 95, "Mir", "African Rock", "dreamcatcher", "8522195689623" },
                    { 96, "The Doors", "Screamo", "retro", "4042881240156" },
                    { 97, "The Manvils", "Grunge", "narwhal", "9140686164209" },
                    { 98, "Moneen", "Acid Easy Listening", "part", "9716798206659" },
                    { 77, "Marilyn's Vitamins", "Fresh Funk", "haven't", "4388080916548" },
                    { 76, "Liferuiner", "Classical", "post-ironic", "6341556560407" },
                    { 85, "Barry Manilow", "Pop", "8-bit", "9577980898124" },
                    { 74, "ABBA", "Rock", "of", "2602954275255" },
                    { 53, "Santana", "House", "occupy", "2420131034413" },
                    { 75, "Mecca Normal", "House", "raw", "624957890540" },
                    { 55, "Men Without Hats", "Hard Screamo", "pork", "2043584697900" },
                    { 56, "The Most Serene Republic", "Modern Jazz", "semiotics", "2732203692538" },
                    { 57, "Miriodor", "Jazz", "craft", "7347847347775" },
                    { 58, "Metric", "African Easy Listening", "denim", "1740114079667" },
                    { 59, "Rihanna", "Doo-Wop", "Ethnic", "5438017302862" },
                    { 60, "Loverboy", "Asian Screamo", "park", "9963307566923" },
                    { 61, "Moneyshot", "Kansas City Folk", "eye", "8785521862462" },
                    { 62, "Eminem", "Classic Rock", "chips", "9798436453472" },
                    { 54, "Mr. Pine", "Kansas City Jazz", "williamsburg", "8654125541753" },
                    { 64, "Liferuiner", "Emo", "mlkshk", "4507930611496" },
                    { 63, "Phil Collins", "Jazz", "stumptown", "215018806147" },
                    { 73, "Library Voices", "Blues", "out", "576347071014" },
                    { 71, "Love and Sas", "Rock", "photo", "5140607205750" },
                    { 70, "Last Man Out", "Hard Funk", "sweater", "2866657163420" },
                    { 69, "Means", "Modern Jazz", "post-ironic", "8246596906448" },
                    { 72, "Mecca Normal", "Jazz", "terry", "3207988349352" },
                    { 67, "The Luyas", "African Grunge", "Messenger", "6497885089599" },
                    { 66, "Lime", "Jazzy R&B", "narwhal", "2570389459175" },
                    { 65, "Lioness", "Blues", "Marfa", "8115255920270" },
                    { 68, "Mes Aïeux", "Grunge", "gentrify", "7720996298697" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[,]
                {
                    { 218, new DateTime(1943, 4, 12, 1, 49, 49, 0, DateTimeKind.Unspecified), "pilarwalker@libra.ry", "Pilar", "828 Ludlam Place ", "Walker", "art", "(665) 482-5806", new DateTime(2019, 12, 29, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(5153), "pilarwalker" },
                    { 211, new DateTime(2010, 2, 18, 7, 13, 27, 0, DateTimeKind.Unspecified), "rosshughes@libra.ry", "Ross", "5334 Argyle Road ", "Hughes", "of", "(543) 718-7302", new DateTime(2019, 10, 15, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(1688), "rosshughes" },
                    { 217, new DateTime(1945, 12, 12, 7, 4, 49, 0, DateTimeKind.Unspecified), "allisontimms@libra.ry", "Allison", "9977 Engert Avenue ", "Timms", "Swag", "(514) 619-9813", new DateTime(2020, 8, 29, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(4715), "allisontimms" },
                    { 216, new DateTime(1933, 5, 11, 7, 18, 32, 0, DateTimeKind.Unspecified), "sophiaadams@libra.ry", "Sophia", "919 Hamilton Avenue ", "Adams", "beer", "(549) 322-9031", new DateTime(2019, 5, 27, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(4234), "sophiaadams" },
                    { 215, new DateTime(1985, 7, 12, 0, 24, 31, 0, DateTimeKind.Unspecified), "gabrielleward@libra.ry", "Gabrielle", "1037 Avenue T  ", "Ward", "sweater", "(509) 229-4408", new DateTime(2020, 4, 13, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(3723), "gabrielleward" },
                    { 214, new DateTime(1966, 4, 28, 10, 46, 35, 0, DateTimeKind.Unspecified), "haileyrodriguez@libra.ry", "Hailey", "7562 Division Place ", "Rodriguez", "cleanse", "(240) 495-6278", new DateTime(2019, 9, 1, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(3251), "haileyrodriguez" },
                    { 213, new DateTime(1928, 9, 23, 2, 40, 37, 0, DateTimeKind.Unspecified), "haileydiaz@libra.ry", "Hailey", "8523 College Place ", "Diaz", "world", "(266) 773-4338", new DateTime(2019, 9, 11, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(2759), "haileydiaz" },
                    { 212, new DateTime(2012, 7, 2, 6, 25, 59, 0, DateTimeKind.Unspecified), "katherinerivera@libra.ry", "Katherine", "688 Brighton 4th Street ", "Rivera", "VHS", "(703) 519-9958", new DateTime(2020, 11, 11, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(2224), "katherinerivera" },
                    { 210, new DateTime(1958, 11, 8, 5, 56, 59, 0, DateTimeKind.Unspecified), "angiethomas@libra.ry", "Angie", "5080 Locust Street ", "Thomas", "richardson", "(459) 240-7306", new DateTime(2020, 1, 20, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(1165), "angiethomas" },
                    { 205, new DateTime(1997, 11, 25, 13, 48, 30, 0, DateTimeKind.Unspecified), "lesliebailey@libra.ry", "Leslie", "2136 Brighton Avenue ", "Bailey", "them", "(361) 276-4227", new DateTime(2018, 10, 22, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(8230), "lesliebailey" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[,]
                {
                    { 208, new DateTime(1941, 1, 30, 8, 42, 51, 0, DateTimeKind.Unspecified), "leroybennett@libra.ry", "Leroy", "2879 Veterans Avenue ", "Bennett", "fixie", "(759) 468-9781", new DateTime(2018, 8, 28, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(43), "leroybennett" },
                    { 207, new DateTime(2015, 10, 5, 20, 34, 14, 0, DateTimeKind.Unspecified), "jordanallen@libra.ry", "Jordan", "9658 Bay 43rd Street ", "Allen", "post-ironic", "(215) 203-6990", new DateTime(2020, 10, 25, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(9283), "jordanallen" },
                    { 206, new DateTime(1999, 1, 4, 8, 53, 48, 0, DateTimeKind.Unspecified), "jesusperez@libra.ry", "Jesus", "9015 Mc Kenny Street ", "Perez", "richardson", "(532) 271-3352", new DateTime(2020, 5, 19, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(8687), "jesusperez" },
                    { 204, new DateTime(1941, 12, 16, 8, 30, 42, 0, DateTimeKind.Unspecified), "christopherhoward@libra.ry", "Christopher", "2660 Radde Place ", "Howard", "eye", "(548) 698-0818", new DateTime(2020, 2, 16, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(7692), "christopherhoward" },
                    { 203, new DateTime(1911, 6, 29, 9, 54, 10, 0, DateTimeKind.Unspecified), "petronilaadams@libra.ry", "Petronila", "1500 Gerritsen Avenue ", "Adams", "organic", "(237) 483-4614", new DateTime(2019, 1, 2, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(7011), "petronilaadams" },
                    { 202, new DateTime(1976, 8, 10, 15, 33, 51, 0, DateTimeKind.Unspecified), "paigecox@libra.ry", "Paige", "9389 Berkeley Place ", "Cox", "vice", "(762) 212-5873", new DateTime(2019, 9, 19, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(6361), "paigecox" },
                    { 201, new DateTime(1983, 5, 6, 6, 9, 38, 0, DateTimeKind.Unspecified), "charlessimmons@libra.ry", "Charles", "5356 Anthony Street ", "Simmons", "they", "(719) 795-9333", new DateTime(2020, 4, 9, 19, 0, 34, 858, DateTimeKind.Local).AddTicks(4576), "charlessimmons" },
                    { 219, new DateTime(1974, 6, 29, 1, 22, 33, 0, DateTimeKind.Unspecified), "victoriawhite@libra.ry", "Victoria", "776 Harbor View Terrace ", "White", "narwhal", "(419) 635-2293", new DateTime(2020, 10, 26, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(5616), "victoriawhite" },
                    { 209, new DateTime(1986, 12, 18, 18, 30, 45, 0, DateTimeKind.Unspecified), "michaeljames@libra.ry", "Michael", "8047 Suydam Street ", "James", "batch", "(408) 247-2316", new DateTime(2020, 11, 24, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(581), "michaeljames" },
                    { 220, new DateTime(1963, 2, 13, 20, 52, 48, 0, DateTimeKind.Unspecified), "nicolereed@libra.ry", "Nicole", "7196 Avenue U  ", "Reed", "art", "(233) 440-6497", new DateTime(2019, 12, 22, 19, 0, 34, 859, DateTimeKind.Local).AddTicks(6108), "nicolereed" }
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
