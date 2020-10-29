using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Models
{
    public class Video
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime? Modified { get; set; }
        public Recipe Recipe { get; set; } 
        public int RecipeId { get; set; }
    }
}
