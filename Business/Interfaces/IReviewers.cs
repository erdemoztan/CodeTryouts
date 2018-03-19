using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    /// <summary>
    /// Interface definition for reviewers.
    /// </summary>
    public interface IReviewers
    {
        /// <summary>
        /// Gets the reviewers.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Reviewer> GetReviewers();

        /// <summary>
        /// Gets the reviewer with identifier.
        /// </summary>
        /// <param name="reviewerId">The reviewer identifier.</param>
        /// <returns></returns>
        Reviewer GetReviewerwithId(Guid reviewerId);

        /// <summary>
        /// Saves the reviewer.
        /// </summary>
        /// <param name="reviewer">The reviewer.</param>
        /// <returns></returns>
        Reviewer SaveReviewer(Reviewer reviewer);

        /// <summary>
        /// Saves the reviewer.
        /// </summary>
        /// <param name="reviewer">The reviewer.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Reviewer SaveReviewer(Reviewer reviewer, Guid id);

        /// <summary>
        /// Deletes the reviewer.
        /// </summary>
        /// <param name="reviewer">The reviewer.</param>
        /// <returns></returns>
        bool DeleteReviewer(Reviewer reviewer);
    }
}
