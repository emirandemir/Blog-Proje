using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NatificationManager : INatificationService
    {
        INatificationDal _natificationDal;

        public NatificationManager(INatificationDal natificationDal)
        {
            _natificationDal = natificationDal;
        }

        public void Add(Natification t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Natification t)
        {
            throw new NotImplementedException();
        }

        public Natification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Natification> GetList()
        {
            return _natificationDal.GetAllList();
        }

        public void Update(Natification t)
        {
            throw new NotImplementedException();
        }
    }
}
