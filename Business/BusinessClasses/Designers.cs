using Business.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessClasses
{
    /// <summary>
    /// Designer business operations implemetation.
    /// </summary>
    /// <seealso cref="Business.Interfaces.IDesigners" />
    public class Designers : IDesigners
    {
        /// <summary>
        /// Deletes the designer.
        /// </summary>
        /// <param name="designer">The designer.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool DeleteDesigner(Designer designer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the designer.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<Designer> GetDesigner()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the designer with provided identifier.
        /// </summary>
        /// <param name="designerId">The designer identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Designer GetDesignerwithId(Guid designerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the board game.
        /// </summary>
        /// <param name="designer">The designer.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Designer SaveBoardGame(Designer designer, Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the designer.
        /// </summary>
        /// <param name="designer">The designer.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Designer SaveDesigner(Designer designer)
        {
            throw new NotImplementedException();
        }
    }
}
