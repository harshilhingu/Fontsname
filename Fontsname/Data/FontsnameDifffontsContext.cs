using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fontsname.Models;
namespace Fontsname.Data{



    public class FontsnameDifffontsContext : DbContext
    {
        public FontsnameDifffontsContext (DbContextOptions<FontsnameDifffontsContext> options)
            : base(options)
        {
            
        }

        public DbSet<Fontsname.Models.Difffonts> Difffonts { get; set; }
    }
}