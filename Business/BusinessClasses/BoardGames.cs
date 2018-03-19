using Business.Interfaces;
using Domain.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessClasses
{
    /// <summary>
    /// Board game business operations implementation.
    /// </summary>
    /// <seealso cref="Business.Interfaces.IBoardGames" />
    public class BoardGames : IBoardGames
    {
        private IBoardGameRepository boardGameRepository;
        public BoardGames(IBoardGameRepository boardGameRepository)
        {
            this.boardGameRepository = boardGameRepository;
        }

        /// <summary>
        /// Deletes the board game.
        /// </summary>
        /// <param name="boardGame">The board game.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool DeleteBoardGame(BoardGame boardGame)
        {
            this.boardGameRepository.Delete(boardGame);
            this.boardGameRepository.Save();
            return true;
        }

        /// <summary>
        /// Gets the board games.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<BoardGame> GetBoardGames()
        {
            return this.boardGameRepository.GetAll();
        }

        /// <summary>
        /// Gets the board game with provided identifier.
        /// </summary>
        /// <param name="boardGameId">The board game identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BoardGame GetBoardGamewithId(Guid boardGameId)
        {
            return this.boardGameRepository.FindBy(q => q.Id == boardGameId).SingleOrDefault();
        }

        /// <summary>
        /// Saves the board game.
        /// </summary>
        /// <param name="boardGame">The board game.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BoardGame SaveBoardGame(BoardGame boardGame)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the board game.
        /// </summary>
        /// <param name="boardGame">The board game.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BoardGame SaveBoardGame(BoardGame boardGame, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
