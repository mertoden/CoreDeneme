using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogDL
    {
        public void Insert(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }


        public List<Blog> GetListAll()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void Update(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
