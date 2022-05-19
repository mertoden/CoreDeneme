using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDL _categoryDL;

        public CategoryManager(ICategoryDL categoryDL)
        {
            _categoryDL = categoryDL;
        }
        public Category TGetById(int id)
        {
            return _categoryDL.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDL.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categoryDL.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDL.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDL.Update(t);
        }
    }
}
