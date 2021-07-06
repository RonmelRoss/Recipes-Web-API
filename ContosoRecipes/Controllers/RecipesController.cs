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
        public ActionResult GetRecipes([FromQuery]int count)
        {
            string[] recipes = { "Garlic", "Onion", "Ginger" };

            if (!recipes.Any())
                return NotFound();
            return Ok(recipes.Take(count));
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

        [HttpDelete("{id}")]    // Route: /api/recipes/{id}
        public ActionResult DeleteRecipes(string id)
        {
            string flag = "1";

            if (flag == id)
                return Ok("Value is deleted");

            return NoContent();
        }
    }
}
