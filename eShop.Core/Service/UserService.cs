using eShop.Core.Entities;
using eShop.Core.Interfaces.Repository;
using eShop.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Service
{
    public class UserService : BaseService<User>, IUserService
    {
        private IUserRepository _UserRepository;

        public UserService(IUserRepository UserRepository) : base(UserRepository)
        {
            _UserRepository = UserRepository;
        }
    }
}