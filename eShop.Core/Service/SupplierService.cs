using eShop.Core.Entities;
using eShop.Core.Interfaces.Repository;
using eShop.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class SupplierService : BaseService<Supplier>, ISupplierService
    {
        private ISupplierRepository _SupplierRepository;

        public SupplierService(ISupplierRepository SupplierRepository) : base(SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }
    }
}