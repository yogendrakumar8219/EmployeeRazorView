using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeRazorView.Models;

namespace EmployeeRazorView.Pages
{
    public class EmployeeModel : PageModel
    {
        AppDbContext _Context;
        public EmployeeModel(AppDbContext databaseContext)
        {
            _Context = databaseContext;
        }
        [BindProperty]
        public Employee Employee { get; set; }
        public void OnGet()
        {
            
        }
        public ActionResult OnPost()
        {
            var employee = Employee;
            if(!ModelState.IsValid)
            {
                return Page();
            }
            var result = _Context.Add(employee);
            _Context.SaveChanges();
            return RedirectToPage("");
        }

    }
}
