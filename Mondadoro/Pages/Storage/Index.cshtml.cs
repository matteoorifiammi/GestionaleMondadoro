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
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly Mondadoro.Data.MondadoroContext _context;

        public IndexModel(Mondadoro.Data.MondadoroContext context)
        {
            _context = context;
        }

        public IList<Storage> Storage { get;set; }

        public async Task OnGetAsync()
        {
            Storage = await _context.Storage.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
