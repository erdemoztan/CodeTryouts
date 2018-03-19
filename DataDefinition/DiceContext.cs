using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Context for the database.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class DiceContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiceContext"/> class.
        /// </summary>
        public DiceContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<DiceContext>(new CreateDatabaseIfNotExists<DiceContext>());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiceContext"/> class.
        /// </summary>
        public DiceContext() : base("name=DbConnectionString")
        {
            Database.SetInitializer<DiceContext>(new CreateDatabaseIfNotExists<DiceContext>());
        }

        /// <summary>
        /// Gets or sets the board games.
        /// </summary>
        /// <value>
        /// The board games.
        /// </value>
        public DbSet<BoardGame> BoardGames { get; set; }

        /// <summary>
        /// Gets or sets the designers.
        /// </summary>
        /// <value>
        /// The designers.
        /// </value>
        public DbSet<Designer> Designers { get; set; }

        /// <summary>
        /// Gets or sets the publishers.
        /// </summary>
        /// <value>
        /// The publishers.
        /// </value>
        public DbSet<Publisher> Publishers { get; set; }

        /// <summary>
        /// Gets or sets the reviewers.
        /// </summary>
        /// <value>
        /// The reviewers.
        /// </value>
        public DbSet<Reviewer> Reviewers { get; set; }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardGame>()
                .HasMany<Publisher>(q => q.PublisherList).WithMany(q => q.BoardGameList)
                .Map(md => {
                    md.MapLeftKey("BoardGameId");
                    md.MapRightKey("PublisherId");
                    md.ToTable("BoardGamePublishers");
                });

            modelBuilder.Entity<BoardGame>()
                .HasMany<Designer>(q => q.DesignerList).WithMany(q => q.BoardGameList)
                .Map(md => {
                    md.MapLeftKey("BoardGameId");
                    md.MapRightKey("DesignerId");
                    md.ToTable("BoardGameDesigners");
                });
        }
    }
}
