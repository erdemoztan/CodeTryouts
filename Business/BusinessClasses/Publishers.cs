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
    /// Publisher business operations implementation.
    /// </summary>
    /// <seealso cref="Business.Interfaces.IPublishers" />
    public class Publishers : IPublishers
    {
        /// <summary>
        /// Deletes the publisher.
        /// </summary>
        /// <param name="publisher">The publisher.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool DeletePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the publishers.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<Publisher> GetPublishers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the publisher with identifier.
        /// </summary>
        /// <param name="publisherId">The publisher identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Publisher GetPublisherwithId(Guid publisherId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the publisher.
        /// </summary>
        /// <param name="publisher">The publisher.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Publisher SavePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the publisher.
        /// </summary>
        /// <param name="publisher">The publisher.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Publisher SavePublisher(Publisher publisher, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
