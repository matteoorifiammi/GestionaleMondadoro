#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mondadoro.Data;
using Mondadoro.Models;

namespace Mondadoro.Pages.Storage
{
    public class CreateModel : PageModel
    {
        private readonly Mondadoro.Data.MondadoroContext _context;

        public CreateModel(Mondadoro.Data.MondadoroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Storage Storage { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Storage.Add(Storage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
