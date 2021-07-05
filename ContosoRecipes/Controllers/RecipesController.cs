using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Garlic", "Onion", "Ginger" };

            if (recipes.Any())
                return NotFound();
            return Ok(recipes);
        }

        [HttpPost]
        public ActionResult CreateRecipes()
        {
            bool itemCreated = true;

            string[] recipes = { "Garlic", "Onion", "Ginger" };

            if (itemCreated)
                return Ok(recipes);

            return NoContent();
        }

        [HttpPut]
        public ActionResult UpdateRecipes()
        {
            bool itemUpdated = false;

            string[] recipes = { "Garlic", "Onion", "Bell Pepper" };

            if (itemUpdated)
                return Ok(recipes);

            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool itemDeleted = false;

            if (itemDeleted)
                return BadRequest();

            return NoContent();
        }
    }
}
