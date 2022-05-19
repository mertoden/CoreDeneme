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
    public class BlogManager : IBlogService
    {
        IBlogDL _blogDL;

        public BlogManager(IBlogDL blogDL)
        {
            _blogDL = blogDL;
        }
       


        public List<Blog> GetBlogListWithCategory()
        {
            return  _blogDL.GetListwithCategory();
        }
        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogDL.GetListWithCategoryByWriter(id);
        }

        public Blog TGetById(int id)
        {
            return _blogDL.GetById(id);
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDL.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return _blogDL.GetListAll();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDL.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogListWithWriter(int id)
        {
            return _blogDL.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Blog t)
        {
            _blogDL.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDL.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDL.Update(t);
        }
    }
}
