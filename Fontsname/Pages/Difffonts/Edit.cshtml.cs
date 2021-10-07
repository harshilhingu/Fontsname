using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fontsname.Models;

namespace Fontsname.Pages_Difffonts
{
    public class EditModel : PageModel
    {
        private readonly Fontsname.Data.FontsnameDifffontsContext _context;

        public EditModel(Fontsname.Data.FontsnameDifffontsContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Difffonts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DifffontsExists(Difffonts.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DifffontsExists(int id)
        {
            return _context.Difffonts.Any(e => e.ID == id);
        }
    }
}
