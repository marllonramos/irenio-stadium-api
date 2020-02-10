using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using IrenioStadium.Domain.Repositories;
using IrenioStadium.Domain.Services;
using IrenioStadium.Infra.Repositories;
using IrenioStadium.Infra.Shared;
using IrenioStadium.Infra.Persistence.DataContexts;
using IrenioStadium.ApplicationService.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace IrenioStadium.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // var builder = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json")
            //     .AddJsonFile("appsettings.Development.json");

            // Configuration = builder.Build();

            // services.AddCors();

            services.AddControllersWithViews();
            services.AddHttpContextAccessor();

            services.AddDbContext<IrenioStadiumDataContext>();
            services.AddScoped<IrenioStadiumDataContext, IrenioStadiumDataContext>();

            services.AddScoped<IJogadorRepository, JogadorRepository>();
            services.AddScoped<IJogadorApplicationService, JogadorApplicationService>();

            services.AddControllers();

            // Settings.ConnectionString = $"{Configuration["ConnectionString:connectionString"]}";
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
