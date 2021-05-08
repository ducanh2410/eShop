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
            var rowAffect = _baseRepository.Delete(TentityId);
            return rowAffect;
        }

        public IEnumerable<T> GetAll()
        {
            var customers = _baseRepository.GetAll();
            return customers;
        }

        public T GetById(Guid TentityId)
        {
            var customer = _baseRepository.GetById(TentityId);
            return customer;
        }

        public int Insert(T Tentity)
        {
            var rowAffect = _baseRepository.Insert(Tentity);
            return rowAffect;
        }

        public int Update(T Tentity)
        {
            var rowAffect = _baseRepository.Update(Tentity);
            return rowAffect;
        }
    }
}