#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using mondadoro_db.Data;
using mondadoro_db.Models;

namespace mondadoro_db.Pages.People
{
    public class DetailsModel : PageModel
    {
        private readonly mondadoro_db.Data.mondadoro_dbContext _context;

        public DetailsModel(mondadoro_db.Data.mondadoro_dbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Person.FirstOrDefaultAsync(m => m.ID == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
