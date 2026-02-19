using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindRestApi.Models;

namespace NorthwindRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentationController : ControllerBase
    {
        // Database context
        NorthwindOriginalContext db = new NorthwindOriginalContext();

        // Hardcoded keycode (school requirement)
        private const string VALID_KEYCODE = "12345";

        // GET: api/documentation/{keycode}
        [HttpGet("{keycode}")]
        public ActionResult GetDocumentation(string keycode)
        {
            // Correct key
            if (keycode == VALID_KEYCODE)
            {
                var docs = db.Documentations.ToList();

                if (docs.Count > 0)
                {
                    return Ok(docs);
                }
                else
                {
                    return Ok("Documentation empty");
                }
            }
            else
            {
                // Wrong key
                return Ok($"{DateTime.Now}: Documentation missing");
            }
        }
    }
}