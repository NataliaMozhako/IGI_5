using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    interface ITag
    {
        public void AddTagDB(Tag tag);
        public IEnumerable<Tag> AllTags();
        public void DeleteTag(Tag tag);
        public Tag GetTagDB(int id);
        public void UpdateTag(Tag tag);
    }
}
