using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Model;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                name = "Carlos",
                age = 21,
                carrer = "Systems engineering"
            }
            );

            Students.Add(new Student
            {
                name = "Valeria",
                age = 17,
                carrer = "Systems engineering"
            }
            );
        }

        internal void AddStudent(Student student)
        {
            Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(res => res.id == id);
            if (Students != null)
            {
                Students.Remove(student);
            }
        }

        public List<Student> GetStudents ()
        {
            return this.Students;
        }
    }
}
