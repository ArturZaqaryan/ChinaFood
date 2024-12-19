using ChinaFood.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChinaFood.Domain;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User>(options)
{
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Связь между Dish и SubCategory
        builder.Entity<Dish>()
            .HasOne(d => d.SubCategory)
            .WithMany()
            .HasForeignKey(d => d.SubCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        //Setting Room, Room facility binding table PK.
        builder.Entity<OrderItem>()
            .HasKey(cs => new { cs.OrderId, cs.DishId });

        //Adding new user role to database.
        builder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
            Name = "admin",
            NormalizedName = "ADMIN"
        });

        //Adding new user to database.
        builder.Entity<User>().HasData(new User
        {
            Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "my@email.com",
            NormalizedEmail = "MY@EMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<User>().HashPassword(null, "superpassword"),
            SecurityStamp = string.Empty
        });

        //Adding new user-role link to database.
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
            UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
        });

        // Заполнение данных подкатегорий
        builder.Entity<SubCategory>().HasData(
            new SubCategory { Id = Guid.Parse("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), TitleEn = "Salads", TitleArm = "Աղցաններ", TitleRu = "Салаты", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), TitleEn = "Soups", TitleArm = "Ապուրներ", TitleRu = "Супы", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("49803b04-2981-4d3f-99fb-34c0e41a64b6"), TitleEn = "Noodles", TitleArm = "Լապշաներ", TitleRu = "Лапша", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("4deeef11-00ca-4fcd-9184-431d15e9e39d"), TitleEn = "Rice and bread", TitleArm = "Բրինձներ, հաց", TitleRu = "Рис, хлеб", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("9e395771-48ce-46ea-95c9-806fae12946f"), TitleEn = "Veal dishes", TitleArm = "Հորթի մսով կերակուրներ", TitleRu = "Блюда из телятины", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("3538e8ff-aeac-4ca1-aa68-9fa34d0453d5"), TitleEn = "Pork dishes", TitleArm = "Խոզի մսով կերակուրներ", TitleRu = "Блюда из свинины", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("f7ae30c0-5ec7-4736-8302-c7553a9516a2"), TitleEn = "Chicken dishes", TitleArm = "Հավի մսով կերակուրներ", TitleRu = "Блюда из курицы", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("dc70a381-ba5c-4a1f-bb63-c7d0d8c52188"), TitleEn = "Lamb dishes", TitleArm = "Գառի մսով կերակուրներ", TitleRu = "Блюда из баранины", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("8dd7be8f-742a-4d01-bcc9-c7a276027c17"), TitleEn = "Rabbit dishes", TitleArm = "Ճագարի մսով կերակուրներ", TitleRu = "Блюда из мяса кролика", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("bfbd9fd9-f98f-42ec-99cb-a14545c89ecc"), TitleEn = "Seafood dishes", TitleArm = "Ծովամթերքով կերակուրներ", TitleRu = "Блюда из морепродуктов", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("63f6c1d4-b259-48fd-9bd3-9c8dc5ce7838"), TitleEn = "Dumplings", TitleArm = "Պիլմենիներ", TitleRu = "пельмени", DishType = DishType.China },
            new SubCategory { Id = Guid.Parse("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), TitleEn = "Sets", TitleArm = "Սեթեր", TitleRu = "Сеты", DishType = DishType.Japan },
            new SubCategory { Id = Guid.Parse("83beee31-2b8d-488a-b6a0-2b672d515720"), TitleEn = "Tea's", TitleArm = "Թեյեր", TitleRu = "Чайы", DishType = DishType.Drink }
        );

        builder.Entity<Dish>().HasData(
            // 6 chinesse dishes
            new Dish { Id = Guid.NewGuid(), Price = 12.99m, DishType = DishType.China, SubCategoryId = Guid.Parse("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), TitleEn = "Kung Pao Chicken", TitleArm = "Կունգ Պաո Հավ", TitleRu = "Кунг Пао Курочка", SubtitleEn = "Spicy stir-fried chicken", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 15.50m, DishType = DishType.China, SubCategoryId = Guid.Parse("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), TitleEn = "Sweet and Sour Pork", TitleArm = "Քաղցր և Թթու Խոզ", TitleRu = "Сладкая и кислая свинина", SubtitleEn = "Traditional sweet pork", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 10.20m, DishType = DishType.China, SubCategoryId = Guid.Parse("547a230d-a5e0-4885-8f35-4a17f8d47e1b"), TitleEn = "Ma Po Tofu", TitleArm = "Մա Պո Թոֆու", TitleRu = "Ма По Тофу", SubtitleEn = "Spicy Sichuan tofu", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 8.75m, DishType = DishType.China, SubCategoryId = Guid.Parse("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), TitleEn = "Peking Duck", TitleArm = "Պեկինյան Բադ", TitleRu = "Пекинская утка", SubtitleEn = "Crispy duck with sauce", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 9.99m, DishType = DishType.China, SubCategoryId = Guid.Parse("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), TitleEn = "Spring Rolls", TitleArm = "Գարնանային Շարունակվածքներ", TitleRu = "Весенние роллы", SubtitleEn = "Crispy fried rolls", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 7.80m, DishType = DishType.China, SubCategoryId = Guid.Parse("eeb295fd-8c9f-40a2-9927-6d88a6e371da"), TitleEn = "Dim Sum", TitleArm = "Դիմ Սում", TitleRu = "Дим Сам", SubtitleEn = "Traditional Chinese dumplings", DateAdded = DateTime.UtcNow },

            // 6 japanesse dishes
            new Dish { Id = Guid.NewGuid(), Price = 12.99m, DishType = DishType.Japan, SubCategoryId = Guid.Parse("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), TitleEn = "Sushi", TitleArm = "Սուշի", TitleRu = "Суши", SubtitleEn = "Traditional Japanese rice and fish", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 14.50m, DishType = DishType.Japan, SubCategoryId = Guid.Parse("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), TitleEn = "Ramen", TitleArm = "Ռամեն", TitleRu = "Рамен", SubtitleEn = "Noodle soup with various toppings", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 11.25m, DishType = DishType.Japan, SubCategoryId = Guid.Parse("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), TitleEn = "Tempura", TitleArm = "Տեմպուրա", TitleRu = "Темпура", SubtitleEn = "Battered and fried seafood or vegetables", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 13.30m, DishType = DishType.Japan, SubCategoryId = Guid.Parse("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), TitleEn = "Udon", TitleArm = "Ուդոն", TitleRu = "Удон", SubtitleEn = "Thick wheat flour noodles", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 10.99m, DishType = DishType.Japan, SubCategoryId = Guid.Parse("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), TitleEn = "Sashimi", TitleArm = "Սաշիմի", TitleRu = "Сашими", SubtitleEn = "Fresh sliced raw fish", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 15.99m, DishType = DishType.Japan, SubCategoryId = Guid.Parse("f9efe343-07b1-4bfc-96f0-0feeeee146cd"), TitleEn = "Yakitori", TitleArm = "Յակիտորի", TitleRu = "Якитори", SubtitleEn = "Grilled skewered chicken", DateAdded = DateTime.UtcNow },

            // 6 drinks
            new Dish { Id = Guid.NewGuid(), Price = 5.99m, DishType = DishType.Drink, SubCategoryId = Guid.Parse("83beee31-2b8d-488a-b6a0-2b672d515720"), TitleEn = "Green Tea", TitleArm = "Կանաչ Թեյ", TitleRu = "Зеленый чай", SubtitleEn = "Traditional Japanese tea", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 6.50m, DishType = DishType.Drink, SubCategoryId = Guid.Parse("83beee31-2b8d-488a-b6a0-2b672d515720"), TitleEn = "Sake", TitleArm = "Սակե", TitleRu = "Саке", SubtitleEn = "Japanese rice wine", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 4.75m, DishType = DishType.Drink, SubCategoryId = Guid.Parse("83beee31-2b8d-488a-b6a0-2b672d515720"), TitleEn = "Oolong Tea", TitleArm = "Օլոնգ Թեյ", TitleRu = "Улун чай", SubtitleEn = "Chinese tea", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 3.99m, DishType = DishType.Drink, SubCategoryId = Guid.Parse("83beee31-2b8d-488a-b6a0-2b672d515720"), TitleEn = "Jasmine Tea", TitleArm = "Յասմին Թեյ", TitleRu = "Жасминовый чай", SubtitleEn = "Scented green tea", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 7.00m, DishType = DishType.Drink, SubCategoryId = Guid.Parse("83beee31-2b8d-488a-b6a0-2b672d515720"), TitleEn = "Bubble Tea", TitleArm = "Բուբլ Թեյ", TitleRu = "Бабл-чай", SubtitleEn = "Tea with tapioca pearls", DateAdded = DateTime.UtcNow },
            new Dish { Id = Guid.NewGuid(), Price = 4.50m, DishType = DishType.Drink, SubCategoryId = Guid.Parse("83beee31-2b8d-488a-b6a0-2b672d515720"), TitleEn = "Black Tea", TitleArm = "Սև Թեյ", TitleRu = "Черный чай", SubtitleEn = "Chinese black tea", DateAdded = DateTime.UtcNow }
        );
    }
}
