using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Database entity that holds information related to publishers.
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [StringLength(100), Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the board game list.
        /// </summary>
        /// <value>
        /// The board game list.
        /// </value>
        public ICollection<BoardGame> BoardGameList { get; set; }
    }
}
