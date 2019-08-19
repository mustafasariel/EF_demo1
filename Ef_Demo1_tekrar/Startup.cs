using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ef_Demo1_tekrar.Enitities;
using Ef_Demo1_tekrar.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ef_Demo1_tekrar
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

          // string strConn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\MSARIEL\Documents\okul5.mdf; Database=okuldb5 Integrated Security = True; Connect Timeout = 30";
            // string strConn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = AppData\okul7.mdf; Database=okuldb7 Trusted connection = true; Connect Timeout = 30";


            string strConn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\MSARIEL\source\repos\EF_demo1\Ef_Demo1_tekrar\AppData\okul7.mdf ; Database=okuldb7 Integrated Security = True; Connect Timeout = 30";



            services.AddDbContext<SchoolContext>(option => option.UseSqlServer(strConn));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Students}/{action=Index}/{id?}");
            });
        }
    }
}
