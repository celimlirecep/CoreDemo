using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View(_blogService.GetBlogListWithCategory());
        }
        public IActionResult BlogDetails(int id)
        {
            return View(_blogService.GetById(id));
        }

        public IActionResult BlogListByWriter()
        {
            

            return View(_blogService.GetBlogListByWriter(2));
        }
        public IActionResult BlogAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p )
        {
            if (!ModelState.IsValid && p==null)
            {
                return View(p);
            }
            p.BlogStatus = true;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            _blogService.Add(p);
            return RedirectToAction("BlogListByWriter");

         
        }
    }
}
