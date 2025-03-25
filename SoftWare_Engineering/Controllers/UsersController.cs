using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using SoftWare_Engineering.Data;
using SoftWare_Engineering.Models;

namespace SoftWare_Engineering.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private DBContext _dbContext;
        public UsersController(DBContext dBContext)
        {
            _dbContext = dBContext;

        }



        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Users);
        }

        [HttpPost("SignUp")]
        public IActionResult SignUp([FromBody] User user)
        {
            var find = _dbContext.Users.FirstOrDefault(x => x.userName == user.userName);
            if (find != null)
            {
                return BadRequest(".نام کاربری از قبل انتخاب شده است");
            }
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return Ok("ثبت نام شما با موفقبت انجام شد");

        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {

            var find = _dbContext.Users.FirstOrDefault(x => x.userName == request.Email);
            if (find == null)
            {
                return NotFound(".کاربر پیدا نشد");
            }
            if (find.Password != request.Password)
            {
                return BadRequest(".رمز عبور اشتباه است");
            }

            return Ok(find);
        }

        [HttpPost("TermCourse")]
        public IActionResult GetTermCourses([FromBody] ScheduleRequest request)
        {
            var courses = _dbContext.Courses
                .Where(c => c.UniversityName == request.University && c.MajorName == request.Major)
                .ToList();

            return Ok(courses);
        }

    }

}
