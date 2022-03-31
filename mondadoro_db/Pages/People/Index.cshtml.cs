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
    public class IndexModel : PageModel
    {
        private readonly mondadoro_db.Data.mondadoro_dbContext _context;

        public IndexModel(mondadoro_db.Data.mondadoro_dbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
