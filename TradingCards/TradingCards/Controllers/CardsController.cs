using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingCards.Models;
using Microsoft.AspNetCore.Mvc;

namespace TradingCards.Controllers
{
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        // GET api/cards
        [HttpGet]
        public IEnumerable<Card> Get()
        {
            return new Card[] {
                new Card { Name = "TestCard", Description = "Test" },
                new Card { Name = "TestCard2", Description = "Test2" }
            };
        }

        // GET api/cards/5
        [HttpGet("{id}")]
        public Card Get(int id)
        {
            return new Card { Name=$"TestCard{id}",Description="Test"};
        }

        // POST api/cards
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cards/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Card updatedCard)
        {
        }

        // DELETE api/cards/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
