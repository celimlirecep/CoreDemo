using BusinessLayer.Abstract;
using ClosedXML.Excel;
using CoreDemo.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class ExportController : Controller
    {
        private IWriterService _writerService;

        public ExportController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult ExportStaticExcelAuthorList()
        {
            using (var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("AuthorList");
                workSheet.Cell(1, 1).Value = "Writer ID";
                workSheet.Cell(1, 2).Value = "Writer Name";
             
                //kaçıncı satırdan başlasın
                int writerRowCount = 2;
                foreach (var item in _writerService.GetListAll())
                {
                    workSheet.Cell(writerRowCount, 1).Value = item.WriterID;
                    workSheet.Cell(writerRowCount, 2).Value = item.WriterName;
                    writerRowCount++;
                }
                using (var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AuthorList.xlsx");
                }
            }
        }

        //ExportStaticExcelAuthorList çalıştıran view
        public IActionResult WriterListExcel()
        {
            return View();
        }

       




    }
}
