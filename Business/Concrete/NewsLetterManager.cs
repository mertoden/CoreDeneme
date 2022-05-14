using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDL _newsletterDL;

        public NewsLetterManager(INewsLetterDL newsletterDL)
        {
            _newsletterDL = newsletterDL;
        }

        public void AddNewsLatter(NewsLetter newsLetter)
        {
            _newsletterDL.Insert(newsLetter);
        }
    }
}
