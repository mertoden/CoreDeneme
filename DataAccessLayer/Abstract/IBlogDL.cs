using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDL:IGenericDL<Blog>
    {
        List<Blog> GetListwithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}
