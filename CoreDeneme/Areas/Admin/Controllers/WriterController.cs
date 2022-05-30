using CoreDeneme.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var JsonWriters = JsonConvert.SerializeObject(writers);
            return Json(JsonWriters);
        }
        public IActionResult GetWriterById(int writerid)
        {
            var findwriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonwriters = JsonConvert.SerializeObject(findwriter);
            return Json(jsonwriters);
        }
        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }

        public IActionResult DeleteWriter( int id)
        {
            var writer = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);
        }

        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x => x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id=1,
                Name="Mert"
            },
            new WriterClass
            {
                Id=2,
                Name="Teoman"
            },
            new WriterClass
            {
                Id=3,
                Name="Olcay"
            },
            new WriterClass
            {
                Id=4,
                Name="Cengiz"
            }
        };
    }
}
