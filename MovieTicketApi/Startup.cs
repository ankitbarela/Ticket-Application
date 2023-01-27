using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MovieTicketApi.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieTicketApi.Repository.State;
using MovieTicketApi.Repository.City;
using MovieTicketApi.Repository;
using MovieTicketApi.Repository.Movie;
using MovieTicketApi.Repository.User;
using MovieTicketApi.Repository.Theater;
using MovieTicketApi.Repository.Screen;
using MovieTicketApi.Repository.Seat;
using MovieTicketApi.Repository.Show;
using MovieTicketApi.Services;

namespace MovieTicketApi
{
    public class Startup
    {
        string myAllowSpecificOrigins;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            myAllowSpecificOrigins = "allowAll";
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "V1",
                    Title = "Movie Ticket Api",
                    Description = "API"
                });
            });

            services.AddDbContext<MovieContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:Con"]);
            });

            services.AddCors(options =>
            {
                options.AddPolicy("MySetPreflightExpirationPolicy",
                    policy =>
                    {
                        policy.WithOrigins("*")
                               .SetPreflightMaxAge(TimeSpan.FromSeconds(2520));
                    });
            });

            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITheaterRepository, TheaterRepository>();
            services.AddScoped<IScreenRepository, ScreenRepository>();
            services.AddScoped<ISeatRepository, SeatRepository>();
            services.AddScoped<IShowRepository, ShowRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api V");
                c.RoutePrefix = string.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseRouting();
         //   app.UseMiddleware<AuthenticationMiddleware>();

            //app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(x => x
                     .AllowAnyMethod()
                     .AllowAnyHeader()
                     .SetIsOriginAllowed(origin => true) // allow any origin
                                                         .WithOrigins("https://localhost:3000") // Allow only this origin can also have multiple origins separated with comma
                     .AllowCredentials());
        }
    }
}
