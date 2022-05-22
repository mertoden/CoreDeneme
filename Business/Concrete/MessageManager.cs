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
    public class MessageManager : IMessageService
    {
        IMessageDL _messageDL;

        public MessageManager(IMessageDL messageDL)
        {
            _messageDL = messageDL;
        }

        public List<Message> GetList()
        {
            return _messageDL.GetListAll();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDL.GetListAll(x=>x.Receiver == p);

        }

        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
