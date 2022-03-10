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
    public class DeleteModel : PageModel
    {
        private readonly Mondadoro.Data.MondadoroContext _context;

        public DeleteModel(Mondadoro.Data.MondadoroContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Storage = await _context.Storage.FindAsync(id);

            if (Storage != null)
            {
                _context.Storage.Remove(Storage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
