using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubsribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubsribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nm.AddNewsLatter(p);
            return PartialView();
        }
    }
}
