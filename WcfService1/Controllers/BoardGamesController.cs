using Business.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class BoardGamesController : ApiController
    {
        private IBoardGames boardGamesBusiness;

        public BoardGamesController(IBoardGames boardGames)
        {
            this.boardGamesBusiness = boardGames;
        }


        // GET: api/BoardGames
        [HttpGet]
        public IEnumerable<BoardGame> Get()
        {
            return this.boardGamesBusiness.GetBoardGames();
        }

        // GET: api/BoardGames/5
        [HttpGet]
        public BoardGame Get(Guid id)
        {
            return this.boardGamesBusiness.GetBoardGamewithId(id);
        }

        // POST: api/BoardGames
        [HttpPost]
        public void Post([FromBody]BoardGame value)
        {
            this.boardGamesBusiness.SaveBoardGame(value);
        }

        // PUT: api/BoardGames/5
        [HttpPut]
        public void Put(Guid id, [FromBody]BoardGame value)
        {
            this.boardGamesBusiness.SaveBoardGame(value, id);
        }

        // DELETE: api/BoardGames/5
        [HttpDelete]
        public void Delete(Guid id)
        {
            var entity = this.Get(id);
            if(entity != null)
            {
                this.boardGamesBusiness.DeleteBoardGame(entity);
            }
        }
    }
}
