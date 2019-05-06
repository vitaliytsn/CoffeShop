using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Data;
using CoffeShop.Models;
using CoffeShop.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Session;

namespace CoffeShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CoffeShopContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CoffeConnection")));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
           
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-GB");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-GB") };
                options.RequestCultureProviders.Clear();
            });

            services.AddScoped<IRepository<Item, CoffeShopContext>,
                Repository<Item, CoffeShopContext>>();
            services.AddScoped<IRepository<Component, CoffeShopContext>,
                Repository<Component, CoffeShopContext>>();
            services.AddScoped<IRepository<ItemGroup, CoffeShopContext>,
                Repository<ItemGroup, CoffeShopContext>>();
            services.AddScoped<IRepository<ItemComponent, CoffeShopContext>,
                Repository<ItemComponent, CoffeShopContext>>();
            services.AddScoped<IRepository<Models.CoffeShop, CoffeShopContext>,
                Repository<Models.CoffeShop, CoffeShopContext>>();
            services.AddScoped<IRepository<User, CoffeShopContext>,
                Repository<User, CoffeShopContext>>();
            services.AddScoped<IRepository<Role, CoffeShopContext>,
                Repository<Role, CoffeShopContext>>();
            services.AddScoped<IRepository<ItemImage, CoffeShopContext>,
                Repository<ItemImage, CoffeShopContext>>();
            services.AddScoped<IRepository<ComponentDelivery, CoffeShopContext>,
                Repository<ComponentDelivery, CoffeShopContext>>();

            services.AddSession();

           
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseRequestLocalization();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
