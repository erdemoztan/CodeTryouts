using DataDefinition.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Database class that holds information related to designers.
    /// </summary>
    public class Designer
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
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        [StringLength(100), Required]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the middle name.
        /// </summary>
        /// <value>
        /// The middle name.
        /// </value>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the type of the designer.
        /// </summary>
        /// <value>
        /// The type of the designer.
        /// </value>
        [Required]
        public DesignerType DesignerType { get; set; }

        /// <summary>
        /// Gets or sets the board game list.
        /// </summary>
        /// <value>
        /// The board game list.
        /// </value>
        public ICollection<BoardGame> BoardGameList { get; set; }
    }
}
