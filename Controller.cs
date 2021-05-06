using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace UdvDeck
{
    [ApiController]
    [IgnoreAntiforgeryToken]
    public class Controller : ControllerBase
    {
        private static readonly DeckController DeckController = new DeckController();
        
        [HttpPut("")]
        public IActionResult Create([FromBody] DeckName arg)
        {
            var name = arg.Name;

            if (DeckController.ContainsName(name))
                return BadRequest();
            
            DeckController.CreateDeck(name);
            return Created($"~/{name}", Deck(name));
        }

        public class DeckName
        {
            public string Name { get; set; }
        }

        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            if (!DeckController.ContainsName(name))
                return NotFound();
                
            DeckController.DeleteDeck(name);
            return Ok();
        }

        [HttpGet("")]
        public IEnumerable<string> List()
        {
            return DeckController.GetDeckList();
        }

        [HttpPatch("{name}")]
        public IActionResult Shuffle(string name)
        {
            if (!DeckController.ContainsName(name))
                return NotFound();
            
            DeckController.ShuffleDeck(name);
            return Ok();
        }

        [HttpGet("{name}")]
        public ActionResult<string[]> Deck(string name)
        {
            if (!DeckController.ContainsName(name))
                return NotFound();
            
            return DeckController.GetDeck(name);
        }
    }
}