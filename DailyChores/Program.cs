using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DailyChores
{
    /// <summary>
    /// The <c>Program</c> class.
    /// This is the entry point of the application.
    /// <list type="bullet">
    /// <item>
    /// <term>Main</term>
    /// <description>Builds the program.</description>
    /// </item>
    /// <item>
    /// <term>CreateHostBuilder</term>
    /// <description>Sets up a host</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This program class initialises the application.</para>
    /// </remarks>
    public class Program
    {
        /// <summary>
        /// Builds the project.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// creates a host.
        /// </summary>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
