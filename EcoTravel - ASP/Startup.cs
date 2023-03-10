using BLLObject = BLL.Entities;
using DALObject = DAL.Entities;
using BLLServ = BLL.Services;
using DALServ = DAL.Services;
using COMMON.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcoTravel___ASP.Handlers;
using Microsoft.AspNetCore.Http;

namespace EcoTravel___ASP
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
            services.AddControllersWithViews();

            services.AddHttpContextAccessor();           
            services.AddScoped<SessionManager>();
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.Cookie.Name = "DBEcoTravel";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(50);
            });
            services.Configure<CookiePolicyOptions>(options => {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.Secure = CookieSecurePolicy.Always;
            });

            services.AddScoped<IClientRepository<BLLObject.Client, int>, BLLServ.ClientService>();
            services.AddScoped<IClientRepository<DALObject.Client, int>, DALServ.ClientService>();
            services.AddScoped<ILogementRepository<BLLObject.Logement, int>, BLLServ.LogementService>();
            services.AddScoped<ILogementRepository<DALObject.Logement, int>, DALServ.LogementService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSession();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
