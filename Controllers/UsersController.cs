using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APITask.Models;
using APITask.Data;

namespace APITask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController :ControllerBase
    {
        private readonly DataContext _context;

        //Constructor: This is where we "inject" the database connection
        public UsersController(DataContext context)
        {
            _context = context;
        }

        //1. GET: api/users (Get all users)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        //2. POST: api/users (Create a new user)
        [HttpPost]
        public async Task<ActionResult<Users>> AddUser(Users user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

                return Ok(user);
        }

    }
}
