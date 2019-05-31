using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParkingLotApp.Data.Context;
using ParkingLotApp.Data.Implementation.SqlServer;
using ParkingLotApp.Data.Interfaces;
using ParkingLotApp.Domain.Model;
using ParkingLotApp.Service.Services;

namespace ParkingLotApp
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Add DbContext as a service
            services.AddDbContext<ParkingLotAppDbContext>();

            //Add identity as a service
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ParkingLotAppDbContext>();

            AddServiceImplementation(services);

            AddRepositoryImplementation(services);

            

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        private void AddRepositoryImplementation(IServiceCollection services)
        {
            services.AddSingleton<IParkingLotRepository, SqlServerParkingLotRepository>();
            services.AddSingleton<IParkingLotTypeRepository, SqlServerParkingLotTypeRepository>();
        }

        private void AddServiceImplementation(IServiceCollection services)
        {
            services.AddSingleton<IParkingLotService, ParkingLotService>();
            services.AddSingleton<IParkingLotTypeService, ParkingLotTypeService>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
