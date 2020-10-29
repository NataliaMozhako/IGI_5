using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Models
{
    public class Image
    {
        public int id { get; set; }
        public string Path { get; set; }
        public DateTime? UploadDate { get; set; }
    }
}
