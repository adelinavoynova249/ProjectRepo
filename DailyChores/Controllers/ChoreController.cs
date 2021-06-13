using DailyChores.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DailyChores.Controllers
{
    /// <summary>
    /// The <c>Chore</c> Controller class.
    /// Contains the link between the back-end Chore services and front-end Home Views.
    /// <list type="bullet">
    /// <item>
    /// <term>Constructor</term>
    /// <description>Initialises the class</description>
    /// </item>
    /// <item>
    /// <term>Create</term>
    /// <description>Loads the create view.</description>
    /// </item>
    /// <item>
    /// <term>Create</term>
    /// <description>Creates new Chore</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Deletes a specified Chore</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This controller connects the create and delete functionality for back-end and front-end.</para>
    /// <para>These operations can be performed on Chore type objects only.</para>
    /// </remarks>
    public class ChoreController : Controller
    {
        private IChoresService service;

        /// <summary>
        /// Initialises a service from <paramref name="service"/>.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        /// <param name="service">An IChoresService object.</param>
        public ChoreController(IChoresService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Http Get request that displays the View Model(DailyChores.ViewModels.CreateChoreViewModel) for creating new Chore.
        /// </summary>
        /// <returns>
        /// returns the Chore Create View;
        /// </returns>
        public IActionResult Create()
        {
            return this.View();
        }

        /// <summary>
        /// Creates new Chore using <paramref name="name"/> and <paramref name="description"/> using the CreateChore method from the service.
        /// </summary>
        /// <returns>
        /// After it creates the Chore, it redirects us back to the index page.
        /// </returns>
        /// <example>
        /// This code example shows how the create method in service is working
        /// <code>
        ///public int CreateChore(string name, string description)
        ///{
        ///    var chore = new Chore() { Name = name, Description = description };
        ///
        ///   context.Chores.Add(chore);
        ///  context.SaveChanges();
        ///  return chore.Id;
        ///}
        /// </code>
        /// </example>
        /// <param name="name">A string.</param>
        /// <param name="description">A string.</param>
        [HttpPost]
        public IActionResult Create(string name, string description)
        {
            this.service.CreateChore(name, description);
            return this.RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Deletes a chore, given its Id in the database - <paramref name="id"/> .
        /// </summary>
        /// <returns>
        /// After it deletes the Chore, it redirects us back to the index page.
        /// </returns>
        /// <example>
        /// This code example shows how the delete method in service is working
        /// <code>
        /// public void Delete(int id)
        ///{
        ///    var chore = this.context.Chores
        ///        .SingleOrDefault(chore => chore.Id == id);
        ///   this.context.Remove(chore);
        ///   this.context.SaveChanges();
        /// }
        /// </code>
        /// </example>
        /// <param name="id">An integer.</param>
        public IActionResult Delete(int id)
        {
            this.service.Delete(id);
            return this.RedirectToAction("Index", "Home");
        }
    }
}
