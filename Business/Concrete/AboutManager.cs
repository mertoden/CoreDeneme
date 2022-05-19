﻿using Business.Abstract;
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

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        { 
            return _aboutDL.GetListAll();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
