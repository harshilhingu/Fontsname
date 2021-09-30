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
    public class DetailsModel : PageModel
    {
        private readonly FontsnameDifffontsContext _context;

        public DetailsModel(FontsnameDifffontsContext context)
        {
            _context = context;
        }

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
    }
}
