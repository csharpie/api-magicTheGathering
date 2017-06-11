using api_magicTheGathering.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_magicTheGathering.Controllers 
{
    [Route("api/[controller]")]
    public class CardsController : Controller 
    {
        [HttpGet]
        public JsonResult Get()
        {
            var cards = new DataAccess().GetCards();
            return Json(cards);
        }
    }
}