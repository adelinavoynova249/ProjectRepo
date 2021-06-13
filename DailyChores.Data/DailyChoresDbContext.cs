using DailyChores.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChores.Data
{
    /// <summary>
    /// The <c>DailyChores.Data.DailyChoresDbContext</c> class.
    /// Initialises the DbContext that is used in the application and configures the connection to the sql server.
    /// <list type="bullet">
    /// <item>
    /// <term>Constructor</term>
    /// <description>Initialises the DbContext</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <para>This ConfigurationData class contains the connection requirements for the databse.</para>
    /// <para>These operations can be performed on Chore type objects only.</para>
    /// </remarks>
    public class DailyChoresDbContext : DbContext
    {

        /// <summary>
        /// Initialises a DbContext from <paramref name="options"/>.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        /// <param name="options">DbContextOptions<DailyChoresDbContext>. /param>
        public DailyChoresDbContext(DbContextOptions<DailyChoresDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Initialises a DbSet  from Chore.
        /// </summary>
        public DbSet<Chore> Chores { get; set; }

        /// <summary>
        /// Configures the data connection and sets one if it has not been set previously.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        /// <param name="optionsBuilder">DbContextOptionsBuilder>. /param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationData.CONNECTION);
            }
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// Here the model can be further configured before it is locked down.
        /// </summary>
        /// <returns>
        /// Does not return anything in this case.
        /// </returns>
        /// <param name="modelBuilder">ModelBuilder>. /param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
