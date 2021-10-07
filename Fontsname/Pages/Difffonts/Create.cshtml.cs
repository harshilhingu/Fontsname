using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fontsname.Models;

namespace Fontsname.Pages_Difffonts
{
    public class CreateModel : PageModel
    {
        private readonly Fontsname.Data.FontsnameDifffontsContext _context;

        public CreateModel(Fontsname.Data.FontsnameDifffontsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Difffonts Difffonts { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Difffonts.Add(Difffonts);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
