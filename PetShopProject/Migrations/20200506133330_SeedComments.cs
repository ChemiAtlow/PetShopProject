using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShopProject.Migrations
{
    public partial class SeedComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "AnimalId", "CommentText" },
                values: new object[,]
                {
                    { 1, 1, "נראה כמו וולדמורט של החתולים 🤔" },
                    { 28, 15, "מטורף לגמרי!" },
                    { 27, 15, "ללא ספק מהדגים היפים שראיתי!" },
                    { 24, 15, "ואוו! חיה מרהיבה!" },
                    { 23, 14, "לא הבנתי מה אפריקאי בציקליד הזה!" },
                    { 26, 13, "אפשר לאכול דגי זהב בתור סושי?" },
                    { 22, 13, "תכל'ס אין על דגי זהב..." },
                    { 21, 12, "לפחות צבעים יפים יש לה 🤷🏼‍♂️" },
                    { 20, 11, "אמרת כאב ראש אמרת קקדו לבן." },
                    { 19, 10, "אל תתקרבו לחיה הזו! היא תנכר לכם במוח כל היום!" },
                    { 18, 10, @"בלי ספק חיה נוראי.
                הלשלשת שלה זו מכה שאין לה מענה!" },
                    { 17, 9, "חיה נוראית. לא כיף לי איתה!" },
                    { 16, 8, "ישש לי כלב מסוג האסקי סיבירי והוא מיילל כל הזמן. כדאי להביא עוד כלב לבית מסוג זה?" },
                    { 15, 8, "יש לי כלב האסקי סיבירי בין חודש ושבוע ורציתי לדעת אם אני כבר יכול להתחיל ללמד אותו לא לעשות את הצרכים בבית ואיך?" },
                    { 14, 8, "היי, אני רוצה כלב ואמא שלי מוכנה רק כלב בלי נשירת שיער כמו פודל או יורקשייר... אבל אני רוצה האסקי סיבירי, יש לו נשירה?" },
                    { 13, 8, "יש לי גור בן 4 שבועות מסוג האסקי סיבירי צבע העניים שלו כחול ים. אני חושב שהוא עיוור. איך אוכל לברר זאת?" },
                    { 12, 7, "האם הוא נוחר בשנתו?" },
                    { 11, 7, " אם משאירים אותו לכמה שעות הוא עושה רעשים?" },
                    { 10, 7, "האם אפשר לאלף אותו שלא יעשה את צרכיו בבית? 💩" },
                    { 9, 6, "לפודל שלנו יש הפרשה חומה מהעין האם זאת דלקת?" },
                    { 8, 6, "שלום, יש לי פודלית ננסית והיא לפעמים עושה פיפי על המיטות כאשר אנחנו לא בבית, בנוסף היא עושה את צרכיה בלילה. איך אפשר למנוע ממנה לעשות זאת?" },
                    { 7, 5, "אוי, האושר בעיניים!" },
                    { 6, 5, "ורנון דרסלי בגרסה הכלבית! 🐶" },
                    { 5, 4, "מה זה הדבר הזה 😰" },
                    { 4, 4, "💩" },
                    { 3, 3, "אין על Grumpy Cat 😾" },
                    { 30, 2, "מזכיר לי חבר ילדות שלי!" },
                    { 2, 2, "נמר מיניאטורי! 😍" },
                    { 25, 16, "איזה מין שם זה אלטום?" },
                    { 29, 16, "לא מועיל, אבל גם לא מזיק..." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 30);
        }
    }
}
