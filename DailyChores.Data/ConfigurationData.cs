using System;

namespace DailyChores.Data
{
    /// <summary>
    /// The <c>DailyChores.Data.ConfigurationData</c> class.
    /// Contains the string, which represents the required connection string to the database.
    /// <list type="bullet">
    /// <item>
    /// <term>CONNECTION</term>
    /// <description>Connection String</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This ConfigurationData class contains the connection requirements for the databse.</para>
    /// <para>These operations can be performed on Chore type objects only.</para>
    /// </remarks>
    public static class ConfigurationData
    {
        /// <summary>
        /// Gives us a conenction to the databse..
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        public const string CONNECTION = "Server=LAPTOP-FFK35529\\SQLEXPRESS;Database=Chores;Integrated Security=true";
    }
}
