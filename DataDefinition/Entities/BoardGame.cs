using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Database class that stores information related to Board Games
    /// </summary>
    public class BoardGame
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [StringLength(1000), Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the minimum player.
        /// </summary>
        /// <value>
        /// The minimum player.
        /// </value>
        public int? MinPlayer { get; set; }

        /// <summary>
        /// Gets or sets the maximum player.
        /// </summary>
        /// <value>
        /// The maximum player.
        /// </value>
        public int? MaxPlayer { get; set; }

        /// <summary>
        /// Gets or sets the minimum playtime.
        /// </summary>
        /// <value>
        /// The minimum playtime.
        /// </value>
        public int? MinPlaytime { get; set; }

        /// <summary>
        /// Gets or sets the maximum playtime.
        /// </summary>
        /// <value>
        /// The maximum playtime.
        /// </value>
        public int? MaxPlaytime { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int? Age { get; set; }

        /// <summary>
        /// Gets or sets the BGG identifier.
        /// </summary>
        /// <value>
        /// The BGG identifier.
        /// </value>
        [StringLength(20)]
        public string BGGId { get; set; }

        /// <summary>
        /// Gets or sets the designer list.
        /// </summary>
        /// <value>
        /// The designer list.
        /// </value>
        public ICollection<Designer> DesignerList { get; set; }

        /// <summary>
        /// Gets or sets the publisher list.
        /// </summary>
        /// <value>
        /// The publisher list.
        /// </value>
        public ICollection<Publisher> PublisherList { get; set; }
    }
}
