using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeDemo.Models;

namespace EmployeeDemo.Pages
{
    public class CreateEmployeeModel : PageModel
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();

        [BindProperty]
        public Employee employee { get; set; }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            objemployee.AddEmployee(employee);

            return RedirectToPage("./EmployeeIndex");
        }
    }
}