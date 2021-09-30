using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fontsname.Models;

namespace Fontsname.Pages_Difffonts
{
    public class DeleteModel : PageModel
    {
        private readonly FontsnameDifffontsContext _context;

        public DeleteModel(FontsnameDifffontsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Difffonts Difffonts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Difffonts = await _context.Difffonts.FirstOrDefaultAsync(m => m.ID == id);

            if (Difffonts == null)
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

            Difffonts = await _context.Difffonts.FindAsync(id);

            if (Difffonts != null)
            {
                _context.Difffonts.Remove(Difffonts);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
