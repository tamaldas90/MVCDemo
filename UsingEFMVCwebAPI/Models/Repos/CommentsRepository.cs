using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsingEFMVCwebAPI.Models.Abstract;
using System.Data;

namespace UsingEFMVCwebAPI.Models.Repos
{
    public class CommentsRepository : ICommentsRepository
    {
        private ReviewedContext _db { get; set; }

        public CommentsRepository()
            : this(new ReviewedContext())
        {

        }

        public CommentsRepository(ReviewedContext db)
        {
            _db = db;
        }

        public Comment Get(int id)
        {
            return _db.Comments.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Comment> GetAll()
        {
            return _db.Comments;
        }

        public Comment Add(Comment Comment)
        {
            _db.Comments.Add(Comment);
            _db.SaveChanges();
            return Comment;
        }

        public Comment Update(Comment comment)
        {
            _db.Entry(comment).State = EntityState.Modified;
            _db.SaveChanges();
            return comment;
        }

        public void Delete(int commentId)
        {
            var comment = _db.Comments.Single(c => c.Id == commentId);
            _db.Comments.Remove(comment);
        }

        public IEnumerable<Comment> GetCommentsByReviewId(int id)
        {
            return _db.Comments.Where(c => c.ReviewId == id);
        }

    }
}