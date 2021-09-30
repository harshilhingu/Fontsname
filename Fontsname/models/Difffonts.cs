using System;
using System.ComponentModel.DataAnnotations;

namespace Fontsname.Models
{
    public class Difffonts
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string weight { get; set; }
        public string cornerrounding{ get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}