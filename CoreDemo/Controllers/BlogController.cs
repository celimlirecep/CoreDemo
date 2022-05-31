using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private ICategoryService _categoryService;
       

        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
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
            

            return View(_blogService.GetListWithCategoryByWriter(2));
        }
        public IActionResult BlogAdd()
        {
            ViewBag.Categories = new SelectList(_categoryService.GetListAll(), "CategoryID", "CategoryName");
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
            p.WriterId = 2;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
            _blogService.Add(p);
            return RedirectToAction("BlogListByWriter");

         
        }
        public IActionResult DeleteBlog(int id)
        {
            Blog blog = _blogService.GetById(id);
            if (blog==null)
            {
                //silme işlemi gerçekleştirilemedi yazdırsın
                return RedirectToAction("BlogListByWriter");
            }

            blog.BlogStatus = false;

            _blogService.Update(blog);

            return RedirectToAction("BlogListByWriter");

        }
        public IActionResult UpdateBlog(int id)
        {
            ViewBag.Categories = new SelectList(_categoryService.GetListAll(), "CategoryID", "CategoryName");
            return View(_blogService.GetById(id));
        }
        [HttpPost]
        public IActionResult UpdateBlog(Blog p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }
            Blog blog = _blogService.GetById(p.BlogID);
            blog.BlogID = p.BlogID;
            blog.BlogContent = p.BlogContent;
            blog.BlogCreateDate = p.BlogCreateDate;
            blog.BlogStatus = p.BlogStatus;
            blog.BlogTitle = p.BlogTitle;
            blog.CategoryID = p.CategoryID;
            blog.Comments = p.Comments;
            blog.WriterId = 2;
            _blogService.Update(blog);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
