using BusinessLayer.Abstract;

using EntityLayer.Concrete;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        private IWriterService _writerService;

        public RegisterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            
        

            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme test";
            _writerService.Add(writer);
            return View();
        }
    }
}
