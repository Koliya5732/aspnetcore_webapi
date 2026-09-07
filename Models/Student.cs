using Microsoft.EntityFrameworkCore;

namespace AspNetCore.WebAPI.Models
{
    public class Student // модель студента
    {
        public int Id { get; set; } // ідентифікатор
        public string? Name { get; set; } // ім'я
        public string? Surname { get; set; } // прізвище
        public int Age { get; set; } // вік
        public double GPA { get; set; } // середній бал
    }
}
