using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDb.Models;
using Microsoft.Extensions.Configuration;
using MVCDb.models;
using Microsoft.EntityFrameworkCore;


namespace MVCDb
{
    public class Startup
    {
        // Reading the connection String
        public IConfiguration configuration;

        // inject config in constructor of Startup
        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // adding services
            services.AddDbContext<_1026dbContext>(db => db.UseSqlServer(configuration.GetConnectionString("mycon")));
            services.AddMvc(s => s.EnableEndpointRouting=false);
            services.AddSingleton<IDept, DeptRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseMvc(routes =>
            {
            routes.MapRoute(
                name: "default",
                template: "{controller=Dept}/{action=List}/{id?}"
                );
                    
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
