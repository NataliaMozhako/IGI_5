using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Models
{
    public class Recipe
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Modified { get; set; } = DateTime.Now;

        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
