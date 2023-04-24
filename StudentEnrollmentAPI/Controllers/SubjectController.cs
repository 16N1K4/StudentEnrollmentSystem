using Microsoft.AspNetCore.Mvc;
using StudentEnrollmentAPI.DTO;
using StudentEnrollmentAPI.IRepository;

namespace StudentEnrollmentAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SubjectController : ControllerBase
    {
        ISubjectRepo _repo;

        public SubjectController(ISubjectRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ViewAllSubjects()
        {
            var SubjectList = _repo.ViewAllSubjects();
            List<SubjectDTO> SubjectDTOList = new List<SubjectDTO>();
            foreach(var Subject in SubjectList)
            {
                SubjectDTOList.Add(
                    new SubjectDTO
                    {
                        ID = Subject.ID,
                        Name = Subject.Name,
                        Units = Subject.Units,
                        ClassSize = Subject.ClassSize,
                        SectionCode = Subject.Section.SectionCode,
                        ScheduleDay = Subject.Section.Day,
                        StartTime = Subject.Section.StartTime,
                        EndTime = Subject.Section.EndTime,
                        CourseName = Subject.Course.Name,
                        FacultyName = Subject.Faculty.FullName
                    }
                    );
            }

            return Ok(SubjectDTOList);
        }

        [HttpGet("ByCourse/{courseID}")]
        public IActionResult ViewSubjectsByCourse([FromRoute] int courseID)
        {
            var SubjectList = _repo.ViewSubjectsByCourse(courseID);
            List<SubjectDTO> SubjectDTOList = new List<SubjectDTO>();
            foreach (var Subject in SubjectList)
            {
                SubjectDTOList.Add(
                    new SubjectDTO
                    {
                        ID = Subject.ID,
                        Name = Subject.Name,
                        Units = Subject.Units,
                        ClassSize = Subject.ClassSize,
                        SectionCode = Subject.Section.SectionCode,
                        ScheduleDay = Subject.Section.Day,
                        StartTime = Subject.Section.StartTime,
                        EndTime = Subject.Section.EndTime,
                        CourseName = Subject.Course.Name,
                        FacultyName = Subject.Faculty.FullName
                    }
                    );
            }
            return Ok(SubjectDTOList);
        }

        [HttpGet("BySchedule/{sectionCode}")]
        public IActionResult ViewSubjectsBySchedule([FromRoute] string sectionCode)
        {
            var SubjectList = _repo.ViewSubjectsBySchedule(sectionCode);
            List<SubjectDTO> SubjectDTOList = new List<SubjectDTO>();
            foreach (var Subject in SubjectList)
            {
                SubjectDTOList.Add(
                    new SubjectDTO
                    {
                        ID = Subject.ID,
                        Name = Subject.Name,
                        Units = Subject.Units,
                        ClassSize = Subject.ClassSize,
                        SectionCode = Subject.Section.SectionCode,
                        ScheduleDay = Subject.Section.Day,
                        StartTime = Subject.Section.StartTime,
                        EndTime = Subject.Section.EndTime,
                        CourseName = Subject.Course.Name,
                        FacultyName = Subject.Faculty.FullName
                    }
                    );
            }
            return Ok(SubjectDTOList);
        }

        [HttpGet("{id}")]
        public IActionResult ViewOneSubject([FromRoute] int id)
        {
            var Subject = _repo.ViewOneSubject(id);
            SubjectDTO subjectDTO = new SubjectDTO
            {
                ID = Subject.ID,
                Name = Subject.Name,
                Units = Subject.Units,
                ClassSize = Subject.ClassSize,
                SectionCode = Subject.Section.SectionCode,
                ScheduleDay = Subject.Section.Day,
                StartTime = Subject.Section.StartTime,
                EndTime = Subject.Section.EndTime,
                CourseName = Subject.Course.Name,
                FacultyName = Subject.Faculty.FullName
            };

            return Ok(subjectDTO);
        }
    }
}
