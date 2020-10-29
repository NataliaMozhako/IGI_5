using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Models
{
    public class User : IdentityUser
    {
        public string Description { get; set; }
        public Image Photo { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
