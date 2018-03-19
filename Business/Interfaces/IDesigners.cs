using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    /// <summary>
    /// Interface for designer related operations
    /// </summary>
    public interface IDesigners
    {
        /// <summary>
        /// Gets the designer.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Designer> GetDesigner();

        /// <summary>
        /// Gets the designer with provided identifier.
        /// </summary>
        /// <param name="designerId">The designer identifier.</param>
        /// <returns></returns>
        Designer GetDesignerwithId(Guid designerId);

        /// <summary>
        /// Saves the designer.
        /// </summary>
        /// <param name="designer">The designer.</param>
        /// <returns></returns>
        Designer SaveDesigner(Designer designer);

        /// <summary>
        /// Saves the board game.
        /// </summary>
        /// <param name="designer">The designer.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Designer SaveBoardGame(Designer designer, Guid id);

        /// <summary>
        /// Deletes the designer.
        /// </summary>
        /// <param name="designer">The designer.</param>
        /// <returns></returns>
        bool DeleteDesigner(Designer designer);
    }
}
