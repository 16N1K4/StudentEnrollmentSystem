using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentEnrollmentAPI.DTO;
using StudentEnrollmentAPI.IRepository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentEnrollmentAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        public IConfiguration _appConfig { get; }
        public IEnrollmentRepo _repo { get; }

        public EnrollmentController(IConfiguration appConfig, IEnrollmentRepo repo)
        {
            _appConfig = appConfig;
            _repo = repo;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            // generate a token and return a token
            var issuer = _appConfig["JWT:Issuer"];
            var audience = _appConfig["JWT:Audience"];
            var key = _appConfig["JWT:Key"];

            if (ModelState.IsValid)
            {
                var loginResult = await _repo.SignInUserAsync(loginDTO);
                if (loginResult.Succeeded)
                {
                    // generate a token
                    var user = _repo.FindUserByEmailAsync(loginDTO.UserName);
                    string role = "";
                    if (User.IsInRole("Administrator"))
                    {
                        role = "Administrator";
                    }
                    else
                    {
                        role = "Student";
                    }
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.Name, loginDTO.UserName),
                        new Claim(ClaimTypes.Role, role)
                    };

                    if (user != null)
                    {
                        var keyBytes = Encoding.UTF8.GetBytes(key);
                        var theKey = new SymmetricSecurityKey(keyBytes); // 256 bits of key
                        var creds = new SigningCredentials(theKey, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(issuer, audience, claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: creds);
                        return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) }); // token 
                    }


                }
            }
            return BadRequest();
        }

        [Authorize(AuthenticationSchemes = "Bearer", Roles = "Administrator")]
        [HttpGet("{email}")]
        public async Task<IActionResult> ViewSchedule([FromRoute] string email)
        {
            var SubjectList = await _repo.ViewSchedule(email); ;
            List<ScheduleDTO> Schedule = new List<ScheduleDTO>();
            foreach (var Subject in SubjectList)
            {
                Schedule.Add(
                    new ScheduleDTO
                    {
                        FirstName = Subject.Student.FirstName,
                        LastName = Subject.Student.LastName,
                        Email = Subject.Student.Email,
                        SubjectName = Subject.Subject.Name,
                        Units = Subject.Subject.Units,
                        ClassSize = Subject.Subject.ClassSize,
                        SectionCode = Subject.Subject.Section.SectionCode,
                        ScheduleDay = _repo.ScheduleDay(Subject.Subject.Section.SectionCode[0]),
                        StartTime = _repo.StartTime(Subject.Subject.Section.SectionCode[1]),
                        EndTime = _repo.EndTime(Subject.Subject.Section.SectionCode[2]),
                        FacultyName = Subject.Subject.Faculty.FullName,
                        CourseName = Subject.Subject.Course.Name
                    }
                    );
            }

            return Ok(Schedule);
        }

        [Authorize(AuthenticationSchemes = "Bearer", Roles = "Student")]
        [HttpGet("self")]
        public async Task<IActionResult> ViewOwnSchedule()
        {
            var SubjectList = await _repo.ViewSchedule(User.Identity.Name); ;
            List<ScheduleDTO> Schedule = new List<ScheduleDTO>();
            foreach (var Subject in SubjectList)
            {
                Schedule.Add(
                    new ScheduleDTO
                    {
                        FirstName = Subject.Student.FirstName,
                        LastName = Subject.Student.LastName,
                        Email = Subject.Student.Email,
                        SubjectName = Subject.Subject.Name,
                        Units = Subject.Subject.Units,
                        ClassSize = Subject.Subject.ClassSize,
                        SectionCode = Subject.Subject.Section.SectionCode,
                        ScheduleDay = _repo.ScheduleDay(Subject.Subject.Section.SectionCode[0]),
                        StartTime = _repo.StartTime(Subject.Subject.Section.SectionCode[1]),
                        EndTime = _repo.EndTime(Subject.Subject.Section.SectionCode[2]),
                        FacultyName = Subject.Subject.Faculty.FullName,
                        CourseName = Subject.Subject.Course.Name
                    }
                    );
            }

            return Ok(Schedule);
        } 
    }
}
