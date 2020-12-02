using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeDemo.Models;

namespace EmployeeDemo.Pages
{
    public class EmployeeDetailsModel : PageModel
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        public Employee employee { get; set; }

        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}