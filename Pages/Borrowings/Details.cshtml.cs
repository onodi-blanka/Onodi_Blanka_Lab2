using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Onodi_Blanka_Lab2.Data;
using Onodi_Blanka_Lab2.Models;

namespace Onodi_Blanka_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Onodi_Blanka_Lab2.Data.Onodi_Blanka_Lab2Context _context;

        public DetailsModel(Onodi_Blanka_Lab2.Data.Onodi_Blanka_Lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}
