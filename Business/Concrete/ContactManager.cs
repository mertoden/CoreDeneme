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
    public class ContactManager: IContactService
    {
        IContactDL _contactDL;

        public ContactManager(IContactDL contactDL)
        {
            _contactDL = contactDL;
        }

        public void ContactAdd(Contact contact)
        {
            _contactDL.Insert(contact);
        }

    }
}
