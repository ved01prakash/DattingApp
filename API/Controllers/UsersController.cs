using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/{Controller}")]
    public class UsersController : ControllerBase
    {
        public DataContext _Context { get; }
        public UsersController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> Getusers()
        {
            return await _Context.Uers.ToListAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<AppUser>> Getuser(int id)
        {
            return await _Context.Uers.FindAsync(id);
        }
    }
}