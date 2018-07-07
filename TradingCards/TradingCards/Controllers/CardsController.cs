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
        public IEnumerable<ExampleCard> Get()
        {
            return new ExampleCard[] {
                new ExampleCard { CardName = "TestCard", CardDescription = "Test" },
                new ExampleCard { CardName = "TestCard2", CardDescription = "Test2" }
            };
        }

        // GET api/cards/5
        [HttpGet("{id}")]
        public ExampleCard Get(int id)
        {
            return new ExampleCard { CardName = $"TestCard{id}", CardDescription = "Test"};
        }

        // POST api/cards
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cards/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ExampleCard updatedCard)
        {
        }

        // DELETE api/cards/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
