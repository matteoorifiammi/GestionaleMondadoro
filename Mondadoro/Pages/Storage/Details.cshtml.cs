#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mondadoro.Data;
using Mondadoro.Models;

namespace Mondadoro.Pages.Storage
{
    public class DetailsModel : PageModel
    {
        private readonly Mondadoro.Data.MondadoroContext _context;

        public DetailsModel(Mondadoro.Data.MondadoroContext context)
        {
            _context = context;
        }

        public Storage Storage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Storage = await _context.Storage.FirstOrDefaultAsync(m => m.ID == id);

            if (Storage == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
