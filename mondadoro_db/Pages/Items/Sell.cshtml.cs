using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using mondadoro_db.Models;
using System.IO;


namespace mondadoro_db.Pages.Items
{
    public class SellModel : PageModel
    {
        private readonly mondadoro_db.Data.mondadoro_dbContext _context;

        public SellModel(mondadoro_db.Data.mondadoro_dbContext context) => _context = context;

        public Item Item { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id, int sellQnty)
        {
            if (id == null)
                return NotFound();

            Item = await _context.Item.FirstOrDefaultAsync(m => m.ID == id);

            if (Item == null)
                return NotFound();

            Item.Quantity = Item.Quantity - sellQnty;

            while ((Item.Quantity - sellQnty) < 0)
                return RedirectToPage("./QntyError");


            double balance;
            StreamReader sr = new StreamReader("./Pages/Shared/balance.txt");
            balance = Convert.ToDouble(sr.ReadLine());
            balance += (sellQnty * Item.SellingPrice) - (sellQnty * Item.ListPrice);
            sr.Close();
            StreamWriter sw = new StreamWriter("./Pages/Shared/balance.txt");
            sw.WriteLine(balance);
            sw.Close();

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
