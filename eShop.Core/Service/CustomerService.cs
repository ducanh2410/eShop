using eShop.Core.Entities;
using eShop.Core.Interfaces;
using eShop.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        private ICustomerRepository _CustomerRepository;

        public CustomerService(ICustomerRepository CustomerRepository) : base(CustomerRepository)
        {
            _CustomerRepository = CustomerRepository;
        }
    }
}