using DailyChores.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChores.Services.Contracts
{
    /// <summary>
    /// The <c>DailyChores.Services.contracts.IChoreService</c> interface.
    /// Gives the "wrap" of all methods that the service class for Chore should override.
    /// <list type="bullet">
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
    /// <para>These operations can be performed on Chore type objects only.</para>
    /// </remarks>
    public interface IChoresService
    {
        /// <summary>
        /// Creates a new Chore from <paramref name="name"/> and <paramref name="description"/>.
        /// </summary>
        /// <returns>
        /// returns the Id of the chore.
        /// </returns>
        /// <param name="name"> A string object. /param>
        /// <param name="description"> A string object. /param>
        int CreateChore(string name, string description);

        /// <summary>
        /// Gets all chores, that are in the database.
        /// </summary>
        /// <returns>
        /// Returns a View Model for All Chores.
        /// </returns>
        IndexAllChoresViewModel GetAllChores();

        /// <summary>
        /// Deletes a Chore with Id = <paramref name="id"/>.
        /// </summary>
        /// <returns>
        /// Does not return anything.
        /// </returns>
        /// <param name="id"> An int object. /param>
        void Delete(int id);
    }
}
