using DailyChores.Models;
using DailyChores.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DailyChores.Controllers
{
    /// <summary>
    /// The <c>Home</c> Controller class.
    /// Contains the link between the back-end Home services and front-end Home Views.
    /// <list type="bullet">
    /// <item>
    /// <term>Constructor</term>
    /// <description>Initialises the class</description>
    /// </item>
    /// <item>
    /// <term>Index</term>
    /// <description>Leads us to the initial web page of the application. Here it displays all Chores in the database</description>
    /// </item>
    /// <item>
    /// <term>Error</term>
    /// <description>custom Error Page</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This Home controller contains the initial page of the project, where all Chore records are displayed.</para>
    /// </remarks>
    public class HomeController : Controller
    {
        private IChoresService service;

        /// <summary>
        /// Initialises a service from <paramref name="service"/>.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        /// <param name="service">An IChoresService object.</param>
        public HomeController(IChoresService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Displays all Chore records that are in the linked database.
        /// </summary>
        /// <returns>
        /// returns the Details view, containing the list of all Chores.
        /// </returns>
        public IActionResult Index()
        {
            var model = service.GetAllChores();
            return View(model);
        }

        /// <summary>
        /// custom Error Page.
        /// </summary>
        /// <returns>
        /// returns the ErrorView.
        /// </returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
