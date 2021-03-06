using System.Collections.Generic;

namespace blazor_19c.Data
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public bool Remove(int id);
    }
}
