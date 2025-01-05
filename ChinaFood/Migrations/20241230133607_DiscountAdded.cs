using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChinaFood.Migrations
{
    /// <inheritdoc />
    public partial class DiscountAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("192c267f-aa05-4c52-b989-da1172234966"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("237a2729-a314-4da1-8589-d6a26a2ac5c5"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("3a5a553c-f617-483a-bccd-d52c7dc4391f"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("46060f79-cb42-4273-91aa-b8ea163a40c5"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("4795a0e0-5659-45e7-bbbf-3adf2ff32000"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("51dddbc4-56fb-4392-b36a-229b9ca14372"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("5ce4d82b-c4a4-40c1-ba2a-fbecc3325fab"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("631bebc5-5eac-4d17-9a03-0f717ac1b750"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("6b518d90-f3dc-4ac7-9b9e-0e3fe99c1179"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("6b7a1d12-32a6-4c90-959c-75eceb117763"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("6f59c965-6c31-4c2f-93e4-fb06e4d1c02a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("79f56c5a-048f-4037-b224-76f23e318fd8"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("7e492f07-96d3-4bc0-8457-44aba3a2108d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("910640b3-4543-49d3-8255-766af4e4adef"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("a97dfec5-1539-41d9-80fd-b9e71be367a2"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("c64e3df8-5574-41cc-8755-42046390c5bd"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("dbbf4fc9-4b4d-48e7-8849-12cb2e530684"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("fef4d7c3-c413-4f15-acb0-f5003c620e15"));

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96610323-439a-4715-be46-cb12efe37774", "AQAAAAIAAYagAAAAEPTNVU5g3LFlHiDxn75YgUTRivaiaiU8XDuTZhNIW604aqtFIhujra8o61lK1P+XFg==" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "DateAdded", "Discount", "DishType", "MetaDescription", "MetaKeywords", "MetaTitle", "Price", "SubCategoryId", "SubtitleArm", "SubtitleEn", "SubtitleRu", "TextArm", "TextEn", "TextRu", "TitleArm", "TitleEn", "TitleImagePath", "TitleRu" },
                values: new object[,]
                {
                    { new Guid("0234ebd9-f29c-45e1-82c4-e92c9f48b05d"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3051), 0, 0, null, null, null, 10.20m, new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), null, "Spicy Sichuan tofu", null, null, null, null, "Մա Պո Թոֆու", "Ma Po Tofu", null, "Ма По Тофу" },
                    { new Guid("051d8fa0-7bfb-452f-bbb2-e7f7c276990d"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3380), 0, 2, null, null, null, 7.00m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Tea with tapioca pearls", null, null, null, null, "Բուբլ Թեյ", "Bubble Tea", null, "Бабл-чай" },
                    { new Guid("066cd1e6-8557-4d89-9b56-740bcd704acb"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3353), 0, 1, null, null, null, 14.50m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Noodle soup with various toppings", null, null, null, null, "Ռամեն", "Ramen", null, "Рамен" },
                    { new Guid("13d642ca-356d-4174-8be6-3a7e4b7152dc"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3383), 0, 2, null, null, null, 4.50m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Chinese black tea", null, null, null, null, "Սև Թեյ", "Black Tea", null, "Черный чай" },
                    { new Guid("1a15c39f-13a5-4823-aaf6-5af32b554ae6"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3066), 0, 0, null, null, null, 7.80m, new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), null, "Traditional Chinese dumplings", null, null, null, null, "Դիմ Սում", "Dim Sum", null, "Дим Сам" },
                    { new Guid("29cf0695-512e-4894-ae0c-ca3c00ce36c3"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3057), 0, 0, null, null, null, 8.75m, new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), null, "Crispy duck with sauce", null, null, null, null, "Պեկինյան Բադ", "Peking Duck", null, "Пекинская утка" },
                    { new Guid("3644568d-483e-402b-903e-1c07b7087d7a"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3109), 0, 1, null, null, null, 12.99m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Traditional Japanese rice and fish", null, null, null, null, "Սուշի", "Sushi", null, "Суши" },
                    { new Guid("3fe1e60f-1bdb-43c5-9afc-d72c4a59bace"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3356), 0, 1, null, null, null, 11.25m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Battered and fried seafood or vegetables", null, null, null, null, "Տեմպուրա", "Tempura", null, "Темпура" },
                    { new Guid("4b55efdb-5fe5-4787-b1e5-5c0d7be0d1db"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3048), 0, 0, null, null, null, 15.50m, new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), null, "Traditional sweet pork", null, null, null, null, "Քաղցր և Թթու Խոզ", "Sweet and Sour Pork", null, "Сладкая и кислая свинина" },
                    { new Guid("73a0663b-8a96-4c9b-8558-8d2fd82d1038"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3362), 0, 1, null, null, null, 10.99m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Fresh sliced raw fish", null, null, null, null, "Սաշիմի", "Sashimi", null, "Сашими" },
                    { new Guid("8b3fd35b-1ed1-459a-ab70-573e00f35e71"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3375), 0, 2, null, null, null, 4.75m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Chinese tea", null, null, null, null, "Օլոնգ Թեյ", "Oolong Tea", null, "Улун чай" },
                    { new Guid("95c87c01-c0fc-43e2-b6f2-6f36f08ff7d2"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3365), 0, 1, null, null, null, 15.99m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Grilled skewered chicken", null, null, null, null, "Յակիտորի", "Yakitori", null, "Якитори" },
                    { new Guid("abf55ff8-d618-44d7-80f5-b795c688ae90"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3378), 0, 2, null, null, null, 3.99m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Scented green tea", null, null, null, null, "Յասմին Թեյ", "Jasmine Tea", null, "Жасминовый чай" },
                    { new Guid("bb0cac24-254d-46e5-a3b2-29f345d60bb8"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3367), 0, 2, null, null, null, 5.99m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Traditional Japanese tea", null, null, null, null, "Կանաչ Թեյ", "Green Tea", null, "Зеленый чай" },
                    { new Guid("c1d0a479-0f37-42a6-9cc7-38194b430307"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3359), 0, 1, null, null, null, 13.30m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Thick wheat flour noodles", null, null, null, null, "Ուդոն", "Udon", null, "Удон" },
                    { new Guid("c80db0fc-6887-43a6-82fb-b8b1c383b8c9"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3370), 0, 2, null, null, null, 6.50m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Japanese rice wine", null, null, null, null, "Սակե", "Sake", null, "Саке" },
                    { new Guid("f5704a8e-4731-41aa-b37b-dc387332cc09"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3044), 0, 0, null, null, null, 12.99m, new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), null, "Spicy stir-fried chicken", null, null, null, null, "Կունգ Պաո Հավ", "Kung Pao Chicken", null, "Кунг Пао Курочка" },
                    { new Guid("fe90c449-5cec-496b-a234-f57a4be76345"), new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(3063), 0, 0, null, null, null, 9.99m, new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), null, "Crispy fried rolls", null, null, null, null, "Գարնանային Շարունակվածքներ", "Spring Rolls", null, "Весенние роллы" }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3538e8ff-aeac-4ca1-aa68-9fa34d0453d5"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("49803b04-2981-4d3f-99fb-34c0e41a64b6"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4deeef11-00ca-4fcd-9184-431d15e9e39d"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("63f6c1d4-b259-48fd-9bd3-9c8dc5ce7838"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8dd7be8f-742a-4d01-bcc9-c7a276027c17"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e395771-48ce-46ea-95c9-806fae12946f"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfbd9fd9-f98f-42ec-99cb-a14545c89ecc"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc70a381-ba5c-4a1f-bb63-c7d0d8c52188"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7ae30c0-5ec7-4736-8302-c7553a9516a2"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 30, 13, 36, 6, 669, DateTimeKind.Utc).AddTicks(2854));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("0234ebd9-f29c-45e1-82c4-e92c9f48b05d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("051d8fa0-7bfb-452f-bbb2-e7f7c276990d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("066cd1e6-8557-4d89-9b56-740bcd704acb"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("13d642ca-356d-4174-8be6-3a7e4b7152dc"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("1a15c39f-13a5-4823-aaf6-5af32b554ae6"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("29cf0695-512e-4894-ae0c-ca3c00ce36c3"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("3644568d-483e-402b-903e-1c07b7087d7a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("3fe1e60f-1bdb-43c5-9afc-d72c4a59bace"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("4b55efdb-5fe5-4787-b1e5-5c0d7be0d1db"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("73a0663b-8a96-4c9b-8558-8d2fd82d1038"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("8b3fd35b-1ed1-459a-ab70-573e00f35e71"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("95c87c01-c0fc-43e2-b6f2-6f36f08ff7d2"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("abf55ff8-d618-44d7-80f5-b795c688ae90"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("bb0cac24-254d-46e5-a3b2-29f345d60bb8"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("c1d0a479-0f37-42a6-9cc7-38194b430307"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("c80db0fc-6887-43a6-82fb-b8b1c383b8c9"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("f5704a8e-4731-41aa-b37b-dc387332cc09"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("fe90c449-5cec-496b-a234-f57a4be76345"));

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Dishes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54c77c62-ce1c-46c5-8b65-d345a0e2f9b6", "AQAAAAIAAYagAAAAEN8DsXYrvJAs0S3CZvVySsrdxJChhWyDynf2UYF4nskvM/DDOXewY2qoWCdlL+wY/Q==" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "DateAdded", "DishType", "MetaDescription", "MetaKeywords", "MetaTitle", "Price", "SubCategoryId", "SubtitleArm", "SubtitleEn", "SubtitleRu", "TextArm", "TextEn", "TextRu", "TitleArm", "TitleEn", "TitleImagePath", "TitleRu" },
                values: new object[,]
                {
                    { new Guid("192c267f-aa05-4c52-b989-da1172234966"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9747), 0, null, null, null, 9.99m, new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), null, "Crispy fried rolls", null, null, null, null, "Գարնանային Շարունակվածքներ", "Spring Rolls", null, "Весенние роллы" },
                    { new Guid("237a2729-a314-4da1-8589-d6a26a2ac5c5"), new DateTime(2024, 12, 16, 19, 15, 31, 34, DateTimeKind.Utc).AddTicks(28), 2, null, null, null, 4.50m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Chinese black tea", null, null, null, null, "Սև Թեյ", "Black Tea", null, "Черный чай" },
                    { new Guid("3a5a553c-f617-483a-bccd-d52c7dc4391f"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9735), 0, null, null, null, 12.99m, new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), null, "Spicy stir-fried chicken", null, null, null, null, "Կունգ Պաո Հավ", "Kung Pao Chicken", null, "Кунг Пао Курочка" },
                    { new Guid("46060f79-cb42-4273-91aa-b8ea163a40c5"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9766), 1, null, null, null, 11.25m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Battered and fried seafood or vegetables", null, null, null, null, "Տեմպուրա", "Tempura", null, "Темпура" },
                    { new Guid("4795a0e0-5659-45e7-bbbf-3adf2ff32000"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9749), 0, null, null, null, 7.80m, new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), null, "Traditional Chinese dumplings", null, null, null, null, "Դիմ Սում", "Dim Sum", null, "Дим Сам" },
                    { new Guid("51dddbc4-56fb-4392-b36a-229b9ca14372"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9780), 2, null, null, null, 6.50m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Japanese rice wine", null, null, null, null, "Սակե", "Sake", null, "Саке" },
                    { new Guid("5ce4d82b-c4a4-40c1-ba2a-fbecc3325fab"), new DateTime(2024, 12, 16, 19, 15, 31, 34, DateTimeKind.Utc).AddTicks(22), 2, null, null, null, 3.99m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Scented green tea", null, null, null, null, "Յասմին Թեյ", "Jasmine Tea", null, "Жасминовый чай" },
                    { new Guid("631bebc5-5eac-4d17-9a03-0f717ac1b750"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9772), 1, null, null, null, 10.99m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Fresh sliced raw fish", null, null, null, null, "Սաշիմի", "Sashimi", null, "Сашими" },
                    { new Guid("6b518d90-f3dc-4ac7-9b9e-0e3fe99c1179"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9738), 0, null, null, null, 15.50m, new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), null, "Traditional sweet pork", null, null, null, null, "Քաղցր և Թթու Խոզ", "Sweet and Sour Pork", null, "Сладкая и кислая свинина" },
                    { new Guid("6b7a1d12-32a6-4c90-959c-75eceb117763"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9777), 2, null, null, null, 5.99m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Traditional Japanese tea", null, null, null, null, "Կանաչ Թեյ", "Green Tea", null, "Зеленый чай" },
                    { new Guid("6f59c965-6c31-4c2f-93e4-fb06e4d1c02a"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9741), 0, null, null, null, 10.20m, new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), null, "Spicy Sichuan tofu", null, null, null, null, "Մա Պո Թոֆու", "Ma Po Tofu", null, "Ма По Тофу" },
                    { new Guid("79f56c5a-048f-4037-b224-76f23e318fd8"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9763), 1, null, null, null, 14.50m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Noodle soup with various toppings", null, null, null, null, "Ռամեն", "Ramen", null, "Рамен" },
                    { new Guid("7e492f07-96d3-4bc0-8457-44aba3a2108d"), new DateTime(2024, 12, 16, 19, 15, 31, 34, DateTimeKind.Utc).AddTicks(25), 2, null, null, null, 7.00m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Tea with tapioca pearls", null, null, null, null, "Բուբլ Թեյ", "Bubble Tea", null, "Бабл-чай" },
                    { new Guid("910640b3-4543-49d3-8255-766af4e4adef"), new DateTime(2024, 12, 16, 19, 15, 31, 34, DateTimeKind.Utc).AddTicks(19), 2, null, null, null, 4.75m, new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), null, "Chinese tea", null, null, null, null, "Օլոնգ Թեյ", "Oolong Tea", null, "Улун чай" },
                    { new Guid("a97dfec5-1539-41d9-80fd-b9e71be367a2"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9760), 1, null, null, null, 12.99m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Traditional Japanese rice and fish", null, null, null, null, "Սուշի", "Sushi", null, "Суши" },
                    { new Guid("c64e3df8-5574-41cc-8755-42046390c5bd"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9775), 1, null, null, null, 15.99m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Grilled skewered chicken", null, null, null, null, "Յակիտորի", "Yakitori", null, "Якитори" },
                    { new Guid("dbbf4fc9-4b4d-48e7-8849-12cb2e530684"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9744), 0, null, null, null, 8.75m, new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), null, "Crispy duck with sauce", null, null, null, null, "Պեկինյան Բադ", "Peking Duck", null, "Пекинская утка" },
                    { new Guid("fef4d7c3-c413-4f15-acb0-f5003c620e15"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9769), 1, null, null, null, 13.30m, new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), null, "Thick wheat flour noodles", null, null, null, null, "Ուդոն", "Udon", null, "Удон" }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3538e8ff-aeac-4ca1-aa68-9fa34d0453d5"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("49803b04-2981-4d3f-99fb-34c0e41a64b6"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4deeef11-00ca-4fcd-9184-431d15e9e39d"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("63f6c1d4-b259-48fd-9bd3-9c8dc5ce7838"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8dd7be8f-742a-4d01-bcc9-c7a276027c17"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e395771-48ce-46ea-95c9-806fae12946f"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfbd9fd9-f98f-42ec-99cb-a14545c89ecc"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc70a381-ba5c-4a1f-bb63-c7d0d8c52188"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f7ae30c0-5ec7-4736-8302-c7553a9516a2"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"),
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9663));
        }
    }
}
