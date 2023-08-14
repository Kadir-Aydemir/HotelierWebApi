using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendeMessageDal;

        public SendMessageManager(ISendMessageDal sendeMessageDal)
        {
            _sendeMessageDal = sendeMessageDal;
        }

        public void TDelete(SendMessage t)
        {
            _sendeMessageDal.Delete(t);
        }

        public SendMessage TGetByID(int id)
        {
           return _sendeMessageDal.GetByID(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendeMessageDal.GetList();
        }

        public void TInsert(SendMessage t)
        {
            _sendeMessageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
            _sendeMessageDal.Update(t);
        }
    }
}
