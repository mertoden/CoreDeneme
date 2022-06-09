using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDL _commentdl;
        public CommentManager(ICommentDL commentdl)
        {
            _commentdl = commentdl;
        }
        public void CommentAdd(Comment comment)
        {
            _commentdl.Insert(comment);
        }

        public List<Comment> GetCommentWithBlog()
        {
            return _commentdl.GetListwithBlog();
            
        }

        public List<Comment> GetList(int id)
        {
            return _commentdl.GetListAll(x => x.BlogID == id);
        }
    }
}
