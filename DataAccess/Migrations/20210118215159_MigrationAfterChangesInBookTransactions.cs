using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class MigrationAfterChangesInBookTransactions : Migration
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
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BookTransactions",
                keyColumn: "TransactionId",
                keyValue: 40);

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
                name: "Password",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Members");

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

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BookTransactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "BookTransactions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "9873236987863", "Lionel Richie", "Avant-Garde Jazz", 2 },
                    { "8169405544562", "New Kids on the Block", "Jazz", 0 },
                    { "6170746024978", "ABBA", "Hard Rock", 3 },
                    { "2870911328934", "B'z", "Grunge", 3 },
                    { "6468848685891", "Local Rabbits", "Caribbean Emo", 1 },
                    { "1409329443303", "Genesis", "Classic Rock", 0 },
                    { "3369878034680", "Lace", "Glam Rock", 4 },
                    { "3078274193752", "The Who", "Classical", 1 },
                    { "0673472538575", "Luciano Pavarotti", "Grunge", 0 },
                    { "8462333069601", "Ladyhawk", "Classic Jazz", 4 },
                    { "1868154808798", "Bon Jovi", "Acid House", 2 },
                    { "8725310517445", "Miriodor", "Asian R&B", 3 },
                    { "0964621026521", "Mecca Normal", "Pop", 3 },
                    { "4763989872261", "My Darkest Days", "R&B", 1 },
                    { "2424505594117", "Mountain City Four", "Brazillian Grunge", 4 },
                    { "1482147233679", "Mir", "Caribbean Rock", 1 },
                    { "8989250971809", "Fleetwood Mac", "Jazz", 1 },
                    { "8000419692704", "The Lincolns", "Funk", 1 },
                    { "3511355836228", "Library Voices", "Acid Folk", 3 },
                    { "0670072170800", "Chicago", "Jazz", 4 },
                    { "3048027896803", "Julio Iglesias", "Funk", 3 },
                    { "4135048064021", "Phil Collins", "Free Folk", 4 },
                    { "3761738098881", "Tina Turner", "Glam Jazz", 0 },
                    { "2268433237378", "Lotus Child", "Emo", 1 },
                    { "2721470577010", "Len", "Rock", 1 },
                    { "2740998781849", "Matt Mays & El Torpedo", "Easy Listening", 1 },
                    { "2421451021836", "U2", "Free Children's", 1 },
                    { "8159767191538", "Major Maker", "Classical", 1 },
                    { "7592844986748", "The Carpenters", "Classic Classical", 3 },
                    { "1226592155054", "Mandala", "Blues", 1 },
                    { "6297894019004", "Billy Joel", "Jazzy Folk", 4 },
                    { "7203176356287", "Magneta Lane", "Jazz", 2 },
                    { "4116951950351", "Merlin", "Blues", 3 },
                    { "9842640597713", "Metric", "Free Doo-Wop", 3 },
                    { "9282426772980", "Moneen", "Blues", 2 },
                    { "2118720089993", "Rihanna", "Caribbean Jazz", 2 },
                    { "9227770857489", "LMDS", "Hard Dance", 2 },
                    { "9300004411121", "U2", "Free Jazz", 0 },
                    { "8604500995833", "Left Spine Down", "Modern Jazz", 4 },
                    { "0626816947751", "Barbra Streisand", "Jazz", 3 },
                    { "5144361941822", "Lili Fatale", "Classic Rock", 2 },
                    { "1677227698623", "The Most Serene Republic", "Electronic Jazz", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "0744897241000", "The Moffatts", "Easy Listening", 1 },
                    { "5277099593344", "The Moffatts", "Electronic Jazz", 3 },
                    { "1399889030400", "MacLean & MacLean", "R&B", 2 },
                    { "7002897197893", "Machete Avenue", "Grunge", 1 },
                    { "9165884990083", "ABBA", "Avant-Garde Blues", 1 },
                    { "0551853444270", "Lost & Profound", "Electronic Blues", 2 },
                    { "0610652660688", "Madonna", "Classic Doo-Wop", 1 },
                    { "3740230815885", "The Mark Inside", "Emo", 0 },
                    { "9359831649360", "Merlin", "Avant-Garde Rock", 1 },
                    { "6492071118873", "Bee Gees", "Emo", 3 },
                    { "7144209446723", "The Luyas", "Avant-Garde Emo", 2 },
                    { "6935870853460", "Moist", "Acid Emo", 2 },
                    { "6889118208112", "Mr. Pine", "Hard Doo-Wop", 1 },
                    { "3163400480438", "Linda Ronstadt", "Asian Grunge", 3 },
                    { "2822521537543", "Lighthouse", "Glam Funk", 2 },
                    { "6393108686301", "Love Kills", "Funk", 3 },
                    { "4371435209784", "Whitney Houston", "Pop", 4 },
                    { "0383068247278", "Elvis Presley", "Modern Emo", 2 },
                    { "2607797904112", "Phil Collins", "Folk", 1 },
                    { "7722374034513", "The Lowest of the Low", "Hard Dance", 3 },
                    { "9531922811534", "Celine Dion", "Screamo", 0 },
                    { "5206777037849", "Julio Iglesias", "Screamo", 4 },
                    { "6449376399108", "Queen", "Electronic Jazz", 2 },
                    { "1684328974966", "Luther Wright and the Wrongs", "Rock", 1 },
                    { "2459509448477", "Guns N' Roses", "Screamo", 2 },
                    { "2227823952138", "Barry Manilow", "Hard Blues", 2 },
                    { "3390734782392", "Me Mom & Morgentaler", "African Rock", 2 },
                    { "3535931308307", "Mecca Normal", "Free Jazz", 1 },
                    { "0228883368791", "Kiss", "Acid Dance", 3 },
                    { "4626617780884", "The Mark Inside", "Modern Emo", 3 },
                    { "8427893470632", "Britney Spears", "Jazzy R&B", 4 },
                    { "5276064399338", "LMDS", "Classic Rock", 0 },
                    { "7180169969973", "Leslie Spit Treeo", "African Folk", 0 },
                    { "0115012172481", "Manic Drive", "Rock", 3 },
                    { "8288679369278", "Lotus Child", "African Doo-Wop", 2 },
                    { "8024508303821", "Mare", "Grunge", 3 },
                    { "2618328332491", "Mythos", "Fresh Dance", 3 },
                    { "8403967900293", "Metric", "Glam Rock", 4 },
                    { "0517994205005", "Lightning Dust", "Electronic Grunge", 4 },
                    { "2681206582942", "Max Webster", "Hard Pop", 4 },
                    { "4303429715730", "The McRackins", "Jazz", 1 },
                    { "5767549751296", "Bryan Adams", "Doo-Wop", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "9798584093376", "Bon Jovi", "Classical", 4 },
                    { "6296198984977", "The Mountains and the Trees", "Dance", 2 },
                    { "8144436924935", "Farm Fresh", "Blues", 1 },
                    { "5208634098625", "Left Spine Down", "Kansas City Children's", 0 },
                    { "0636230085074", "ABBA", "Caribbean Dance", 2 },
                    { "5135535502929", "The Matadors", "Glam Funk", 1 },
                    { "6011270228565", "Michael Jackson", "Classic House", 3 },
                    { "3411934836990", "The Look People", "Brazillian Emo", 0 },
                    { "5888960045799", "Motion Ensemble", "Classical", 0 },
                    { "7404596099484", "Rihanna", "Doo-Wop", 4 },
                    { "6021080312206", "Lime", "Modern Grunge", 0 },
                    { "3681479597629", "Loco Locass", "Pop", 3 },
                    { "7975024845354", "R.E.M.", "Asian Rock", 0 },
                    { "3243335541992", "Luke & The Apostles", "Jazzy Jazz", 4 },
                    { "6022805776271", "Ladyhawk", "Blues", 3 },
                    { "6755779189638", "Leslie Spit Treeo", "House", 0 },
                    { "1631298931951", "Luciano Pavarotti", "Acid Doo-Wop", 1 },
                    { "1771148437025", "The Mohawk Lodge", "Classic Jazz", 4 },
                    { "7410339716668", "Motion Ensemble", "Blues", 1 },
                    { "0939525329739", "The MRQ", "Rock", 0 },
                    { "2102923801667", "Mean Red Spiders", "Jazzy Jazz", 3 },
                    { "8244427618029", "Lost & Profound", "Classical", 2 },
                    { "9561077218201", "The Manvils", "Asian Screamo", 0 },
                    { "0812125901533", "George Michael", "Acid Jazz", 2 },
                    { "7695192056088", "Love Kills", "House", 1 },
                    { "8879478055740", "Red Hot Chili Peppers", "Jazzy Grunge", 0 },
                    { "6206954569508", "Lava Hay", "Electronic Rock", 2 },
                    { "5266857416368", "Metric", "Avant-Garde House", 0 },
                    { "2287910302161", "Matthew Good Band", "Classic R&B", 0 },
                    { "2503263656763", "LiveonRelease", "Hard Rock", 3 },
                    { "1311526627469", "Mes Aïeux", "African Dance", 2 },
                    { "6039179723913", "Bon Jovi", "Kansas City Doo-Wop", 1 },
                    { "1297407510709", "Major Maker", "Glam Dance", 1 },
                    { "5855777535170", "Donna Summer", "Easy Listening", 2 },
                    { "1790625049533", "Mood Ruff", "Rock", 2 },
                    { "9156666747904", "Mes Aïeux", "R&B", 1 },
                    { "1967462884311", "Mystery", "Blues", 2 },
                    { "3980609506830", "Lioness", "Doo-Wop", 2 },
                    { "7643121782578", "The Manvils", "Asian Blues", 3 },
                    { "4002069527508", "Merryweather", "Asian Jazz", 0 },
                    { "8273652623835", "Love Kills", "Kansas City Jazz", 4 },
                    { "7276659921195", "Martyr", "Brazillian Emo", 4 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "4040868159992", "Men Without Hats", "Rock", 2 },
                    { "1121836716909", "Lillix", "Children's", 3 },
                    { "3781351488822", "Manic Drive", "Acid Funk", 0 },
                    { "4551209642316", "Matt Mays & El Torpedo", "Classic Jazz", 3 },
                    { "4604291978709", "Lime", "Free Easy Listening", 2 },
                    { "1703070095021", "Men Without Hats", "Doo-Wop", 1 },
                    { "6277784144998", "The Marble Index", "Rock", 3 },
                    { "0614768255994", "Phil Collins", "African Folk", 0 },
                    { "4184060162107", "Mir", "Emo", 1 },
                    { "8263914230537", "MacLean & MacLean", "Modern Doo-Wop", 0 },
                    { "2678584242192", "LMDS", "Blues", 1 },
                    { "1907264062838", "The McRackins", "Blues", 3 },
                    { "6023819596204", "LiveonRelease", "R&B", 4 },
                    { "4101158816482", "Kiss", "Jazzy Blues", 2 },
                    { "9954431440808", "Metalwood", "Electronic Doo-Wop", 4 },
                    { "6820228601671", "Mystery Machine", "Children's", 0 },
                    { "5497895113704", "Miriodor", "Grunge", 2 },
                    { "7912779711027", "Lillix", "Easy Listening", 3 },
                    { "8566581885485", "Mariah Carey", "Funk", 3 },
                    { "8463416977173", "Loco Locass", "Classic Pop", 4 },
                    { "1265627077590", "Left Spine Down", "Fresh Pop", 2 },
                    { "1574401049287", "Celine Dion", "Jazzy House", 3 },
                    { "0446236583357", "Mr. Pine", "Rock", 1 },
                    { "3531364637983", "Tina Turner", "Easy Listening", 1 },
                    { "9146216172052", "Matthew Good Band", "Kansas City Dance", 3 },
                    { "2842495863515", "Eminem", "Grunge", 1 },
                    { "1707400073269", "Means", "Glam Funk", 0 },
                    { "5918039707076", "Mannequin Depressives", "Rock", 4 },
                    { "2146629585341", "Tina Turner", "Electronic Emo", 0 },
                    { "2571625210138", "Gloria Estefan", "Pop", 1 },
                    { "1555481290257", "Machete Avenue", "Glam R&B", 2 },
                    { "3621365918184", "The Musical Box", "Classical", 1 },
                    { "2765503827083", "Billy Joel", "Modern Jazz", 3 },
                    { "9055727330939", "Bryan Adams", "Emo", 2 },
                    { "4436576966597", "Mes Aïeux", "Blues", 3 },
                    { "3799455718012", "Love Kills", "Rock", 1 },
                    { "2365263777151", "Mare", "Acid Children's", 2 },
                    { "8336661010777", "Kenny Rogers", "Caribbean Pop", 0 },
                    { "3358121730508", "Barry Manilow", "Hard Emo", 3 },
                    { "0580642117164", "Lightning Dust", "Acid Grunge", 0 },
                    { "5531344435956", "New Kids on the Block", "Pop", 0 },
                    { "5526364087539", "Lost Dakotas", "Blues", 2 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "5013370581040", "The Look People", "Fresh Grunge", 0 },
                    { "6172624301890", "Merryweather", "Dance", 0 },
                    { "3610516059958", "Aerosmith", "Emo", 1 },
                    { "3975031435186", "Land of Talk", "African Doo-Wop", 4 },
                    { "1622164584453", "Lost Dakotas", "Blues", 2 },
                    { "3774631174731", "B'z", "Modern Easy Listening", 4 },
                    { "2981051687370", "Memphis", "Dance", 0 },
                    { "7230647740134", "The Midway State", "Glam Jazz", 0 },
                    { "4928775008322", "Moist", "Brazillian Emo", 4 },
                    { "4517493431268", "The Manvils", "Classic Folk", 1 },
                    { "4458251614303", "Mariah Carey", "Children's", 3 },
                    { "2883359286910", "Men Without Hats", "Caribbean Grunge", 3 },
                    { "1599518498832", "The Mahones", "Blues", 2 },
                    { "5561264111829", "Monster Voodoo Machine", "House", 4 },
                    { "7938028306804", "L'Étranger", "Emo", 1 },
                    { "7002911502081", "Lace", "Classical", 3 },
                    { "4536977894373", "The Marble Index", "Jazz", 4 },
                    { "3593067528125", "Lace", "Asian Blues", 2 },
                    { "4963438740764", "Kate and Anna McGarrigle", "Hard Jazz", 0 },
                    { "6129882601582", "Memoryhouse", "Emo", 1 },
                    { "9737873064009", "Cher", "Asian Doo-Wop", 2 },
                    { "9343564533692", "Moxy", "Electronic R&B", 2 },
                    { "7281914785760", "The Lincolns", "Grunge", 3 },
                    { "0379925197243", "Monster Voodoo Machine", "Classical", 0 },
                    { "6937661099509", "The McRackins", "Fresh Rock", 4 },
                    { "2474111867925", "George Michael", "Jazzy Folk", 2 },
                    { "3098590755149", "Liferuiner", "Blues", 0 },
                    { "2484108933994", "Metallica", "Jazzy Emo", 2 },
                    { "1009915044552", "Mercy, the Sexton", "African Children's", 2 },
                    { "8815799358556", "The Marble Index", "Children's", 4 },
                    { "0472412984797", "Ladyhawk", "Dance", 1 },
                    { "2671934227518", "Memphis", "Funk", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1945, 10, 9, 9, 48, 10, 0, DateTimeKind.Unspecified), "sydneyıginla@libra.ry", "Sydney", "5282 24th Street ", "Iginla", "(446) 428-6883", new DateTime(2020, 6, 25, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1924, 9, 6, 1, 9, 24, 0, DateTimeKind.Unspecified), "silviarichardson@libra.ry", "Silvia", "5173 Church Lane ", "Richardson", "(790) 488-7472", new DateTime(2019, 2, 23, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 3,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(2019, 9, 2, 12, 59, 49, 0, DateTimeKind.Unspecified), "nataliefoster@libra.ry", "Natalie", "6274 Strauss Street ", "Foster", "(248) 531-9455", new DateTime(2019, 7, 10, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 4,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1914, 11, 26, 22, 42, 44, 0, DateTimeKind.Unspecified), "jadamiller@libra.ry", "Jada", "2804 Beverly Road ", "Miller", "(372) 422-3356", new DateTime(2020, 6, 5, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 5,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1919, 6, 18, 9, 53, 3, 0, DateTimeKind.Unspecified), "jadetorres@libra.ry", "Jade", "2681 38th Street ", "Torres", "(498) 232-2190", new DateTime(2020, 7, 2, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 6,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1957, 10, 28, 10, 4, 36, 0, DateTimeKind.Unspecified), "lindseymoore@libra.ry", "Lindsey", "5820 Hazel Court ", "Moore", "(575) 379-1342", new DateTime(2019, 1, 13, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 7,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1959, 4, 8, 22, 12, 9, 0, DateTimeKind.Unspecified), "samanthatorres@libra.ry", "Samantha", "1849 Grove Street ", "Torres", "(720) 316-3762", new DateTime(2018, 9, 5, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 8,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(2015, 10, 18, 9, 8, 20, 0, DateTimeKind.Unspecified), "amandafoster@libra.ry", "Amanda", "4106 Billings Place ", "Foster", "(445) 233-8906", new DateTime(2020, 5, 18, 0, 51, 59, 326, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 9,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1995, 11, 22, 11, 14, 53, 0, DateTimeKind.Unspecified), "jordanroberts@libra.ry", "Jordan", "1475 Pierrepont Place ", "Roberts", "(285) 646-0359", new DateTime(2019, 8, 12, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 10,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(2013, 8, 18, 22, 8, 3, 0, DateTimeKind.Unspecified), "jennagarcia@libra.ry", "Jenna", "8855 Ridgewood Place ", "Garcia", "(695) 311-0252", new DateTime(2020, 4, 10, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 11,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1963, 2, 22, 11, 7, 7, 0, DateTimeKind.Unspecified), "amandarodriguez@libra.ry", "Amanda", "6903 Branton Street ", "Rodriguez", "(702) 732-0790", new DateTime(2020, 11, 22, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 12,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1921, 1, 1, 3, 11, 28, 0, DateTimeKind.Unspecified), "brandonmiller@libra.ry", "Brandon", "1493 Boynton Place ", "Miller", "(433) 230-6315", new DateTime(2018, 6, 28, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 13,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1936, 3, 22, 10, 36, 38, 0, DateTimeKind.Unspecified), "kennethmartinez@libra.ry", "Kenneth", "3856 Olean Street ", "Martinez", "(327) 336-7046", new DateTime(2020, 1, 27, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 14,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1969, 7, 3, 22, 43, 46, 0, DateTimeKind.Unspecified), "katiesimmons@libra.ry", "Katie", "692 Nolans Lane ", "Simmons", "(746) 742-1463", new DateTime(2019, 10, 24, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 15,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1945, 2, 3, 17, 58, 13, 0, DateTimeKind.Unspecified), "jacobdavis@libra.ry", "Jacob", "2603 Narrows Avenue ", "Davis", "(623) 677-9745", new DateTime(2019, 5, 13, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 16,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1931, 10, 14, 3, 56, 15, 0, DateTimeKind.Unspecified), "chloefoster@libra.ry", "Chloe", "9825 Shell Road ", "Foster", "(575) 605-8513", new DateTime(2020, 12, 14, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 17,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(2019, 4, 8, 13, 24, 40, 0, DateTimeKind.Unspecified), "ashleyphillips@libra.ry", "Ashley", "9944 Meserole Street ", "Phillips", "(572) 282-7252", new DateTime(2020, 11, 22, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 18,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1992, 10, 22, 1, 40, 14, 0, DateTimeKind.Unspecified), "abigaildavis@libra.ry", "Abigail", "4107 Delmonico Place ", "Davis", "(264) 511-9081", new DateTime(2018, 5, 30, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 19,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(2017, 10, 13, 16, 25, 41, 0, DateTimeKind.Unspecified), "haleyjackson@libra.ry", "Haley", "2163 27th Avenue ", "Jackson", "(276) 367-4691", new DateTime(2019, 2, 24, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 20,
                columns: new[] { "BirthDate", "EmailAddress", "FirstName", "HomeAddress", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[] { new DateTime(1949, 10, 31, 18, 19, 26, 0, DateTimeKind.Unspecified), "sierracarter@libra.ry", "Sierra", "5322 Marginal Street ", "Carter", "(329) 304-8362", new DateTime(2020, 1, 20, 0, 51, 59, 327, DateTimeKind.Local).AddTicks(5364) });

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
                keyValue: "0115012172481");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0228883368791");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0379925197243");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0383068247278");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0446236583357");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0472412984797");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0517994205005");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0551853444270");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0580642117164");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0610652660688");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0614768255994");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0626816947751");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0636230085074");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0670072170800");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0673472538575");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0744897241000");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0812125901533");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0939525329739");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "0964621026521");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1009915044552");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1121836716909");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1226592155054");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1265627077590");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1297407510709");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1311526627469");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1399889030400");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1409329443303");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1482147233679");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1555481290257");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1574401049287");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1599518498832");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1622164584453");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1631298931951");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1677227698623");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1684328974966");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1703070095021");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1707400073269");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1771148437025");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1790625049533");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1868154808798");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1907264062838");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "1967462884311");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2102923801667");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2118720089993");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2146629585341");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2227823952138");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2268433237378");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2287910302161");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2365263777151");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2421451021836");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2424505594117");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2459509448477");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2474111867925");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2484108933994");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2503263656763");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2571625210138");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2607797904112");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2618328332491");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2671934227518");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2678584242192");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2681206582942");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2721470577010");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2740998781849");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2765503827083");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2822521537543");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2842495863515");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2870911328934");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2883359286910");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "2981051687370");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3048027896803");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3078274193752");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3098590755149");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3163400480438");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3243335541992");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3358121730508");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3369878034680");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3390734782392");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3411934836990");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3511355836228");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3531364637983");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3535931308307");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3593067528125");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3610516059958");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3621365918184");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3681479597629");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3740230815885");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3761738098881");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3774631174731");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3781351488822");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3799455718012");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3975031435186");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "3980609506830");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4002069527508");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4040868159992");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4101158816482");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4116951950351");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4135048064021");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4184060162107");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4303429715730");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4371435209784");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4436576966597");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4458251614303");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4517493431268");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4536977894373");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4551209642316");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4604291978709");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4626617780884");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4763989872261");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4928775008322");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "4963438740764");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5013370581040");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5135535502929");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5144361941822");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5206777037849");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5208634098625");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5266857416368");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5276064399338");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5277099593344");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5497895113704");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5526364087539");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5531344435956");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5561264111829");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5767549751296");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5855777535170");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5888960045799");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "5918039707076");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6011270228565");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6021080312206");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6022805776271");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6023819596204");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6039179723913");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6129882601582");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6170746024978");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6172624301890");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6206954569508");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6277784144998");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6296198984977");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6297894019004");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6393108686301");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6449376399108");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6468848685891");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6492071118873");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6755779189638");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6820228601671");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6889118208112");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6935870853460");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "6937661099509");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7002897197893");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7002911502081");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7144209446723");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7180169969973");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7203176356287");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7230647740134");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7276659921195");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7281914785760");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7404596099484");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7410339716668");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7592844986748");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7643121782578");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7695192056088");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7722374034513");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7912779711027");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7938028306804");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "7975024845354");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8000419692704");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8024508303821");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8144436924935");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8159767191538");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8169405544562");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8244427618029");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8263914230537");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8273652623835");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8288679369278");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8336661010777");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8403967900293");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8427893470632");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8462333069601");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8463416977173");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8566581885485");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8604500995833");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8725310517445");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8815799358556");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8879478055740");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "8989250971809");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9055727330939");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9146216172052");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9156666747904");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9165884990083");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9227770857489");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9282426772980");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9300004411121");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9343564533692");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9359831649360");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9531922811534");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9561077218201");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9737873064009");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9798584093376");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9842640597713");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9873236987863");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "IsbnId",
                keyValue: "9954431440808");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BookTransactions");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "BookTransactions");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "BookTransactions",
                columns: new[] { "TransactionId", "BookIsbnId", "EndDate", "IsbnId", "MemberId", "StartDate" },
                values: new object[,]
                {
                    { 21, null, new DateTime(1953, 8, 11, 18, 58, 32, 0, DateTimeKind.Unspecified), "7566978182067", 1, new DateTime(1995, 8, 7, 18, 18, 5, 0, DateTimeKind.Unspecified) },
                    { 22, null, new DateTime(2005, 1, 15, 21, 34, 24, 0, DateTimeKind.Unspecified), "4016344283136", 2, new DateTime(1954, 10, 2, 8, 39, 17, 0, DateTimeKind.Unspecified) },
                    { 23, null, new DateTime(1938, 10, 10, 14, 34, 39, 0, DateTimeKind.Unspecified), "4885244068443", 3, new DateTime(1979, 4, 24, 18, 46, 3, 0, DateTimeKind.Unspecified) },
                    { 24, null, new DateTime(1928, 12, 17, 19, 29, 53, 0, DateTimeKind.Unspecified), "9491966923493", 4, new DateTime(1976, 1, 10, 16, 41, 58, 0, DateTimeKind.Unspecified) },
                    { 25, null, new DateTime(2010, 8, 7, 17, 11, 43, 0, DateTimeKind.Unspecified), "6889629773489", 5, new DateTime(2015, 8, 14, 12, 30, 21, 0, DateTimeKind.Unspecified) },
                    { 26, null, new DateTime(1902, 7, 11, 19, 1, 1, 0, DateTimeKind.Unspecified), "9038110524465", 6, new DateTime(1910, 2, 18, 13, 54, 1, 0, DateTimeKind.Unspecified) },
                    { 28, null, new DateTime(1980, 1, 10, 21, 52, 24, 0, DateTimeKind.Unspecified), "4327640555308", 8, new DateTime(2008, 11, 24, 0, 57, 4, 0, DateTimeKind.Unspecified) },
                    { 29, null, new DateTime(1990, 9, 18, 16, 13, 13, 0, DateTimeKind.Unspecified), "1507139565229", 9, new DateTime(2015, 9, 27, 13, 24, 52, 0, DateTimeKind.Unspecified) },
                    { 30, null, new DateTime(1983, 6, 6, 2, 40, 12, 0, DateTimeKind.Unspecified), "0432048934301", 10, new DateTime(1929, 1, 15, 3, 41, 26, 0, DateTimeKind.Unspecified) },
                    { 31, null, new DateTime(1903, 4, 26, 19, 50, 23, 0, DateTimeKind.Unspecified), "9730097015298", 11, new DateTime(2006, 8, 9, 23, 32, 16, 0, DateTimeKind.Unspecified) },
                    { 27, null, new DateTime(1909, 4, 1, 22, 8, 50, 0, DateTimeKind.Unspecified), "8682541963320", 7, new DateTime(1967, 12, 11, 2, 50, 41, 0, DateTimeKind.Unspecified) },
                    { 33, null, new DateTime(2017, 9, 24, 3, 44, 26, 0, DateTimeKind.Unspecified), "8998854048595", 13, new DateTime(1968, 12, 19, 11, 21, 25, 0, DateTimeKind.Unspecified) },
                    { 32, null, new DateTime(1928, 3, 11, 15, 15, 28, 0, DateTimeKind.Unspecified), "1363954059778", 12, new DateTime(1992, 1, 27, 18, 2, 31, 0, DateTimeKind.Unspecified) },
                    { 39, null, new DateTime(2001, 2, 28, 2, 28, 16, 0, DateTimeKind.Unspecified), "7646690586523", 19, new DateTime(2000, 9, 8, 19, 15, 31, 0, DateTimeKind.Unspecified) },
                    { 38, null, new DateTime(1969, 4, 20, 19, 14, 1, 0, DateTimeKind.Unspecified), "9280308286998", 18, new DateTime(2014, 7, 21, 13, 31, 19, 0, DateTimeKind.Unspecified) },
                    { 37, null, new DateTime(1978, 10, 30, 1, 39, 32, 0, DateTimeKind.Unspecified), "3430089775499", 17, new DateTime(1914, 8, 18, 9, 48, 51, 0, DateTimeKind.Unspecified) },
                    { 40, null, new DateTime(1903, 11, 4, 19, 25, 45, 0, DateTimeKind.Unspecified), "9578877800599", 20, new DateTime(1966, 10, 17, 4, 39, 37, 0, DateTimeKind.Unspecified) },
                    { 35, null, new DateTime(1927, 10, 6, 8, 0, 39, 0, DateTimeKind.Unspecified), "1717993753416", 15, new DateTime(1989, 10, 12, 15, 36, 44, 0, DateTimeKind.Unspecified) },
                    { 34, null, new DateTime(1902, 10, 31, 5, 3, 16, 0, DateTimeKind.Unspecified), "8304590763036", 14, new DateTime(1936, 1, 29, 21, 3, 24, 0, DateTimeKind.Unspecified) },
                    { 36, null, new DateTime(2020, 12, 12, 14, 46, 26, 0, DateTimeKind.Unspecified), "2590367690606", 16, new DateTime(1934, 5, 28, 22, 40, 47, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "IsbnId", "Author", "BookName", "Count" },
                values: new object[,]
                {
                    { "4433793318090", "Lili Fatale", "Avant-Garde Jazz", 0 },
                    { "8280825102352", "The Mohawk Lodge", "African Pop", 0 },
                    { "7010644927183", "The Carpenters", "Blues", 0 },
                    { "9723527373626", "The Mynah Birds", "Classical", 0 },
                    { "0557998412466", "Mariah Carey", "Glam Easy Listening", 0 },
                    { "0026710159404", "B'z", "Free Pop", 0 },
                    { "3730598868691", "Little Caesar and the Consuls", "Modern Jazz", 0 },
                    { "5919019513571", "The Lowest of the Low", "Pop", 0 },
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
