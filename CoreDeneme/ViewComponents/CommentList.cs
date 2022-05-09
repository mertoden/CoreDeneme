using CoreDeneme.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Murat"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Mert"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Simay"
                }
            };
            return View(commentvalues);
        }
    }
}
