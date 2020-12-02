using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeDemo.Models;

namespace EmployeeDemo.Pages
{
    public class DeleteEmployeeModel : PageModel
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

        public ActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            objemployee.DeleteEmployee(id);

            return RedirectToPage("./EmployeeIndex");
        }
    }
}