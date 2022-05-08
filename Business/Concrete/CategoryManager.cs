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
        public void CategoryAdd(Category category)
        {
            _categoryDL.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDL.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDL.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDL.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDL.GetListAll();
        }
    }
}
