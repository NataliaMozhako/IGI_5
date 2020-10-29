using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Modified { get; set; }
    }
}
