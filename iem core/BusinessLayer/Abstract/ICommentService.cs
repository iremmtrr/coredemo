using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICommentService : IGenericService<Comment>
    {
        void Add(Comment comment);
        // void Delete(Comment comment);
        // void Update(Comment comment);
        List<Comment> GetListWithBlog();
        List<Comment> GetAll(int id);
      //  Comment GetById(int id);
    }
}
