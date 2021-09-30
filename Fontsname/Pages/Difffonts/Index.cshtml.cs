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
    public class IndexModel : PageModel
    {
        private readonly FontsnameDifffontsContext _context;

        public IndexModel(FontsnameDifffontsContext context)
        {
            _context = context;
        }

        public IList<Difffonts> Difffonts { get;set; }

        public async Task OnGetAsync()
        {
            Difffonts = await _context.Difffonts.ToListAsync();
        }
    }
}
