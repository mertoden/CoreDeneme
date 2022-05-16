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
    
    public class AboutManager: IAboutService
    {
        IAboutDL _aboutDL;
        public AboutManager(IAboutDL aboutDL)
        {
            _aboutDL = aboutDL;
        }

        public List<About> GetList()
        { 
            return _aboutDL.GetListAll();
        }
    }
}
