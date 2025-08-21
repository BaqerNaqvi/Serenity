using Microsoft.AspNetCore.Mvc;

namespace SerenityAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        public record UserDto(int Id, string Name, string Email);

        // GET: /api/Admin
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> Get()
        {
            var users = new List<UserDto>
            {
                new UserDto(1, "Alice Johnson", "alice@example.com"),
                new UserDto(2, "Bob Smith", "bob@example.com"),
                new UserDto(3, "Charlie Brown", "charlie@example.com"),
            };

            return Ok(users);
        }
    }
}
