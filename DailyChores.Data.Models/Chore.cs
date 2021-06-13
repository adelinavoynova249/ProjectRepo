using System;

namespace DailyChores.Data.Models
{
    /// <summary>
    /// The <c>DailyChores.Data.Models.Chore</c> class.
    /// Creates a new model for the dataset. In this case, it in named Chore.
    /// <list type="bullet">
    /// <item>
    /// <term>Constructor</term>
    /// <description>Initialises Chore and sets the CreatedOn on the current datetime.</description>
    /// </item>
    /// <item>
    /// <term>Id</term>
    /// <description>Ids are unique for each Chore</description>
    /// </item>
    /// <item>
    /// <term>Name</term>
    /// <description>Each chore should have a name.</description>
    /// </item>
    /// <item>
    /// <term>Description</term>
    /// <description>Gives more information about the Chore</description>
    /// </item>
    /// <item>
    /// <term>CreatedOn</term>
    /// <description>stores when the Chore was created.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This chore model stores the basic information about each Chore, that the app is working with.</para>
    /// </remarks>
    public class Chore
    {
        /// <summary>
        /// Initialises a chore and the datetime when it was created.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        public Chore()
        {
            CreatedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// Each Chore must have different Id. By default, it auto increments.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Each Chore must have a Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Each Chore must have a small description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This is teh datetime, when the Chore was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }

    }
}
