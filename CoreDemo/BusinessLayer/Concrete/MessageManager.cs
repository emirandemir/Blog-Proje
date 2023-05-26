﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetInboxByWriter(string p)
        {
          return  _messageDal.GetAllList(x => x.Receiver == p);
        }

        public List<Message> GetList()
        {
           return _messageDal.GetAllList();
        }

        

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
