using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using RestfulCoreAPI.Data;
using RestfulCoreAPI.Data.Repositories;
using RestfulCoreAPI.Data.Repositories.Interfaces;
using RestfulCoreAPI.Hypermedia;
using RestfulCoreAPI.Services;
using RestfulCoreAPI.Services.Interfaces;
using Tapioca.HATEOAS;

namespace RestfulCoreAPI
{
    public class Startup
    {
        private IConfiguration _configuration { get; }
        private ILogger _logger { get; }
        private IHostingEnvironment _environment { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment environment, ILogger<Startup> logger)
        {
            _configuration = configuration;
            _environment = environment;
            _logger = logger;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configuration["MySqlConnection:MySqlConnectionString"];

            services.AddDbContext<MySQLContext>(options =>
                options.UseMySql(connectionString)
            );

            #region Repositories and Services Injection

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookService, BookService>();

            #endregion

            #region Migration

            // Migrate our database using Evolve
            EvolveMigrations.Migrate(connectionString);

            #endregion

            #region XML Response
            // Uncomment if you want your api to return XML Responses
            //services.AddMvc(options =>
            //{
            //    options.RespectBrowserAcceptHeader = true;
            //    //Use Microsoft.Net.Http.Headers.MediaTypeHeaderValue for Parser

            //   options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("text/xml"));
            //}).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            #endregion

            #region HATEOAS Configuration

            var filterOptions = new HyperMediaFilterOptions();
            filterOptions.ObjectContentResponseEnricherList.Add(new PersonEnricher());
            services.AddSingleton(filterOptions);

            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // API Versioning
            services.AddApiVersioning();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes => {
                routes.MapRoute(name: "DefaultApi", template: "{controller=Values}/{id?}");
            });
        }
    }
}
