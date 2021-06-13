using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChores.ViewModels
{
    /// <summary>
    /// The <c>DailyChores.ViewModels.IndexAllChoresViewModel</c> interface.
    /// This is the View Model that we need for Details View. We need a collection with all chores in it.
    /// <list type="bullet">
    /// <item>
    /// <term>Chores</term>
    /// <description>Collection of all Chores..</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>Holds a collection of Chores</para>
    /// </remarks>
    public class IndexAllChoresViewModel
    {
        /// <summary>
        /// This is the Chores collection.
        /// </summary>
        public IEnumerable<IndexSingleChoreModel> Chores { get; set; }
    }
}
