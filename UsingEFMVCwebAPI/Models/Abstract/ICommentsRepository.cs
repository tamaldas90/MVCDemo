using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingEFMVCwebAPI.Controllers;


namespace UsingEFMVCwebAPI.Models.Abstract
{
    public interface ICommentsRepository
    {

        Comment Get(int id);
        IEnumerable<Comment> GetAll();
        Comment Add(Comment Comment);
        Comment Update(Comment comment);
        void Delete(int commentId);
        IEnumerable<Comment> GetCommentsByReviewId(int id);
    }
}
