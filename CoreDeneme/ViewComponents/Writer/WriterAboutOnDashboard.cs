using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.ViewComponents.Writer
{
   
    public class WriterAboutOnDashboard: ViewComponent
    {
        WriterManager writermanager = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = writermanager.GetWriterByID(1);
            return View(values);
        }
    }
}
