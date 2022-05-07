﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICategoryDL
    {
        List<Category> ListAllCategory();
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        Category GetById(int id);
    }
}
