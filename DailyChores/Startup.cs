using DailyChores.Data;
using DailyChores.Services;
using DailyChores.Services.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DailyChores
{
    /// <summary>
    /// The <c>StartUp</c> class.
    /// Configures services and the app's request pipeline
    /// <list type="bullet">
    /// <item>
    /// <term>Constructor</term>
    /// <description>Initialises the configuration.</description>
    /// </item>
    /// <item>
    /// <term>Configuration</term>
    /// <description>Get method for configuration.</description>
    /// </item>
    /// <item>
    /// <term>ConfigureServices</term>
    /// <description>Adds services to the container.</description>
    /// </item>
    /// <item>
    /// <term>Configure</term>
    /// <description>Configures the HTTP request pipeline.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This startup class configures the application.</para>
    /// </remarks>
    public class Startup
    {
        /// <summary>
        /// Initialises a configuration from <paramref name="configuration"/>.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        /// <param name="configuration">An IConfiguration object.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// get method for Configuration.
        /// </summary>
        /// <returns>
        /// returns IConfiguration;
        /// </returns>
        public IConfiguration Configuration { get; }


        /// <summary>
        /// Adds services and DbContext to the project.
        /// </summary>
        /// <returns>
        /// It is a void method;
        /// </returns>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DailyChoresDbContext>(options => options.UseSqlServer(ConfigurationData.CONNECTION));
            services.AddScoped<IChoresService, ChoresService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// Configures the HTTP request pipeline.
        /// </summary>
        /// <returns>
        /// It is a void method;
        /// </returns>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
