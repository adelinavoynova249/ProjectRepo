using System;

namespace DailyChores.ViewModels
{
    /// <summary>
    /// The <c>DailyChores.ViewModels.CreateChoreViewModel</c> interface.
    /// This is the View Model that we need for Create View. For create, we only want the name of the Chore and its description.
    /// <list type="bullet">
    /// <item>
    /// <term>Name</term>
    /// <description>Name of Chore.</description>
    /// </item>
    /// <item>
    /// <term>Description</term>
    /// <description>Description of chore</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>View Model for the Create part.</para>
    /// </remarks>
    public class CreateChoreViewModel
    {
        /// <summary>
        /// Shows the field with required Name input. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Shows the field with required Description input. 
        /// </summary>
        public string Description { get; set; }
    }
}
