using AspNetCore.WebAPI.Models;
using AspNetCore.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Students")]
    public class StudentsController : ControllerBase
    {
        private readonly FirebaseStudentRepository _repository;

        public StudentsController(FirebaseStudentRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var students = await _repository.GetStudentsAsync();

            return Ok(students);
        }
    }
}
