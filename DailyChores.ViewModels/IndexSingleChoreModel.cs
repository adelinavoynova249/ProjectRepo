using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChores.ViewModels
{
    /// <summary> >
    /// The <c>DailyChores.ViewModels.IndexSingleChoreMode</c> interface.
    /// This is the View Model that we need for Create View. For create, we only want the name of the Chore and its description.
    /// <list type="bullet">
    /// <item>
    /// <term>Id</term>
    /// <description>Unique Id of Chore.</description>
    /// </item>
    /// <item>
    /// <term>Name</term>
    /// <description>Name of Chore.</description>
    /// </item>
    /// <item>
    /// <term>Description</term>
    /// <description>Description of chore</description>
    /// </item>
    /// <item>
    /// <term>CreatedOn</term>
    /// <description>The datetime, when the chore was created.</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>View Model for the Display Details part.</para>
    /// </remarks>
    public class IndexSingleChoreModel
    {
        /// <summary>
        /// Shows the Id of the Chore. 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Shows the Name of the Chore. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Shows the Description of the Chore. 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Shows when the Chore was created. 
        /// </summary>
        public string CreatedOn { get; set; }
    }
}
