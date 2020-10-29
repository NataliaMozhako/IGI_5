using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    interface ILike
    {
        public void AddLikeDB(Like like);
        public IEnumerable<Like> AllLikes();
        public void DeleteLike(Like like);
        public Like GetLikeDB(int id);
        public void UpdateLike(Like like);
    }
}
