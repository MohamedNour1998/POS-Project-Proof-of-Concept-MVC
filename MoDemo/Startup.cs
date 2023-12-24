using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoDemo.Models;
using MoDemo.Reprository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoDemo
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
            services.AddControllersWithViews(/*conf=>conf.Filters.Add()pipeline filter*/)/*.AddSessionStateTempDataProvider() for make tempdata store in session*/;
            services.AddSession(conf=> {
                conf.IdleTimeout = TimeSpan.FromMinutes(20);
                });
            services.AddDbContext<ITIEntity>(optionBuilder=>
            {
                optionBuilder.UseSqlServer(Configuration.GetConnectionString("cs"));
            }
            );

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                // Default Password settings.
                //options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 0;
            }).AddEntityFrameworkStores<ITIEntity>()
            .AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider);

            services.AddScoped<IDepartmentRep, DepartmentRep>();
            services.AddScoped<IEmployeeRep, EmployeeRep>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
           {
            #region custom midleware
            //app.Use(async(httpContext,next)=> 
            //{
            //    //write response
            //   await httpContext.Response.WriteAsync("midelware1\n");
            //    //call next
            //    await next.Invoke();
            //});
            //app.Use(async (httpContext, next) =>
            //{
            //    //write response
            //    await httpContext.Response.WriteAsync("midelware2\n");
            //    //call next
            //    await next.Invoke();
            //});
            //app.Run(async(httpContext)=> 
            //{
            //    await httpContext.Response.WriteAsync("midelware33\n");
            //});

            #endregion
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
