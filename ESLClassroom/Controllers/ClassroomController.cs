using ESLClassroom.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ESLClassroom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        ClassroomDbContext dbcontext = new ClassroomDbContext();

        [HttpGet("GetUserByID")]//Default End Point
        public User UserByTeacherId(int teacherID)
        {
            User u = dbcontext.Users.FirstOrDefault(u => u.TeacherId == teacherID);
            return u;
        }
    }
}
