﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetListWithBlog();
        List<Comment> GetIdComment();
        List<Comment> CommentStatus();
    }
}
