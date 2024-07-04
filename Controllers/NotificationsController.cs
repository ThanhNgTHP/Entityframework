using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.DataContext;

namespace server.Controllers
{
    [Route("api")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly ComicsContext _context;
        public NotificationsController(ComicsContext comicsContext)
        {
            _context = comicsContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            string message = "";
            _context.comics.ToList().ForEach(lop =>
            {
                message = lop.name;
            });
            //Lop
            return Ok(new
            {
                message = message
            }); ;
        }
    }
}
