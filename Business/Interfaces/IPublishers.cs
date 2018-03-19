using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    /// <summary>
    /// Interface definition for publisher related operations.
    /// </summary>
    public interface IPublishers
    {
        /// <summary>
        /// Gets the publishers.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Publisher> GetPublishers();

        /// <summary>
        /// Gets the publisher with identifier.
        /// </summary>
        /// <param name="publisherId">The publisher identifier.</param>
        /// <returns></returns>
        Publisher GetPublisherwithId(Guid publisherId);

        /// <summary>
        /// Saves the publisher.
        /// </summary>
        /// <param name="publisher">The publisher.</param>
        /// <returns></returns>
        Publisher SavePublisher(Publisher publisher);

        /// <summary>
        /// Saves the publisher.
        /// </summary>
        /// <param name="publisher">The publisher.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Publisher SavePublisher(Publisher publisher, Guid id);

        /// <summary>
        /// Deletes the publisher.
        /// </summary>
        /// <param name="publisher">The publisher.</param>
        /// <returns></returns>
        bool DeletePublisher(Publisher publisher);
    }
}
