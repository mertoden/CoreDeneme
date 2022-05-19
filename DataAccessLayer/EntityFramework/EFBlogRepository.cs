using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDL
    {
        public List<Blog> GetListwithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x=>x.WriterID == id).ToList();
            }
        }
    }
}
