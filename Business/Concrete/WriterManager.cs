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
    public class WriterManager : IWriterService
    {
        IWriterDL _writerdal;

        public WriterManager(IWriterDL writerdal)
        {
            _writerdal = writerdal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterByID(int id)
        {
            return _writerdal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Writer t)
        {
            _writerdal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return _writerdal.GetById(id);
        }

        public void TUpdate(Writer t)
        {
            _writerdal.Update(t);
        }
    }
}
