using eShop.Core.Interfaces;
using eShop.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public int Delete(Guid TentityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid TentityId)
        {
            throw new NotImplementedException();
        }

        public int Insert(T Tentity)
        {
            throw new NotImplementedException();
        }

        public int Update(T Tentity)
        {
            throw new NotImplementedException();
        }
    }
}