using AspNetCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

public class StudentContext : DbContext // контекст бази даних для студентів
{
    public DbSet<Student> Students { get; set; } // набір студентів

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
        if (Database.EnsureCreated()) // якщо база даних створюється вперше
        {
            if (Students is not null) // перевірка колекції на null перед додаванням
            {
                Students.Add(new Student { Name = "Іван", Surname = "Іваненко", Age = 20, GPA = 10.5 });
                Students.Add(new Student { Name = "Марія", Surname = "Шевченко", Age = 19, GPA = 11.8 });
                Students.Add(new Student { Name = "Олена", Surname = "Коваленко", Age = 21, GPA = 10.2 });
                Students.Add(new Student { Name = "Петро", Surname = "Бойко", Age = 22, GPA = 9.7 });
                Students.Add(new Student { Name = "Андрій", Surname = "Ткаченко", Age = 18, GPA = 12.0 });
                Students.Add(new Student { Name = "Софія", Surname = "Мельник", Age = 20, GPA = 11.3 });
                Students.Add(new Student { Name = "Дмитро", Surname = "Кравченко", Age = 23, GPA = 10.9 });
                Students.Add(new Student { Name = "Юлія", Surname = "Олійник", Age = 19, GPA = 11.5 });
                Students.Add(new Student { Name = "Максим", Surname = "Лисенко", Age = 21, GPA = 10.4 });
                Students.Add(new Student { Name = "Анна", Surname = "Петренко", Age = 20, GPA = 11.0 });
                Students.Add(new Student { Name = "Віктор", Surname = "Савченко", Age = 22, GPA = 9.8 });
                Students.Add(new Student { Name = "Катерина", Surname = "Гончаренко", Age = 19, GPA = 11.7 });
                Students.Add(new Student { Name = "Олексій", Surname = "Мороз", Age = 24, GPA = 10.6 });
                Students.Add(new Student { Name = "Наталія", Surname = "Бондаренко", Age = 18, GPA = 12.0 });
                Students.Add(new Student { Name = "Роман", Surname = "Даниленко", Age = 21, GPA = 10.1 });
                Students.Add(new Student { Name = "Тетяна", Surname = "Захарченко", Age = 20, GPA = 11.2 });
                Students.Add(new Student { Name = "Богдан", Surname = "Левченко", Age = 23, GPA = 10.8 });
                Students.Add(new Student { Name = "Ірина", Surname = "Романенко", Age = 19, GPA = 11.4 });
                Students.Add(new Student { Name = "Сергій", Surname = "Василенко", Age = 22, GPA = 10.3 });
                Students.Add(new Student { Name = "Ольга", Surname = "Кушнір", Age = 20, GPA = 11.6 });
                SaveChanges(); // збереження змін у базі даних
            }
        }
    }
}