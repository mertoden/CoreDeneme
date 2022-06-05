using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EFMessage2Repository());
        Context c = new Context();
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            var values = mm.GetInboxByWriter(writerID);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            return View(value);

        }
    }
     
}
