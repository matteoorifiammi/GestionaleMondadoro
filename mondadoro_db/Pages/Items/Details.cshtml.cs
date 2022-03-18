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

namespace mondadoro_db.Pages.Items
{
    public class DetailsModel : PageModel
    {
        private readonly mondadoro_db.Data.mondadoro_dbContext _context;

        public DetailsModel(mondadoro_db.Data.mondadoro_dbContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FirstOrDefaultAsync(m => m.ID == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
