using DailyChores.Data;
using DailyChores.Data.Models;
using DailyChores.Services.Contracts;
using DailyChores.ViewModels;
using System;
using System.Linq;

namespace DailyChores.Services
{
    /// <summary>
    /// The <c>DailyChores.Services.ChoreService</c> interface.
    /// Overrides the methods from the revelant interface.
    /// <list type="bullet">
    /// <item>
    /// <term>Constructor</term>
    /// <description>Initialises the DbContext.</description>
    /// </item>
    /// <item>
    /// <term>CreateChore</term>
    /// <description>Creates new Chore from View Model.</description>
    /// </item>
    /// <item>
    /// <term>GetAllChores</term>
    /// <description>Returns all Chores, present in the database.</description>
    /// </item>
    /// <item>
    /// <term>Delete</term>
    /// <description>Deletes a Chore, based on its Id.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>All back-end logic for Chore Motifying is here.</para>
    /// </remarks>
    public class ChoresService : IChoresService
    {
        private DailyChoresDbContext context;

        /// <summary>
        /// Allocates the right context using <paramref name="context"/>. 
        /// </summary>
        /// <returns>
        /// returns the Id of the chore.
        /// </returns>
        /// <param name="name"> A string object. /param>
        /// <param name="description"> A string object. /param>
        public ChoresService(DailyChoresDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Creates a new Chore from <paramref name="name"/> and <paramref name="description"/>.
        /// </summary>
        /// <returns>
        /// returns the Id of the chore.
        /// </returns>
        /// <param name="name"> A string object. /param>
        /// <param name="description"> A string object. /param>
        public int CreateChore(string name, string description)
        {
            var chore = new Chore() { Name = name, Description = description };

            context.Chores.Add(chore);
            context.SaveChanges();
            return chore.Id;
            
        }

        /// <summary>
        /// Deletes a Chore with Id = <paramref name="id"/>.
        /// </summary>
        /// <returns>
        /// Does not return anything.
        /// </returns>
        /// <param name="id"> An int object. /param>
        public void Delete(int id)
        {
            var chore =  this.context.Chores
                .SingleOrDefault(chore => chore.Id == id);

            this.context.Remove(chore);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Gets all chores, that are in the database.
        /// </summary>
        /// <returns>
        /// Returns a View Model for All Chores.
        /// </returns>
        public IndexAllChoresViewModel GetAllChores()
        {
            var chores = context.Chores.Select(s => new IndexSingleChoreModel()
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                CreatedOn = s.CreatedOn.ToString()
            });

            var model = new IndexAllChoresViewModel() { Chores = chores };
            return model;
        }
    }
}
