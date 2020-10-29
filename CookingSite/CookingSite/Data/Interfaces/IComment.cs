using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    public interface IComment
    {
        public void AddCommentDB(Comment comment);
        public IEnumerable<Comment> AllComments();
        public void DeleteComment(Comment comment);
        public Comment GetCommentDB(int id);
        public void UpdateComment(Comment comment);
    }
}
