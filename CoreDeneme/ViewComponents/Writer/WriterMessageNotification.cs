using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "oden.mert@gmail.com";
            var values = mm.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
