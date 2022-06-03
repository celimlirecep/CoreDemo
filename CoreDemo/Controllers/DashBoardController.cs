using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class DashBoardController : Controller
    {
        private IBlogService _blogService;
        private ICategoryService _categoryService;

        public DashBoardController(IBlogService blogService,ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int id=2)
        {
            ViewBag.BlogCount = _blogService.GetListAll().Count();
            ViewBag.WriterBlogCount = _blogService.GetListByFunc(i=>i.WriterId==id).Count();
            ViewBag.CategoryCount = _categoryService.GetListAll().Count();
            return View();
        }
       
    }
}
