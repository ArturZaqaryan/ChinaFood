using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChinaFood.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishType = table.Column<int>(type: "int", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DishType = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dishes_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubtitleRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextArm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.DishId });
                    table.ForeignKey(
                        name: "FK_OrderItems_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, null, "54c77c62-ce1c-46c5-8b65-d345a0e2f9b6", "my@email.com", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEN8DsXYrvJAs0S3CZvVySsrdxJChhWyDynf2UYF4nskvM/DDOXewY2qoWCdlL+wY/Q==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "DateAdded", "DishType", "MetaDescription", "MetaKeywords", "MetaTitle", "SubtitleArm", "SubtitleEn", "SubtitleRu", "TextArm", "TextEn", "TextRu", "TitleArm", "TitleEn", "TitleImagePath", "TitleRu" },
                values: new object[,]
                {
                    { new Guid("3538e8ff-aeac-4ca1-aa68-9fa34d0453d5"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9655), 0, null, null, null, null, null, null, null, null, null, "Խոզի մսով կերակուրներ", "Pork dishes", null, "Блюда из свинины" },
                    { new Guid("49803b04-2981-4d3f-99fb-34c0e41a64b6"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9648), 0, null, null, null, null, null, null, null, null, null, "Լապշաներ", "Noodles", null, "Лапша" },
                    { new Guid("4deeef11-00ca-4fcd-9184-431d15e9e39d"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9652), 0, null, null, null, null, null, null, null, null, null, "Բրինձներ, հաց", "Rice and bread", null, "Рис, хлеб" },
                    { new Guid("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9631), 0, null, null, null, null, null, null, null, null, null, "Աղցաններ", "Salads", null, "Салаты" },
                    { new Guid("63f6c1d4-b259-48fd-9bd3-9c8dc5ce7838"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9662), 0, null, null, null, null, null, null, null, null, null, "Պիլմենիներ", "Dumplings", null, "пельмени" },
                    { new Guid("83beee31-2b8d-488a-b6a0-2b672d515720"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9665), 2, null, null, null, null, null, null, null, null, null, "Թեյեր", "Tea's", null, "Чайы" },
                    { new Guid("8dd7be8f-742a-4d01-bcc9-c7a276027c17"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9659), 0, null, null, null, null, null, null, null, null, null, "Ճագարի մսով կերակուրներ", "Rabbit dishes", null, "Блюда из мяса кролика" },
                    { new Guid("9e395771-48ce-46ea-95c9-806fae12946f"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9653), 0, null, null, null, null, null, null, null, null, null, "Հորթի մսով կերակուրներ", "Veal dishes", null, "Блюда из телятины" },
                    { new Guid("bfbd9fd9-f98f-42ec-99cb-a14545c89ecc"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9660), 0, null, null, null, null, null, null, null, null, null, "Ծովամթերքով կերակուրներ", "Seafood dishes", null, "Блюда из морепродуктов" },
                    { new Guid("dc70a381-ba5c-4a1f-bb63-c7d0d8c52188"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9658), 0, null, null, null, null, null, null, null, null, null, "Գառի մսով կերակուրներ", "Lamb dishes", null, "Блюда из баранины" },
                    { new Guid("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9646), 0, null, null, null, null, null, null, null, null, null, "Ապուրներ", "Soups", null, "Супы" },
                    { new Guid("f7ae30c0-5ec7-4736-8302-c7553a9516a2"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9656), 0, null, null, null, null, null, null, null, null, null, "Հավի մսով կերակուրներ", "Chicken dishes", null, "Блюда из курицы" },
                    { new Guid("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), new DateTime(2024, 12, 16, 19, 15, 31, 33, DateTimeKind.Utc).AddTicks(9663), 1, null, null, null, null, null, null, null, null, null, "Սեթեր", "Sets", null, "Сеты" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_SubCategoryId",
                table: "Dishes",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DishId",
                table: "OrderItems",
                column: "DishId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
