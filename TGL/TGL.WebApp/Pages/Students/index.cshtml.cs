using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGL.WebApp.Data;
using TGL.WebApp.Model;

namespace TGL.WebApp.Pages.Students
{
    public class indexModel : PageModel
    {
        public StudentStore StudentStore { get; set; }
        public List<Student> StudentsList { get; set; }
        public indexModel(StudentStore studentsStore)
        {
            StudentStore = studentsStore;
            StudentsList = studentsStore.GetStudents();
        }
        public IActionResult OnPostDelete (Guid id)
        {
            StudentStore.DeleteStudent(id);
            return RedirectToPage();
        }
        public void OnGet()
        {

        }
    }
}
