using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGL.WebApp.Model
{
    public class Student
    {
        public Student()
        {
            id = Guid.NewGuid();
        }
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        [Required] [MaxLength(2)]
        public int age { get; set; }
        [Required]
        public string carrer { get; set; }

    }
}
