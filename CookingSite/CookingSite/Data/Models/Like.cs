using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Models
{
    public class Like
    {
        public int id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
    }
}
