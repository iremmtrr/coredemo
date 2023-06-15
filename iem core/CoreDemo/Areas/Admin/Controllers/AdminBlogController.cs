using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
         
        public IActionResult Index()
        {
            var values = blogManager.GetBlogsListWithCategory();
            return View(values);
        }
        public IActionResult BlogDelete(int id)
        {
            var value = blogManager.TGetById(id);
            blogManager.TDelete(value);
            return RedirectToAction("");
        }
        public IActionResult BlogStatus(int id)
        {
            var blogValue = blogManager.TGetById(id);
            if (blogValue.Status)
            {
                blogValue.Status = false;
            }
            else
            {
                blogValue.Status = true;
            }
            blogManager.TUpdate(blogValue);
            return RedirectToAction("");
        }

    }
}
