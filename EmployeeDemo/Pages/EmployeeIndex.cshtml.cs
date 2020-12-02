using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeDemo.Models;

namespace EmployeeDemo.Pages
{
    public class EmployeeIndexModel : PageModel
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        public List<Employee> employee { get; set; }

        public void OnGet()
        {
            employee = objemployee.GetAllEmployees().ToList();
        }
    }
}