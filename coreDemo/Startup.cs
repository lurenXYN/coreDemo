using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using coreDemo.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using coreDemo.Settings;

namespace coreDemo
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<ICinemaServices, CinemaMemoryService>();
            services.AddSingleton<IMovieServices, MovieMemoryService>();

            services.Configure<ConnectionOptions>(_configuration.GetSection("ConnectionStrings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (env.IsProduction())
            {
                app.UseForwardedHeaders(new ForwardedHeadersOptions
                {
                    ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor
                        | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
                });
            }


            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name : "default", 
                    template : "{controller=Home}/{action=Index}/{id?}");
            });

            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("M1 start");
            //    await context.Response.WriteAsync("Hello World!");
            //    await next();
            //    logger.LogInformation("M1 end");
            //});

            //app.Run(async (context)=> {
            //    logger.LogInformation("M2 start");
            //    await context.Response.WriteAsync("23333");
            //    logger.LogInformation("M2 end");
            //});
        }
    }
}
