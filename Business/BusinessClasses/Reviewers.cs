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
    /// Reviewers business operations implementation.
    /// </summary>
    /// <seealso cref="Business.Interfaces.IReviewers" />
    public class Reviewers : IReviewers
    {
        /// <summary>
        /// Deletes the reviewer.
        /// </summary>
        /// <param name="reviewer">The reviewer.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool DeleteReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the reviewers.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<Reviewer> GetReviewers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the reviewer with identifier.
        /// </summary>
        /// <param name="reviewerId">The reviewer identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Reviewer GetReviewerwithId(Guid reviewerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the reviewer.
        /// </summary>
        /// <param name="reviewer">The reviewer.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Reviewer SaveReviewer(Reviewer reviewer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the reviewer.
        /// </summary>
        /// <param name="reviewer">The reviewer.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Reviewer SaveReviewer(Reviewer reviewer, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
