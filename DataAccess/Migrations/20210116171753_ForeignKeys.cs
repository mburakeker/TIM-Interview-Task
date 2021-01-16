using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransactions_Books_BookIsbnId",
                table: "BookTransactions");

            migrationBuilder.DropIndex(
                name: "IX_BookTransactions_BookIsbnId",
                table: "BookTransactions");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0026710159404");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0160499489034");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0209716785574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0229025008576");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0260348597980");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0366049104804");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0397179164165");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0432048934301");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0496026826921");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0550876969911");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0557998412466");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0576530225506");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0661547965142");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0749240871945");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0802517836762");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0816881874187");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0839986619801");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1034062645625");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1099561882495");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1363954059778");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1399167854697");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1443840972412");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1485712115018");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1504790430465");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1507139565229");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1571131207462");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1637705254659");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1679102917993");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1717993753416");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1762765469132");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1812188738755");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1839204523740");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1845936791605");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1853512138786");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2104105138863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2127077230662");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2144609237906");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2151106519797");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2236157077574");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2265353065805");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2271928271573");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2304171889627");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2405412078906");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2413089280845");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2419560961650");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2465933504425");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2500889308575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2570839661651");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2590367690606");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2630126390523");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2739518909682");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2755956505031");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2825195305508");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2825969709648");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2863021818074");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2878204828748");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2886711755235");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2925734709639");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3043560012229");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3277900209800");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3294649440734");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3317284794800");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3375070742270");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3430089775499");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3437783344881");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3453176588657");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3461096201116");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3516985587448");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3603260319605");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3626853988339");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3627668999497");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3659180399802");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3710825084517");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3730598868691");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3741291052814");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3852441532920");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3862153781325");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3895136618811");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3903864728913");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4016344283136");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4134214991185");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4159995837230");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4170901748118");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4210470546260");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4211189583329");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4269072416616");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4327640555308");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4433793318090");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4438437259005");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4440915288299");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4459268021555");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4469192523243");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4612205720170");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4637310419076");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4762456712431");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4802404416751");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4807765352319");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4885244068443");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4905041205592");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5019148508890");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5036839122804");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5133474216449");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5241714136009");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5270594625972");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5373069546000");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5421913322780");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5449933808917");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5582848633111");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5676438542467");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5705570652565");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5838713421565");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5880067511871");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5919019513571");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5930152455742");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5943539087336");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5997762808987");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6116939089214");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6118005371231");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6323365779792");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6564697132668");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6584620745733");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6625579424224");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6636883384498");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6727261435134");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6742628745796");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6853734301434");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6889629773489");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6898820558819");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6951757353259");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6976416123070");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7003534711532");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7010644927183");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7014349735026");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7100801826508");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7231952204957");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7348104569079");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7370399883784");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7448643973209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7525329743224");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7542623024950");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7566978182067");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7567427201009");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7646690586523");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7729043547754");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7733997498219");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7801111108956");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7801350704225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7809648063458");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7857337845028");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7926307772423");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7995863863415");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8047973470376");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8129995223870");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8152285383680");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8222625065793");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8260343128226");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8268368345056");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8280825102352");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8304590763036");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8322356329434");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8333240561144");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8341408636389");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8346615452538");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8426895492979");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8469711199942");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8488491841895");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8507899298236");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8598398698607");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8617976832052");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8682541963320");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8736774737346");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8785982033887");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8816164982850");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8818723218235");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8822187714707");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8852653683004");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8885867267983");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8941449512064");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8983543883592");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8997120160314");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8998854048595");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9006292287016");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9008643730914");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9038110524465");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9095255988696");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9203538107210");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9280308286998");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9337231007984");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9405832212264");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9432835664783");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9477619897822");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9491966923493");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9566033725474");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9578877800599");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9643141036044");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9644410619472");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9723527373626");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9730097015298");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9897703681371");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9971768195754");

            migrationBuilder.DropColumn(
                name: "BookIsbnId",
                table: "BookTransactions");

            migrationBuilder.AlterColumn<string>(
                name: "IsbnId",
                table: "BookTransactions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "0611160809575", "Masochistic Religion", "Asian Doo-Wop", 1 },
                    { "1387670595902", "Gloria Estefan", "Blues", 1 },
                    { "3321041750646", "DJ Jazzy Jeff and the Fresh Prince", "Brazillian Rock", 1 },
                    { "9939440481310", "Lighthouse", "Acid Blues", 1 },
                    { "6997737146919", "Merlin", "R&B", 1 },
                    { "5306302724345", "Me Mom & Morgentaler", "Fresh Jazz", 1 },
                    { "8642429531863", "Messenjah", "Blues", 1 },
                    { "8419646953527", "The Lovely Feathers", "Jazz", 1 },
                    { "0674595230406", "Fleetwood Mac", "Acid Rock", 1 },
                    { "0796402022542", "Gloria Estefan", "Classical", 1 },
                    { "7116768342156", "Maow", "Jazz", 1 },
                    { "7250698733664", "L'Étranger", "Free Classical", 1 },
                    { "9251568016083", "Mes Aïeux", "Jazzy Rock", 1 },
                    { "0614337528457", "Means", "Screamo", 1 },
                    { "5240547531943", "The Beatles", "House", 1 },
                    { "5023664780386", "Lee Harvey Osmond", "Jazz", 1 },
                    { "3310709684152", "Love Inc.", "Dance", 1 },
                    { "2310815774860", "Michael Jackson", "Acid Grunge", 1 },
                    { "2921191209226", "The Manvils", "Emo", 1 },
                    { "6472699907930", "New Kids on the Block", "Asian Screamo", 1 },
                    { "2700599263078", "The Midway State", "R&B", 1 },
                    { "6198836740537", "Elton John", "Hard Rock", 1 },
                    { "3867435020510", "Lace", "Funk", 1 },
                    { "5335009546069", "Stevie Wonder", "Classical", 1 },
                    { "0972862428215", "Lava Hay", "Asian House", 1 },
                    { "8150713538301", "Matthew Good Band", "Jazz", 1 },
                    { "8957867348608", "Monster Voodoo Machine", "Free Blues", 1 },
                    { "8809684626566", "The McRackins", "Free Rock", 1 },
                    { "4086669946425", "Me Mom & Morgentaler", "Electronic Rock", 1 },
                    { "3682902505406", "Matthew Good Band", "Glam Children's", 1 },
                    { "1589350070068", "R.E.M.", "Dance", 1 },
                    { "4318345812481", "Farm Fresh", "Emo", 1 },
                    { "6974898484262", "The Moffatts", "Hard Classical", 1 },
                    { "6525750000499", "Leigh Ashford", "Grunge", 1 },
                    { "3470943661939", "The Latency", "Classic Classical", 1 },
                    { "2690018014107", "Lost Dakotas", "Electronic Easy Listening", 1 },
                    { "1531736077558", "Library Voices", "Children's", 1 },
                    { "9996990546133", "Lighthouse", "African House", 1 },
                    { "4363861322824", "Johnny Hallyday", "Jazz", 1 },
                    { "0023012093008", "Memphis", "Kansas City Emo", 1 },
                    { "3745541562611", "The Mynah Birds", "Grunge", 1 },
                    { "7950659441261", "Linda Ronstadt", "House", 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "0373373714166", "Michael Jackson", "Jazz", 1 },
                    { "4212240390987", "Matthew Good Band", "Blues", 1 },
                    { "9731313025699", "Mandala", "Brazillian Children's", 1 },
                    { "7230269334689", "Mir", "Modern Funk", 1 },
                    { "8455028777209", "The Memories Attack", "Brazillian House", 1 },
                    { "3162372697317", "The Memories Attack", "Brazillian House", 1 },
                    { "5003117930950", "Lightning Dust", "Caribbean Jazz", 1 },
                    { "4622346349289", "Library Voices", "Jazz", 1 },
                    { "1746512711494", "Metric", "Modern Pop", 1 },
                    { "2491950502329", "Malhavoc", "Rock", 1 },
                    { "3952100962639", "Mudmen", "Jazz", 1 },
                    { "5534691338389", "Madrid", "Rock", 1 },
                    { "4931026453225", "Gloria Estefan", "Emo", 1 },
                    { "3315099223084", "Lillix", "Funk", 1 },
                    { "5580351992949", "Lime", "Children's", 1 },
                    { "2579532305274", "The Lincolns", "Modern Pop", 1 },
                    { "2513652608678", "MacLean & MacLean", "Glam Grunge", 1 },
                    { "9578248630414", "U2", "African Jazz", 1 },
                    { "7969344670181", "Cher", "Glam House", 1 },
                    { "2113543169048", "Max Webster", "Jazzy R&B", 1 },
                    { "9758589218269", "The Lemon Bucket Orkestra", "Asian Screamo", 1 },
                    { "0293563451143", "Mariah Carey", "Rock", 1 },
                    { "6457807253891", "Love and Sas", "Modern Grunge", 1 },
                    { "6326401484556", "Mandala", "Rock", 1 },
                    { "6541527938892", "Low Level Flight", "Rock", 1 },
                    { "2892412478900", "Garth Brooks", "Asian Blues", 1 },
                    { "2309872315364", "Metallica", "Free Jazz", 1 },
                    { "1369818046770", "Luther Wright and the Wrongs", "Rock", 1 },
                    { "9000166389142", "MonkeyJunk", "Jazzy Emo", 1 },
                    { "2782782921280", "Lillix", "Jazz", 1 },
                    { "3406641175603", "Elton John", "Modern Jazz", 1 },
                    { "1181997823789", "Mystery Machine", "Modern Funk", 1 },
                    { "1970086418565", "Olivia Newton-John", "Avant-Garde Folk", 1 },
                    { "6234111032296", "Monster Voodoo Machine", "Caribbean Pop", 1 },
                    { "2990492267184", "Lionel Richie", "Jazz", 1 },
                    { "7935503034935", "Bruce Springsteen", "Pop", 1 },
                    { "3568541957732", "Martyr", "Blues", 1 },
                    { "8178424185389", "Johnny Hallyday", "African Doo-Wop", 1 },
                    { "7765266744651", "Mariah Carey", "Blues", 1 },
                    { "7921389261517", "Love Kills", "Jazz", 1 },
                    { "8186715422361", "Mes Aïeux", "Children's", 1 },
                    { "9972468250443", "Len", "Jazz", 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "4984343222811", "Mudmen", "Free Classical", 1 },
                    { "0193103389832", "The Who", "Glam House", 1 },
                    { "8146265346826", "The Manvils", "Caribbean Jazz", 1 },
                    { "0916284906869", "My Darkest Days", "Rock", 1 },
                    { "6790441026833", "Moev", "Pop", 1 },
                    { "5427069110846", "The McDades", "Rock", 1 },
                    { "1310026655497", "MCJ & Cool G", "Grunge", 1 },
                    { "0374517297284", "Rod Stewart", "Children's", 1 },
                    { "6584833488979", "Malhavoc", "Kansas City Jazz", 1 },
                    { "0829887473534", "B'z", "Emo", 1 },
                    { "0168671924105", "The Midway State", "Acid Blues", 1 },
                    { "3757271002199", "Prince", "R&B", 1 },
                    { "5961519598431", "Ladyhawk", "Classic Rock", 1 },
                    { "7021474358960", "Fleetwood Mac", "Free Grunge", 1 },
                    { "1572971468264", "Metric", "Blues", 1 },
                    { "6037426810177", "Masochistic Religion", "Rock", 1 },
                    { "4249993776321", "The Memories Attack", "Funk", 1 },
                    { "6101437808096", "Len", "Rock", 1 },
                    { "2966855138490", "Dire Straits", "Avant-Garde Doo-Wop", 1 },
                    { "1436988379607", "MonkeyJunk", "Rock", 1 },
                    { "5510419929482", "Metallica", "Hard Rock", 1 },
                    { "7544169109510", "MCJ & Cool G", "Classical", 1 },
                    { "8651639755438", "Leslie Spit Treeo", "Avant-Garde Classical", 1 },
                    { "1008482657252", "Miriodor", "African House", 1 },
                    { "3805894763740", "Leslie Spit Treeo", "Blues", 1 },
                    { "5745094209268", "Max Webster", "Electronic Classical", 1 },
                    { "2221116372535", "Frank Sinatra", "Doo-Wop", 1 },
                    { "6330768027667", "Lola Dutronic", "Easy Listening", 1 },
                    { "1171422488890", "Mes Aïeux", "Acid Jazz", 1 },
                    { "5963985717024", "George Michael", "Rock", 1 },
                    { "4767288869858", "Little Caesar and the Consuls", "Rock", 1 },
                    { "4885315252668", "Lighthouse", "African Rock", 1 },
                    { "4401085461589", "Lioness", "R&B", 1 },
                    { "1532599422495", "Lace", "Caribbean Screamo", 1 },
                    { "6891194601030", "Letters to Elora", "Glam Children's", 1 },
                    { "6869164468322", "My Darkest Days", "Hard Rock", 1 },
                    { "5980028580766", "Mystery Machine", "Dance", 1 },
                    { "1149963622231", "Men Without Hats", "Screamo", 1 },
                    { "4462177381419", "The Latency", "Rock", 1 },
                    { "9691580406065", "Billy Joel", "Brazillian Folk", 1 },
                    { "5445967852957", "Mountain City Four", "Screamo", 1 },
                    { "5912245997965", "LMDS", "Avant-Garde Jazz", 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "5872052906348", "Lola Dutronic", "African Emo", 1 },
                    { "6865478461589", "Mariah Carey", "Jazz", 1 },
                    { "0302531185230", "Tina Turner", "Kansas City Doo-Wop", 1 },
                    { "0113771319471", "Queen", "Classical", 1 },
                    { "2476534456564", "Loco Locass", "Brazillian House", 1 },
                    { "2022446580281", "The MRQ", "African Blues", 1 },
                    { "7129035680462", "Leahy", "Brazillian Blues", 1 },
                    { "4732604102549", "Barry Manilow", "Brazillian Emo", 1 },
                    { "4608265372476", "Whitney Houston", "Funk", 1 },
                    { "8333925902443", "Last Man Out", "Kansas City Classical", 1 },
                    { "0635498971091", "My Darkest Days", "Asian Rock", 1 },
                    { "1565268516273", "AC/DC", "Hard Doo-Wop", 1 },
                    { "0951074427841", "Library Voices", "Fresh Rock", 1 },
                    { "1249404242079", "Whitney Houston", "Modern Doo-Wop", 1 },
                    { "4976680262243", "The Moffatts", "Caribbean Rock", 1 },
                    { "6868574127264", "Motion Ensemble", "Fresh Pop", 1 },
                    { "4589325737983", "Lili Fatale", "Jazz", 1 },
                    { "4239983504446", "Moneen", "Acid Rock", 1 },
                    { "4066545814895", "Mountain City Four", "Funk", 1 },
                    { "8485759647523", "Moneyshot", "Avant-Garde R&B", 1 },
                    { "0921159335040", "Love Inc.", "Jazz", 1 },
                    { "6440204202412", "Longing for Dawn", "Jazzy Rock", 1 },
                    { "3774088786966", "Messenjah", "Avant-Garde Dance", 1 },
                    { "6809583039145", "Olivia Newton-John", "Children's", 1 },
                    { "4624476046023", "Local Rabbits", "Blues", 1 },
                    { "1925882392677", "The Marble Index", "Classic Dance", 1 },
                    { "9865337857489", "Tina Turner", "R&B", 1 },
                    { "4145312359189", "Mean Red Spiders", "Fresh Rock", 1 },
                    { "6265316611279", "Genesis", "African Jazz", 1 },
                    { "7194645590452", "The Lovely Feathers", "Children's", 1 },
                    { "1558432403980", "Mean Red Spiders", "Fresh Rock", 1 },
                    { "2491841197898", "Lighthouse", "Brazillian Jazz", 1 },
                    { "8664014795469", "The Most Serene Republic", "Easy Listening", 1 },
                    { "4074930506838", "Lili Fatale", "Blues", 1 },
                    { "7100805754499", "The Marble Index", "Electronic Rock", 1 },
                    { "4941249425273", "Loco Locass", "Modern Grunge", 1 },
                    { "2296465171172", "Frank Sinatra", "Emo", 1 },
                    { "4736125091396", "Prince", "R&B", 1 },
                    { "0298275287221", "Mercy, the Sexton", "Classical", 1 },
                    { "1574147602106", "The Luyas", "African House", 1 },
                    { "9129706697912", "The Mark Inside", "Folk", 1 },
                    { "1900299748785", "My Darkest Days", "Jazz", 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "6969897167384", "Mannequin Depressives", "Folk", 1 },
                    { "8933409113417", "Malajube", "Brazillian Pop", 1 },
                    { "2436432695641", "Eagles", "Electronic Jazz", 1 },
                    { "7763691850705", "Celine Dion", "Classical", 1 },
                    { "1105469738646", "Marianas Trench", "Asian Jazz", 1 },
                    { "2434743979503", "Mountain City Four", "Electronic Easy Listening", 1 },
                    { "2170052953169", "The Lemon Bucket Orkestra", "House", 1 },
                    { "3782482046704", "Frank Sinatra", "Glam Blues", 1 },
                    { "5672042348236", "Stevie Wonder", "Jazz", 1 },
                    { "6561675118290", "The Beatles", "Classic Grunge", 1 },
                    { "3617592757519", "Memoryhouse", "Grunge", 1 },
                    { "3822315428099", "Limblifter", "Classic Jazz", 1 },
                    { "0770057649771", "Aerosmith", "Classical", 1 },
                    { "1433384780415", "Men Without Hats", "African Folk", 1 },
                    { "0353837847875", "MSTRKRFT", "Jazz", 1 },
                    { "1692906452134", "The Carpenters", "Hard Rock", 1 },
                    { "1463953494758", "The Midway State", "Caribbean Classical", 1 },
                    { "4293004776859", "Mountain City Four", "Glam Grunge", 1 },
                    { "9593274347470", "Eminem", "Classical", 1 },
                    { "1424608715224", "Mystery Machine", "House", 1 },
                    { "3534785739108", "The Matadors", "Rock", 1 },
                    { "6360273616245", "Means", "Screamo", 1 },
                    { "8052184966186", "The Mark Inside", "Glam Jazz", 1 },
                    { "9246277388905", "Malajube", "Fresh Screamo", 1 },
                    { "0558053896195", "Martyr", "Rock", 1 },
                    { "7205019943841", "Luther Wright and the Wrongs", "Classic Pop", 1 },
                    { "0266116448657", "The Memories Attack", "Jazz", 1 },
                    { "2766738206063", "Longing for Dawn", "Jazz", 1 },
                    { "0018002062960", "Prince", "Children's", 1 },
                    { "7800234272850", "Van Halen", "House", 1 },
                    { "0680331422347", "Moev", "Easy Listening", 1 },
                    { "5538425960674", "Mythos", "Asian Dance", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2020, 4, 13, 5, 51, 47, 0, DateTimeKind.Unspecified), "adrianhenderson@libra.ry", "Adrian", "5734 Driggs Avenue ", "Henderson", "Polaroid", "(411) 574-0519", new DateTime(2020, 5, 4, 20, 17, 53, 68, DateTimeKind.Local).AddTicks(6871), "adrianhenderson" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2008, 3, 2, 18, 2, 17, 0, DateTimeKind.Unspecified), "oliviapowell@libra.ry", "Olivia", "5128 Ocean Court ", "Powell", "synth", "(766) 417-6433", new DateTime(2018, 6, 2, 20, 17, 53, 68, DateTimeKind.Local).AddTicks(8692), "oliviapowell" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1911, 11, 6, 10, 59, 40, 0, DateTimeKind.Unspecified), "trevortellies@libra.ry", "Trevor", "3391 Halsey Street ", "Tellies", "you", "(600) 472-8131", new DateTime(2019, 2, 23, 20, 17, 53, 68, DateTimeKind.Local).AddTicks(9240), "trevortellies" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1985, 4, 21, 9, 48, 2, 0, DateTimeKind.Unspecified), "ısabellacooper@libra.ry", "Isabella", "2430 Apollo Street ", "Cooper", "small", "(629) 684-5634", new DateTime(2020, 7, 7, 20, 17, 53, 68, DateTimeKind.Local).AddTicks(9741), "ısabellacooper" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2014, 8, 14, 19, 0, 36, 0, DateTimeKind.Unspecified), "sabrinadavis@libra.ry", "Sabrina", "4167 Amber Street ", "Davis", "richardson", "(406) 424-0870", new DateTime(2020, 6, 5, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(236), "sabrinadavis" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1930, 9, 7, 17, 33, 20, 0, DateTimeKind.Unspecified), "richardross@libra.ry", "Richard", "8654 Vermont Street ", "Ross", "fap", "(479) 428-6231", new DateTime(2018, 10, 23, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(723), "richardross" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 7,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1905, 6, 23, 8, 27, 17, 0, DateTimeKind.Unspecified), "megangonzales@libra.ry", "Megan", "7377 Bridge Street ", "Gonzales", "Post-ironic", "(229) 582-4597", new DateTime(2020, 3, 4, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(1199), "megangonzales" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 8,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1938, 10, 10, 21, 49, 55, 0, DateTimeKind.Unspecified), "nicolehayes@libra.ry", "Nicole", "4523 Raleigh Place ", "Hayes", "post-ironic", "(375) 662-5486", new DateTime(2020, 2, 15, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(1678), "nicolehayes" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 9,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1957, 1, 17, 14, 0, 1, 0, DateTimeKind.Unspecified), "katelynsimmons@libra.ry", "Katelyn", "5749 Walker Court ", "Simmons", "case", "(435) 284-0578", new DateTime(2018, 8, 2, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(2241), "katelynsimmons" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 10,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1992, 7, 5, 9, 25, 56, 0, DateTimeKind.Unspecified), "emilychambers@libra.ry", "Emily", "6664 Warren Street ", "Chambers", "organic", "(530) 605-5457", new DateTime(2018, 8, 12, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(2688), "emilychambers" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 11,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1915, 1, 21, 20, 52, 35, 0, DateTimeKind.Unspecified), "kathrynreed@libra.ry", "Kathryn", "569 Kiely Place ", "Reed", "Gluten-free", "(373) 352-9721", new DateTime(2019, 11, 6, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(3253), "kathrynreed" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 12,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1957, 1, 22, 9, 50, 48, 0, DateTimeKind.Unspecified), "trevorhall@libra.ry", "Trevor", "5073 Losee Terrace ", "Hall", "future", "(242) 604-1217", new DateTime(2020, 7, 22, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(3743), "trevorhall" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 13,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1992, 10, 1, 13, 40, 8, 0, DateTimeKind.Unspecified), "kellyross@libra.ry", "Kelly", "645 Aitken Place ", "Ross", "tofu", "(282) 388-1701", new DateTime(2020, 4, 8, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(4263), "kellyross" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 14,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1917, 7, 8, 8, 1, 18, 0, DateTimeKind.Unspecified), "loganrobinson@libra.ry", "Logan", "1216 Covert Street ", "Robinson", "of", "(725) 399-5756", new DateTime(2020, 8, 3, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(4716), "loganrobinson" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 15,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1978, 9, 22, 8, 36, 14, 0, DateTimeKind.Unspecified), "spencermorgan@libra.ry", "Spencer", "8776 Bedford Place ", "Morgan", "messenger", "(638) 669-4419", new DateTime(2020, 7, 14, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(5223), "spencermorgan" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 16,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2007, 7, 23, 9, 27, 52, 0, DateTimeKind.Unspecified), "luishenderson@libra.ry", "Luis", "8661 Monroe Street ", "Henderson", "sriracha", "(379) 380-4848", new DateTime(2019, 1, 11, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(5691), "luishenderson" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 17,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2003, 3, 31, 17, 20, 36, 0, DateTimeKind.Unspecified), "lucasrivera@libra.ry", "Lucas", "1817 Skidmore Place ", "Rivera", "mlkshk", "(763) 379-0053", new DateTime(2019, 11, 18, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(6182), "lucasrivera" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 18,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1961, 10, 8, 10, 9, 16, 0, DateTimeKind.Unspecified), "chloehernandez@libra.ry", "Chloe", "4750 Paerdegat 13th Street ", "Hernandez", "shorts", "(537) 669-5522", new DateTime(2020, 4, 17, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(6635), "chloehernandez" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 19,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1933, 12, 20, 3, 48, 22, 0, DateTimeKind.Unspecified), "baileybrandzin@libra.ry", "Bailey", "7608 Roder Avenue ", "Brandzin", "occupy", "(650) 305-3979", new DateTime(2019, 4, 24, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(7137), "baileybrandzin" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 20,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1973, 2, 17, 23, 28, 42, 0, DateTimeKind.Unspecified), "lucaspowell@libra.ry", "Lucas", "6116 Bay Street ", "Powell", "brooklyn", "(256) 374-0520", new DateTime(2020, 7, 30, 20, 17, 53, 69, DateTimeKind.Local).AddTicks(7615), "lucaspowell" });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 21,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1918, 2, 25, 3, 16, 50, 0, DateTimeKind.Unspecified), "0611160809575", new DateTime(1982, 10, 30, 7, 39, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 22,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1942, 9, 25, 18, 47, 53, 0, DateTimeKind.Unspecified), "6865478461589", new DateTime(1986, 10, 22, 11, 36, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 23,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1921, 10, 23, 2, 15, 5, 0, DateTimeKind.Unspecified), "0302531185230", new DateTime(1945, 12, 14, 13, 45, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 24,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1999, 1, 7, 19, 9, 6, 0, DateTimeKind.Unspecified), "0113771319471", new DateTime(2014, 8, 4, 11, 17, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 25,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1912, 4, 26, 6, 46, 36, 0, DateTimeKind.Unspecified), "2476534456564", new DateTime(1939, 12, 4, 19, 47, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 26,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1974, 11, 27, 3, 19, 8, 0, DateTimeKind.Unspecified), "2022446580281", new DateTime(1990, 11, 3, 7, 52, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 27,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1938, 4, 4, 19, 43, 56, 0, DateTimeKind.Unspecified), "7129035680462", new DateTime(1963, 10, 31, 10, 37, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 28,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(2019, 9, 2, 8, 23, 22, 0, DateTimeKind.Unspecified), "4732604102549", new DateTime(1900, 7, 11, 4, 25, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 29,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1951, 6, 10, 7, 30, 41, 0, DateTimeKind.Unspecified), "4608265372476", new DateTime(1955, 3, 29, 21, 5, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 30,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1958, 7, 13, 13, 53, 44, 0, DateTimeKind.Unspecified), "8333925902443", new DateTime(1956, 12, 10, 6, 32, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 31,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1928, 5, 12, 17, 44, 58, 0, DateTimeKind.Unspecified), "0635498971091", new DateTime(1900, 12, 23, 21, 36, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 32,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1904, 3, 20, 1, 22, 23, 0, DateTimeKind.Unspecified), "0951074427841", new DateTime(1937, 1, 14, 7, 13, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 33,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1966, 5, 14, 0, 22, 56, 0, DateTimeKind.Unspecified), "6809583039145", new DateTime(1969, 7, 9, 18, 10, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 34,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1931, 8, 13, 8, 33, 19, 0, DateTimeKind.Unspecified), "1249404242079", new DateTime(2009, 7, 7, 12, 13, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 35,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1973, 10, 5, 6, 34, 46, 0, DateTimeKind.Unspecified), "4976680262243", new DateTime(1984, 9, 26, 0, 16, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 36,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1994, 4, 14, 4, 41, 35, 0, DateTimeKind.Unspecified), "6868574127264", new DateTime(1920, 4, 5, 12, 44, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 37,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1977, 2, 28, 1, 37, 58, 0, DateTimeKind.Unspecified), "4589325737983", new DateTime(1970, 10, 7, 19, 56, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 38,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1939, 8, 26, 1, 22, 51, 0, DateTimeKind.Unspecified), "4239983504446", new DateTime(1905, 6, 28, 12, 7, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 39,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1933, 3, 16, 20, 24, 5, 0, DateTimeKind.Unspecified), "4066545814895", new DateTime(1941, 4, 4, 12, 32, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 40,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(2000, 9, 29, 5, 26, 9, 0, DateTimeKind.Unspecified), "8485759647523", new DateTime(1911, 4, 28, 21, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_BookTransactions_IsbnId",
                table: "BookTransactions",
                column: "IsbnId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransactions_Books_IsbnId",
                table: "BookTransactions",
                column: "IsbnId",
                principalTable: "Books",
                principalColumn: "IsbnId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTransactions_Books_IsbnId",
                table: "BookTransactions");

            migrationBuilder.DropIndex(
                name: "IX_BookTransactions_IsbnId",
                table: "BookTransactions");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0018002062960");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0023012093008");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0113771319471");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0168671924105");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0193103389832");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0266116448657");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0293563451143");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0298275287221");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0302531185230");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0353837847875");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0373373714166");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0374517297284");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0558053896195");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0611160809575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0614337528457");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0635498971091");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0674595230406");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0680331422347");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0770057649771");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0796402022542");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0829887473534");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0916284906869");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0921159335040");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0951074427841");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0972862428215");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1008482657252");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1105469738646");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1149963622231");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1171422488890");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1181997823789");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1249404242079");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1310026655497");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1369818046770");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1387670595902");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1424608715224");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1433384780415");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1436988379607");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1463953494758");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1531736077558");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1532599422495");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1558432403980");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1565268516273");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1572971468264");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1574147602106");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1589350070068");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1692906452134");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1746512711494");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1900299748785");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1925882392677");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1970086418565");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2022446580281");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2113543169048");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2170052953169");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2221116372535");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2296465171172");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2309872315364");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2310815774860");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2434743979503");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2436432695641");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2476534456564");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2491841197898");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2491950502329");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2513652608678");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2579532305274");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2690018014107");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2700599263078");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2766738206063");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2782782921280");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2892412478900");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2921191209226");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2966855138490");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2990492267184");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3162372697317");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3310709684152");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3315099223084");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3321041750646");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3406641175603");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3470943661939");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3534785739108");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3568541957732");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3617592757519");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3682902505406");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3745541562611");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3757271002199");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3774088786966");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3782482046704");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3805894763740");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3822315428099");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3867435020510");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3952100962639");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4066545814895");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4074930506838");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4086669946425");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4145312359189");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4212240390987");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4239983504446");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4249993776321");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4293004776859");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4318345812481");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4363861322824");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4401085461589");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4462177381419");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4589325737983");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4608265372476");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4622346349289");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4624476046023");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4732604102549");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4736125091396");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4767288869858");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4885315252668");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4931026453225");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4941249425273");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4976680262243");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4984343222811");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5003117930950");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5023664780386");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5240547531943");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5306302724345");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5335009546069");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5427069110846");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5445967852957");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5510419929482");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5534691338389");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5538425960674");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5580351992949");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5672042348236");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5745094209268");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5872052906348");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5912245997965");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5961519598431");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5963985717024");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5980028580766");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6037426810177");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6101437808096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6198836740537");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6234111032296");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6265316611279");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6326401484556");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6330768027667");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6360273616245");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6440204202412");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6457807253891");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6472699907930");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6525750000499");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6541527938892");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6561675118290");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6584833488979");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6790441026833");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6809583039145");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6865478461589");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6868574127264");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6869164468322");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6891194601030");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6969897167384");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6974898484262");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6997737146919");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7021474358960");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7100805754499");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7116768342156");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7129035680462");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7194645590452");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7205019943841");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7230269334689");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7250698733664");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7544169109510");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7763691850705");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7765266744651");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7800234272850");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7921389261517");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7935503034935");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7950659441261");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7969344670181");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8052184966186");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8146265346826");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8150713538301");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8178424185389");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8186715422361");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8333925902443");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8419646953527");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8455028777209");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8485759647523");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8642429531863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8651639755438");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8664014795469");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8809684626566");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8933409113417");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8957867348608");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9000166389142");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9129706697912");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9246277388905");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9251568016083");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9578248630414");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9593274347470");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9691580406065");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9731313025699");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9758589218269");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9865337857489");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9939440481310");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9972468250443");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9996990546133");

            migrationBuilder.AlterColumn<string>(
                name: "IsbnId",
                table: "BookTransactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookIsbnId",
                table: "BookTransactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 21,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1953, 8, 11, 18, 58, 32, 0, DateTimeKind.Unspecified), "7566978182067", new DateTime(1995, 8, 7, 18, 18, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 22,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(2005, 1, 15, 21, 34, 24, 0, DateTimeKind.Unspecified), "4016344283136", new DateTime(1954, 10, 2, 8, 39, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 23,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1938, 10, 10, 14, 34, 39, 0, DateTimeKind.Unspecified), "4885244068443", new DateTime(1979, 4, 24, 18, 46, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 24,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1928, 12, 17, 19, 29, 53, 0, DateTimeKind.Unspecified), "9491966923493", new DateTime(1976, 1, 10, 16, 41, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 25,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(2010, 8, 7, 17, 11, 43, 0, DateTimeKind.Unspecified), "6889629773489", new DateTime(2015, 8, 14, 12, 30, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 26,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1902, 7, 11, 19, 1, 1, 0, DateTimeKind.Unspecified), "9038110524465", new DateTime(1910, 2, 18, 13, 54, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 27,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1909, 4, 1, 22, 8, 50, 0, DateTimeKind.Unspecified), "8682541963320", new DateTime(1967, 12, 11, 2, 50, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 28,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1980, 1, 10, 21, 52, 24, 0, DateTimeKind.Unspecified), "4327640555308", new DateTime(2008, 11, 24, 0, 57, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 29,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1990, 9, 18, 16, 13, 13, 0, DateTimeKind.Unspecified), "1507139565229", new DateTime(2015, 9, 27, 13, 24, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 30,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1983, 6, 6, 2, 40, 12, 0, DateTimeKind.Unspecified), "0432048934301", new DateTime(1929, 1, 15, 3, 41, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 31,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1903, 4, 26, 19, 50, 23, 0, DateTimeKind.Unspecified), "9730097015298", new DateTime(2006, 8, 9, 23, 32, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 32,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1928, 3, 11, 15, 15, 28, 0, DateTimeKind.Unspecified), "1363954059778", new DateTime(1992, 1, 27, 18, 2, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 33,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(2017, 9, 24, 3, 44, 26, 0, DateTimeKind.Unspecified), "8998854048595", new DateTime(1968, 12, 19, 11, 21, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 34,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1902, 10, 31, 5, 3, 16, 0, DateTimeKind.Unspecified), "8304590763036", new DateTime(1936, 1, 29, 21, 3, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 35,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1927, 10, 6, 8, 0, 39, 0, DateTimeKind.Unspecified), "1717993753416", new DateTime(1989, 10, 12, 15, 36, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 36,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(2020, 12, 12, 14, 46, 26, 0, DateTimeKind.Unspecified), "2590367690606", new DateTime(1934, 5, 28, 22, 40, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 37,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1978, 10, 30, 1, 39, 32, 0, DateTimeKind.Unspecified), "3430089775499", new DateTime(1914, 8, 18, 9, 48, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 38,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1969, 4, 20, 19, 14, 1, 0, DateTimeKind.Unspecified), "9280308286998", new DateTime(2014, 7, 21, 13, 31, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 39,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(2001, 2, 28, 2, 28, 16, 0, DateTimeKind.Unspecified), "7646690586523", new DateTime(2000, 9, 8, 19, 15, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 40,
                columns: new[] { "EndDate", "IsbnId", "StartDate" },
                values: new object[] { new DateTime(1903, 11, 4, 19, 25, 45, 0, DateTimeKind.Unspecified), "9578877800599", new DateTime(1966, 10, 17, 4, 39, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "8280825102352", "The Mohawk Lodge", "African Pop", 0 },
                    { "7010644927183", "The Carpenters", "Blues", 0 },
                    { "9723527373626", "The Mynah Birds", "Classical", 0 },
                    { "0557998412466", "Mariah Carey", "Glam Easy Listening", 0 },
                    { "0026710159404", "B'z", "Free Pop", 0 },
                    { "3730598868691", "Little Caesar and the Consuls", "Modern Jazz", 0 },
                    { "5919019513571", "The Lowest of the Low", "Pop", 0 },
                    { "4433793318090", "Lili Fatale", "Avant-Garde Jazz", 0 },
                    { "8785982033887", "Live on Arrival", "Screamo", 0 },
                    { "7566978182067", "The Manvils", "Classical", 0 },
                    { "3903864728913", "Eagles", "Caribbean Easy Listening", 0 },
                    { "8852653683004", "Leahy", "Funk", 0 },
                    { "6727261435134", "Michael Jackson", "Rock", 0 },
                    { "9337231007984", "Malajube", "Easy Listening", 0 },
                    { "5930152455742", "The McRackins", "Classical", 0 },
                    { "0576530225506", "Little Caesar and the Consuls", "House", 0 },
                    { "1099561882495", "Moneyshot", "Glam Jazz", 0 },
                    { "2755956505031", "Dire Straits", "Glam Pop", 0 },
                    { "4762456712431", "Moneen", "African Funk", 0 },
                    { "6636883384498", "Donna Summer", "Rock", 0 },
                    { "7542623024950", "Chicago", "African Jazz", 0 },
                    { "3627668999497", "The Beatles", "Brazillian Rock", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "2236157077574", "Lime", "Children's", 0 },
                    { "7995863863415", "Manic Drive", "African Rock", 0 },
                    { "7231952204957", "The Mynah Birds", "Asian Blues", 0 },
                    { "6118005371231", "Frank Sinatra", "Screamo", 0 },
                    { "0496026826921", "Dire Straits", "Acid Jazz", 0 },
                    { "8346615452538", "Mare", "Kansas City Folk", 0 },
                    { "4612205720170", "ABBA", "Jazz", 0 },
                    { "7733997498219", "ABBA", "Rock", 0 },
                    { "2144609237906", "Phil Collins", "Classic Folk", 0 },
                    { "8222625065793", "Messenjah", "Classic Emo", 0 },
                    { "8983543883592", "Metalwood", "Hard Emo", 0 },
                    { "7857337845028", "Mecca Normal", "Electronic Emo", 0 },
                    { "8469711199942", "Love Inc.", "Jazz", 0 },
                    { "1443840972412", "Mannequin Depressives", "Rock", 0 },
                    { "3862153781325", "Metallica", "Asian Easy Listening", 0 },
                    { "3317284794800", "The Mahones", "Blues", 0 },
                    { "0397179164165", "Luther Wright and the Wrongs", "Modern Doo-Wop", 0 },
                    { "2878204828748", "The McRackins", "Avant-Garde House", 0 },
                    { "8333240561144", "Monster Voodoo Machine", "Fresh House", 0 },
                    { "0160499489034", "Madrid", "House", 0 },
                    { "7448643973209", "The McRackins", "Asian Folk", 0 },
                    { "2500889308575", "The Memories Attack", "Electronic Folk", 0 },
                    { "3453176588657", "The Beatles", "Emo", 0 },
                    { "3277900209800", "Monster Voodoo Machine", "Jazz", 0 },
                    { "2271928271573", "Lee Harvey Osmond", "Blues", 0 },
                    { "3852441532920", "Malhavoc", "Rock", 0 },
                    { "8322356329434", "Frank Sinatra", "Modern Emo", 0 },
                    { "4210470546260", "Kenny Rogers", "Blues", 0 },
                    { "5019148508890", "Moneyshot", "Easy Listening", 0 },
                    { "6323365779792", "Major Maker", "Asian Emo", 0 },
                    { "6742628745796", "Bryan Adams", "Pop", 0 },
                    { "6853734301434", "Martha and the Muffins", "Hard Blues", 0 },
                    { "2304171889627", "Rod Stewart", "Screamo", 0 },
                    { "3516985587448", "Moxy", "Electronic Screamo", 0 },
                    { "2265353065805", "Lightning Dust", "Kansas City Blues", 0 },
                    { "1853512138786", "Marianas Trench", "Jazz", 0 },
                    { "2825969709648", "Madrid", "Jazz", 0 },
                    { "0816881874187", "Martyr", "Glam Blues", 0 },
                    { "1839204523740", "Britney Spears", "Kansas City R&B", 0 },
                    { "8129995223870", "Liferuiner", "Classical", 0 },
                    { "8047973470376", "Love and Sas", "Screamo", 0 },
                    { "7525329743224", "Marilyn's Vitamins", "Classical", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "0209716785574", "The Lincolns", "Blues", 0 },
                    { "4802404416751", "Mythos", "Avant-Garde Rock", 0 },
                    { "8507899298236", "Local Rabbits", "Caribbean Rock", 0 },
                    { "9095255988696", "Luke & The Apostles", "Asian Jazz", 0 },
                    { "1812188738755", "The Lincolns", "Funk", 0 },
                    { "2419560961650", "Lighthouse", "Rock", 0 },
                    { "4159995837230", "Luke & The Apostles", "Grunge", 0 },
                    { "7003534711532", "Mir", "Emo", 0 },
                    { "5449933808917", "McMaster & James", "R&B", 0 },
                    { "2863021818074", "Liferuiner", "Fresh Jazz", 0 },
                    { "5133474216449", "New Kids on the Block", "Acid Jazz", 0 },
                    { "4170901748118", "Longing for Dawn", "Folk", 0 },
                    { "5838713421565", "Lost Dakotas", "Modern Doo-Wop", 0 },
                    { "8426895492979", "Mashmakhan", "Jazzy Screamo", 0 },
                    { "7809648063458", "Madonna", "Rock", 0 },
                    { "6951757353259", "Billy Joel", "Screamo", 0 },
                    { "8617976832052", "Merryweather", "Emo", 0 },
                    { "9477619897822", "Michael Jackson", "Caribbean Blues", 0 },
                    { "8598398698607", "Malajube", "Electronic Screamo", 0 },
                    { "2151106519797", "Lotus Child", "African Rock", 0 },
                    { "4438437259005", "Library Voices", "Acid Jazz", 0 },
                    { "5036839122804", "Mythos", "Rock", 0 },
                    { "5676438542467", "Stevie Wonder", "Jazz", 0 },
                    { "9566033725474", "Lighthouse", "Grunge", 0 },
                    { "2104105138863", "Matt Mays & El Torpedo", "Electronic Blues", 0 },
                    { "8736774737346", "Mir", "Modern Pop", 0 },
                    { "7801111108956", "Farm Fresh", "Fresh Rock", 0 },
                    { "0749240871945", "Moev", "Rock", 0 },
                    { "1399167854697", "Red Hot Chili Peppers", "Blues", 0 },
                    { "2886711755235", "The Musical Box", "Glam R&B", 0 },
                    { "9644410619472", "Johnny Hallyday", "Acid Children's", 0 },
                    { "8260343128226", "The Lovely Feathers", "House", 0 },
                    { "2127077230662", "Neil Diamond", "Easy Listening", 0 },
                    { "8941449512064", "Julio Iglesias", "Kansas City Dance", 0 },
                    { "9971768195754", "Moneen", "Jazzy Jazz", 0 },
                    { "1034062645625", "Mandala", "Easy Listening", 0 },
                    { "5270594625972", "Billy Joel", "Hard Blues", 0 },
                    { "4905041205592", "The Lemon Bucket Orkestra", "Jazz", 0 },
                    { "9203538107210", "The McDades", "R&B", 0 },
                    { "3437783344881", "Metric", "Jazzy Grunge", 0 },
                    { "4211189583329", "McKenna Mendelson Mainline", "Grunge", 0 },
                    { "1679102917993", "Miriodor", "Funk", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "0839986619801", "The Most Serene Republic", "Emo", 0 },
                    { "2825195305508", "DJ Jazzy Jeff and the Fresh Prince", "Hard Rock", 0 },
                    { "5241714136009", "Motion Ensemble", "Fresh Blues", 0 },
                    { "7100801826508", "Donna Summer", "Jazzy Screamo", 0 },
                    { "9006292287016", "Main Source", "Blues", 0 },
                    { "5373069546000", "The Lincolns", "Asian Rock", 0 },
                    { "9897703681371", "Donna Summer", "Emo", 0 },
                    { "1762765469132", "Donna Summer", "Acid Folk", 0 },
                    { "5880067511871", "The Carpenters", "Jazz", 0 },
                    { "4440915288299", "Lili Fatale", "Folk", 0 },
                    { "8816164982850", "Rod Stewart", "Classical", 0 },
                    { "6116939089214", "The Mohawk Lodge", "Acid Dance", 0 },
                    { "1485712115018", "Olivia Newton-John", "Electronic Jazz", 0 },
                    { "7567427201009", "Linda Ronstadt", "Rock", 0 },
                    { "4016344283136", "Letters to Elora", "Avant-Garde Children's", 0 },
                    { "4885244068443", "Manteca", "Funk", 0 },
                    { "9491966923493", "Left Spine Down", "Jazz", 0 },
                    { "6889629773489", "Moneen", "Rock", 0 },
                    { "9038110524465", "AC/DC", "Children's", 0 },
                    { "8682541963320", "The Who", "Brazillian Jazz", 0 },
                    { "4327640555308", "Mercey Brothers", "Avant-Garde Folk", 0 },
                    { "1507139565229", "Luciano Pavarotti", "Acid Rock", 0 },
                    { "0432048934301", "Lola Dutronic", "Free Folk", 0 },
                    { "9730097015298", "Leahy", "Rock", 0 },
                    { "1363954059778", "LiveonRelease", "Hard Classical", 0 },
                    { "2405412078906", "Mecca Normal", "Brazillian Jazz", 0 },
                    { "8998854048595", "Rihanna", "Grunge", 0 },
                    { "1717993753416", "Mashmakhan", "Jazzy Classical", 0 },
                    { "2590367690606", "Phil Collins", "Blues", 0 },
                    { "3430089775499", "Little Caesar and the Consuls", "Classic Classical", 0 },
                    { "9280308286998", "Mobile", "Classic Emo", 0 },
                    { "7646690586523", "Leslie Spit Treeo", "Glam Dance", 0 },
                    { "9578877800599", "New Kids on the Block", "Rock", 0 },
                    { "0550876969911", "Love Kills", "Modern Emo", 0 },
                    { "8885867267983", "Mecca Normal", "Dance", 0 },
                    { "1845936791605", "Major Maker", "Acid Rock", 0 },
                    { "8488491841895", "Gloria Estefan", "Funk", 0 },
                    { "3043560012229", "MSTRKRFT", "Fresh Emo", 0 },
                    { "8304590763036", "Manteca", "Emo", 0 },
                    { "6976416123070", "Metric", "Acid Jazz", 0 },
                    { "6564697132668", "Madrid", "Kansas City R&B", 0 },
                    { "9432835664783", "Dire Straits", "Fresh Jazz", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "4269072416616", "Chicago", "Emo", 0 },
                    { "2465933504425", "The Luyas", "Fresh Easy Listening", 0 },
                    { "9405832212264", "Madrid", "Caribbean Pop", 0 },
                    { "2413089280845", "Main Source", "Kansas City Rock", 0 },
                    { "0260348597980", "Lola Dutronic", "Blues", 0 },
                    { "7801350704225", "Lionel Richie", "Jazzy Jazz", 0 },
                    { "4637310419076", "Genesis", "Hard Folk", 0 },
                    { "5943539087336", "Janet Jackson", "Jazz", 0 },
                    { "5582848633111", "Farm Fresh", "Electronic Jazz", 0 },
                    { "2570839661651", "Last Man Out", "Glam Rock", 0 },
                    { "7014349735026", "Manteca", "Jazz", 0 },
                    { "7926307772423", "Mudmen", "Free Jazz", 0 },
                    { "1571131207462", "Stevie Wonder", "Jazz", 0 },
                    { "3294649440734", "Little Girls", "Blues", 0 },
                    { "2739518909682", "The Mohawk Lodge", "Avant-Garde Rock", 0 },
                    { "3461096201116", "Low Level Flight", "Modern Rock", 0 },
                    { "0229025008576", "Live on Arrival", "Electronic Grunge", 0 },
                    { "9643141036044", "The Lovely Feathers", "Screamo", 0 },
                    { "3626853988339", "Mountain City Four", "Hard Blues", 0 },
                    { "8341408636389", "The Marble Index", "Easy Listening", 0 },
                    { "3603260319605", "Land of Talk", "Folk", 0 },
                    { "1504790430465", "My Darkest Days", "Avant-Garde Folk", 0 },
                    { "5997762808987", "Me Mom & Morgentaler", "Folk", 0 },
                    { "6898820558819", "Johnny Hallyday", "Classic Funk", 0 },
                    { "0802517836762", "Celine Dion", "Jazz", 0 },
                    { "8822187714707", "Gloria Estefan", "Hard Rock", 0 },
                    { "0661547965142", "Local Rabbits", "House", 0 },
                    { "3659180399802", "Lili Fatale", "Pop", 0 },
                    { "3710825084517", "The Mahones", "Free Folk", 0 },
                    { "6584620745733", "My Darkest Days", "House", 0 },
                    { "3375070742270", "Phil Collins", "African Emo", 0 },
                    { "4459268021555", "Lola Dutronic", "Kansas City Blues", 0 },
                    { "8152285383680", "Mystery", "Doo-Wop", 0 },
                    { "7370399883784", "Metric", "Folk", 0 },
                    { "4807765352319", "MacLean & MacLean", "Jazzy Jazz", 0 },
                    { "7348104569079", "Led Zeppelin", "Emo", 0 },
                    { "0366049104804", "Dire Straits", "Doo-Wop", 0 },
                    { "4134214991185", "Prince", "Pop", 0 },
                    { "6625579424224", "LMDS", "Modern Rock", 0 },
                    { "3895136618811", "L'Étranger", "Caribbean Screamo", 0 },
                    { "8818723218235", "Lace", "R&B", 0 },
                    { "5421913322780", "Red Hot Chili Peppers", "Blues", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "1637705254659", "The Lemon Bucket Orkestra", "Asian Doo-Wop", 0 },
                    { "5705570652565", "Bryan Adams", "Jazz", 0 },
                    { "9008643730914", "Rod Stewart", "Classical", 0 },
                    { "2630126390523", "Neil Diamond", "Hard House", 0 },
                    { "8997120160314", "The Lowest of the Low", "African Children's", 0 },
                    { "4469192523243", "Mercy, the Sexton", "Doo-Wop", 0 },
                    { "8268368345056", "The Mark Inside", "Modern Emo", 0 },
                    { "2925734709639", "The Mynah Birds", "Doo-Wop", 0 },
                    { "3741291052814", "Billy Joel", "Modern Dance", 0 },
                    { "7729043547754", "Love and Sas", "Acid Folk", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1931, 9, 27, 18, 36, 49, 0, DateTimeKind.Unspecified), "emilytaylor@libra.ry", "Emily", "1720 Bay 37th Street ", "Taylor", "terry", "(507) 228-9600", new DateTime(2020, 2, 3, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(1531), "emilytaylor" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2002, 9, 13, 13, 38, 9, 0, DateTimeKind.Unspecified), "gabrielcooper@libra.ry", "Gabriel", "7635 29th Street ", "Cooper", "life", "(216) 508-1205", new DateTime(2018, 7, 13, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(3433), "gabrielcooper" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2011, 12, 20, 23, 55, 56, 0, DateTimeKind.Unspecified), "carolineedwards@libra.ry", "Caroline", "1478 Jackson Place ", "Edwards", "art", "(757) 492-2172", new DateTime(2019, 7, 20, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(3982), "carolineedwards" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1935, 10, 11, 8, 53, 35, 0, DateTimeKind.Unspecified), "alexislong@libra.ry", "Alexis", "2831 Brighton 3rd Street ", "Long", "denim", "(597) 363-2480", new DateTime(2019, 1, 30, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(4463), "alexislong" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2011, 5, 30, 12, 34, 26, 0, DateTimeKind.Unspecified), "colehenderson@libra.ry", "Cole", "1104 Evergreen Avenue ", "Henderson", "future", "(492) 224-9392", new DateTime(2019, 10, 4, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(4933), "colehenderson" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1967, 5, 20, 13, 42, 52, 0, DateTimeKind.Unspecified), "angrodriguez@libra.ry", "Ang", "3373 Rodney Street ", "Rodriguez", "post-ironic", "(710) 482-5140", new DateTime(2019, 6, 19, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(5439), "angrodriguez" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 7,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1961, 7, 25, 13, 57, 0, 0, DateTimeKind.Unspecified), "nicoledavis@libra.ry", "Nicole", "4240 Conklin Avenue ", "Davis", "irony", "(612) 797-7823", new DateTime(2019, 12, 9, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(5927), "nicoledavis" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 8,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1979, 12, 28, 0, 57, 49, 0, DateTimeKind.Unspecified), "williamhoward@libra.ry", "William", "6941 Atkins Avenue ", "Howard", "Iphone", "(502) 478-3759", new DateTime(2019, 8, 27, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(6364), "williamhoward" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 9,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2018, 10, 30, 22, 38, 26, 0, DateTimeKind.Unspecified), "sebastianbaker@libra.ry", "Sebastian", "6698 Gates Avenue ", "Baker", "park", "(580) 584-4844", new DateTime(2018, 6, 16, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(6824), "sebastianbaker" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 10,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1965, 3, 26, 19, 42, 19, 0, DateTimeKind.Unspecified), "taylorgreen@libra.ry", "Taylor", "3032 Schenectady Avenue ", "Green", "Swag", "(513) 413-3013", new DateTime(2020, 12, 8, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(7293), "taylorgreen" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 11,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1952, 10, 29, 13, 46, 36, 0, DateTimeKind.Unspecified), "kylierussell@libra.ry", "Kylie", "5523 Ingraham Street ", "Russell", "richardson", "(396) 259-8595", new DateTime(2019, 12, 6, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(7808), "kylierussell" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 12,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1903, 1, 29, 1, 13, 27, 0, DateTimeKind.Unspecified), "gabrielfoster@libra.ry", "Gabriel", "2391 Porter Avenue ", "Foster", "a", "(645) 751-8769", new DateTime(2018, 9, 23, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(8248), "gabrielfoster" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 13,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2000, 4, 15, 19, 37, 6, 0, DateTimeKind.Unspecified), "emmawhite@libra.ry", "Emma", "3225 Windsor Place ", "White", "terry", "(632) 675-2454", new DateTime(2020, 10, 31, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(8714), "emmawhite" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 14,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1940, 8, 9, 13, 45, 27, 0, DateTimeKind.Unspecified), "johnwalker@libra.ry", "John", "5111 72nd Street ", "Walker", "cred", "(493) 669-5648", new DateTime(2019, 3, 20, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(9207), "johnwalker" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 15,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1960, 12, 6, 22, 21, 54, 0, DateTimeKind.Unspecified), "justinmorris@libra.ry", "Justin", "1603 Tabor Court ", "Morris", "odd", "(707) 309-5576", new DateTime(2020, 6, 15, 20, 16, 38, 521, DateTimeKind.Local).AddTicks(9700), "justinmorris" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 16,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1973, 4, 17, 13, 57, 52, 0, DateTimeKind.Unspecified), "destinyrussell@libra.ry", "Destiny", "6924 4th Street ", "Russell", "kale", "(314) 261-5992", new DateTime(2018, 8, 12, 20, 16, 38, 522, DateTimeKind.Local).AddTicks(151), "destinyrussell" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 17,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1948, 1, 29, 5, 46, 29, 0, DateTimeKind.Unspecified), "jordanwashington@libra.ry", "Jordan", "835 Vandervoort Place ", "Washington", "semiotics", "(262) 354-9642", new DateTime(2020, 7, 4, 20, 16, 38, 522, DateTimeKind.Local).AddTicks(606), "jordanwashington" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 18,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(2017, 8, 12, 23, 0, 40, 0, DateTimeKind.Unspecified), "kimberlyperez@libra.ry", "Kimberly", "274 Varick Avenue ", "Perez", "you", "(395) 572-7846", new DateTime(2018, 10, 17, 20, 16, 38, 522, DateTimeKind.Local).AddTicks(1063), "kimberlyperez" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 19,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1960, 10, 27, 10, 36, 29, 0, DateTimeKind.Unspecified), "lilyyoung@libra.ry", "Lily", "6229 40th Street ", "Young", "art", "(426) 372-9202", new DateTime(2019, 4, 9, 20, 16, 38, 522, DateTimeKind.Local).AddTicks(1533), "lilyyoung" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 20,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "Password", "PhoneNumber", "RegistrationDate", "Username" },
                values: new object[] { new DateTime(1953, 5, 21, 15, 14, 17, 0, DateTimeKind.Unspecified), "jasonwilliams@libra.ry", "Jason", "1088 Hull Street ", "Williams", "high", "(700) 332-6562", new DateTime(2019, 3, 4, 20, 16, 38, 522, DateTimeKind.Local).AddTicks(2003), "jasonwilliams" });

            migrationBuilder.CreateIndex(
                name: "IX_BookTransactions_BookIsbnId",
                table: "BookTransactions",
                column: "BookIsbnId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookTransactions_Books_BookIsbnId",
                table: "BookTransactions",
                column: "BookIsbnId",
                principalTable: "Books",
                principalColumn: "IsbnId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
