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
  public  class Message2Manager: IMessage2Service
    {
        IMessage2DL _messageDL;
public Message2Manager(IMessage2DL messageDL)
        {
            _messageDL = messageDL;
        }

        public List<Message2> GetInboxByWriter(int id)
        {
            return _messageDL.GetListWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _messageDL.GetListAll();
        }

        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            return _messageDL.GetById(id);
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
