using System.Collections.Generic;
using System.Linq;

namespace blazor_19c.Data
{
    public class StudentService : IStudentService
    {
        private List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Jan",
                    LastName = "Papaj",
                    Birthdate = new System.DateTime(2137, 1, 1),
                    Studies = "Ble",
                    Avatar = "https://i1.sndcdn.com/avatars-000184062541-d79jz9-t500x500.jpg"
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Misio",
                    LastName = "Ździsio",
                    Birthdate = new System.DateTime(1990, 1, 1),
                    Studies = "Bla",
                    Avatar = "https://thishouse.pl/environment/cache/images/0_0_productGfx_20221.jpg"
                },
                new Student
                {
                    ID = 3,
                    FirstName = "Henryk",
                    LastName = "Sienkiewicz",
                    Birthdate = new System.DateTime(1444, 1, 1),
                    Studies = "Blu",
                    Avatar = "https://www.blu.com.pl/img/blu-logo-1624539925.jpg"
                }
            };
        }
        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(e => e.ID == id);
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public bool Remove(int id)
        {
            return _students.Remove(_students.FirstOrDefault(e => e.ID == id));
        }
    }
}
