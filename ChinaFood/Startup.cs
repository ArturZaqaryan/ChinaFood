using ChinaFood.Domain;
using ChinaFood.Domain.Entities;
using ChinaFood.Domain.Repositories.Abstract;
using ChinaFood.Domain.Repositories.Entity_Framework;
using ChinaFood.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

namespace ChinaFood
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        private static readonly string[] configureOptions = ["en-US", "hy-AM", "ru-RU"];

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Connecting config from appsettings.json
            Configuration.Bind("Project", new Config());

            //Connecting the necessary functionality of the application as services
            //services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IDishesRepository, EFDishesRepository>();
            services.AddTransient<DataManager>();

            //Connecting DB context
            services.AddDbContext<AppDbContext>(
                x => x.UseLazyLoadingProxies()
                      .UseSqlServer(Config.ConnectionString));

            //Setting up the identity system
            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //Setting up authentication cookie
            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.Cookie.Name = "myCompanyAuth";
            //    options.Cookie.HttpOnly = true;
            //    options.LoginPath = "/account/login";
            //    options.AccessDeniedPath = "/account/accessdenied";
            //    options.SlidingExpiration = true;
            //});

            //Configuring the authorization policy for the Admin area
           // services.AddAuthorizationBuilder()
                    //Configuring the authorization policy for the Admin area
                    //.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });

            //Adding support for controllers and views
            //services.AddControllersWithViews(x =>
            //{
            //    x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            //})
            //    //Setting compatibility with asp.net core 3.0
            //    .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

            //Adding localization
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = configureOptions;
                options.SetDefaultCulture(supportedCultures[1])
                    .AddSupportedCultures(supportedCultures)
                    .AddSupportedUICultures(supportedCultures);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Adding localization
            var supportedCultures = new[] { "en-US", "hy-AM", "ru-RU" };
            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            app.UseRequestLocalization(localizationOptions);

            //Enabling support for static files in the app
            app.UseStaticFiles();

            //Connecting routing system
            app.UseRouting();

            //Connecting authentication and authorization
            //app.UseCookiePolicy();
            //app.UseAuthentication();
            //app.UseAuthorization();

            //Registering the routes(endpoints) we need
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
