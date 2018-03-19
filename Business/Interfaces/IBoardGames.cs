using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    /// <summary>
    /// Interface for board game related operations
    /// </summary>
    public interface IBoardGames
    {
        /// <summary>
        /// Gets the board games.
        /// </summary>
        /// <returns></returns>
        IEnumerable<BoardGame> GetBoardGames();

        /// <summary>
        /// Gets the board game with provided identifier.
        /// </summary>
        /// <param name="boardGameId">The board game identifier.</param>
        /// <returns></returns>
        BoardGame GetBoardGamewithId(Guid boardGameId);

        /// <summary>
        /// Saves the board game.
        /// </summary>
        /// <param name="boardGame">The board game.</param>
        /// <returns></returns>
        BoardGame SaveBoardGame(BoardGame boardGame);

        /// <summary>
        /// Saves the board game.
        /// </summary>
        /// <param name="boardGame">The board game.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        BoardGame SaveBoardGame(BoardGame boardGame, Guid id);

        /// <summary>
        /// Deletes the board game.
        /// </summary>
        /// <param name="boardGame">The board game.</param>
        /// <returns></returns>
        bool DeleteBoardGame(BoardGame boardGame);
    }
}
