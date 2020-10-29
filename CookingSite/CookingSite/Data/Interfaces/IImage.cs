using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    interface IImage
    {
        public void AddImageDB(Image image);
        public IEnumerable<Image> AllImages();
        public void DeleteImage(Image image);
        public Image GetImageDB(int id);
        public void UpdateImage(Image image);
    }
}
