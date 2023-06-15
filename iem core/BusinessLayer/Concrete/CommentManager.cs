using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
             _commentDal.Add(comment);
        }

        public List<Comment> GetAll(int id)
        {
            return _commentDal.GetAll(x => x.BlogId == id);
        }

        public List<Comment> GetListWithBlog()
        {
           return _commentDal.GetListWithBlog();
        }

        public void TAdd(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public List<Comment> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
